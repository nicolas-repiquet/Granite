using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Granite3D
{
    public struct Vec4f
    {
        private readonly float m_x;
        private readonly float m_y;
        private readonly float m_z;
        private readonly float m_w;

        public Vec4f(float x, float y, float z, float w)
        {
            m_x = x;
            m_y = y;
            m_z = z;
            m_w = w;
        }

        public float X { get { return m_x; } }
        public float Y { get { return m_y; } }
        public float Z { get { return m_z; } }
        public float W { get { return m_w; } }
    }

    public struct Vec3f
    {
        private readonly float m_x;
        private readonly float m_y;
        private readonly float m_z;

        public Vec3f(float x, float y, float z)
        {
            m_x = x;
            m_y = y;
            m_z = z;
        }

        public float X { get { return m_x; } }
        public float Y { get { return m_y; } }
        public float Z { get { return m_z; } }

        public float Length
        {
            get { return (float)Math.Sqrt(m_x * m_x + m_y * m_y + m_z * m_z); }
        }

        public Vec3f Normalize()
        {
            var l = Length;
            return new Vec3f(m_x / l, m_y / l, m_z / l);
        }

        public Vec3f Cross(Vec3f v)
        {
            return new Vec3f(
                m_y * v.m_z - v.m_y * m_z,
                m_z * v.m_x - v.m_z * m_x,
                m_x * v.m_y - v.m_x * m_y
            );
        }

        public float Dot(Vec3f v)
        {
            return m_x * v.m_x + m_y * v.m_y + m_z * v.m_z;
        }

        public Vec3f Add(Vec3f v)
        {
            return new Vec3f(
                m_x + v.m_x,
                m_y + v.m_y,
                m_z + v.m_z
            );
        }

        public Vec3f Substract(Vec3f v)
        {
            return new Vec3f(
                m_x - v.m_x,
                m_y - v.m_y,
                m_z - v.m_z
            );
        }
    }

    public struct Vec2f
    {
        private readonly float m_x;
        private readonly float m_y;

        public Vec2f(float x, float y)
        {
            m_x = x;
            m_y = y;
        }

        public float X { get { return m_x; } }
        public float Y { get { return m_y; } }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Mat44f
    {
        #region STATIC

        private static readonly Mat44f s_identity = new Mat44f(
            1f, 0f, 0f, 0f,
            0f, 1f, 0f, 0f,
            0f, 0f, 1f, 0f,
            0f, 0f, 0f, 1f
        );

        public static Mat44f Identity { get { return s_identity; } }

        public static Mat44f Multiply(Mat44f m1, Mat44f m2)
        {
            return new Mat44f(
                m1.m_m00 * m2.m_m00 + m1.m_m01 * m2.m_m10 + m1.m_m02 * m2.m_m20 + m1.m_m03 * m2.m_m30,
                m1.m_m00 * m2.m_m01 + m1.m_m01 * m2.m_m11 + m1.m_m02 * m2.m_m21 + m1.m_m03 * m2.m_m31,
                m1.m_m00 * m2.m_m02 + m1.m_m01 * m2.m_m12 + m1.m_m02 * m2.m_m22 + m1.m_m03 * m2.m_m32,
                m1.m_m00 * m2.m_m03 + m1.m_m01 * m2.m_m13 + m1.m_m02 * m2.m_m23 + m1.m_m03 * m2.m_m33,
                m1.m_m10 * m2.m_m00 + m1.m_m11 * m2.m_m10 + m1.m_m12 * m2.m_m20 + m1.m_m13 * m2.m_m30,
                m1.m_m10 * m2.m_m01 + m1.m_m11 * m2.m_m11 + m1.m_m12 * m2.m_m21 + m1.m_m13 * m2.m_m31,
                m1.m_m10 * m2.m_m02 + m1.m_m11 * m2.m_m12 + m1.m_m12 * m2.m_m22 + m1.m_m13 * m2.m_m32,
                m1.m_m10 * m2.m_m03 + m1.m_m11 * m2.m_m13 + m1.m_m12 * m2.m_m23 + m1.m_m13 * m2.m_m33,
                m1.m_m20 * m2.m_m00 + m1.m_m21 * m2.m_m10 + m1.m_m22 * m2.m_m20 + m1.m_m23 * m2.m_m30,
                m1.m_m20 * m2.m_m01 + m1.m_m21 * m2.m_m11 + m1.m_m22 * m2.m_m21 + m1.m_m23 * m2.m_m31,
                m1.m_m20 * m2.m_m02 + m1.m_m21 * m2.m_m12 + m1.m_m22 * m2.m_m22 + m1.m_m23 * m2.m_m32,
                m1.m_m20 * m2.m_m03 + m1.m_m21 * m2.m_m13 + m1.m_m22 * m2.m_m23 + m1.m_m23 * m2.m_m33,
                m1.m_m30 * m2.m_m00 + m1.m_m31 * m2.m_m10 + m1.m_m32 * m2.m_m20 + m1.m_m33 * m2.m_m30,
                m1.m_m30 * m2.m_m01 + m1.m_m31 * m2.m_m11 + m1.m_m32 * m2.m_m21 + m1.m_m33 * m2.m_m31,
                m1.m_m30 * m2.m_m02 + m1.m_m31 * m2.m_m12 + m1.m_m32 * m2.m_m22 + m1.m_m33 * m2.m_m32,
                m1.m_m30 * m2.m_m03 + m1.m_m31 * m2.m_m13 + m1.m_m32 * m2.m_m23 + m1.m_m33 * m2.m_m33
            );
        }

        public static Vec4f Multiply(Mat44f m, Vec4f v)
        {
            return new Vec4f(
                m.m_m00 * v.X + m.m_m01 * v.Y + m.m_m02 * v.Z + m.m_m03 * v.W,
                m.m_m10 * v.X + m.m_m11 * v.Y + m.m_m12 * v.Z + m.m_m13 * v.W,
                m.m_m20 * v.X + m.m_m21 * v.Y + m.m_m22 * v.Z + m.m_m23 * v.W,
                m.m_m30 * v.X + m.m_m31 * v.Y + m.m_m32 * v.Z + m.m_m33 * v.W
            );
        }

        public static Mat44f Ortho(float left, float right, float bottom, float top, float near, float far)
        {
            var right_minus_left = right - left;
            var top_minus_bottom = top - bottom;
            var far_minus_near = far - near;

            return new Mat44f(
                2 / right_minus_left, 0, 0, (right + left) / right_minus_left,
                0, 2 / top_minus_bottom, 0, (top + bottom) / top_minus_bottom,
                0, 0, -2 / far_minus_near, (far + near) / far_minus_near,
                0, 0, 0, 1
            );
        }

        public static Mat44f Frustum(float left, float right, float bottom, float top, float near, float far)
        {
            var near_2 = near * 2;
            var right_minus_left = right - left;
            var top_minus_bottom = top - bottom;
            var far_minus_near = far - near;

            return new Mat44f(
                near_2 / right_minus_left, 0, (right + left) / right_minus_left, 0,
                0, near_2 / top_minus_bottom, (top + bottom) / top_minus_bottom, 0,
                0, 0, -(far + near) / far_minus_near, -(far * near * 2) / far_minus_near,
                0, 0, -1, 0
            );
        }

        public static Mat44f LookAt(Vec3f eye, Vec3f target, Vec3f up)
        {
            var zaxis = target.Substract(eye).Normalize();
            var xaxis = up.Cross(zaxis).Normalize();
            var yaxis = zaxis.Cross(xaxis);

            return new Mat44f(
                xaxis.X, xaxis.Y, xaxis.Z, -xaxis.Dot(eye),
                yaxis.X, yaxis.Y, yaxis.Z, -yaxis.Dot(eye),
                zaxis.X, zaxis.Y, zaxis.Z, -zaxis.Dot(eye),
                0, 0, 0, 1
            );
        }
        #endregion


        private readonly float m_m00;
        private readonly float m_m10;
        private readonly float m_m20;
        private readonly float m_m30;

        private readonly float m_m01;
        private readonly float m_m11;
        private readonly float m_m21;
        private readonly float m_m31;

        private readonly float m_m02;
        private readonly float m_m12;
        private readonly float m_m22;
        private readonly float m_m32;

        private readonly float m_m03;
        private readonly float m_m13;
        private readonly float m_m23;
        private readonly float m_m33;
        
        public Mat44f(
            float m00, float m01, float m02, float m03,
            float m10, float m11, float m12, float m13,
            float m20, float m21, float m22, float m23,
            float m30, float m31, float m32, float m33)
        {
            m_m00 = m00;
            m_m01 = m01;
            m_m02 = m02;
            m_m03 = m03;

            m_m10 = m10;
            m_m11 = m11;
            m_m12 = m12;
            m_m13 = m13;

            m_m20 = m20;
            m_m21 = m21;
            m_m22 = m22;
            m_m23 = m23;

            m_m30 = m30;
            m_m31 = m31;
            m_m32 = m32;
            m_m33 = m33;
        }

        public Mat44f Multiply(Mat44f m)
        {
            return Multiply(this, m);
        }

        public Mat44f RotateX(float angle)
        {
            return Multiply(this, new Mat44f(
                1, 0, 0, 0,
                0, (float)Math.Cos(angle), (float)-Math.Sin(angle), 0,
                0, (float)Math.Sin(angle), (float)Math.Cos(angle), 0,
                0, 0, 0, 1
            ));
        }

        public Mat44f RotateY(float angle)
        {
            return Multiply(this, new Mat44f(
                (float)Math.Cos(angle), 0, (float)Math.Sin(angle), 0,
                0, 1, 0, 0,
                (float)-Math.Sin(angle), 0, (float)Math.Cos(angle), 0,
                0, 0, 0, 1
            ));
        }

        public Mat44f RotateZ(float angle)
        {
            return Multiply(this, new Mat44f(
                (float)Math.Cos(angle), (float)-Math.Sin(angle), 0, 0,
                (float)Math.Sin(angle), (float)Math.Cos(angle), 0, 0,
                0, 0, 1, 0,
                0, 0, 0, 1
            ));
        }

        public Mat44f Scale(float x, float y, float z)
        {
            return Multiply(this, new Mat44f(
                x, 0, 0, 0,
                0, y, 0, 0,
                0, 0, z, 0,
                0, 0, 0, 1
            ));
        }

        public Mat44f Translate(float x, float y, float z)
        {
            return Multiply(this, new Mat44f(
                1, 0, 0, x,
                0, 1, 0, y,
                0, 0, 1, z,
                0, 0, 0, 1
            ));
        }
    }
}
