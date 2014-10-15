using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test.Game_01.Sprites;

namespace Test.Game_01.Maps
{
    public sealed class Map
    {
        private const int CELL_SIZE = 70;
        private const int CELL_PACK_SIZE = 16;

        private sealed class CellPack
        {
            public SpriteRenderer Renderer { get; private set; }
            private readonly Cell[,] m_cells;

            public CellPack()
            {
                Renderer = new SpriteRenderer(TilesSprites.Instance);
                m_cells = new Cell[CELL_PACK_SIZE, CELL_PACK_SIZE];
            }

            public void SetMaterial(int x, int y, Material material, Sprite sprite)
            {
                var cell = new Cell(material, Renderer.AddSprite(sprite));
                cell.Sprite.Position = new Vector2(x * CELL_SIZE, y * CELL_SIZE);
                cell.Sprite.Size = new Vector2(CELL_SIZE, CELL_SIZE);
                m_cells[x, y] = cell;
            }
        }

        private sealed class Cell
        {
            public Material Material { get; private set; }
            public ISpriteInstance Sprite { get; private set; }

            public Cell(Material material, ISpriteInstance sprite)
            {
                Material = material;
                Sprite = sprite;
            }
        }

        private readonly int m_width;
        private readonly int m_height;
        private readonly int m_packWidth;
        private readonly int m_packHeight;
        private readonly CellPack[,] m_packs;

        public Map(Material[,] materials)
        {
            m_width = materials.GetLength(0);
            m_height = materials.GetLength(1);

            var packWidth = m_width / CELL_PACK_SIZE;
            if (m_width % CELL_PACK_SIZE != 0)
            {
                packWidth++;
            }
            m_packWidth = packWidth;

            var packHeight = m_height / CELL_PACK_SIZE;
            if (m_height % CELL_PACK_SIZE != 0)
            {
                packHeight++;
            }
            m_packHeight = packHeight;

            m_packs = new CellPack[m_packWidth, m_packHeight];

            for (int y = 0; y < m_packHeight; y++)
            {
                for (int x = 0; x < m_packWidth; x++)
                {
                    m_packs[x, y] = new CellPack();
                }
            }

            for (int y = 0; y < m_height; y++)
            {
                var py = y / CELL_PACK_SIZE;
                var cy = y % CELL_PACK_SIZE;

                for (int x = 0; x < m_width; x++)
                {
                    if (materials[x, y] != null)
                    {
                        Material topLeft = null;
                        Material top = null;
                        Material topRight = null;

                        Material left = null;
                        Material right = null;

                        Material bottomLeft = null;
                        Material bottom = null;
                        Material bottomRight = null;

                        if (x > 0)
                        {
                            left = materials[x - 1, y];

                            if (y > 0)
                            {
                                bottomLeft = materials[x - 1, y - 1];
                            }
                            if (y < m_height - 1)
                            {
                                topLeft = materials[x - 1, y + 1];
                            }
                        }

                        if (x < m_width - 1)
                        {
                            right = materials[x + 1, y];

                            if (y > 0)
                            {
                                bottomRight = materials[x + 1, y - 1];
                            }
                            if (y < m_height - 1)
                            {
                                topRight = materials[x + 1, y + 1];
                            }
                        }

                        if (y > 0)
                        {
                            bottom = materials[x, y - 1];
                        }

                        if (y < m_height - 1)
                        {
                            top = materials[x, y + 1];
                        }

                        var px = x / CELL_PACK_SIZE;
                        var cx = x % CELL_PACK_SIZE;

                        var pack = m_packs[px, py];

                        var material = materials[x, y];
                        var sprite = material.GetSprite(
                            topLeft, top, topRight,
                            left, right,
                            bottomLeft, bottom, bottomRight
                        );

                        pack.SetMaterial(cx, cy, material, sprite);
                    }
                }
            }
        }

        public void Render(Matrix4 transform)
        {
            for (int y = 0; y < m_packHeight; y++)
            {
                for (int x = 0; x < m_packWidth; x++)
                {
                    m_packs[x, y].Renderer.Render(
                        transform * Matrix4.Translate(x * CELL_PACK_SIZE * CELL_SIZE, y * CELL_PACK_SIZE * CELL_SIZE, 0f)
                    );
                }
            }
        }

        public Vector2 Size { get { return new Vector2(m_width * CELL_SIZE, m_height * CELL_SIZE); } }
    }
}
