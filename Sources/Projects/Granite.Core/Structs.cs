﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite.Core
{
    partial struct Vector4
    {
        public Vector3 Xyz => new Vector3(X, Y, Z);
    }

    partial struct Matrix3x2
    {
        public static Vector2 operator *(Matrix3x2 m, Vector2 v)
        {
            return new Vector2(
                m.M00 * v.X + m.M10 * v.Y + m.M20,
                m.M01 * v.X + m.M11 * v.Y + m.M21
            );
        }

        public static Matrix3x2 operator *(Matrix3x2 left, Matrix3x2 right)
        {
            return new Matrix3x2(
                left.M00 * right.M00 + left.M10 * right.M01,
                left.M01 * right.M00 + left.M11 * right.M01,

                left.M00 * right.M10 + left.M10 * right.M11,
                left.M01 * right.M10 + left.M11 * right.M11,

                left.M00 * right.M20 + left.M10 * right.M21 + left.M20,
                left.M01 * right.M20 + left.M11 * right.M21 + left.M21
            );
        }

        public static readonly Matrix3x2 Identity = new Matrix3x2(1, 0, 0, 1, 0, 0);
    }

    partial struct Matrix3x2d
    {
        public static Vector2d operator *(Matrix3x2d m, Vector2d v)
        {
            return new Vector2d(
                m.M00 * v.X + m.M10 * v.Y + m.M20,
                m.M01 * v.X + m.M11 * v.Y + m.M21
            );
        }

        public static Matrix3x2d operator *(Matrix3x2d left, Matrix3x2d right)
        {
            return new Matrix3x2d(
                left.M00 * right.M00 + left.M10 * right.M01,
                left.M01 * right.M00 + left.M11 * right.M01,

                left.M00 * right.M10 + left.M10 * right.M11,
                left.M01 * right.M10 + left.M11 * right.M11,

                left.M00 * right.M20 + left.M10 * right.M21 + left.M20,
                left.M01 * right.M20 + left.M11 * right.M21 + left.M21
            );
        }

        public static readonly Matrix3x2d Identity = new Matrix3x2d(1, 0, 0, 1, 0, 0);
    }

    partial struct Matrix3x4
    {
        public static readonly Matrix3x4 Identity = new Matrix3x4(
            1, 0, 0, 0,
            0, 1, 0, 0,
            0, 0, 1, 0
        );


    }

    /*
    partial struct Matrix3x4
    {
        public static Vector3 operator *(Matrix3x4 m, Vector3 v)
        {
            return new Vector3(
                m.M00 * v.X + m.M10 * v.Y + m.M20 * v.Z + m.M30,
                m.M01 * v.X + m.M11 * v.Y + m.M21 * v.Z + m.M31,
                m.M02 * v.X + m.M12 * v.Y + m.M22 * v.Z + m.M32
            );
        }

        public static Matrix3x4 operator *(Matrix3x4 left, Matrix3x4 right)
        {
            return new Matrix4x3(
                left.M00 * right.M00 + left.M10 * right.M01 + left.M20 * right.M02,
                left.M01 * right.M00 + left.M11 * right.M01 + left.M21 * right.M02,
                left.M02 * right.M00 + left.M12 * right.M01 + left.M22 * right.M02,

                left.M00 * right.M10 + left.M10 * right.M11 + left.M20 * right.M12,
                left.M01 * right.M10 + left.M11 * right.M11 + left.M21 * right.M12,
                left.M02 * right.M10 + left.M12 * right.M11 + left.M22 * right.M12,

                left.M00 * right.M20 + left.M10 * right.M21 + left.M20 * right.M22,
                left.M01 * right.M20 + left.M11 * right.M21 + left.M21 * right.M22,
                left.M02 * right.M20 + left.M12 * right.M21 + left.M22 * right.M22,

                left.M00 * right.M30 + left.M10 * right.M31 + left.M20 * right.M32 + left.M30,
                left.M01 * right.M30 + left.M11 * right.M31 + left.M21 * right.M32 + left.M31,
                left.M02 * right.M30 + left.M12 * right.M31 + left.M22 * right.M32 + left.M32
            );
        }

        public static readonly Matrix4x3 Identity = new Matrix4x3(1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0);

        public static Matrix4x3 LookAt(Vector3 eye, Vector3 target, Vector3 up)
        {
            var zaxis = (eye - target).Normalize();
            var xaxis = Vector3.Cross(up, zaxis).Normalize();
            var yaxis = Vector3.Cross(zaxis, xaxis);

            return new Matrix4x3(
                xaxis.X, yaxis.X, zaxis.X,
                xaxis.Y, yaxis.Y, zaxis.Y,
                xaxis.Z, yaxis.Z, zaxis.Z,
                Vector3.Dot(xaxis, -eye), Vector3.Dot(yaxis, -eye), Vector3.Dot(zaxis, -eye)
            );
        }

        public static Matrix4x3 LookAtInverse(Vector3 eye, Vector3 target, Vector3 up)
        {
            var zaxis = (target - eye).Normalize();
            var xaxis = Vector3.Cross(up, zaxis).Normalize();
            var yaxis = Vector3.Cross(zaxis, xaxis);

            return new Matrix4x3(
                xaxis.X, yaxis.X, zaxis.X,
                xaxis.Y, yaxis.Y, zaxis.Y,
                xaxis.Z, yaxis.Z, zaxis.Z,
                eye.X, eye.Y, eye.Z
            );
        }

        public static Matrix4x3 RotateX(float angle)
        {
            var c = (float)Math.Cos(angle);
            var s = (float)Math.Sin(angle);

            return new Matrix4x3(
                1, 0, 0, 0,
                0, c, s, 0,
                0, -s, c, 0
            );
        }

        public static Matrix4x3 RotateY(float angle)
        {
            var c = (float)Math.Cos(angle);
            var s = (float)Math.Sin(angle);

            return new Matrix4x3(
                c, 0, -s, 0,
                0, 1, 0, 0,
                s, 0, c, 0
            );
        }

        public static Matrix4x3 RotateZ(float angle)
        {
            var c = (float)Math.Cos(angle);
            var s = (float)Math.Sin(angle);

            return new Matrix4x3(
                c, s, 0, 0,
                -s, c, 0, 0,
                0, 0, 0, 0
            );
        }

        public static Matrix4x3 Scale(float x, float y, float z)
        {
            return new Matrix4x3(
                x, 0, 0, 0,
                0, y, 0, 0,
                0, 0, z, 0
            );
        }

        public static Matrix4x3 Translate(float x, float y, float z)
        {
            return new Matrix4x3(
                1, 0, 0,
                0, 1, 0,
                0, 0, 1,
                x, y, z
            );
        }
    }

    partial struct Matrix4x3d
    {
        public static Vector3d operator *(Matrix4x3d m, Vector3d v)
        {
            return new Vector3d(
                m.M00 * v.X + m.M10 * v.Y + m.M20 * v.Z + m.M30,
                m.M01 * v.X + m.M11 * v.Y + m.M21 * v.Z + m.M31,
                m.M02 * v.X + m.M12 * v.Y + m.M22 * v.Z + m.M32
            );
        }

        public static Matrix4x3d operator *(Matrix4x3d left, Matrix4x3d right)
        {
            return new Matrix4x3d(
                left.M00 * right.M00 + left.M10 * right.M01 + left.M20 * right.M02,
                left.M01 * right.M00 + left.M11 * right.M01 + left.M21 * right.M02,
                left.M02 * right.M00 + left.M12 * right.M01 + left.M22 * right.M02,

                left.M00 * right.M10 + left.M10 * right.M11 + left.M20 * right.M12,
                left.M01 * right.M10 + left.M11 * right.M11 + left.M21 * right.M12,
                left.M02 * right.M10 + left.M12 * right.M11 + left.M22 * right.M12,

                left.M00 * right.M20 + left.M10 * right.M21 + left.M20 * right.M22,
                left.M01 * right.M20 + left.M11 * right.M21 + left.M21 * right.M22,
                left.M02 * right.M20 + left.M12 * right.M21 + left.M22 * right.M22,

                left.M00 * right.M30 + left.M10 * right.M31 + left.M20 * right.M32 + left.M30,
                left.M01 * right.M30 + left.M11 * right.M31 + left.M21 * right.M32 + left.M31,
                left.M02 * right.M30 + left.M12 * right.M31 + left.M22 * right.M32 + left.M32
            );
        }

        public static readonly Matrix4x3d Identity = new Matrix4x3d(1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0);

        public static Matrix4x3d LookAt(Vector3d eye, Vector3d target, Vector3d up)
        {
            var zaxis = (eye - target).Normalize();
            var xaxis = Vector3d.Cross(up, zaxis).Normalize();
            var yaxis = Vector3d.Cross(zaxis, xaxis);

            return new Matrix4x3d(
                xaxis.X, xaxis.Y, xaxis.Z, Vector3d.Dot(xaxis, -eye),
                yaxis.X, yaxis.Y, yaxis.Z, Vector3d.Dot(yaxis, -eye),
                zaxis.X, zaxis.Y, zaxis.Z, Vector3d.Dot(zaxis, -eye)
            );
        }

        public static Matrix4x3d RotateX(double angle)
        {
            var c = Math.Cos(angle);
            var s = Math.Sin(angle);

            return new Matrix4x3d(
                1, 0, 0, 0,
                0, c, s, 0,
                0, -s, c, 0
            );
        }

        public static Matrix4x3d RotateY(double angle)
        {
            var c = Math.Cos(angle);
            var s = Math.Sin(angle);

            return new Matrix4x3d(
                c, 0, -s, 0,
                0, 1, 0, 0,
                s, 0, c, 0
            );
        }

        public static Matrix4x3d RotateZ(double angle)
        {
            var c = Math.Cos(angle);
            var s = Math.Sin(angle);

            return new Matrix4x3d(
                c, s, 0, 0,
                -s, c, 0, 0,
                0, 0, 0, 0
            );
        }

        public static Matrix4x3d Scale(double x, double y, double z)
        {
            return new Matrix4x3d(
                x, 0, 0, 0,
                0, y, 0, 0,
                0, 0, z, 0
            );
        }

        public static Matrix4x3d Translate(double x, double y, double z)
        {
            return new Matrix4x3d(
                1, 0, 0, x,
                0, 1, 0, y,
                0, 0, 1, z
            );
        }
    }
    */

    partial struct Matrix4
    {
        public static Matrix4 Ortho(float left, float right, float bottom, float top, float near, float far)
        {
            var right_minus_left = right - left;
            var top_minus_bottom = top - bottom;
            var far_minus_near = far - near;

            return new Matrix4(
                2, 0, 0, 0,
                0, 2 / top_minus_bottom, 0, 0,
                0, 0, -2 / far_minus_near, 0,
                (right + left) / right_minus_left, (top + bottom) / top_minus_bottom, (far + near) / far_minus_near, 1
            );

        }

        public static Matrix4 Frustum(float left, float right, float bottom, float top, float near, float far)
        {
            var near_2 = near * 2;
            var right_minus_left = right - left;
            var top_minus_bottom = top - bottom;
            var far_minus_near = far - near;

            return new Matrix4(
                near_2 / right_minus_left, 0, 0, 0,
                0, near_2 / top_minus_bottom, 0, 0,
                (right + left) / right_minus_left, (top + bottom) / top_minus_bottom, -(far + near) / far_minus_near, -1,
                0, 0, -(far * near * 2) / far_minus_near, 0
            );
        }

        public static Matrix4 LookAt(Vector3 eye, Vector3 target, Vector3 up)
        {
            var zaxis = (eye - target).Normalize();
            var xaxis = Vector3.Cross(up, zaxis).Normalize();
            var yaxis = Vector3.Cross(zaxis, xaxis);

            return new Matrix4(
                xaxis.X, yaxis.X, zaxis.X, 0,
                xaxis.Y, yaxis.Y, zaxis.Y, 0,
                xaxis.Z, yaxis.Z, zaxis.Z, 0,
                Vector3.Dot(xaxis, -eye), Vector3.Dot(yaxis, -eye), Vector3.Dot(zaxis, -eye), 1
            );
        }

        public static Matrix4 RotateX(float angle)
        {
            var c = (float)Math.Cos(angle);
            var s = (float)Math.Sin(angle);

            return new Matrix4(
                1, 0, 0, 0,
                0, c, -s, 0,
                0, s, c, 0,
                0, 0, 0, 1
            );
        }

        public static Matrix4 RotateY(float angle)
        {
            var c = (float)Math.Cos(angle);
            var s = (float)Math.Sin(angle);

            return new Matrix4(
                c, 0, s, 0,
                0, 1, 0, 0,
                -s, 0, c, 0,
                0, 0, 0, 1
            );
        }

        public static Matrix4 RotateZ(float angle)
        {
            var c = (float)Math.Cos(angle);
            var s = (float)Math.Sin(angle);

            return new Matrix4(
                c, -s, 0, 0,
                s, c, 0, 0,
                0, 0, 0, 0,
                0, 0, 0, 1
            );
        }

        public static Matrix4 Scale(float x, float y, float z)
        {
            return new Matrix4(
                x, 0, 0, 0,
                0, y, 0, 0,
                0, 0, z, 0,
                0, 0, 0, 1
            );
        }

        public static Matrix4 Translate(float x, float y, float z)
        {
            return new Matrix4(
                1, 0, 0, 0,
                0, 1, 0, 0,
                0, 0, 1, 0,
                x, y, z, 1
            );
        }

    }

    partial struct Matrix4d
    {
        public static Matrix4d Ortho(double left, double right, double bottom, double top, double near, double far)
        {
            var rightMinusLeft = right - left;
            var topMinusBottom = top - bottom;
            var farMinusNear = far - near;

            return new Matrix4d(
                2, 0, 0, 0,
                0, 2 / topMinusBottom, 0, 0,
                0, 0, -2 / farMinusNear, 0,
                (right + left) / rightMinusLeft, (top + bottom) / topMinusBottom, (far + near) / farMinusNear, 1
            );
        }

        public static Matrix4d Frustum(double left, double right, double bottom, double top, double near, double far)
        {
            var Near2 = near * 2;
            var rightMinusLeft = right - left;
            var topMinusBottom = top - bottom;
            var farMinusNear = far - near;

            return new Matrix4d(
                Near2 / rightMinusLeft, 0, 0, 0,
                0, Near2 / topMinusBottom, 0, 0,
                (right + left) / rightMinusLeft, (top + bottom) / topMinusBottom, -(far + near) / farMinusNear, -1,
                0, 0, -(far * near * 2) / farMinusNear, 0
            );
        }

        public static Matrix4d LookAt(Vector3d eye, Vector3d target, Vector3d up)
        {
            var zaxis = (target - eye).Normalize();
            var xaxis = Vector3d.Cross(up, zaxis).Normalize();
            var yaxis = Vector3d.Cross(zaxis, xaxis);

            return new Matrix4d(
                xaxis.X, yaxis.X, zaxis.X, 0,
                xaxis.Y, yaxis.Y, zaxis.Y, 0,
                xaxis.Z, yaxis.Z, zaxis.Z, 0,
                -Vector3d.Dot(xaxis, eye), -Vector3d.Dot(yaxis, eye), -Vector3d.Dot(zaxis, eye), 1
            );
        }

        public static Matrix4d RotateX(double angle)
        {
            var c = Math.Cos(angle);
            var s = Math.Sin(angle);

            return new Matrix4d(
                1, 0, 0, 0,
                0, c, s, 0,
                0, -s, c, 0,
                0, 0, 0, 1
            );
        }

        public static Matrix4d RotateY(double angle)
        {
            var c = Math.Cos(angle);
            var s = Math.Sin(angle);

            return new Matrix4d(
                c, 0, -s, 0,
                0, 1, 0, 0,
                s, 0, c, 0,
                0, 0, 0, 1
            );
        }

        public static Matrix4d RotateZ(double angle)
        {
            var c = Math.Cos(angle);
            var s = Math.Sin(angle);

            return new Matrix4d(
                c, s, 0, 0,
                -s, c, 0, 0,
                0, 0, 0, 0,
                0, 0, 0, 1
            );
        }

        public static Matrix4d Scale(double x, double y, double z)
        {
            return new Matrix4d(
                x, 0, 0, 0,
                0, y, 0, 0,
                0, 0, z, 0,
                0, 0, 0, 1
            );
        }

        public static Matrix4d Translate(double x, double y, double z)
        {
            return new Matrix4d(
                1, 0, 0, x,
                0, 1, 0, y,
                0, 0, 1, z,
                0, 0, 0, 1
            );
        }
    }
}
