using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Granite.Core
{
    public static class Extensions
    {
        public static Stream GetAssociatedResource(this Type type, string extension)
        {
            return type.Assembly.GetManifestResourceStream(type.FullName + "." + extension);
        }

        public static Color4ub Next(this Random random, Color4ub min, Color4ub max)
        {
            return new Color4ub(
                (byte)random.Next(min.R, max.R + 1),
                (byte)random.Next(min.G, max.G + 1),
                (byte)random.Next(min.B, max.B + 1),
                (byte)random.Next(min.A, max.A + 1)
            );
        }

        public static Vector2 Next(this Random random, Vector2 min, Vector2 max)
        {
            return new Vector2(
                min.X + (float)random.NextDouble() * (max.X - min.X),
                min.Y + (float)random.NextDouble() * (max.Y - min.Y)
            );
        }

        public static Vector2d Next(this Random random, Vector2d min, Vector2d max)
        {
            return new Vector2d(
                min.X + random.NextDouble() * (max.X - min.X),
                min.Y + random.NextDouble() * (max.Y - min.Y)
            );
        }

        public static Vector2b Next(this Random random, Vector2b min, Vector2b max)
        {
            return new Vector2b(
                (sbyte)random.Next(min.X, max.X + 1),
                (sbyte)random.Next(min.Y, max.Y + 1)
            );
        }

        public static Vector2ub Next(this Random random, Vector2ub min, Vector2ub max)
        {
            return new Vector2ub(
                (byte)random.Next(min.X, max.X + 1),
                (byte)random.Next(min.Y, max.Y + 1)
            );
        }

        public static Vector2s Next(this Random random, Vector2s min, Vector2s max)
        {
            return new Vector2s(
                (short)random.Next(min.X, max.X + 1),
                (short)random.Next(min.Y, max.Y + 1)
            );
        }

        public static Vector2us Next(this Random random, Vector2us min, Vector2us max)
        {
            return new Vector2us(
                (ushort)random.Next(min.X, max.X + 1),
                (ushort)random.Next(min.Y, max.Y + 1)
            );
        }

        public static Vector2i Next(this Random random, Vector2i min, Vector2i max)
        {
            return new Vector2i(
                random.Next(min.X, max.X + 1),
                random.Next(min.Y, max.Y + 1)
            );
        }
    }
}