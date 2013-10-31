using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Granite3D;
using System.Threading;
using System.Runtime.InteropServices;

namespace Test
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Color
    {
        public byte R;
        public byte G;
        public byte B;

        public Color(byte r, byte g, byte b)
        {
            R = r;
            G = g;
            B = b;
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Vertex
    {
        public Vec3f Position;
        public Vec2f TexCoord;
        public Color Color;
    }

    public class GameLogic : IEngineLogic, IDisplayLogic
    {
        private Display m_display;

        private Texture2D m_texture;

        private Buffer<Vertex> m_vertices;
        private IBufferView m_positionsView;
        private IBufferView m_colorsView;
        private IBufferView m_texCoordsView;

        private Buffer<uint> m_elements;

        private VertexShader m_vertexShader;
        private FragmentShader m_fragmentShader;
        
        private Granite3D.Program m_program;

        private ProgramInstance m_programInstance;

        private float m_rotation;

        // ********************************************************************
        // * Engine

        private void CreateFace(List<Vertex> vertices, Vertex p0, Vertex p1, Vertex p2)
        {
            vertices.Add(p0);
            vertices.Add(p1);
            vertices.Add(p2);
        }

        private void CreateQuad(List<Vertex> vertices, Vertex p0, Vertex p1, Vertex p2, Vertex p3, Color c)
        {
            p0.Color = c;
            p0.TexCoord = new Vec2f(0, 0);
            p1.Color = c;
            p1.TexCoord = new Vec2f(0, 1);
            p2.Color = c;
            p2.TexCoord = new Vec2f(1, 1);
            p3.Color = c;
            p3.TexCoord = new Vec2f(1, 0);
            CreateFace(vertices, p0, p1, p2);
            CreateFace(vertices, p2, p3, p0);
        }

        private Vertex[] CreateDiamond()
        {
            var vertices = new List<Vertex>();

            var near =   new Vertex() { Position = new Vec3f(0, 0, -1), Color = new Color(255, 0, 0) };
            var far = new Vertex() { Position = new Vec3f(0, 0, 1), Color = new Color(0, 255, 0) };
            var left = new Vertex() { Position = new Vec3f(-1, 0, 0), Color = new Color(0, 0, 255) };
            var right = new Vertex() { Position = new Vec3f(1, 0, 0), Color = new Color(255, 255, 0) };
            var top = new Vertex() { Position = new Vec3f(0, 1, 0), Color = new Color(255, 0, 255) };
            var bottom = new Vertex() { Position = new Vec3f(0, -1, 0), Color = new Color(0, 255, 255) };

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
                Position = new Vec3f(-1, -1, -1),
            };
            var LeftBottomFar = new Vertex()
            {
                Position = new Vec3f(-1, -1, 1),
            };
            var LeftTopNear = new Vertex()
            {
                Position = new Vec3f(-1, 1, -1),
            };
            var LeftTopFar = new Vertex()
            {
                Position = new Vec3f(-1, 1, 1),
            };
            var RightBottomNear = new Vertex()
            {
                Position = new Vec3f(1, -1, -1),
            };

            var RightBottomFar = new Vertex()
            {
                Position = new Vec3f(1, -1, 1),
            };
            var RightTopNear = new Vertex()
            {
                Position = new Vec3f(1, 1, -1),
            };
            var RightTopFar = new Vertex()
            {
                Position = new Vec3f(1, 1, 1),
            };

            CreateQuad(vertices, LeftTopFar, RightTopFar, RightBottomFar, LeftBottomFar, new Color(255, 0, 0));
            CreateQuad(vertices, LeftTopNear, RightTopNear, RightBottomNear, LeftBottomNear, new Color(0, 255, 0));
            CreateQuad(vertices, LeftTopNear, RightTopNear, RightTopFar, LeftTopFar, new Color(0, 0, 255));
            CreateQuad(vertices, LeftBottomNear, RightBottomNear, RightBottomFar, LeftBottomFar, new Color(255, 255, 0));
            CreateQuad(vertices, LeftBottomNear, LeftTopNear, LeftTopFar, LeftBottomFar, new Color(255, 0, 255));
            CreateQuad(vertices, RightBottomNear, RightTopNear, RightTopFar, RightBottomFar, new Color(0, 255, 255));

            // Far : red
            // Near : green
            // top : blue
            // bottom : yellow
            // left : magenta
            // right : cyan

            return vertices.ToArray();
        }

        private Color[] CreateCheckboardTexture(int width, int height)
        {
            var black = new Color(0, 0, 0);
            var white = new Color(255, 255, 255);
            var colors = new Color[width * height];
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    colors[y * width + x] = x % 2 == 0 ^ y % 2 == 0 ? black : white;
                }
            }
            return colors;
        }

        public void OnStart(Engine engine)
        {
            m_display = engine.CreateDisplay(new DisplaySettings(), this);
            m_display.Show();

            m_texture = engine.CreateTexture2D();
            m_texture.SetData(8, 8, CreateCheckboardTexture(8, 8));

            m_vertices = engine.CreateBuffer(CreateCube());

            m_positionsView = m_vertices.GetView("Position");
            m_colorsView = m_vertices.GetView("Color");
            m_texCoordsView = m_vertices.GetView("TexCoord");

            m_elements = engine.CreateBuffer(new uint[] { 0, 1, 2, 3 });

            m_vertexShader = engine.CreateVertexShader(@"
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
            m_fragmentShader = engine.CreateFragmentShader(@"
#version 110

uniform sampler2D texture;

varying vec3 c;
varying vec2 t;
varying vec4 pos;

void main()
{
    gl_FragColor = vec4(c, 1.0) * texture2D(texture, t); // * vec4(d, d, d, 1.0);
}
");

            m_program = engine.CreateProgram(m_vertexShader, m_fragmentShader);

            m_programInstance = m_program.CreateInstance(new Dictionary<string,IBufferView> { 
                { "position", m_positionsView },
                { "color", m_colorsView },
                { "texcoord", m_texCoordsView }
            });
            m_programInstance.SetUniform("texture", m_texture);

        }

        public void OnStop(Engine engine)
        {

        }

        // ********************************************************************
        // * Display

        public void OnMouseMove(Display display, int x, int y)
        {

        }

        public void OnCloseCommand(Display display)
        {
            display.Engine.Stop();
        }

        public void Render(Display display, Graphics graphics, TimeSpan elapsed)
        {
            m_rotation += (float)(elapsed.TotalSeconds * Math.PI);

            var ratio = display.Width / (float)display.Height;

            // Identity
            //var projMatrix = Mat44f.Identity;
            //projMatrix = projMatrix.Scale(1f / (10f * ratio), 1f / 10f, 0.5f);

            // Ortho
            //var projMatrix = Mat44f.Ortho(-10 * ratio, 10 * ratio, -10, 10, -2f, 2f);

            // Frustum
            var projMatrix = Mat44f.Frustum(-1f * ratio, 1f * ratio, -1f, 1f, 2f, 1000f);
            //projMatrix = projMatrix.Translate(0, 0, -28f);


            var modelMatrix = Mat44f.Identity;
            modelMatrix = modelMatrix.Scale(-1, 1, -1);
            modelMatrix = Mat44f.Multiply(modelMatrix, Mat44f.LookAt(
                new Vec3f(20, -20, 20),
                new Vec3f(0, 0, 0),
                new Vec3f(0, 0, 1)
            ));


            //var modelMatrix = Mat44f.Identity;

            //modelMatrix = modelMatrix.RotateY(m_rotation / 10f);


            var m = modelMatrix.Translate(0, 0, 0);

            m_programInstance.SetUniform("model_matrix", m);
            m_programInstance.SetUniform("proj_matrix", projMatrix);
            m_programInstance.Draw();

            // X
            m = modelMatrix.Translate(3, 0, 0);

            m_programInstance.SetUniform("model_matrix", m);
            m_programInstance.SetUniform("proj_matrix", projMatrix);
            m_programInstance.Draw();

            // Y
            m = modelMatrix.Translate(0, 3, 0);

            m_programInstance.SetUniform("model_matrix", m);
            m_programInstance.SetUniform("proj_matrix", projMatrix);
            m_programInstance.Draw();

            // Z
            m = modelMatrix.Translate(0, 0, 3);

            m_programInstance.SetUniform("model_matrix", m);
            m_programInstance.SetUniform("proj_matrix", projMatrix);
            m_programInstance.Draw();

            display.Invalidate();
        }
    }
}
