using System.Runtime.InteropServices;
using System;
using System.Diagnostics;

namespace Granite.Core
{
    public partial class GL : OpenGLContext
    {


        #region Enable/Disable
        public void Enable_DEPTH_TEST() { Enable(DEPTH_TEST); }
        public void Disable_DEPTH_TEST() { Disable(DEPTH_TEST); }
        public void Enable_BLEND() { Enable(BLEND); }
        public void Disable_BLEND() { Disable(BLEND); }
        #endregion

        #region Create/Delete
        
        internal uint GenTexture()
        {
            uint name;
            GenTextures(1, out name);
            return name;
        }
        
        internal void GenTextures(uint[] names)
        {
            GenTextures(names.Length, names);
        }
        
        internal void DeleteTexture(uint name)
        {
            DeleteTextures(1, ref name);
        }



        #endregion

        #region Buffers
        public void BindBuffer(uint target, Buffer buffer)
        {
            BindBuffer(target, buffer == null ? 0 : buffer.Name);
        }
        public void BindBuffer_ARRAY_BUFFER(Buffer buffer)
        {
            BindBuffer(ARRAY_BUFFER, buffer == null ? 0 : buffer.Name);
        }
        public void BindBuffer_ELEMENT_ARRAY_BUFFER(Buffer buffer)
        {
            BindBuffer(ELEMENT_ARRAY_BUFFER, buffer == null ? 0 : buffer.Name);
        }
        #endregion

        #region Programs / Shaders
        public void UseProgram(Program program)
        {
            UseProgram(program == null ? 0 : program.Name);
        }
        #endregion
    }
}
