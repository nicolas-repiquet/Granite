using Microsoft.CSharp;
using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Granite.Code.StructsGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var file = File.CreateText(@"..\..\..\Granite.Core\StructsGenerated.cs"))
            {
                var w = new CodeWriter(file);

                w.WriteLine("namespace Granite.Core");
                w.WriteLine("{");
                w.PushIndent();
                foreach (var v in Vector.Vectors)
                {
                    v.Build(w);
                    w.WriteLine("");
                }
                foreach (var m in Matrix.Matrices)
                {
                    m.Build(w);
                    w.WriteLine("");
                }
                foreach (var b in Box.Boxes)
                {
                    b.Build(w);
                    w.WriteLine("");
                }
                w.PopIndent();
                w.WriteLine("}");
            }
        }
    }
}
