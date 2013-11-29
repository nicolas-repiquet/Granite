using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite3D
{

    partial struct Matrix4
    {
        public static Matrix4 Ortho(float left, float right, float bottom, float top, float near, float far)
        {
            var right_minus_left = right - left;
            var top_minus_bottom = top - bottom;
            var far_minus_near = far - near;

            return new Matrix4(
                2 / right_minus_left, 0, 0, (right + left) / right_minus_left,
                0, 2 / top_minus_bottom, 0, (top + bottom) / top_minus_bottom,
                0, 0, -2 / far_minus_near, (far + near) / far_minus_near,
                0, 0, 0, 1
            );
        }

        public static Matrix4 Frustum(float left, float right, float bottom, float top, float near, float far)
        {
            var near_2 = near * 2;
            var right_minus_left = right - left;
            var top_minus_bottom = top - bottom;
            var far_minus_near = far - near;

            return new Matrix4(
                near_2 / right_minus_left, 0, (right + left) / right_minus_left, 0,
                0, near_2 / top_minus_bottom, (top + bottom) / top_minus_bottom, 0,
                0, 0, -(far + near) / far_minus_near, -(far * near * 2) / far_minus_near,
                0, 0, -1, 0
            );
        }

        public static Matrix4 LookAt(Vector3 eye, Vector3 target, Vector3 up)
        {
            var zaxis = (target - eye).Normalize();
            var xaxis = Vector3.Cross(up, zaxis).Normalize();
            var yaxis = Vector3.Cross(zaxis, xaxis);

            return new Matrix4(
                xaxis.X, xaxis.Y, xaxis.Z, -Vector3.Dot(xaxis, eye),
                yaxis.X, yaxis.Y, yaxis.Z, -Vector3.Dot(yaxis, eye),
                zaxis.X, zaxis.Y, zaxis.Z, -Vector3.Dot(zaxis, eye),
                0, 0, 0, 1
            );
        }

        public static Matrix4 RotateX(float angle)
        {
            return new Matrix4(
                1, 0, 0, 0,
                0, (float)System.Math.Cos(angle), (float)-System.Math.Sin(angle), 0,
                0, (float)System.Math.Sin(angle), (float)System.Math.Cos(angle), 0,
                0, 0, 0, 1
            );
        }

        public static Matrix4 RotateY(float angle)
        {
            return new Matrix4(
                (float)System.Math.Cos(angle), 0, (float)System.Math.Sin(angle), 0,
                0, 1, 0, 0,
                (float)-System.Math.Sin(angle), 0, (float)System.Math.Cos(angle), 0,
                0, 0, 0, 1
            );
        }

        public static Matrix4 RotateZ(float angle)
        {
            return new Matrix4(
                (float)System.Math.Cos(angle), (float)-System.Math.Sin(angle), 0, 0,
                (float)System.Math.Sin(angle), (float)System.Math.Cos(angle), 0, 0,
                0, 0, 1, 0,
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
                1, 0, 0, x,
                0, 1, 0, y,
                0, 0, 1, z,
                0, 0, 0, 1
            );
        }
    }

    partial struct Matrix4d
    {
        public static Matrix4d Ortho(double left, double right, double bottom, double top, double near, double far)
        {
            var right_minus_left = right - left;
            var top_minus_bottom = top - bottom;
            var far_minus_near = far - near;

            return new Matrix4d(
                2 / right_minus_left, 0, 0, (right + left) / right_minus_left,
                0, 2 / top_minus_bottom, 0, (top + bottom) / top_minus_bottom,
                0, 0, -2 / far_minus_near, (far + near) / far_minus_near,
                0, 0, 0, 1
            );
        }

        public static Matrix4d Frustum(double left, double right, double bottom, double top, double near, double far)
        {
            var near_2 = near * 2;
            var right_minus_left = right - left;
            var top_minus_bottom = top - bottom;
            var far_minus_near = far - near;

            return new Matrix4d(
                near_2 / right_minus_left, 0, (right + left) / right_minus_left, 0,
                0, near_2 / top_minus_bottom, (top + bottom) / top_minus_bottom, 0,
                0, 0, -(far + near) / far_minus_near, -(far * near * 2) / far_minus_near,
                0, 0, -1, 0
            );
        }

        public static Matrix4d LookAt(Vector3d eye, Vector3d target, Vector3d up)
        {
            var zaxis = (target - eye).Normalize();
            var xaxis = Vector3d.Cross(up, zaxis).Normalize();
            var yaxis = Vector3d.Cross(zaxis, xaxis);

            return new Matrix4d(
                xaxis.X, xaxis.Y, xaxis.Z, -Vector3d.Dot(xaxis, eye),
                yaxis.X, yaxis.Y, yaxis.Z, -Vector3d.Dot(yaxis, eye),
                zaxis.X, zaxis.Y, zaxis.Z, -Vector3d.Dot(zaxis, eye),
                0, 0, 0, 1
            );
        }

        public static Matrix4d RotateX(double angle)
        {
            return new Matrix4d(
                1, 0, 0, 0,
                0, System.Math.Cos(angle), -System.Math.Sin(angle), 0,
                0, System.Math.Sin(angle), System.Math.Cos(angle), 0,
                0, 0, 0, 1
            );
        }

        public static Matrix4d RotateY(double angle)
        {
            return new Matrix4d(
                System.Math.Cos(angle), 0, System.Math.Sin(angle), 0,
                0, 1, 0, 0,
                -System.Math.Sin(angle), 0, System.Math.Cos(angle), 0,
                0, 0, 0, 1
            );
        }

        public static Matrix4d RotateZ(double angle)
        {
            return new Matrix4d(
                System.Math.Cos(angle), -System.Math.Sin(angle), 0, 0,
                System.Math.Sin(angle), System.Math.Cos(angle), 0, 0,
                0, 0, 1, 0,
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
