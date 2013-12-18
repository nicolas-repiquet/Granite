using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Granite.Core;
using System.Threading;
using System.Runtime.InteropServices;

namespace Test
{

    [StructLayout(LayoutKind.Sequential)]
    public struct Vertex
    {
        public Vector3 Position;
        public Vector2 TexCoord;
        public Color3ub Color;
    }

    public class GameLogic : DisplayLogicBase, IRunnableLogic
    {
        private Display m_display;
        private Font m_font;

        private Texture2D m_texture;

        private Buffer<Vertex> m_grid;
        private IBufferView m_gridPositionsView;
        private IBufferView m_gridColorsView;
        private IBufferView m_gridTexCoordsView;

        private Buffer<Vertex> m_vertices;
        private IBufferView m_positionsView;
        private IBufferView m_colorsView;
        private IBufferView m_texCoordsView;

        private Buffer<uint> m_elements;

        private VertexShader m_vertexShader;
        private FragmentShader m_fragmentShader;

        private Granite.Core.Program m_program;

        private ProgramInstance m_programInstance;
        private ProgramInstance m_programGridInstance;

        private float m_rotation;

        // ********************************************************************
        // * Engine

        private Vertex[] CreateGrid(Box2 area, float step)
        {
            var points = new List<Vertex>();

            for (float x = area.MinX; x <= area.MaxX; x += step)
            {
                points.Add(new Vertex() { Position = new Vector3(x, area.MinY, 0) });
                points.Add(new Vertex() { Position = new Vector3(x, area.MaxY, 0) });
            }

            for (float y = area.MinY; y <= area.MaxY; y += step)
            {
                points.Add(new Vertex() { Position = new Vector3(area.MinX, y, 0) });
                points.Add(new Vertex() { Position = new Vector3(area.MaxX, y, 0) });
            }

            return points.ToArray();
        }

        private void CreateFace(List<Vertex> vertices, Vertex p0, Vertex p1, Vertex p2)
        {
            vertices.Add(p0);
            vertices.Add(p1);
            vertices.Add(p2);
        }

        private void CreateQuad(List<Vertex> vertices, Vertex p0, Vertex p1, Vertex p2, Vertex p3, Color3ub c)
        {
            p0.Color = c;
            p0.TexCoord = new Vector2(0, 0);
            p1.Color = c;
            p1.TexCoord = new Vector2(0, 1);
            p2.Color = c;
            p2.TexCoord = new Vector2(1, 1);
            p3.Color = c;
            p3.TexCoord = new Vector2(1, 0);
            CreateFace(vertices, p0, p1, p2);
            CreateFace(vertices, p2, p3, p0);
        }

        private Vertex[] CreateDiamond()
        {
            var vertices = new List<Vertex>();

            var near =   new Vertex() { Position = new Vector3(0, 0, -1), Color = new Color3ub(255, 0, 0) };
            var far = new Vertex() { Position = new Vector3(0, 0, 1), Color = new Color3ub(0, 255, 0) };
            var left = new Vertex() { Position = new Vector3(-1, 0, 0), Color = new Color3ub(0, 0, 255) };
            var right = new Vertex() { Position = new Vector3(1, 0, 0), Color = new Color3ub(255, 255, 0) };
            var top = new Vertex() { Position = new Vector3(0, 1, 0), Color = new Color3ub(255, 0, 255) };
            var bottom = new Vertex() { Position = new Vector3(0, -1, 0), Color = new Color3ub(0, 255, 255) };

            CreateFace(vertices, bottom, near, left);
            CreateFace(vertices, left, near, top);
            CreateFace(vertices, top, near, right);
            CreateFace(vertices, right, near, bottom);

            CreateFace(vertices, bottom, far, left);
            CreateFace(vertices, left, far, top);
            CreateFace(vertices, top, far, right);
            CreateFace(vertices, right, far, bottom);

            return vertices.ToArray();
        }

