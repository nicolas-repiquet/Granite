using Granite.Core;
using Granite.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test.Game_01.Entities;
using Test.Game_01.Sprites;

namespace Test.Game_01.Maps
{
    public sealed class Map
    {
        public const int CELL_SIZE = 32;
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

            public Cell GetCell(int x, int y)
            {
                if (x >= 0 && x < CELL_PACK_SIZE
                    && y >= 0 && y < CELL_PACK_SIZE)
                {
                    return m_cells[x, y];
                }

                return null;
            }
        }

        public sealed class Cell
        {
            public Material Material { get; private set; }
            
            public ISpriteInstance Sprite { get; private set; }

            public VerticalEdge LeftEdge { get; set; }
            public VerticalEdge RightEdge { get; set; }
            
            public HorizontalEdge TopEdge { get; set; }
            public HorizontalEdge BottomEdge { get; set; }

            public Cell(Material material, ISpriteInstance sprite)
            {
                Material = material;
                Sprite = sprite;
            }
        }

        public sealed class VerticalEdge
        {
            public int X { get; private set; }
            public int NX { get; private set; }
            public int Y0 { get; private set; }
            public int Y1 { get; private set; }

            public VerticalEdge(int x, int nx, int y0, int y1)
            {
                X = x;
                NX = nx;
                Y0 = y0;
                Y1 = y1;
            }
        }

        public sealed class HorizontalEdge
        {
            public int Y { get; private set; }
            public int NY { get; private set; }
            public int X0 { get; private set; }
            public int X1 { get; private set; }

            public HorizontalEdge(int y, int ny, int x0, int x1)
            {
                Y = y;
                NY = ny;
                X0 = x0;
                X1 = x1;
            }
        }

        public struct Collision : IComparable<Collision>
        {
            public Vector2 Displacement { get; set; }
            public Vector2 Normal { get; set; }            
            public Box2 AjustedLocation { get; set; }
            public Material Material { get; set; }

            public int CompareTo(Collision other)
            {
                return Math.Sign(Displacement.SquaredLength - other.Displacement.SquaredLength);
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

            for (int y = 0; y < m_height; y++)
            {
                for (int x = 0; x < m_width; x++)
                {
                    var cell = GetCellAtIndex(x, y);

                    if (cell != null)
                    {
                        var leftCell = GetCellAtIndex(x - 1, y);
                        var bottomCell = GetCellAtIndex(x, y - 1);
                        var rightCell = GetCellAtIndex(x + 1, y);
                        var topCell = GetCellAtIndex(x, y + 1);

                        if (x == 0 || leftCell == null)
                        {
                            cell.LeftEdge = new VerticalEdge(
                                x * CELL_SIZE,
                                GetNormal(null, cell),
                                y * CELL_SIZE,
                                y * CELL_SIZE + CELL_SIZE
                            );
                        }
                        else
                        {
                            cell.LeftEdge = leftCell.RightEdge;
                        }

                        if (y == 0 || bottomCell == null)
                        {
                            cell.BottomEdge = new HorizontalEdge(
                                y * CELL_SIZE,
                                GetNormal(cell, null),
                                x * CELL_SIZE,
                                x * CELL_SIZE + CELL_SIZE
                            );
                        }
                        else
                        {
                            cell.BottomEdge = bottomCell.TopEdge;
                        }

                        cell.RightEdge = new VerticalEdge(
                            x * CELL_SIZE + CELL_SIZE,
                            GetNormal(cell, rightCell),
                            y * CELL_SIZE,
                            y * CELL_SIZE + CELL_SIZE
                        );

                        cell.TopEdge = new HorizontalEdge(
                            y * CELL_SIZE + CELL_SIZE,
                            GetNormal(topCell, cell),
                            x * CELL_SIZE,
                            x * CELL_SIZE + CELL_SIZE
                        );
                    }
                }
            }
        }

