using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Granite.Code.StructsGenerator
{
    class CodeWriter
    {
        private readonly TextWriter m_writer;
        private int m_indents;
        private bool m_newLine;

        public CodeWriter(TextWriter writer)
        {
            m_writer = writer;
            m_indents = 0;
            m_newLine = true;
        }

        public void PushIndent()
        {
            m_indents++;
        }

        public void PopIndent()
        {
            m_indents--;
        }

        private void WriteIndent()
        {
            if (m_newLine)
            {
                for (int i = 0; i < m_indents; i++)
                {
                    m_writer.Write("    ");
                }
                m_newLine = false;
            }
        }

        public void Write(string s)
        {
            WriteIndent();
            m_writer.Write(s);
        }

        public void Write(string s, params object[] args)
        {
            WriteIndent();
            m_writer.Write(s, args);
        }

        public void WriteLine(string s)
        {
            WriteIndent();
            m_writer.WriteLine(s);
            m_newLine = true;
        }

        public void WriteLine(string s, params object[] args)
        {
            WriteIndent();
            m_writer.WriteLine(s, args);
            m_newLine = true;
        }
    }
}