        private Vertex[] CreateCube()
        {
            var vertices = new List<Vertex>();

            var LeftBottomNear = new Vertex()
            {
                Position = new Vector3(-1, -1, -1),
            };
            var LeftBottomFar = new Vertex()
            {
                Position = new Vector3(-1, -1, 1),
            };
            var LeftTopNear = new Vertex()
            {
                Position = new Vector3(-1, 1, -1),
            };
            var LeftTopFar = new Vertex()
            {
                Position = new Vector3(-1, 1, 1),
            };
            var RightBottomNear = new Vertex()
            {
                Position = new Vector3(1, -1, -1),
            };

            var RightBottomFar = new Vertex()
            {
                Position = new Vector3(1, -1, 1),
            };
            var RightTopNear = new Vertex()
            {
                Position = new Vector3(1, 1, -1),
            };
            var RightTopFar = new Vertex()
            {
                Position = new Vector3(1, 1, 1),
            };

            CreateQuad(vertices, LeftTopFar, RightTopFar, RightBottomFar, LeftBottomFar, new Color3ub(255, 0, 0));
            CreateQuad(vertices, LeftTopNear, RightTopNear, RightBottomNear, LeftBottomNear, new Color3ub(0, 255, 0));
            CreateQuad(vertices, LeftTopNear, RightTopNear, RightTopFar, LeftTopFar, new Color3ub(0, 0, 255));
            CreateQuad(vertices, LeftBottomNear, RightBottomNear, RightBottomFar, LeftBottomFar, new Color3ub(255, 255, 0));
            CreateQuad(vertices, LeftBottomNear, LeftTopNear, LeftTopFar, LeftBottomFar, new Color3ub(255, 0, 255));
            CreateQuad(vertices, RightBottomNear, RightTopNear, RightTopFar, RightBottomFar, new Color3ub(0, 255, 255));

            // Far    : red       : z+
            // Near   : green     : z-
            // Top    : blue      : y+
            // Bottom : yellow    : y-
            // Right  : cyan      : x+
            // Left   : magenta   : x-

            return vertices.ToArray();
        }