        private int GetNormal(Cell cell0, Cell cell1)
        {
            if (cell0 == null || cell0.Material.CanPassThrough)
            {
                if (cell1 == null || cell1.Material.CanPassThrough)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                if (cell1 == null || cell1.Material.CanPassThrough)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }

        public Cell GetCellAtIndex(int x, int y)
        {
            if (x < 0 || x >= m_width || y < 0 || y >= m_height)
            {
                return null;
            }
            else
            {
                return m_packs[x / CELL_PACK_SIZE, y / CELL_PACK_SIZE].GetCell(x % CELL_PACK_SIZE, y % CELL_PACK_SIZE);
            }
        }

        private void AdjustYLocation(Box2 location, Vector2 displacement, List<Collision> collisions)
        {
            var xstart = (int)(location.MinX / CELL_SIZE);
            var xstop = (int)(location.MaxX / CELL_SIZE);
            var ystart = (int)(location.MinY / CELL_SIZE);
            var ystop = (int)(location.MaxY / CELL_SIZE);

            for (int y = ystart; y <= ystop; y++)
            {
                for (int x = xstart; x <= xstop; x++)
                {
                    var cell = GetCellAtIndex(x, y);

                    if (cell != null)
                    {
                        if (displacement.Y > 0)
                        {
                            if (cell.BottomEdge.NY == -1 &&
                                cell.BottomEdge.X0 < location.MaxX &&
                                cell.BottomEdge.X1 > location.MinX &&
                                cell.BottomEdge.Y > location.MinY &&
                                cell.BottomEdge.Y < location.MaxY)
                            {
                                var d = new Vector2(0, cell.BottomEdge.Y - location.MaxY);
                                collisions.Add(new Collision()
                                {
                                    Displacement = d,
                                    Material = cell.Material,
                                    Normal = new Vector2(0, -1),
                                    AjustedLocation = location.Translate(d)
                                });
                            }
                        }
                        else if (displacement.Y < 0)
                        {
                            if (cell.TopEdge.NY == 1 &&
                                cell.TopEdge.X0 < location.MaxX &&
                                cell.TopEdge.X1 > location.MinX &&
                                cell.TopEdge.Y > location.MinY &&
                                cell.TopEdge.Y < location.MaxY)
                            {
                                var d = new Vector2(0, cell.TopEdge.Y - location.MinY);
                                collisions.Add(new Collision()
                                {
                                    Displacement = d,
                                    Material = cell.Material,
                                    Normal = new Vector2(0, 1),
                                    AjustedLocation = location.Translate(d)
                                });
                            }
                        }
                    }
                }
            }
        }

        public void AdjustXLocation(Box2 location, Vector2 displacement, List<Collision> collisions)
        {
            var xstart = (int)(location.MinX / CELL_SIZE);
            var xstop = (int)(location.MaxX / CELL_SIZE);
            var ystart = (int)(location.MinY / CELL_SIZE);
            var ystop = (int)(location.MaxY / CELL_SIZE);

            for (int y = ystart; y <= ystop; y++)
            {
                for (int x = xstart; x <= xstop; x++)
                {
                    var cell = GetCellAtIndex(x, y);

                    if (cell != null)
                    {
                        if (displacement.X > 0)
                        {
                            if (cell.LeftEdge.NX == 1 &&
                                cell.LeftEdge.Y0 < location.MaxY &&
                                cell.LeftEdge.Y1 > location.MinY &&
                                cell.LeftEdge.X > location.MinX &&
                                cell.LeftEdge.X < location.MaxX)
                            {
                                var d = new Vector2(cell.LeftEdge.X - location.MaxX, 0);
                                collisions.Add(new Collision()
                                {
                                    Displacement = d,
                                    Material = cell.Material,
                                    Normal = new Vector2(1, 0),
                                    AjustedLocation = location.Translate(d)
                                });
                            }
                        }
                        else if (displacement.X < 0)
                        {
                            if (cell.RightEdge.NX == -1 &&
                                cell.RightEdge.Y0 < location.MaxY &&
                                cell.RightEdge.Y1 > location.MinY &&
                                cell.RightEdge.X > location.MinX &&
                                cell.RightEdge.X < location.MaxX)
                            {
                                var d = new Vector2(cell.RightEdge.X - location.MinX, 0);
                                collisions.Add(new Collision()
                                {
                                    Displacement = d,
                                    Material = cell.Material,
                                    Normal = new Vector2(-1, 0),
                                    AjustedLocation = location.Translate(d)
                                });
                            }
                        }
                    }
                }
            }

        }

        public Collision? TestCollision(Box2 location, Vector2 displacement)
        {
            var collisions = new List<Collision>();

            AdjustXLocation(location, displacement, collisions);
            AdjustYLocation(location, displacement, collisions);

            if (collisions.Count == 0)
            {
                return null;
            }
            else if (collisions.Count == 1)
            {
                return collisions[0];
            }
            else
            {
                collisions.Sort();

                var result = new Collision()
                {
                    Material = collisions[0].Material,
                    Normal = collisions[0].Normal
                };

                var adjustedLocation = collisions[0].AjustedLocation;

                while(true)
                {
                    collisions.Clear();

                    AdjustXLocation(adjustedLocation, displacement, collisions);
                    AdjustYLocation(adjustedLocation, displacement, collisions);

                    if (collisions.Count == 0)
                    {
                        break;
                    }
                    else
                    {
                        collisions.Sort();
                        adjustedLocation = collisions[0].AjustedLocation;
                    }
                }

                result.AjustedLocation = adjustedLocation;
                result.Displacement = adjustedLocation.Position - location.Position;

                return result;
            }

            //Vector2 xnormal;
            //Material xmaterial;
            //var xlocation = AdjustXLocation(location, displacement, out xmaterial, out xnormal);
            //Vector2 ynormal;
            //Material ymaterial;
            //var ylocation = AdjustYLocation(location, displacement, out ymaterial, out ynormal);
            //var xdisplacement = location.Position - xlocation.Position;
            //var ydisplacement = location.Position - ylocation.Position;
            //var xlength = xdisplacement.Length;
            //var ylength = ydisplacement.Length;

            //if (xlength > 0)
            //{
            //    if (ylength > 0)
            //    {
            //        if (xlength < ylength)
            //        {
            //            return new Collision()
            //            {
            //                Normal = xnormal,
            //                Material = xmaterial,
            //                AjustedPosition = AdjustYLocation(xlocation, displacement, out ymaterial, out ynormal)
            //            };
            //        }
            //        else
            //        {
            //            return new Collision()
            //            {
            //                Normal = ynormal,
            //                Material = ymaterial,
            //                AjustedPosition = AdjustXLocation(ylocation, displacement, out xmaterial, out xnormal)
            //            };
            //        }
            //    }
            //    else
            //    {
            //        return new Collision()
            //        {
            //            Normal = xnormal,
            //            Material = xmaterial,
            //            AjustedPosition = xlocation
            //        };
            //    }
            //}
            //else
            //{
            //    if (ylength > 0)
            //    {
            //        return new Collision()
            //        {
            //            Normal = ynormal,
            //            Material = ymaterial,
            //            AjustedPosition = ylocation
            //        };
            //    }
            //    else
            //    {
            //        return null;
            //    }
            //}
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

            RenderDebugData();
        }

        #region DEBUG
        private readonly Graphics m_g = new Graphics();
        private void RenderDebugData()
        {
            m_g.Clear();
            var camera = World.Instance.Camera;

            for (int y = 0; y < m_height; y++)
            {
                for (int x = 0; x < m_width; x++)
                {
                    var cell = GetCellAtIndex(x, y);

                    if (cell != null)
                    {
                        if (cell.LeftEdge.NX == 1)
                        {
                            m_g.FillRectangle(new Box2i(
                                cell.LeftEdge.X - 1 - (int)camera.Location.MinX,
                                cell.LeftEdge.Y0 - (int)camera.Location.MinY, 2, CELL_SIZE),
                                new Color4(0xFF, 0x00, 0x00, 0xFF));
                        }

                        if (cell.RightEdge.NX == -1)
                        {
                            m_g.FillRectangle(new Box2i(
                                cell.RightEdge.X - 1 - (int)camera.Location.MinX,
                                cell.RightEdge.Y0 - (int)camera.Location.MinY, 2, CELL_SIZE),
                                new Color4(0x00, 0xFF, 0x00, 0xFF));
                        }

                        if (cell.TopEdge.NY == 1)
                        {
                            m_g.FillRectangle(new Box2i(
                                cell.TopEdge.X0 - (int)camera.Location.MinX,
                                cell.TopEdge.Y - 1 - (int)camera.Location.MinY, CELL_SIZE, 2),
                                new Color4(0xFF, 0x00, 0xFF, 0xFF));
                        }

                        if (cell.BottomEdge.NY == -1)
                        {
                            m_g.FillRectangle(new Box2i(
                                cell.BottomEdge.X0 - (int)camera.Location.MinX,
                                cell.BottomEdge.Y - 1 - (int)camera.Location.MinY, CELL_SIZE, 2),
                                new Color4(0xFF, 0xFF, 0x00, 0xFF));
                        }
                    }
                }
            }

            var player = World.Instance.Player.Location;
            m_g.FillRectangle(new Box2i(
                (int)(player.MinX - camera.Location.MinX),
                (int)(player.MinY - camera.Location.MinY),
                (int)player.Size.X, (int)player.Size.Y
            ), new Color4(0x00, 0xFF, 0xFF, 0x80));

            foreach (var ennemy in World.Instance.Ennemies)
            {
                m_g.FillRectangle(new Box2i(
                    (int)(ennemy.Location.MinX - camera.Location.MinX),
                    (int)(ennemy.Location.MinY - camera.Location.MinY),
                    (int)ennemy.Location.Size.X, (int)ennemy.Location.Size.Y
                ), new Color4(0xFF, 0xFF, 0x00, 0x80));
            }
            m_g.Flush();
        }
        #endregion


        /// <summary>
        /// Récupère le pack de cellules où se trouve la position passé en paramètre.
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public Material GetMaterial(Vector2 position)
        {
            Material mat = null;

            var cell = GetCell(position);

            if (cell != null)
            {
                mat = cell.Material;
            }

            return mat;
        }

        public Cell GetCell(Vector2 position)
        {
            Cell cell = null;

            var packX = (int)(position.X / (CELL_PACK_SIZE * CELL_SIZE));

            var cellX = (int)((position.X - (packX * (CELL_PACK_SIZE * CELL_SIZE))) / CELL_SIZE);

            var packY = (int)(position.Y / (CELL_PACK_SIZE * CELL_SIZE));

            var cellY = (int)((position.Y - (packY * (CELL_PACK_SIZE * CELL_SIZE))) / CELL_SIZE);

            if (packX >= 0 && packX < m_packWidth
                && packY >= 0 && packY < m_packHeight
                && cellX >= 0 && cellX < CELL_PACK_SIZE
                && cellY >= 0 && cellY < CELL_PACK_SIZE
                )
            {
                cell = m_packs[packX, packY].GetCell(cellX, cellY);
            }

            return cell;
        }

        public Vector2 Size { get { return new Vector2(m_width * CELL_SIZE, m_height * CELL_SIZE); } }
    }
}
