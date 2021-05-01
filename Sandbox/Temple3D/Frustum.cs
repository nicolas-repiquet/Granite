using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temple3D
{
    public class Frustum
    {
        public Frustum(
            Vector3 nearTopLeft, Vector3 nearTopRight, Vector3 nearBottomLeft, Vector3 nearBottomRight,
            Vector3 farTopLeft, Vector3 farTopRight, Vector3 farBottomLeft, Vector3 farBottomRight)
        {
            NearTopLeft = nearTopLeft;
            NearTopRight = nearTopRight;
            NearBottomLeft = nearBottomLeft;
            NearBottomRight = nearBottomRight;
            FarTopLeft = farTopLeft;
            FarTopRight = farTopRight;
            FarBottomLeft = farBottomLeft;
            FarBottomRight = farBottomRight;
        }

        public Vector3 NearTopLeft { get; }
        public Vector3 NearTopRight { get; }
        public Vector3 NearBottomLeft { get; }
        public Vector3 NearBottomRight { get; }
        public Vector3 FarTopLeft { get; }
        public Vector3 FarTopRight { get; }
        public Vector3 FarBottomLeft { get; }
        public Vector3 FarBottomRight { get; }
    }
}