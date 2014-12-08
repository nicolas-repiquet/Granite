using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite.Code.StructsGenerator
{
    class Vector
    {
        public static readonly Vector Vec2b = new Vector("Vector2b", ElementType.ByteType, 2);
        public static readonly Vector Vec3b = new Vector("Vector3b", ElementType.ByteType, 3);
        public static readonly Vector Vec4b = new Vector("Vector4b", ElementType.ByteType, 4);

        public static readonly Vector Vec2ub = new Vector("Vector2ub", ElementType.UByteType, 2);
        public static readonly Vector Vec3ub = new Vector("Vector3ub", ElementType.UByteType, 3);
        public static readonly Vector Vec4ub = new Vector("Vector4ub", ElementType.UByteType, 4);

        public static readonly Vector Vec2s = new Vector("Vector2s", ElementType.ShortType, 2);
        public static readonly Vector Vec3s = new Vector("Vector3s", ElementType.ShortType, 3);
        public static readonly Vector Vec4s = new Vector("Vector4s", ElementType.ShortType, 4);

        public static readonly Vector Vec2us = new Vector("Vector2us", ElementType.UShortType, 2);
        public static readonly Vector Vec3us = new Vector("Vector3us", ElementType.UShortType, 3);
        public static readonly Vector Vec4us = new Vector("Vector4us", ElementType.UShortType, 4);

        public static readonly Vector Vec2i = new Vector("Vector2i", ElementType.IntType, 2);
        public static readonly Vector Vec3i = new Vector("Vector3i", ElementType.IntType, 3);
        public static readonly Vector Vec4i = new Vector("Vector4i", ElementType.IntType, 4);

        public static readonly Vector Vec2ui = new Vector("Vector2ui", ElementType.UIntType, 2);
        public static readonly Vector Vec3ui = new Vector("Vector3ui", ElementType.UIntType, 3);
        public static readonly Vector Vec4ui = new Vector("Vector4ui", ElementType.UIntType, 4);

        public static readonly Vector Vec2 = new Vector("Vector2", ElementType.FloatType, 2);
        public static readonly Vector Vec3 = new Vector("Vector3", ElementType.FloatType, 3);
        public static readonly Vector Vec4 = new Vector("Vector4", ElementType.FloatType, 4);

        public static readonly Vector Vec2d = new Vector("Vector2d", ElementType.DoubleType, 2);
        public static readonly Vector Vec3d = new Vector("Vector3d", ElementType.DoubleType, 3);
        public static readonly Vector Vec4d = new Vector("Vector4d", ElementType.DoubleType, 4);

        public static IEnumerable<Vector> Vectors
        {
            get
            {
                yield return Vec2b;
                yield return Vec3b;
                yield return Vec4b;
                yield return Vec2ub;
                yield return Vec3ub;
                yield return Vec4ub;
                yield return Vec2s;
                yield return Vec3s;
                yield return Vec4s;
                yield return Vec2us;
                yield return Vec3us;
                yield return Vec4us;
                yield return Vec2i;
                yield return Vec3i;
                yield return Vec4i;
                yield return Vec2ui;
                yield return Vec3ui;
                yield return Vec4ui;
                yield return Vec2;
                yield return Vec3;
                yield return Vec4;
                yield return Vec2d; 
                yield return Vec3d;
                yield return Vec4d;
            }
        }

        public static Vector GetVector(ElementType type, int dimensions)
        {
            return Vectors.Where(v => v.ElementType == type && v.Dimensions == dimensions).First();
        }

        // *************************************************************************

        public static string[] s_fieldName = { "X", "Y", "Z", "W" };
        public static string[] s_parameterName = { "x", "y", "z", "w" };
        //public static string[] s_propertyName = { "X", "Y", "Z", "W" };
        public static string[] s_unitName = { "UnitX", "UnitY", "UnitZ", "UnitW" };

        public string Name { get; private set; }
        public ElementType ElementType { get; private set; }
        public int Dimensions { get; private set; }

        public Vector(string name, ElementType elementType, int dimensions)
        {
            Name = name;
            ElementType = elementType;
            Dimensions = dimensions;
        }

        public void Build(CodeWriter w)
        {
            w.WriteLine("[System.Serializable]");
            w.WriteLine("[System.Diagnostics.Contracts.Pure]");
            w.WriteLine("[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]");
            w.WriteLine("public partial struct {0} : System.IEquatable<{0}>", Name);
            w.WriteLine("{");
            w.PushIndent();

            // Fields
            for(int i = 0; i < Dimensions; i++)
            {
                w.WriteLine("public readonly {0} {1};", ElementType.Name, s_fieldName[i]);
            }

            w.WriteLine("");

            // Constructors
            w.Write("public {0}(", Name);
            for (int i = 0; i < Dimensions; i++)
            {
                if (i != 0) w.Write(", ");
                w.Write("{0} {1}", ElementType.Name, s_parameterName[i]);
            }
            w.WriteLine(")");
            w.WriteLine("{");
            w.PushIndent();
            for (int i = 0; i < Dimensions; i++)
            {
                w.WriteLine("{0} = {1};", s_fieldName[i], s_parameterName[i]);
            }
            w.PopIndent();
            w.WriteLine("}");

            w.WriteLine("");

            for (int d = 2; d < Dimensions; d++)
            {
                var vector = GetVector(ElementType, d);

                w.Write("public {0}({1} v", Name, vector.Name);
                for (int i = d; i < Dimensions; i++)
                {
                    w.Write(", {0} {1}", ElementType.Name, s_parameterName[i]);
                }
                w.WriteLine(")");
                w.WriteLine("{");
                w.PushIndent();
                for (int i = 0; i < d; i++)
                {
                    w.WriteLine("{0} = v.{1};", s_fieldName[i], s_fieldName[i]);
                }
                for (int i = d; i < Dimensions; i++)
                {
                    w.WriteLine("{0} = {1};", s_fieldName[i], s_parameterName[i]);
                }
                w.PopIndent();
                w.WriteLine("}");
                w.WriteLine("");
            }

            // Casts
            foreach (var c in Vectors)
            {
                if (c != this && c.Dimensions == Dimensions)
                {
                    var isImplicit = ElementType.CanConvertImplicitlyTo(c.ElementType);
                    w.WriteLine("public static {0} operator {1}({2} v)",
                        isImplicit ? "implicit" : "explicit", 
                        c.Name, Name
                    );
                    w.WriteLine("{");
                    w.PushIndent();
                    w.Write("return new {0}(", c.Name);
                    for (int i = 0; i < Dimensions; i++)
                    {
                        if (i != 0) w.Write(", ");
                        if (isImplicit)
                        {
                            w.Write("v.{0}", s_fieldName[i]);
                        }
                        else
                        {
                            w.Write("({0})v.{1}", c.ElementType.Name, s_fieldName[i]);
                        }
                    }
                    w.WriteLine(");");
                    w.PopIndent();
                    w.WriteLine("}");
                    w.WriteLine("");
                }
            }

            // ToString
            BuildToString(w);

            // Equals == != GetHashCode
            BuildEqualsRelatedMembers(w);

            // Arithmetic
            BuildBinaryOperator(w, "+");
            BuildBinaryOperator(w, "-");
            BuildBinaryOperator(w, "*");
            BuildBinaryOperator(w, "/");

            // -
            BuildNegate(w);

            // Dot Cross
            BuildDotAndCrossProducts(w);

            // SquaredLength, Length, Normalize
            BuildLengthRelatedMembers(w);

            // Zero, One, UnitX...W
            BuildStaticValues(w);

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
            w.Write("return ");
            for (int i = 0; i < Dimensions; i++)
            {
                if (i != 0) w.Write(" && ");
                w.Write("a.{0} == b.{0}", s_fieldName[i]);
            }
            w.WriteLine(";");
            w.PopIndent();
            w.WriteLine("}");
            w.WriteLine("");

            w.WriteLine("public static bool operator !=({0} a, {0} b)", Name);
            w.WriteLine("{");
            w.PushIndent();
            w.Write("return ");
            for (int i = 0; i < Dimensions; i++)
            {
                if (i != 0) w.Write(" || ");
                w.Write("a.{0} != b.{0}", s_fieldName[i]);
            }
            w.WriteLine(";");
            w.PopIndent();
            w.WriteLine("}");
            w.WriteLine("");

            w.WriteLine("public bool Equals({0} other)", Name);
            w.WriteLine("{");
            w.PushIndent();
            w.Write("return ");
            for (int i = 0; i < Dimensions; i++)
            {
                if (i != 0) w.Write(" && ");
                w.Write("{0} == other.{0}", s_fieldName[i]);
            }
            w.WriteLine(";");
            w.PopIndent();
            w.WriteLine("}");
            w.WriteLine("");

            w.WriteLine("public override bool Equals(object other)");
            w.WriteLine("{");
            w.PushIndent();
            w.WriteLine("if(!(other is {0})) return false;", Name);
            w.WriteLine("var v = ({0})other;", Name);
            w.Write("return ");
            for (int i = 0; i < Dimensions; i++)
            {
                if (i != 0) w.Write(" && ");
                w.Write("{0} == v.{0}", s_fieldName[i]);
            }
            w.WriteLine(";");
            w.PopIndent();
            w.WriteLine("}");
            w.WriteLine("");

            w.WriteLine("public override int GetHashCode()");
            w.WriteLine("{");
            w.PushIndent();
            w.Write("return ");
            for (int i = 0; i < Dimensions; i++)
            {
                if (i != 0) w.Write(" ^ ");
                w.Write("{0}.GetHashCode()", s_fieldName[i]);
            }
            w.WriteLine(";");
            w.PopIndent();
            w.WriteLine("}");
            w.WriteLine("");
        }

        private void BuildToString(CodeWriter w)
        {
            w.WriteLine("public override string ToString()");
            w.WriteLine("{");
            w.PushIndent();
            w.Write("return string.Format(\"[");
            for (int i = 0; i < Dimensions; i++)
            {
                if (i != 0) w.Write(", ");
                w.Write("{{{0}}}", i);
            }
            w.Write("]\", ");
            for (int i = 0; i < Dimensions; i++)
            {
                if (i != 0) w.Write(", ");
                w.Write(s_fieldName[i]);
            }
            w.WriteLine(");");
            w.PopIndent();
            w.WriteLine("}");
            w.WriteLine("");
        }

        private void BuildStaticValues(CodeWriter w)
        {
            w.WriteLine("public static readonly {0} {1} = new {0}({2});",
                Name, "Zero",
                string.Join(", ", Enumerable.Repeat(ElementType.Zero, Dimensions)));

            w.WriteLine("public static readonly {0} {1} = new {0}({2});",
                Name, "One",
                string.Join(", ", Enumerable.Repeat(ElementType.One, Dimensions)));

            for (int i = 0; i < Dimensions; i++)
            {
                w.WriteLine("public static readonly {0} {1} = new {0}({2});",
                    Name, s_unitName[i],
                    string.Join(", ", Enumerable.Range(0, Dimensions).Select(d => d == i ? ElementType.One : ElementType.Zero)));
            }
            w.WriteLine("");
        }

        private void BuildBinaryOperator(CodeWriter w, string op)
        {
            var resultType = GetVector(ElementType.ArithmeticType, Dimensions);

            w.WriteLine("public static {0} operator {1}({2} a, {3} b)", resultType.Name, op, Name, resultType.Name);
            w.WriteLine("{");
            w.PushIndent();
            w.Write("return new {0}(", resultType.Name);
            for (int i = 0; i < Dimensions; i++)
            {
                if (i != 0) w.Write(", ");
                w.Write("a.{0} {1} b.{0}", s_fieldName[i], op);
            }
            w.WriteLine(");");
            w.PopIndent();
            w.WriteLine("}");
            w.WriteLine("");

            w.WriteLine("public static {0} operator {1}({2} a, {3} b)", resultType.Name, op, Name, ElementType.ArithmeticType.Name);
            w.WriteLine("{");
            w.PushIndent();
            w.Write("return new {0}(", resultType.Name);
            for (int i = 0; i < Dimensions; i++)
            {
                if (i != 0) w.Write(", ");
                w.Write("a.{0} {1} b", s_fieldName[i], op);
            }
            w.WriteLine(");");
            w.PopIndent();
            w.WriteLine("}");
            w.WriteLine("");
        }

        private void BuildNegate(CodeWriter w)
        {
            if (ElementType.Signed)
            {
                var resultType = GetVector(ElementType.ArithmeticType, Dimensions);

                w.WriteLine("public static {0} operator -({1} v)", resultType.Name, Name);
                w.WriteLine("{");
                w.PushIndent();
                w.Write("return new {0} (", resultType.Name);
                for (int i = 0; i < Dimensions; i++)
                {
                    if (i != 0) w.Write(", ");
                    w.Write("-v.{0}", s_fieldName[i]);
                }
                w.WriteLine(");");
                w.PopIndent();
                w.WriteLine("}");
                w.WriteLine("");
            }
        }

        private void BuildLengthRelatedMembers(CodeWriter w)
        {
            var precisionVector = GetVector(ElementType.PrecisionType, Dimensions);
            var mathCast = (ElementType.PrecisionType == ElementType.DoubleType) ? "" : string.Format("({0})", ElementType.PrecisionType.Name);

            w.WriteLine("public {0} SquaredLength", ElementType.ArithmeticType.Name);
            w.WriteLine("{");
            w.PushIndent();
            w.Write("get { return ");
            for (int i = 0; i < Dimensions; i++)
            {
                if (i != 0) w.Write(" + ");
                w.Write("{0} * {0}", s_fieldName[i]);
            }
            w.WriteLine("; }");
            w.PopIndent();
            w.WriteLine("}");
            w.WriteLine("");

            w.WriteLine("public {0} Length", ElementType.PrecisionType.Name);
            w.WriteLine("{");
            w.PushIndent();
            w.Write("get {{ return {0}System.Math.Sqrt(", mathCast);
            for (int i = 0; i < Dimensions; i++)
            {
                if (i != 0) w.Write(" + ");
                w.Write("{0} * {0}", s_fieldName[i]);
            }
            w.WriteLine("); }");
            w.PopIndent();
            w.WriteLine("}");
            w.WriteLine("");

            w.WriteLine("public {0} Normalize()", precisionVector.Name);
            w.WriteLine("{");
            w.PushIndent();
            w.WriteLine("var l = Length;");
            w.Write("return new {0}(", precisionVector.Name);
            for (int i = 0; i < Dimensions; i++)
            {
                if (i != 0) w.Write(", ");
                w.Write("{0} / l", s_fieldName[i]);
            }
            w.WriteLine(");");
            w.PopIndent();
            w.WriteLine("}");
            w.WriteLine("");
        }

        private void BuildDotAndCrossProducts(CodeWriter w)
        {
            w.WriteLine("public static {0} Dot({1} a, {1} b)", ElementType.ArithmeticType.Name, Name);
            w.WriteLine("{");
            w.PushIndent();
            w.Write("return ");
            for (int i = 0; i < Dimensions; i++)
            {
                if (i != 0) w.Write(" + ");
                w.Write("a.{0} * b.{0}", s_fieldName[i]);
            }
            w.WriteLine(";");
            w.PopIndent();
            w.WriteLine("}");
            w.WriteLine("");

            if (Dimensions == 3)
            {
                var vector = Vector.GetVector(ElementType.ArithmeticType, Dimensions);

                w.WriteLine("public static {0} Cross({1} a, {1} b)", vector.Name, Name);
                w.WriteLine("{");
                w.PushIndent();
                w.WriteLine("return new {0}(", vector.Name);
                w.PushIndent();
                w.WriteLine("a.Y * b.Z - a.Z * b.Y,");
                w.WriteLine("a.Z * b.X - a.X * b.Z,");
                w.WriteLine("a.X * b.Y - a.Y * b.X");
                w.PopIndent();
                w.WriteLine(");");
                w.PopIndent();
                w.WriteLine("}");
                w.WriteLine("");
            }
        }
    }
}
