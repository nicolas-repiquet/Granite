using Granite3D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test
{
    public partial class Font
    {
        private struct CharacterVertex
        {
            public Vector2 position;
            public Vector2 texCoords; 
        }

        private class Character
        {
            public Box2i box;
            public Box2 uvs;

            public Character(char c, int x, int y, int width, int height)
            {
                box = new Box2i(x, y, width, height);
                uvs = new Box2((x-1) / (float)s_width, (y-1) / (float)s_height, (width+2) / (float)s_width, (height+2) / (float)s_height);
            }

            public void AppendTo(List<CharacterVertex> vertices, Vector2i position)
            {
                var v0 = new CharacterVertex()
                {
                    position = new Vector2(position.X - 1, position.Y - 1),
                    texCoords = new Vector2(uvs.MinX, uvs.MinY)
                };
                var v1 = new CharacterVertex()
                {
                    position = new Vector2(position.X + box.Size.X + 1, position.Y - 1),
                    texCoords = new Vector2(uvs.MaxX, uvs.MinY)
                };
                var v2 = new CharacterVertex()
                {
                    position = new Vector2(position.X + box.Size.X + 1, position.Y + box.Size.Y + 1),
                    texCoords = new Vector2(uvs.MaxX, uvs.MaxY)
                };
                var v3 = new CharacterVertex()
                {
                    position = new Vector2(position.X - 1, position.Y + box.Size.Y + 1),
                    texCoords = new Vector2(uvs.MinX, uvs.MaxY)
                };

                vertices.Add(v0);
                vertices.Add(v1);
                vertices.Add(v2);

                vertices.Add(v2);
                vertices.Add(v3);
                vertices.Add(v0);
            }
        }

        public readonly Texture2D m_texture;

        private readonly VertexShader m_vertexShader;
        private readonly FragmentShader m_fragmentShader;
        private readonly Granite3D.Program m_program;

        public Font()
        {
            m_texture = Engine.CreateTexture2D();
            m_texture.SetData(s_width, s_height, s_bytes);

            m_vertexShader = Engine.CreateVertexShader(@"
#version 110

attribute vec2 position;
attribute vec2 texcoord;

uniform mat4 matrix;

varying vec2 t;

void main()
{
    gl_Position = matrix * vec4(position.x, position.y, 0.0, 1.0);
    t = texcoord;
}
");
            m_fragmentShader = Engine.CreateFragmentShader(@"
#version 110

uniform sampler2D texture;
uniform vec3 color;

varying vec2 t;

void main()
{
    gl_FragColor = vec4(color.x, color.y, color.z, texture2D(texture, t).x);
}
");
            m_program = Engine.CreateProgram(m_vertexShader, m_fragmentShader);
        }

        public void DrawText(Display display, Vector2i position, string s)
        {
            var vertices = new List<CharacterVertex>();
            int x = 0;

            foreach (var c in s)
            {
                int index = (int)c;
                if (index > 0 && index < s_var_small_characters.Length)
                {
                    var ch = s_var_small_characters[index];

                    if (ch != null)
                    {
                        ch.AppendTo(vertices, new Vector2i(position.X + x, position.Y));
                        x += ch.box.Size.X;
                    }
                }
            }

            using (var buffer = Engine.CreateBuffer(vertices.ToArray()))
            {
                var positions = buffer.GetView("position");
                var texcoords = buffer.GetView("texCoords");

                var instance = m_program.CreateInstance(new Dictionary<string, IBufferView>()
                {
                    { "position", positions },
                    { "texcoord", texcoords }
                });

                var matrix = Matrix4.Identity;

                matrix = matrix * Matrix4.Translate(-1f, 1f, 0f);
                matrix = matrix * Matrix4.Scale(2f / display.Width, -2f / display.Height, 1);
                
                Engine.Gl.Disable(GL.DEPTH_TEST);
                
                instance.SetUniform("texture", m_texture);

                instance.SetUniform("matrix", matrix * Matrix4.Translate(1f, 1f, 0f));
                instance.SetUniform("color", new Vector3(0.2f, 0.2f, 0.2f));
                instance.Draw(vertices.Count);

                instance.SetUniform("matrix", matrix);
                instance.SetUniform("color", new Vector3(1f, 1f, 1f));
                instance.Draw(vertices.Count);
            }
        }

    }
}
