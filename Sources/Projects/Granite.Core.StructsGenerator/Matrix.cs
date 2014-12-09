// *****************************************************************************
// * Example of a 3x2 matrix
// *
// * 3x2 means 3 columns and 2 rows, as in GLSL
// *
// * [M00, M10, M20]
// * [M01, M11, M21]
// *
// * Individual elements are named M{zero based column index}{zero based row index}
// *
// * Memory layout is "column major" :
// * { M00, M01,
// *   M10, M11,
// *   M20, M21 }
// *
// * When used as transformation matrix, translation is usualy stored in the last column (M20 = Tx, M21 = Ty)
// *
// * Constructor use GLSL convension (columns major).
// * So a 3x2 translation matrix is constructed like that :
// *
// * [1, 0, Tx]
// * [0, 1, Ty]
// *
// * mat3x2 m = mat3x2(1, 0, 0, 1, Tx, Ty)
// *

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite.Code.StructsGenerator
{
    class Matrix
    {
        public static readonly Matrix Mat2 = new Matrix("Matrix2", ElementType.FloatType, 2, 2);
        public static readonly Matrix Mat2x3 = new Matrix("Matrix2x3", ElementType.FloatType, 2, 3);
        public static readonly Matrix Mat2x4 = new Matrix("Matrix2x4", ElementType.FloatType, 2, 4);

        public static readonly Matrix Mat3x2 = new Matrix("Matrix3x2", ElementType.FloatType, 3, 2);
        public static readonly Matrix Mat3 = new Matrix("Matrix3", ElementType.FloatType, 3, 3);
        public static readonly Matrix Mat3x4 = new Matrix("Matrix3x4", ElementType.FloatType, 3, 4);

        public static readonly Matrix Mat4x2 = new Matrix("Matrix4x2", ElementType.FloatType, 4, 2);
        public static readonly Matrix Mat4x3 = new Matrix("Matrix4x3", ElementType.FloatType, 4, 3);
        public static readonly Matrix Mat4 = new Matrix("Matrix4", ElementType.FloatType, 4, 4);

        public static readonly Matrix Mat2d = new Matrix("Matrix2d", ElementType.DoubleType, 2, 2);
        public static readonly Matrix Mat2x3d = new Matrix("Matrix2x3d", ElementType.DoubleType, 2, 3);
        public static readonly Matrix Mat2x4d = new Matrix("Matrix2x4d", ElementType.DoubleType, 2, 4);

        public static readonly Matrix Mat3x2d = new Matrix("Matrix3x2d", ElementType.DoubleType, 3, 2);
        public static readonly Matrix Mat3d = new Matrix("Matrix3d", ElementType.DoubleType, 3, 3);
        public static readonly Matrix Mat3x4d = new Matrix("Matrix3x4d", ElementType.DoubleType, 3, 4);

        public static readonly Matrix Mat4x2d = new Matrix("Matrix4x2d", ElementType.DoubleType, 4, 2);
        public static readonly Matrix Mat4x3d = new Matrix("Matrix4x3d", ElementType.DoubleType, 4, 3);
        public static readonly Matrix Mat4d = new Matrix("Matrix4d", ElementType.DoubleType, 4, 4);

        public static IEnumerable<Matrix> Matrices
        {
            get
            {
                yield return Mat2;
                yield return Mat2x3;
                yield return Mat2x4;
                yield return Mat3x2;
                yield return Mat3;
                yield return Mat3x4;
                yield return Mat4x2;
                yield return Mat4x3;
                yield return Mat4;
                yield return Mat2d;
                yield return Mat2x3d;
                yield return Mat2x4d;
                yield return Mat3x2d;
                yield return Mat3d;
                yield return Mat3x4d;
                yield return Mat4x2d;
                yield return Mat4x3d;
                yield return Mat4d;
            }
        }

        public static Matrix GetMatrix(ElementType elementType, int columns, int rows)
        {
            return Matrices.Where(m => m.ElementType == elementType && m.Rows == rows && m.Columns == columns).First();
        }

        // *********************************************************************

        public static readonly string[] s_columnPropertyName = { "Column0", "Column1", "Column2", "Column3" };
        public static readonly string[] s_columnParameterName = { "column0", "column1", "column2", "column3" };
        public static readonly string[] s_rowPropertyName = { "Row0", "Row1", "Row2", "Row3" };
        
        public static readonly string[,] s_elementName = {
            { "M00", "M01", "M02", "M03" },
            { "M10", "M11", "M12", "M13" },
            { "M20", "M21", "M22", "M23" },
            { "M30", "M31", "M32", "M33" },
        };

        public static readonly string[,] s_elementParameterName = {
            { "m00", "m01", "m02", "m03" },
            { "m10", "m11", "m12", "m13" },
            { "m20", "m21", "m22", "m23" },
            { "m30", "m31", "m32", "m33" },
        };

        public string Name { get; private set; }
        public ElementType ElementType { get; private set; }
        public int Rows { get; private set; }
        public int Columns { get; private set; }

        private Matrix(string name, ElementType elementType, int columns, int rows)
        {
            Name = name;
            ElementType = elementType;
            Columns = columns;
            Rows = rows;
        }

        public void Build(CodeWriter w)
        {
            w.WriteLine("[System.Serializable]");
            w.WriteLine("[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]");
            w.WriteLine("public partial struct {0} : System.IEquatable<{0}>", Name);
            w.WriteLine("{");
            w.PushIndent();

            // Fields and properties
            BuildFieldsAndProperties(w);

            // Constructor
            BuildConstructor(w);

            // Equals == != etc
            BuildEqualsRelatedMembers(w);

            // ToString
            BuildToString(w);

            // Identity
            BuildStaticValues(w);

            // Multiply
            BuildMatrixMultiply(w);
            BuildVectorMultiply(w);

            // End struct
            w.PopIndent();
            w.WriteLine("}");
            w.WriteLine("");
        }

        private void BuildFieldsAndProperties(CodeWriter w)
        {
            var columnVector = Vector.GetVector(ElementType, Rows);
            var rowVector = Vector.GetVector(ElementType, Columns);

            for (int c = 0; c < Columns; c++)
            {
                for (int r = 0; r < Rows; r++)
                {
                    w.WriteLine("public readonly {0} {1};", ElementType.Name, s_elementName[c, r]);
                }
            }

            w.WriteLine("");

            for (int c = 0; c < Columns; c++)
            {
                w.Write("public {0} {1} {{ get {{ return new {0}(", columnVector.Name, s_columnPropertyName[c]);
                for (int r = 0; r < Rows; r++)
                {
                    if (r != 0) w.Write(", ");
                    w.Write(s_elementName[c, r]);
                }
                w.WriteLine("); } }");
            }

            w.WriteLine("");

            for (int r = 0; r < Rows; r++)
            {
                w.Write("public {0} {1} {{ get {{ return new {0}(", rowVector.Name, s_rowPropertyName[r]);
                for (int c = 0; c < Columns; c++)
                {
                    if (c != 0) w.Write(", ");
                    w.Write(s_elementName[c, r]);
                }
                w.WriteLine("); } }");
            }

            w.WriteLine("");
        }

        private void BuildConstructor(CodeWriter w)
        {
            var vector = Vector.GetVector(ElementType, Rows);

            w.Write("public {0}(", Name);
            for (int c = 0; c < Columns; c++)
            {
                if (c != 0) w.Write(", ");
                w.Write("{0} {1}", vector.Name, s_columnParameterName[c]);
            }
            w.WriteLine(")");
            w.WriteLine("{");
            w.PushIndent();

            for (int c = 0; c < Columns; c++)
            {
                for (int r = 0; r < Rows; r++)
                {
                    w.WriteLine("{0} = {1}.{2};", s_elementName[c, r], s_columnParameterName[c], Vector.s_fieldName[r]);
                }
            }

            w.PopIndent();
            w.WriteLine("}");
            w.WriteLine("");



            w.Write("public {0}(", Name);
            for (int c = 0; c < Columns; c++)
            {
                for (int r = 0; r < Rows; r++)
                {
                    if (r != 0 || c != 0) w.Write(", ");
                    w.Write("{0} {1}", ElementType.Name, s_elementParameterName[c, r]);
                }
            }
            w.WriteLine(")");
            w.WriteLine("{");
            w.PushIndent();

            for (int c = 0; c < Columns; c++)
            {
                for (int r = 0; r < Rows; r++)
                {
                    w.WriteLine("{0} = {1};", s_elementName[c, r], s_elementParameterName[c, r]);
                }
            }

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
            for (int c = 0; c < Columns; c++)
            {
                for (int r = 0; r < Rows; r++)
                {
                    if (c != 0 || r != 0) w.Write(" && ");
                    w.Write("a.{0} == b.{0}", s_elementName[c, r]);
                }
            }
            w.WriteLine(";");
            w.PopIndent();
            w.WriteLine("}");
            w.WriteLine("");

            w.WriteLine("public static bool operator !=({0} a, {0} b)", Name);
            w.WriteLine("{");
            w.PushIndent();
            w.Write("return ");
            for (int c = 0; c < Columns; c++)
            {
                for (int r = 0; r < Rows; r++)
                {
                    if (c != 0 || r != 0) w.Write(" || ");
                    w.Write("a.{0} != b.{0}", s_elementName[c, r]);
                }
            }
            w.WriteLine(";");
            w.PopIndent();
            w.WriteLine("}");
            w.WriteLine("");

            w.WriteLine("public bool Equals({0} other)", Name);
            w.WriteLine("{");
            w.PushIndent();
            w.Write("return ");
            for (int c = 0; c < Columns; c++)
            {
                for (int r = 0; r < Rows; r++)
                {
                    if (c != 0 || r != 0) w.Write(" && ");
                    w.Write("{0} == other.{0}", s_elementName[c, r]);
                }
            }
            w.WriteLine(";");
            w.PopIndent();
            w.WriteLine("}");
            w.WriteLine("");

            w.WriteLine("public override bool Equals(object other)");
            w.WriteLine("{");
            w.PushIndent();
            w.WriteLine("if(!(other is {0})) return false;", Name);
            w.WriteLine("var m = ({0})other;", Name);
            w.Write("return ");
            for (int c = 0; c < Columns; c++)
            {
                for (int r = 0; r < Rows; r++)
                {
                    if (c != 0 || r != 0) w.Write(" && ");
                    w.Write("{0} == m.{0}", s_elementName[c, r]);
                }
            }
            w.WriteLine(";");
            w.PopIndent();
            w.WriteLine("}");
            w.WriteLine("");

            w.WriteLine("public override int GetHashCode()");
            w.WriteLine("{");
            w.PushIndent();
            w.Write("return ");
            for (int c = 0; c < Columns; c++)
            {
                for (int r = 0; r < Rows; r++)
                {
                    if (c != 0 || r != 0) w.Write(" ^ ");
                    w.Write("{0}.GetHashCode()", s_elementName[c, r]);
                }
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
            w.Write("return ");
            for (int c = 0; c < Columns; c++)
            {
                if (c != 0)
                {
                    w.Write(" + ");
                }

                w.Write("\"[\"");
                for (int r = 0; r < Rows; r++)
                {
                    w.Write(" + {0}.ToString()", s_elementName[c, r]);
                }
                w.WriteLine(" + \"]\"");
            }
            w.WriteLine(";");
            w.PopIndent();
            w.WriteLine("}");
            w.WriteLine("");
        }

        private void BuildStaticValues(CodeWriter w)
        {
            if(Rows == Columns)
            {
                var vector = Vector.GetVector(ElementType, Rows);

                w.Write("public static readonly {0} Identity = new {0}(", Name);

                for (int c = 0; c < Columns; c++)
                {
                    if (c != 0) w.Write(", ");
                    w.Write("{0}.{1}", vector.Name, Vector.s_unitName[c]);
                }

                w.WriteLine(");");
                w.WriteLine("");
            }
        }

        private void BuildMatrixMultiply(CodeWriter w)
        {
            foreach (var m in Matrices)
            {
                if (m.ElementType == ElementType && Columns == m.Rows)
                {
                    BuildMatrixMultiply(w, m);
                }
            }
        }

        private void BuildMatrixMultiply(CodeWriter w, Matrix m)
        {
            var resultMatrix = GetMatrix(ElementType, m.Columns, Rows);

            w.WriteLine("public static void Multiply(ref {0} left, ref {1} right, out {2} result)", Name, m.Name, resultMatrix.Name);
            w.WriteLine("{");
            w.PushIndent();

            w.WriteLine("result = new {0}(", resultMatrix.Name);
            w.PushIndent();

            for (int c = 0; c < resultMatrix.Columns; c++)
            {
                for (int r = 0; r < resultMatrix.Rows; r++)
                {
                    for (int i = 0; i < Columns; i++)
                    {
                        if (i != 0) w.Write(" + ");
                        w.Write("left.{0} * right.{1}", s_elementName[i, r], s_elementName[c, i]);
                    }

                    if (c == resultMatrix.Columns - 1 && r == resultMatrix.Rows - 1)
                    {
                        w.WriteLine("");
                    }
                    else
                    {
                        w.WriteLine(",");
                    }
                }
            }

            w.PopIndent();
            w.WriteLine(");");

            w.PopIndent();
            w.WriteLine("}");
            w.WriteLine("");
        }

        private void BuildVectorMultiply(CodeWriter w)
        {
            var inVector = Vector.GetVector(ElementType, Columns);
            var outVector = Vector.GetVector(ElementType, Rows);

            w.WriteLine("public static {0} Multiply(ref {1} m, {2} v)", outVector.Name, Name, inVector.Name);
            w.WriteLine("{");
            w.PushIndent();

            w.WriteLine("return new {0}(", outVector.Name);
            w.PushIndent();

            for (int r = 0; r < Rows; r++)
            {
                if (r != 0) w.WriteLine(",");
                for (int c = 0; c < Columns; c++)
                {
                    if (c != 0) w.Write(" + ");
                    w.Write("m.{0} * v.{1}", s_elementName[c, r], Vector.s_fieldName[c]);
                }
            }

            w.WriteLine("");

            w.PopIndent();
            w.WriteLine(");");

            w.PopIndent();
            w.WriteLine("}");
            w.WriteLine("");
        }
    }
}
