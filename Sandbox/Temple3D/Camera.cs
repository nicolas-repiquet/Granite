using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temple3D
{
    public class Camera
    {
        public Vector3 Position { get; set; }
        public Vector3 Target { get; set; }
        public Vector3 UpDirection { get; set; } = Vector3.UnitZ;
        public float FieldOfView { get; set; } = 60f;
        public float NearPlaneDistance { get; set; } = 1f;
        public float FarPlaneDistance { get; set; } = 100f;
        public Box2i Viewport { get; set; }

        public Matrix4 CreateWorldToViewportMatrix()
        {
            var lookAt = Matrix4.LookAt(
                Position,
                Target,
                UpDirection
            );

            var fy = (float)Math.Tan(0.5 * FieldOfView * Math.PI / 180.0) * NearPlaneDistance;
            var fx = fy * Viewport.Size.X / Viewport.Size.Y;

            var frustum = Matrix4.Frustum(
                -fx,
                fx,
                -fy,
                fy,
                NearPlaneDistance,
                FarPlaneDistance
            );

            return frustum * lookAt;
        }

        public Frustum GetFrustum()
        {
            // var lookAt = Matrix3x4.Identity;

            /*
            var lookAt = Matrix4.LookAt(
                Position,
                Target,
                UpDirection
            );
            */
            
            
            
            var lookAt = Matrix4.Translate(
                Position.X,
                Position.Y,
                Position.Z
            );
            

            // var r = lookAt * new Vector4(0, 0, 0, 1);

            var fy = (float)Math.Tan(FieldOfView / 360.0 * Math.PI);
            var fx = fy * ((float)Viewport.Size.X / (float)Viewport.Size.Y);

            var nearX = fx * NearPlaneDistance;
            var nearY = fy * NearPlaneDistance;
            var farX = fx * FarPlaneDistance;
            var farY = fy * FarPlaneDistance;


            return new Frustum(
                (lookAt * new Vector4(-nearX, -nearY, NearPlaneDistance, 1)).Xyz,
                (lookAt * new Vector4(nearX, -nearY, NearPlaneDistance, 1)).Xyz,
                (lookAt * new Vector4(-nearX, nearY, NearPlaneDistance, 1)).Xyz,
                (lookAt * new Vector4(nearX, nearY, NearPlaneDistance, 1)).Xyz,
                (lookAt * new Vector4(-farX, -farY, FarPlaneDistance, 1)).Xyz,
                (lookAt * new Vector4(farX, -farY, FarPlaneDistance, 1)).Xyz,
                (lookAt * new Vector4(-farX, farY, FarPlaneDistance, 1)).Xyz,
                (lookAt * new Vector4(farX, farY, FarPlaneDistance, 1)).Xyz
            );
        }

    }
}
