using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite.Render
{
    public sealed class Renderer
    {
        private struct RendererData
        {
            public Color4ub Color;
            public Vector2 Position;
            public Vector2 TextureCoordinates;
        }

        private TriangleProgram m_program;
        private readonly Buffer<RendererData> m_buffer;
        private readonly VertexArray m_vao;
        private List<RendererData> m_datas;

        public Renderer(TriangleProgram program)
        {
            m_program = program;
            m_datas = new List<RendererData>();

            m_vao = new VertexArray();

            GL.BindVertexArray(m_vao);

            m_buffer = new Buffer<RendererData>();

            GL.UseProgram(m_program);

            m_program.Position.SetValue(m_buffer.GetView(s => s.Position));
            m_program.Color.SetValue(m_buffer.GetView(s => s.Color));
            m_program.TextureCoordinates.SetValue(m_buffer.GetView(s => s.TextureCoordinates));

            GL.BindVertexArray(null);
        }

        public void AddRenderObject(RenderObject obj)
        {
            //Si sprite on fait 2 triangles
            if (obj.Sprite != null)
            {
                var pos = obj.Position[0];
                var halfSize = obj.Size / 2;
                var pos1 = pos - halfSize;
                var pos2 = new Vector2(pos.X - halfSize.X, pos.Y + halfSize.Y);
                var pos3 = new Vector2(pos.X + halfSize.X, pos.Y - halfSize.Y);
                var pos4 = pos + halfSize;

                //Triangle 1
                var data = new RendererData();

                data.Color = obj.Color;
                data.Position = pos1;
                data.TextureCoordinates = new Vector2(obj.Sprite.Coordinates.MinX, obj.Sprite.Coordinates.MaxY);

                m_datas.Add(data);

                data = new RendererData();

                data.Color = obj.Color;
                data.Position = pos2;
                data.TextureCoordinates = new Vector2(obj.Sprite.Coordinates.MinX, obj.Sprite.Coordinates.MinY);

                m_datas.Add(data);

                data = new RendererData();

                data.Color = obj.Color;
                data.Position = pos3;
                data.TextureCoordinates = new Vector2(obj.Sprite.Coordinates.MaxX, obj.Sprite.Coordinates.MaxY);

                m_datas.Add(data);

                //Triangle 2
                data = new RendererData();

                data.Color = obj.Color;
                data.Position = pos2;
                data.TextureCoordinates = new Vector2(obj.Sprite.Coordinates.MinX, obj.Sprite.Coordinates.MinY);

                m_datas.Add(data);

                data = new RendererData();

                data.Color = obj.Color;
                data.Position = pos3;
                data.TextureCoordinates = new Vector2(obj.Sprite.Coordinates.MaxX, obj.Sprite.Coordinates.MaxY);

                m_datas.Add(data);

                data = new RendererData();

                data.Color = obj.Color;
                data.Position = pos4;
                data.TextureCoordinates = new Vector2(obj.Sprite.Coordinates.MaxX, obj.Sprite.Coordinates.MinY);

                m_datas.Add(data);
            }
            else
            {
                var data = new RendererData();

                data.Color = obj.Color;
                data.Position = obj.Position[0];

                m_datas.Add(data);

                data = new RendererData();

                data.Color = obj.Color;
                data.Position = obj.Position[1];

                m_datas.Add(data);

                data = new RendererData();

                data.Color = obj.Color;
                data.Position = obj.Position[2];

                m_datas.Add(data);
            }
        }

        public void Clear()
        {
            m_datas.Clear();
        }

        public void Render(Matrix4 transform)
        {
            RebuildBuffer();

            if (m_datas.Count != 0)
            {
                GL.BindVertexArray(m_vao);
                GL.UseProgram(m_program);

                m_program.Projection.SetValue(transform);
                //m_program.Texture.SetValue(SpriteSheet.Texture);

                GL.DrawArrays(GL.TRIANGLES, 0, m_datas.Count);

                //GL.BindVertexArray(null);
            }

            Clear();
        }

        private void RebuildBuffer()
        {
            GL.BindVertexArray(m_vao);
            m_buffer.SetData(m_datas.ToArray(), GL.STREAM_DRAW);
        }
    }
}
