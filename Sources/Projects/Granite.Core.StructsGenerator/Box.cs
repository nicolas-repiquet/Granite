using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite.Code.StructsGenerator
{
    class Box
    {
        public static readonly Box Box2b = new Box("Box2b", ElementType.ByteType, 2);
        public static readonly Box Box3b = new Box("Box3b", ElementType.ByteType, 3);

        public static readonly Box Box2ub = new Box("Box2ub", ElementType.UByteType, 2);
        public static readonly Box Box3ub = new Box("Box3ub", ElementType.UByteType, 3);

        public static readonly Box Box2s = new Box("Box2s", ElementType.ShortType, 2);
        public static readonly Box Box3s = new Box("Box3s", ElementType.ShortType, 3);

        public static readonly Box Box2us = new Box("Box2us", ElementType.UShortType, 2);
        public static readonly Box Box3us = new Box("Box3us", ElementType.UShortType, 3);

        public static readonly Box Box2i = new Box("Box2i", ElementType.IntType, 2);
        public static readonly Box Box3i = new Box("Box3i", ElementType.IntType, 3);

        public static readonly Box Box2ui = new Box("Box2ui", ElementType.UIntType, 2);
        public static readonly Box Box3ui = new Box("Box3ui", ElementType.UIntType, 3);

        public static readonly Box Box2 = new Box("Box2", ElementType.FloatType, 2);
        public static readonly Box Box3 = new Box("Box3", ElementType.FloatType, 3);

        public static readonly Box Box2d = new Box("Box2d", ElementType.DoubleType, 2);
        public static readonly Box Box3d = new Box("Box3d", ElementType.DoubleType, 3);

        public static IEnumerable<Box> Boxes
        {
            get
            {
                yield return Box2b;
                yield return Box3b;

                yield return Box2ub;
                yield return Box3ub;

                yield return Box2s;
                yield return Box3s;

                yield return Box2us;
                yield return Box3us;

                yield return Box2i;
                yield return Box3i;

                yield return Box2ui;
                yield return Box3ui;

                yield return Box2;
                yield return Box3;

                yield return Box2d;
                yield return Box3d;
            }
        }

        public static Box GetBox(ElementType type, int dimensions)
        {
            return Boxes.Where(v => v.ElementType == type && v.Dimensions == dimensions).First();
        }

        // *************************************************************************

        public static readonly string[] s_positionName = { "x", "y", "z" };
        public static readonly string[] s_sizeName = { "sx", "sy", "sz" };

        public string Name { get; private set; }
        public ElementType ElementType { get; private set; }
        public int Dimensions { get; private set; }
        public Vector Vector { get; private set; }

        public Box(string name, ElementType elementType, int dimensions)
        {
            Name = name;
            ElementType = elementType;
            Dimensions = dimensions;
            Vector = Vector.GetVector(ElementType, dimensions);
        }

        public void Build(CodeWriter w)
        {
            w.WriteLine("[System.Serializable]");
            w.WriteLine("[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]");
            w.WriteLine("public partial struct {0} : System.IEquatable<{0}>", Name);
            w.WriteLine("{");
            w.PushIndent();

            // Fields
            w.WriteLine("public readonly {0} Position;", Vector.Name);
            w.WriteLine("public readonly {0} Size;", Vector.Name);

            w.WriteLine("");

            // Constructors
            w.Write("public {0}({1} position, {1} size)", Name, Vector.Name);
            w.WriteLine("{");
            w.PushIndent();
            w.WriteLine("Position = position;");
            w.WriteLine("Size = size;");
            w.PopIndent();
            w.WriteLine("}");

            w.WriteLine("");

            if (Dimensions == 2)
            {
                w.Write("public {0}({1} x, {1} y, {1} sx, {1} sy)", Name, ElementType.Name);
                w.WriteLine("{");
                w.PushIndent();
                w.WriteLine("Position = new {0}(x, y);", Vector.Name);
                w.WriteLine("Size = new {0}(sx, sy);", Vector.Name);
                w.PopIndent();
                w.WriteLine("}");
            }
            else // 3
            {
                w.Write("public {0}({1} x, {1} y, {1} z, {1} sx, {1} sy, {1} sz)", Name, ElementType.Name);
                w.WriteLine("{");
                w.PushIndent();
                w.WriteLine("Position = new {0}(x, y, z);", Vector.Name);
                w.WriteLine("Size = new {0}(sx, sy, sz);", Vector.Name);
                w.PopIndent();
                w.WriteLine("}");
            }

            w.WriteLine("");

            // Casts
            foreach (var b in Boxes)
            {
                if (b != this && b.Dimensions == Dimensions)
                {
                    var isImplicit = ElementType.CanConvertImplicitlyTo(b.ElementType);
                    w.WriteLine("public static {0} operator {1}({2} v)",
                        isImplicit ? "implicit" : "explicit",
                        b.Name, Name
                    );
                    w.WriteLine("{");
                    w.PushIndent();
                    if (isImplicit)
                    {
                        w.WriteLine("return new {0}(v.Position, v.Size);", b.Name);
                    }
                    else
                    {
                        w.WriteLine("return new {0}(({1})v.Position, ({1})v.Size);", b.Name, b.Vector.Name);
                    }
                    w.PopIndent();
                    w.WriteLine("}");
                    w.WriteLine("");
                }
            }

            // ToString
            BuildToString(w);

            // Equals == != GetHashCode
            BuildEqualsRelatedMembers(w);

            // MinX, MaxX, etc
            BuildMinMax(w);

            // Center point
            BuildCenter(w);

            // Translate
            BuildTranslate(w);

            // End struct
            w.PopIndent();
            w.WriteLine("}");
            w.WriteLine("");
        }

        private void BuildEqualsRelatedMembers(CodeWriter w)
        {
            w.WriteLine("public static bool operator ==({0} a, {0} b)", Name);
            w.WriteLine("{");
            w.PushIndent();
            w.WriteLine("return a.Position == b.Position && a.Size == b.Size;");
            w.PopIndent();
            w.WriteLine("}");
            w.WriteLine("");

            w.WriteLine("public static bool operator !=({0} a, {0} b)", Name);
            w.WriteLine("{");
            w.PushIndent();
            w.WriteLine("return a.Position != b.Position || a.Size != b.Size;");
            w.PopIndent();
            w.WriteLine("}");
            w.WriteLine("");

            w.WriteLine("public bool Equals({0} other)", Name);
            w.WriteLine("{");
            w.PushIndent();
            w.WriteLine("return Position == other.Position && Size == other.Size;");
            w.PopIndent();
            w.WriteLine("}");
            w.WriteLine("");

            w.WriteLine("public override bool Equals(object other)");
            w.WriteLine("{");
            w.PushIndent();
            w.WriteLine("if(!(other is {0})) return false;", Name);
            w.WriteLine("var b = ({0})other;", Name);
            w.WriteLine("return Position == b.Position && Size == b.Size;");
            w.PopIndent();
            w.WriteLine("}");
            w.WriteLine("");

            w.WriteLine("public override int GetHashCode()");
            w.WriteLine("{");
            w.PushIndent();
            w.WriteLine("return Position.GetHashCode() ^ Size.GetHashCode();");
            w.PopIndent();
            w.WriteLine("}");
            w.WriteLine("");
        }

        private void BuildToString(CodeWriter w)
        {
            w.WriteLine("public override string ToString()");
            w.WriteLine("{");
            w.PushIndent();
            w.Write("return Position.ToString() + Size.ToString();");
            w.PopIndent();
            w.WriteLine("}");
            w.WriteLine("");
        }

        private void BuildMinMax(CodeWriter w)
        {
            w.WriteLine("public {0} MinX {{ get {{ return System.Math.Min(Position.X, ({0})(Position.X + Size.X)); }} }}", ElementType.Name);
            w.WriteLine("public {0} MaxX {{ get {{ return System.Math.Max(Position.X, ({0})(Position.X + Size.X)); }} }}", ElementType.Name);

            w.WriteLine("public {0} MinY {{ get {{ return System.Math.Min(Position.Y, ({0})(Position.Y + Size.Y)); }} }}", ElementType.Name);
            w.WriteLine("public {0} MaxY {{ get {{ return System.Math.Max(Position.Y, ({0})(Position.Y + Size.Y)); }} }}", ElementType.Name);

            if (Dimensions == 3)
            {
                w.WriteLine("public {0} MinZ {{ get {{ return System.Math.Min(Position.Z, ({0})(Position.Z + Size.Z)); }} }}", ElementType.Name);
                w.WriteLine("public {0} MaxZ {{ get {{ return System.Math.Max(Position.Z, ({0})(Position.Z + Size.Z)); }} }}", ElementType.Name);
            }

            w.WriteLine("");
        }

        private void BuildCenter(CodeWriter w)
        {
            var vector = Vector.GetVector(ElementType.PrecisionType, Dimensions);

            w.WriteLine("public {0} Center {{", vector.Name);
            w.PushIndent();
            w.WriteLine("get {");
            w.PushIndent();
            w.WriteLine("return new {0}(", vector.Name);
            for (int i = 0; i < Dimensions; i++)
            {
                if (i != 0) w.WriteLine(",");
                w.Write("Position.{0} + Size.{0} / {1}", Vector.s_fieldName[i], ElementType.PrecisionType.Two);
            }
            w.WriteLine("");
            w.WriteLine(");");
            w.PopIndent();
            w.WriteLine("}");
            w.PopIndent();
            w.WriteLine("}");
            w.WriteLine("");
        }

        private void BuildTranslate(CodeWriter w)
        {
            var vector = Vector.GetVector(ElementType.ArithmeticType, Dimensions);
            var box = Box.GetBox(ElementType.ArithmeticType, Dimensions);

            w.WriteLine("public {0} Translate({1} v)", box.Name, vector.Name);
            w.WriteLine("{");
            w.PushIndent();
            w.WriteLine("return new {0}(Position + v, Size);", box.Name);
            w.PopIndent();
            w.WriteLine("}");
            w.WriteLine("");
        }
    }
}
