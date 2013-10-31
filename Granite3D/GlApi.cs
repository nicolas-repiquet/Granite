using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace Granite3D
{
    internal sealed class GlApi
    {
        internal const uint GL_NO_ERROR = 0;
        internal const uint GL_ARRAY_BUFFER = 0x8892;
        internal const uint GL_ELEMENT_ARRAY_BUFFER = 0x8893;
        internal const uint GL_STATIC_DRAW = 0x88E4;
        internal const uint GL_BUFFER_SIZE = 0x8764;
        internal const uint GL_FRAGMENT_SHADER = 0x8B30;
        internal const uint GL_VERTEX_SHADER = 0x8B31;
        internal const uint GL_COMPILE_STATUS = 0x8B81;
        internal const uint GL_LINK_STATUS = 0x8B82;
        internal const uint GL_ACTIVE_UNIFORMS = 0x8B86;
        internal const uint GL_ACTIVE_ATTRIBUTES = 0x8B89;
        internal const uint GL_POINTS = 0x0000;
        internal const uint GL_LINE_LOOP = 0x0002;
        internal const uint GL_TRIANGLE_FAN = 0x0006;
        internal const uint GL_FLOAT_VEC2 = 0x8B50;
        internal const uint GL_FLOAT_VEC3 = 0x8B51;
        internal const uint GL_FLOAT_VEC4 = 0x8B52;
        internal const uint GL_FLOAT_MAT4 = 0x8B5C;
        internal const uint GL_BLEND = 0x0BE2;
        internal const uint GL_SRC_ALPHA = 0x0302;
        internal const uint GL_ONE_MINUS_SRC_ALPHA = 0x0303;
        internal const uint GL_TEXTURE_2D = 0x0DE1;
        internal const uint GL_RGB = 0x1907;
        internal const uint GL_RGBA = 0x1908;
        internal const uint GL_SAMPLER_2D = 0x8B5E;
        internal const uint GL_TEXTURE0 = 0x84C0;
        internal const uint GL_NEAREST = 0x2600;
        internal const uint GL_LINEAR = 0x2601;
        internal const uint GL_NEAREST_MIPMAP_NEAREST = 0x2700;
        internal const uint GL_LINEAR_MIPMAP_NEAREST = 0x2701;
        internal const uint GL_NEAREST_MIPMAP_LINEAR = 0x2702;
        internal const uint GL_LINEAR_MIPMAP_LINEAR = 0x2703;
        internal const uint GL_TEXTURE_MAG_FILTER = 0x2800;
        internal const uint GL_TEXTURE_MIN_FILTER = 0x2801;
        internal const uint GL_TEXTURE_WRAP_S = 0x2802;
        internal const uint GL_TEXTURE_WRAP_T = 0x2803;
        internal const uint GL_CLAMP = 0x2900;
        internal const uint GL_REPEAT = 0x2901;
        internal const uint GL_CLAMP_TO_EDGE = 0x812F;
        internal const uint GL_TRIANGLES = 0x0004;
        internal const uint GL_COLOR_BUFFER_BIT = 0x00004000;
        internal const uint GL_DEPTH_BUFFER_BIT = 0x00000100;
        internal const uint GL_DEPTH_TEST = 0x0B71;
        internal const uint GL_GREATER = 0x0204;

        internal const uint GL_BYTE = 0x1400;
        internal const uint GL_UNSIGNED_BYTE = 0x1401;
        internal const uint GL_SHORT = 0x1402;
        internal const uint GL_UNSIGNED_SHORT = 0x1403;
        internal const uint GL_INT = 0x1404;
        internal const uint GL_UNSIGNED_INT = 0x1405;
        internal const uint GL_FLOAT = 0x1406;
        internal const uint GL_DOUBLE = 0x140A;

        internal delegate uint Gl_Uint32();
        internal delegate void Gl_Void_Float_Float_Float_Float(float p1, float p2, float p3, float p4);
        internal delegate void Gl_Void_UInt32(uint p1);
        internal delegate void Gl_Void_Int32_Int32(int p1, int p2);
        internal delegate void Gl_Void_Int32_OutUInt32(int p1, out uint p2);
        internal delegate void Gl_Void_UInt32_UInt32(uint p1, uint p2);
        internal delegate void Gl_Void_UInt32_IntPtr_IntPtr_UInt32(uint p1, IntPtr p2, IntPtr p3, uint p4);
        internal delegate void Gl_Void_UInt32_UInt32_OutInt32(uint p1, uint p2, out int p3);
        internal delegate uint Gl_UInt32_UInt32(uint p1);
        internal delegate void Gl_Void_UInt32_UInt32_Int32(uint p1, uint p2, int p3);
        internal delegate void Gl_Void_UInt32_Int32_IntPtrArray_Int32Array(uint p1, int p2, IntPtr[] p3, int[] p4);
        internal delegate void Gl_Void_UInt32_Int32_OutInt32_ByteArray(uint p1, int p2, out int p3, byte[] p4);
        internal delegate void Gl_Void_UInt32_UInt32_Int32_OutInt32_OutInt32_OutUInt32_ByteArray(uint p1, uint p2, int p3, out int p4, out int p5, out uint p6, byte[] p7);
        internal delegate int Gl_Int32_UInt32_ByteArray(uint p1, byte[] p2);
        internal delegate void Gl_Void_UInt32_Int32_UInt32_IntPtr(uint p1, int p2, uint p3, IntPtr p4);
        internal delegate void Gl_Void_UInt32_Int32_UInt32_Byte_Int32_IntPtr(uint p1, int p2, uint p3, byte p4, int p5, IntPtr p6);
        internal delegate void Gl_Void_Int32_Float(int p1, float p2);
        internal delegate void Gl_Void_UInt32_Int32_Int32(uint p1, int p2, int p3);
        internal delegate void Gl_Void_Int32_Int32_Int32_RefMat44f(int p1, int p2, byte p3, ref Mat44f p4);
        internal delegate void Gl_Void_Int32_Int32_Int32_Int32(int p1, int p2, int p3, int p4);
        internal delegate void Gl_Void_UInt32_Int32_Int32_Int32_Int32_Int32_UInt32_UInt32_IntPtr(uint p1, int p2, int p3, int p4, int p5, int p6, uint p7, uint p8, IntPtr p9);
        internal delegate void Gl_Void_Double(double p1);

        internal GlApi()
        {
            foreach (var property in typeof(GlApi).GetProperties(BindingFlags.Instance | BindingFlags.NonPublic))
            {
                var proc = WinApi.wglGetProcAddress(property.Name);
                if (proc == IntPtr.Zero)
                {
                    throw new Exception(string.Format("Can't find function {0}", property.Name));
                }

                property.SetValue(this, Marshal.GetDelegateForFunctionPointer(proc, property.PropertyType), null);
            }
        }

        internal void CheckError()
        {
            var error = glGetError();
            if (error != GL_NO_ERROR)
            {
                throw new Exception(string.Format("Error : {0}", error));
            }
        }

        internal Gl_Uint32 glGetError { get; private set; }
        internal Gl_Void_Float_Float_Float_Float glClearColor { get; private set; }
        internal Gl_Void_UInt32 glClear { get; private set; }
        internal Gl_Void_Int32_OutUInt32 glGenBuffers { get; private set; }
        internal Gl_Void_Int32_OutUInt32 glDeleteBuffers { get; private set; }
        internal Gl_Void_UInt32_UInt32 glBindBuffer { get; private set; }
        internal Gl_Void_UInt32_IntPtr_IntPtr_UInt32 glBufferData { get; private set; }
        internal Gl_Void_UInt32_UInt32_OutInt32 glGetBufferParameteriv { get; private set; }
        internal Gl_UInt32_UInt32 glCreateShader { get; private set; }
        internal Gl_Void_UInt32 glDeleteShader { get; private set; }
        internal Gl_Void_UInt32_Int32_IntPtrArray_Int32Array glShaderSource { get; private set; }
        internal Gl_Void_UInt32_UInt32_OutInt32 glGetShaderiv { get; private set; }
        internal Gl_Void_UInt32 glCompileShader { get; private set; }
        internal Gl_Void_UInt32_Int32_OutInt32_ByteArray glGetShaderInfoLog { get; private set; }
        internal Gl_Uint32 glCreateProgram { get; private set; }
        internal Gl_Void_UInt32 glDeleteProgram { get; private set; }
        internal Gl_Void_UInt32_UInt32 glAttachShader { get; private set; }
        internal Gl_Void_UInt32 glLinkProgram { get; private set; }
        internal Gl_Void_UInt32_UInt32_OutInt32 glGetProgramiv { get; private set; }
        internal Gl_Void_UInt32_Int32_OutInt32_ByteArray glGetProgramInfoLog { get; private set; }
        internal Gl_Void_UInt32_UInt32_Int32_OutInt32_OutInt32_OutUInt32_ByteArray glGetActiveUniform { get; private set; }
        internal Gl_Void_UInt32_UInt32_Int32_OutInt32_OutInt32_OutUInt32_ByteArray glGetActiveAttrib { get; private set; }
        internal Gl_Int32_UInt32_ByteArray glGetUniformLocation { get; private set; }
        internal Gl_Int32_UInt32_ByteArray glGetAttribLocation { get; private set; }
        internal Gl_Void_UInt32 glUseProgram { get; private set; }
        internal Gl_Void_UInt32_Int32_UInt32_IntPtr glDrawElements { get; private set; }
        internal Gl_Void_UInt32_Int32_UInt32_Byte_Int32_IntPtr glVertexAttribPointer { get; private set; }
        internal Gl_Void_UInt32 glEnableVertexAttribArray { get; private set; }
        internal Gl_Void_UInt32 glDisableVertexAttribArray { get; private set; }
        internal Gl_Void_Int32_Float glUniform1f { get; private set; }
        internal Gl_Void_Int32_Int32 glUniform1i { get; private set; }
        internal Gl_Void_UInt32_Int32_Int32 glDrawArrays { get; private set; }
        internal Gl_Void_Int32_Int32_Int32_RefMat44f glUniformMatrix4fv { get; private set; }
        internal Gl_Void_Int32_Int32_Int32_Int32 glViewport { get; private set; }
        internal Gl_Void_Int32_OutUInt32 glGenTextures { get; private set; }
        internal Gl_Void_Int32_OutUInt32 glDeleteTextures { get; private set; }
        internal Gl_Void_Int32_OutUInt32 glGenVertexArrays { get; private set; }
        internal Gl_Void_Int32_OutUInt32 glDeleteVertexArrays { get; private set; }
        internal Gl_Void_UInt32 glBindVertexArray { get; private set; }
        internal Gl_Void_UInt32 glEnable { get; private set; }
        internal Gl_Void_UInt32_UInt32 glBlendFunc { get; private set; }
        internal Gl_Void_UInt32_UInt32 glBindTexture { get; private set; }
        internal Gl_Void_UInt32_Int32_Int32_Int32_Int32_Int32_UInt32_UInt32_IntPtr glTexImage2D { get; private set; }
        internal Gl_Void_UInt32 glActiveTexture { get; private set; }
        internal Gl_Void_UInt32_UInt32_Int32 glTexParameteri { get; private set; }
        internal Gl_Void_UInt32 glDepthFunc { get; private set; }
        internal Gl_Void_Double glClearDepth { get; private set; }
    }
}