        private Color3ub[] CreateCheckboardTexture(int width, int height)
        {
            var black = new Color3ub(0, 0, 0);
            var white = new Color3ub(255, 255, 255);
            var colors = new Color3ub[width * height];
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    colors[y * width + x] = x % 2 == 0 ^ y % 2 == 0 ? black : white;
                }
            }
            return colors;
        }

        public void OnStart()
        {
            m_display = Engine.CreateDisplay(new DisplaySettings(), this);
            m_display.Show();

            m_grid = Engine.CreateBuffer(CreateGrid(new Box2(-10, -10, 20, 20), 1));
            m_gridPositionsView = m_grid.GetView("Position");
            m_gridColorsView = m_grid.GetView("Color");
            m_gridTexCoordsView = m_grid.GetView("TexCoord");
            m_font = new Font();

            m_texture = Engine.CreateTexture2D();
            m_texture.SetData(8, 8, CreateCheckboardTexture(8, 8));

            m_vertices = Engine.CreateBuffer(CreateCube());

            m_positionsView = m_vertices.GetView("Position");
            m_colorsView = m_vertices.GetView("Color");
            m_texCoordsView = m_vertices.GetView("TexCoord");

            m_elements = Engine.CreateBuffer(new uint[] { 0, 1, 2, 3 });

            m_vertexShader = Engine.CreateVertexShader(@"
#version 110

uniform mat4 model_matrix;
uniform mat4 proj_matrix;

attribute vec3 position;
attribute vec2 texcoord;
attribute vec3 color;

varying vec3 c;
varying vec2 t;
varying vec4 pos;

void main()
{
    vec4 p = vec4(position, 1.0);
    p = model_matrix * p;
    p = proj_matrix * p;
    pos = p;
    gl_Position = p;
    c = color;
    t = texcoord;
}
");
            m_fragmentShader = Engine.CreateFragmentShader(@"
#version 110

uniform sampler2D texture;

varying vec3 c;
varying vec2 t;
varying vec4 pos;

void main()
{
    gl_FragColor = vec4(c, 1.0) * texture2D(texture, t);
}
");

            m_program = Engine.CreateProgram(m_vertexShader, m_fragmentShader);

            m_programInstance = m_program.CreateInstance(new Dictionary<string, IBufferView> { 
                { "position", m_positionsView },
                { "color", m_colorsView },
                { "texcoord", m_texCoordsView }
            });
            m_programInstance.SetUniform("texture", m_texture);

            m_programGridInstance = m_program.CreateInstance(new Dictionary<string, IBufferView>
            {
                { "position", m_gridPositionsView },
                { "color", m_gridColorsView },
                { "texcoord", m_gridTexCoordsView }
            });
        }

        public void OnStop()
        {

        }

        // ********************************************************************
        // * Display

        private HashSet<Keys> m_keys = new HashSet<Keys>();
        private float m_x, m_z;

        public override void OnKeyDown(Keys key)
        {
            m_keys.Add(key);
        }

        public override void OnKeyUp(Keys key)
        {
            m_keys.Remove(key);
        }

        public override void OnLostFocus()
        {
            m_keys.Clear();
        }

        public void UpdateKey(TimeSpan elapsed, Keys key)
        {
            switch (key)
            {
                case Keys.Up:
                    m_z += 10f * (float)elapsed.TotalSeconds;
                    break;

                case Keys.Down:
                    m_z -= 10f * (float)elapsed.TotalSeconds;
                    break;

                case Keys.Left:
                    m_x -= 10f * (float)elapsed.TotalSeconds;
                    break;

                case Keys.Right:
                    m_x += 10f * (float)elapsed.TotalSeconds;
                    break;
            }
        }

        public override void OnCloseCommand(Display display)
        {
            Engine.Stop();
        }

        public override void OnChar(char c)
        {
            
        }

 
        public override void Render(Display display, Graphics graphics, TimeSpan elapsed)
        {
            var gl = Engine.Gl;

            foreach (var key in m_keys)
            {
                UpdateKey(elapsed, key);
            }

            m_rotation += (float)(elapsed.TotalSeconds * Math.PI);

            var ratio = display.Width / (float)display.Height;

            // Identity
            //var projMatrix = Granite.Math.Matrix4.Scale(1f / (10f * ratio), 1f / 10f, 0.01f);

            // Ortho
            //var projMatrix = Granite.Math.Matrix4.Ortho(-10f * ratio, 10f * ratio, -10f, 10f, -100f, 100f);

            // Frustum
            var projMatrix = Matrix4.Frustum(-1f * ratio, 1f * ratio, -1f, 1f, 2f, 1000f);


            var modelMatrix = Matrix4.Identity;


            modelMatrix = modelMatrix * Matrix4.Scale(-1, 1, -1);

            var lookat = Matrix4.LookAt(
                new Vector3(m_x, -20, m_z),
                new Vector3(0, 0, 0),
                new Vector3(0, 0, 1)
            );

            modelMatrix = modelMatrix * lookat;

            m_programGridInstance.SetUniform("model_matrix", modelMatrix);
            m_programGridInstance.SetUniform("proj_matrix", projMatrix);
            m_programGridInstance.DrawLines();

            var m = modelMatrix * Matrix4.Translate(0, 0, 0);


            m_programInstance.SetUniform("model_matrix", m);
            m_programInstance.SetUniform("proj_matrix", projMatrix);
            m_programInstance.Draw(m_vertices.Count);

            // X
            m = modelMatrix * Matrix4.Translate(3, 0, 0);

            m_programInstance.SetUniform("model_matrix", m);
            m_programInstance.SetUniform("proj_matrix", projMatrix);
            m_programInstance.Draw(m_vertices.Count);

            // Y
            m = modelMatrix * Matrix4.Translate(0, 3, 0);

            m_programInstance.SetUniform("model_matrix", m);
            m_programInstance.SetUniform("proj_matrix", projMatrix);
            m_programInstance.Draw(m_vertices.Count);

            // Z
            m = modelMatrix * Matrix4.Translate(0, 0, 3);

            m_programInstance.SetUniform("model_matrix", m);
            m_programInstance.SetUniform("proj_matrix", projMatrix);
            m_programInstance.Draw(m_vertices.Count);

            var builder = new StringBuilder();
            for (int i = 0; i < 256; i++)
            {
                var c = (char)i;
                if (!char.IsControl(c))
                {
                    builder.Append(c);
                }
            }

            m_font.DrawText(display, new Vector2i(0, 20 * 0), builder.ToString());
            m_font.DrawText(display, new Vector2i(0, 20 * 1), string.Format("x position: {0,7:F2}", m_x));
            m_font.DrawText(display, new Vector2i(0, 20 * 2), string.Format("z position: {0,7:F2}", m_z));

            display.Invalidate();
        }
    }
}
