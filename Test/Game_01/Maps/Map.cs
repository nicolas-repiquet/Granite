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
        public const int CELL_SIZE = 70;
        private const int CELL_PACK_SIZE = 16;

        private sealed class CellPack
        {
            public SpriteRenderer Renderer { get; private set; }
            private readonly Cell[,] m_cells;
            public List<Segment> Segments_green { get; set; }
            public List<Segment> Segments_blue { get; set; }
            public List<Segment> Segments_purple { get; set; }
            public List<Segment> Segments_red { get; set; }

            public CellPack()
            {
                Renderer = new SpriteRenderer(TilesSprites.Instance);
                m_cells = new Cell[CELL_PACK_SIZE, CELL_PACK_SIZE];

                Segments_green = new List<Segment>();
                Segments_blue = new List<Segment>();
                Segments_purple = new List<Segment>();
                Segments_red = new List<Segment>();
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

        public abstract class Edge
        {

        }

        public sealed class VerticalEdge : Edge
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

        public sealed class HorizontalEdge : Edge
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

        public sealed class Collision
        {
            public Box2 AjustedPosition { get; set; }
            public Vector2 Normal { get; set; }
            public Material Material { get; set; }
        }

        public class Segment
        {
            public Vector2 P1 { get; set; }
            public Vector2 P2 { get; set; }
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

            CalculSegments();

            for (int y = 0; y < m_height; y++)
            {
                for (int x = 0; x < m_width; x++)
                {
                    var cell = GetCell(x, y);

                    if (cell != null)
                    {
                        var leftCell = GetCell(x - 1, y);
                        var bottomCell = GetCell(x, y - 1);
                        var rightCell = GetCell(x + 1, y);
                        var topCell = GetCell(x, y + 1);

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

        public Cell GetCell(int x, int y)
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

        private Box2 AdjustYLocation(Box2 location, Vector2 displacement, out Material material, out Vector2 normal)
        {
            var adjustedLocation = location;

            var xstart = (int)(location.MinX / CELL_SIZE);
            var xstop = (int)(location.MaxX / CELL_SIZE);
            var ystart = (int)(location.MinY / CELL_SIZE);
            var ystop = (int)(location.MaxY / CELL_SIZE);

            material = null;
            normal = Vector2.Zero;

            for (int y = ystart; y <= ystop; y++)
            {
                for (int x = xstart; x <= xstop; x++)
                {
                    var cell = GetCell(x, y);

                    if (cell != null)
                    {
                        if (displacement.Y > 0)
                        {
                            if (cell.BottomEdge.NY == -1 &&
                                cell.BottomEdge.X0 < adjustedLocation.MaxX &&
                                cell.BottomEdge.X1 > adjustedLocation.MinX &&
                                cell.BottomEdge.Y > adjustedLocation.MinY &&
                                cell.BottomEdge.Y < adjustedLocation.MaxY)
                            {
                                material = cell.Material;
                                normal = new Vector2(0, -1);

                                adjustedLocation = adjustedLocation.Translate(new Vector2(0, cell.BottomEdge.Y - adjustedLocation.MaxY));
                            }
                        }
                        else if (displacement.Y < 0)
                        {
                            if (cell.TopEdge.NY == 1 &&
                                cell.TopEdge.X0 < adjustedLocation.MaxX &&
                                cell.TopEdge.X1 > adjustedLocation.MinX &&
                                cell.TopEdge.Y > adjustedLocation.MinY &&
                                cell.TopEdge.Y < adjustedLocation.MaxY)
                            {
                                material = cell.Material;
                                normal = new Vector2(0, 1);

                                adjustedLocation = adjustedLocation.Translate(new Vector2(0, cell.TopEdge.Y - adjustedLocation.MinY));
                            }
                        }
                    }
                }
            }

            return adjustedLocation;
        }

        public Box2 AdjustXLocation(Box2 location, Vector2 displacement, out Material material, out Vector2 normal)
        {
            var adjustedLocation = location;

            var xstart = (int)(location.MinX / CELL_SIZE);
            var xstop = (int)(location.MaxX / CELL_SIZE);
            var ystart = (int)(location.MinY / CELL_SIZE);
            var ystop = (int)(location.MaxY / CELL_SIZE);

            material = null;
            normal = Vector2.Zero;

            for (int y = ystart; y <= ystop; y++)
            {
                for (int x = xstart; x <= xstop; x++)
                {
                    var cell = GetCell(x, y);

                    if (cell != null)
                    {
                        if (displacement.X > 0)
                        {
                            if (cell.LeftEdge.NX == 1 &&
                                cell.LeftEdge.Y0 < adjustedLocation.MaxY &&
                                cell.LeftEdge.Y1 > adjustedLocation.MinY &&
                                cell.LeftEdge.X > adjustedLocation.MinX &&
                                cell.LeftEdge.X < adjustedLocation.MaxX)
                            {
                                material = cell.Material;
                                normal = new Vector2(1, 0);

                                adjustedLocation = adjustedLocation.Translate(new Vector2(cell.LeftEdge.X - adjustedLocation.MaxX, 0));
                            }
                        }
                        else if (displacement.X < 0)
                        {
                            if (cell.RightEdge.NX == -1 &&
                                cell.RightEdge.Y0 < adjustedLocation.MaxY &&
                                cell.RightEdge.Y1 > adjustedLocation.MinY &&
                                cell.RightEdge.X > adjustedLocation.MinX &&
                                cell.RightEdge.X < adjustedLocation.MaxX)
                            {
                                material = cell.Material;
                                normal = new Vector2(-1, 0);

                                adjustedLocation = adjustedLocation.Translate(new Vector2(cell.RightEdge.X - adjustedLocation.MinX, 0));
                            }
                        }
                    }
                }
            }

            return adjustedLocation;
        }

        public Collision TestCollision(Box2 location, Vector2 displacement)
        {
            Vector2 xnormal;
            Material xmaterial;
            var xlocation = AdjustXLocation(location, displacement, out xmaterial, out xnormal);
            Vector2 ynormal;
            Material ymaterial;
            var ylocation = AdjustYLocation(location, displacement, out ymaterial, out ynormal);
            var xdisplacement = location.Position - xlocation.Position;
            var ydisplacement = location.Position - ylocation.Position;
            var xlength = xdisplacement.Length;
            var ylength = ydisplacement.Length;

            if (xlength > 0)
            {
                if (ylength > 0)
                {
                    if (xlength < ylength)
                    {
                        return new Collision()
                        {
                            Normal = xnormal,
                            Material = xmaterial,
                            AjustedPosition = AdjustYLocation(xlocation, displacement, out ymaterial, out ynormal)
                        };
                    }
                    else
                    {
                        return new Collision()
                        {
                            Normal = ynormal,
                            Material = ymaterial,
                            AjustedPosition = AdjustXLocation(ylocation, displacement, out xmaterial, out xnormal)
                        };
                    }
                }
                else
                {
                    return new Collision()
                    {
                        Normal = xnormal,
                        Material = xmaterial,
                        AjustedPosition = xlocation
                    };
                }
            }
            else
            {
                if (ylength > 0)
                {
                    return new Collision()
                    {
                        Normal = ynormal,
                        Material = ymaterial,
                        AjustedPosition = ylocation
                    };
                }
                else
                {
                    return null;
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
                    var cell = GetCell(x, y);

                    if (cell != null)
                    {
                        if (cell.LeftEdge.NX == 1)
                        {
                            m_g.FillRectangle(new Box2i(
                                cell.LeftEdge.X - 1 - (int)camera.Location.MinX,
                                cell.LeftEdge.Y0 - (int)camera.Location.MinY, 2, 70),
                                new Color4(0xFF, 0x00, 0x00, 0xFF));
                        }

                        if (cell.RightEdge.NX == -1)
                        {
                            m_g.FillRectangle(new Box2i(
                                cell.RightEdge.X - 1 - (int)camera.Location.MinX,
                                cell.RightEdge.Y0 - (int)camera.Location.MinY, 2, 70),
                                new Color4(0x00, 0xFF, 0x00, 0xFF));
                        }

                        if (cell.TopEdge.NY == 1)
                        {
                            m_g.FillRectangle(new Box2i(
                                cell.TopEdge.X0 - (int)camera.Location.MinX,
                                cell.TopEdge.Y - 1 - (int)camera.Location.MinY, 70, 2),
                                new Color4(0xFF, 0x00, 0xFF, 0xFF));
                        }

                        if (cell.BottomEdge.NY == -1)
                        {
                            m_g.FillRectangle(new Box2i(
                                cell.BottomEdge.X0 - (int)camera.Location.MinX,
                                cell.BottomEdge.Y - 1 - (int)camera.Location.MinY, 70, 2),
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

            m_g.Flush();
        }
        #endregion

        private void CalculSegments()
        {
            
            for (var packRow = 0; packRow < m_packHeight; packRow++)
            {
                for (var packCol = 0; packCol < m_packWidth; packCol++)
                {
                    var pack = m_packs[packCol, packRow];

                    for (var row = 0; row < CELL_PACK_SIZE; row++)
                    {
                        for (var col = 0; col < CELL_PACK_SIZE; col++)
                        {
                            var cell = pack.GetCell(col, row);

                            if (cell != null && cell.Material == Grass.Instance)
                            {
                                //Vert
                                if (row != CELL_PACK_SIZE - 1)
                                {
                                    var cellTop = pack.GetCell(col, row+1);

                                    if (cellTop == null)
                                    {
                                        pack.Segments_green.Add(new Segment()
                                            {
                                                P1 = new Vector2(
                                                    col * CELL_SIZE + packCol * CELL_PACK_SIZE * CELL_SIZE,
                                                    (row + 1) * CELL_SIZE + packRow * CELL_PACK_SIZE * CELL_SIZE),
                                                P2 = new Vector2(
                                                    (col + 1) * CELL_SIZE + packCol * CELL_PACK_SIZE * CELL_SIZE,
                                                    (row + 1) * CELL_SIZE + packRow * CELL_PACK_SIZE * CELL_SIZE),
                                            });
                                    }
                                }

                                //Violet
                                if (row != 0)
                                {
                                    var cellBottom = pack.GetCell(col, row-1);

                                    if (cellBottom == null)
                                    {
                                        pack.Segments_purple.Add(new Segment()
                                        {
                                            P1 = new Vector2(
                                                col * CELL_SIZE + packCol * CELL_PACK_SIZE * CELL_SIZE,
                                                row * CELL_SIZE + packRow * CELL_PACK_SIZE * CELL_SIZE),
                                            P2 = new Vector2(
                                                (col + 1) * CELL_SIZE + packCol * CELL_PACK_SIZE * CELL_SIZE,
                                                row * CELL_SIZE + packRow * CELL_PACK_SIZE * CELL_SIZE),
                                        });
                                    }
                                }

                                //Rouge
                                if (col != 0)
                                {
                                    var cellLeft = pack.GetCell(col-1, row);

                                    if (cellLeft == null)
                                    {
                                        pack.Segments_red.Add(new Segment()
                                        {
                                            P1 = new Vector2(
                                                col * CELL_SIZE + packCol * CELL_PACK_SIZE * CELL_SIZE,
                                                row * CELL_SIZE + packRow * CELL_PACK_SIZE * CELL_SIZE),
                                            P2 = new Vector2(
                                                col * CELL_SIZE + packCol * CELL_PACK_SIZE * CELL_SIZE,
                                                (row + 1) * CELL_SIZE + packRow * CELL_PACK_SIZE * CELL_SIZE),
                                        });
                                    }
                                }

                                //Bleu
                                if (col != CELL_PACK_SIZE - 1)
                                {
                                    var cellRight = pack.GetCell(col+1, row);

                                    if (cellRight == null)
                                    {
                                        pack.Segments_blue.Add(new Segment()
                                        {
                                            P1 = new Vector2(
                                                (col + 1) * CELL_SIZE + packCol * CELL_PACK_SIZE * CELL_SIZE,
                                                row * CELL_SIZE + packRow * CELL_PACK_SIZE * CELL_SIZE),
                                            P2 = new Vector2(
                                                (col + 1) * CELL_SIZE + packCol * CELL_PACK_SIZE * CELL_SIZE,
                                                (row + 1) * CELL_SIZE + packRow * CELL_PACK_SIZE * CELL_SIZE),
                                        });
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }


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

        public Tuple<float?, float?> Move(Vector2 location, Vector2 destination)
        {
            Vector2? result = null;

            //On récupère le cadran
            var cadran = Cadran(location, destination);

            //On récupère la case origin
            var packOriginX = (int)(location.X / (CELL_PACK_SIZE * CELL_SIZE));;
            var packOriginY = (int)(location.Y / (CELL_PACK_SIZE * CELL_SIZE));

            //On récupère la case destination
            var packDestX = (int)(destination.X / (CELL_PACK_SIZE * CELL_SIZE));
            var packDestY = (int)(destination.Y / (CELL_PACK_SIZE * CELL_SIZE));

            
            var segmentDirection = new Segment()
            {
                P1 = new Vector2(
                    location.X - packOriginX * CELL_PACK_SIZE * CELL_SIZE, 
                    location.Y - packOriginY * CELL_PACK_SIZE * CELL_SIZE),
                P2 = new Vector2(
                    destination.X - packDestX * CELL_PACK_SIZE * CELL_SIZE,
                    destination.Y - packDestY * CELL_PACK_SIZE * CELL_SIZE)
            };

            float? collisionX = null;
            float? collisionY = null;

            //Si les deux points sont dans le même pack
            if (cadran != Vector2.Zero
                && packOriginX == packDestX
                && packOriginY == packDestY)
            {
                var pack = m_packs[packOriginX, packOriginY];

                //Rouge
                if (cadran.X > 0)
                {
                    foreach (var segment in pack.Segments_red.Where(x => x.P1.X >= segmentDirection.P1.X))
                    {
                        var inter = IntersectionSegment(segmentDirection, segment);

                        if(inter != null)
                        {
                            if (collisionX == null || inter.Value.X < collisionX.Value)
                            {
                                collisionX = inter.Value.X;
                            }
                        }
                    }
                }

                //Bleu
                if (cadran.X < 0)
                {
                    foreach (var segment in pack.Segments_blue.Where(x => x.P1.X <= segmentDirection.P1.X))
                    {
                        var inter = IntersectionSegment(segmentDirection, segment);

                        if (inter != null)
                        {
                            if (collisionX == null || inter.Value.X > collisionX.Value)
                            {
                                collisionX = inter.Value.X;
                            }
                        }
                    }
                }

                //Violet
                if (cadran.Y > 0)
                {
                    foreach (var segment in pack.Segments_purple.Where(x => x.P1.Y >= segmentDirection.P1.Y))
                    {
                        var inter = IntersectionSegment(segmentDirection, segment);

                        if (inter != null)
                        {
                            if (collisionY == null || inter.Value.Y < collisionY.Value)
                            {
                                collisionY = inter.Value.Y;
                            }
                        }
                    }
                }

                //Vert
                if (cadran.Y < 0)
                {
                    foreach (var segment in pack.Segments_green.Where(x => x.P1.Y <= segmentDirection.P1.Y))
                    {
                        var inter = IntersectionSegment(segmentDirection, segment);

                        if (inter != null)
                        {
                            if (collisionY == null || inter.Value.Y > collisionY.Value)
                            {
                                collisionY = inter.Value.Y;
                            }
                        }
                    }
                }

                //On retransforme les coordonnées Pack => Monde
                if (collisionX.HasValue)
                {
                    collisionX = collisionX + packOriginX * CELL_PACK_SIZE * CELL_SIZE;
                }
                if (collisionY.HasValue)
                {
                    collisionY = collisionY + packOriginY * CELL_PACK_SIZE * CELL_SIZE;
                }
            }

            return new Tuple<float?, float?>(collisionX, collisionY);
        }

        /// <summary>
        /// Récupère les cases traversé par le rayCast
        /// </summary>
        /// <param name="cell"></param>
        /// <param name="cadran"></param>
        /// <returns></returns>
        public Queue<Vector2> SearchPath(Segment s, Vector2 cadran, int packX, int packY, out Vector2 collision)
        {
            var result = new Queue<Vector2>();
            collision = Vector2.Zero;

            //Si déplacement vertical
            if (s.P1.X == s.P2.X)
            {
                int row = (int)s.P1.Y;
                while(row != s.P2.Y)
                {
                    var cell = m_packs[packX, packY].GetCell((int)s.P1.X, row);
                    if (cell != null && cell.Material == Grass.Instance)
                    {
                        collision = new Vector2(0, Math.Sign(cadran.Y));
                        break;
                    }
                    else
                    {
                        result.Enqueue(new Vector2(s.P1.X, row));
                        row += Math.Sign(cadran.Y);
                    }
                }

                if (row == s.P2.Y)
                {
                    var cell = m_packs[packX, packY].GetCell((int)s.P1.X, row);
                    if (!(cell != null && cell.Material == Grass.Instance))
                    {
                        result.Enqueue(new Vector2(s.P1.X, row));
                    }
                    else
                    {
                        collision = new Vector2(0, Math.Sign(cadran.Y));
                    }
                }
            }
            else if (s.P1.Y == s.P2.Y) //Si déplacement horizontal
            {
                int col = (int)s.P1.X;
                while (col != s.P2.X)
                {
                    var cell = m_packs[packX, packY].GetCell(col, (int)s.P1.Y);
                    if (cell != null && cell.Material == Grass.Instance)
                    {
                        collision = new Vector2(Math.Sign(cadran.X), 0);
                        break;
                    }
                    else
                    {
                        result.Enqueue(new Vector2(col, s.P1.Y));
                        col += Math.Sign(cadran.X);
                    }
                }

                if (col == s.P2.X)
                {
                    var cell = m_packs[packX, packY].GetCell(col, (int)s.P1.Y);
                    if (!(cell != null && cell.Material == Grass.Instance))
                    {
                        result.Enqueue(new Vector2(col, s.P1.Y));
                    }
                    else
                    {
                        collision = new Vector2(Math.Sign(cadran.X), 0);
                    }
                }
            }
            else //Dans ce cas les 2 points sont sur des lignes et des colonnes différentes
            {
                var actualCell = s.P1;
                Vector2? inter = null;

                int col = (int)s.P1.X;
                while (col != s.P2.X)
                {
                    if (inter == null) //Premier tour
                    {
                        result.Enqueue(new Vector2(col, s.P1.Y));

                        //On calcul le point d'intersection de la prochaine colonne
                        inter = IntersectionSegment(s, new Segment()
                        {
                            P1 = new Vector2(col, 0),
                            P2 = new Vector2(col, CELL_PACK_SIZE)
                        });
                    }
                    else
                    {
                        //On calcul le point d'intersection de la prochaine colonne
                        Vector2? nextInter = IntersectionSegment(s, new Segment()
                        {
                            P1 = new Vector2(col + Math.Sign(cadran.X), 0),
                            P2 = new Vector2(col + Math.Sign(cadran.X), CELL_PACK_SIZE)
                        });

                        if (nextInter != null)
                        {
                            int row = (int)s.P1.Y;
                            while (row != s.P2.Y)
                            {
                                var cell = m_packs[packX, packY].GetCell((int)s.P1.X, row);
                                if (cell != null && cell.Material == Grass.Instance)
                                {
                                    if (row == (int)s.P1.Y)
                                    {
                                        collision = new Vector2(Math.Sign(cadran.X), 0);
                                    }
                                    else
                                    {
                                        collision = new Vector2(0, Math.Sign(cadran.Y));
                                    }
                                    break;
                                }
                                else
                                {
                                    result.Enqueue(new Vector2(s.P1.X, row));
                                    row += Math.Sign(cadran.Y);
                                }
                            }

                            if (col == s.P2.X)
                            {
                                var cell = m_packs[packX, packY].GetCell(col, (int)s.P1.Y);
                                if (!(cell != null && cell.Material == Grass.Instance))
                                {
                                    result.Enqueue(new Vector2(col, s.P1.Y));
                                }
                                else
                                {
                                    collision = new Vector2(Math.Sign(cadran.X), 0);
                                }
                            }

                            inter = nextInter;
                        }
                    }

                    if (inter == null)
                    {
                        break;
                    }

                    col += Math.Sign(cadran.X);
                }

            }

            return result;
        }

        public static Vector2 Cadran(Vector2 start, Vector2 end)
        {
            Vector2 cadran = new Vector2(end.X - start.X, end.Y - start.Y);

            if (cadran != Vector2.Zero)
            {
                return cadran.Normalize();
            }
            else
            {
                return Vector2.Zero;
            }
        }

        public Vector2? IntersectionSegment(Segment s1, Segment s2)
        {
            float Ax = s1.P1.X;
            float Ay = s1.P1.Y;
            float Bx = s1.P2.X;
            float By = s1.P2.Y;
            float Cx = s2.P1.X;
            float Cy = s2.P1.Y;
            float Dx = s2.P2.X;
            float Dy = s2.P2.Y;

            double Sx;
            double Sy;

            if (Ax == Bx)
            {
                if (Cx == Dx) return null;
                else
                {
                    double pCD = (Cy - Dy) / (Cx - Dx);
                    Sx = Ax;
                    Sy = pCD * (Ax - Cx) + Cy;
                }
            }
            else
            {
                if (Cx == Dx)
                {
                    double pAB = (Ay - By) / (Ax - Bx);
                    Sx = Cx;
                    Sy = pAB * (Cx - Ax) + Ay;
                }
                else
                {
                    double pCD = (Cy - Dy) / (Cx - Dx);
                    double pAB = (Ay - By) / (Ax - Bx);
                    double oCD = Cy - pCD * Cx;
                    double oAB = Ay - pAB * Ax;
                    Sx = (oAB - oCD) / (pCD - pAB);
                    Sy = pCD * Sx + oCD;
                }
            }
            if ((Sx < Ax && Sx < Bx) | (Sx > Ax && Sx > Bx) | (Sx < Cx && Sx < Dx) | (Sx > Cx && Sx > Dx)
                    | (Sy < Ay && Sy < By) | (Sy > Ay && Sy > By) | (Sy < Cy && Sy < Dy) | (Sy > Cy && Sy > Dy)) return null;
            return new Vector2((float)Sx, (float)Sy);
        }

        public bool Intersect(Vector2d startSegment, Vector2d endSegment, Vector2 cell)
        {
            //On test les 4 coté de la cellule
            var p1 = IntersectSegmentCorner(startSegment, endSegment, cell.X, cell.Y);
            var p2 = IntersectSegmentCorner(startSegment, endSegment, cell.X + 70, cell.Y);
            var p3 = IntersectSegmentCorner(startSegment, endSegment, cell.X + 70, cell.Y + 70);
            var p4 = IntersectSegmentCorner(startSegment, endSegment, cell.X, cell.Y + 70);

            return p1 || p2 || p3 || p4;
        }

        public bool IntersectSegmentCorner(Vector2d startSegment, Vector2d endSegment, double x, double y)
        {
            //On test les 4 coté de la cellule
            return (endSegment.Y - startSegment.Y) * x +
                (endSegment.X - startSegment.Y) * y
                + (endSegment.Y * startSegment.Y - startSegment.X * endSegment.X) == 0;
        }


        public Vector2 Size { get { return new Vector2(m_width * CELL_SIZE, m_height * CELL_SIZE); } }
    }
}
