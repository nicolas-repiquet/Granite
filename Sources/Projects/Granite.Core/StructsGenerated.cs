namespace Granite.Core
{
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Vector2b : System.IEquatable<Vector2b>
    {
        public readonly sbyte X;
        public readonly sbyte Y;
        
        public Vector2b(sbyte x, sbyte y)
        {
            X = x;
            Y = y;
        }
        
        public static explicit operator Vector2ub(Vector2b v)
        {
            return new Vector2ub((byte)v.X, (byte)v.Y);
        }
        
        public static implicit operator Vector2s(Vector2b v)
        {
            return new Vector2s(v.X, v.Y);
        }
        
        public static explicit operator Vector2us(Vector2b v)
        {
            return new Vector2us((ushort)v.X, (ushort)v.Y);
        }
        
        public static implicit operator Vector2i(Vector2b v)
        {
            return new Vector2i(v.X, v.Y);
        }
        
        public static explicit operator Vector2ui(Vector2b v)
        {
            return new Vector2ui((uint)v.X, (uint)v.Y);
        }
        
        public static implicit operator Vector2(Vector2b v)
        {
            return new Vector2(v.X, v.Y);
        }
        
        public static implicit operator Vector2d(Vector2b v)
        {
            return new Vector2d(v.X, v.Y);
        }
        
        public override string ToString()
        {
            return string.Format("[{0}, {1}]", X, Y);
        }
        
        public static bool operator ==(Vector2b a, Vector2b b)
        {
            return a.X == b.X && a.Y == b.Y;
        }
        
        public static bool operator !=(Vector2b a, Vector2b b)
        {
            return a.X != b.X || a.Y != b.Y;
        }
        
        public bool Equals(Vector2b other)
        {
            return X == other.X && Y == other.Y;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Vector2b)) return false;
            var v = (Vector2b)other;
            return X == v.X && Y == v.Y;
        }
        
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode();
        }
        
        public static Vector2i operator +(Vector2b a, Vector2i b)
        {
            return new Vector2i(a.X + b.X, a.Y + b.Y);
        }
        
        public static Vector2i operator +(Vector2b a, int b)
        {
            return new Vector2i(a.X + b, a.Y + b);
        }
        
        public static Vector2i operator -(Vector2b a, Vector2i b)
        {
            return new Vector2i(a.X - b.X, a.Y - b.Y);
        }
        
        public static Vector2i operator -(Vector2b a, int b)
        {
            return new Vector2i(a.X - b, a.Y - b);
        }
        
        public static Vector2i operator *(Vector2b a, Vector2i b)
        {
            return new Vector2i(a.X * b.X, a.Y * b.Y);
        }
        
        public static Vector2i operator *(Vector2b a, int b)
        {
            return new Vector2i(a.X * b, a.Y * b);
        }
        
        public static Vector2i operator /(Vector2b a, Vector2i b)
        {
            return new Vector2i(a.X / b.X, a.Y / b.Y);
        }
        
        public static Vector2i operator /(Vector2b a, int b)
        {
            return new Vector2i(a.X / b, a.Y / b);
        }
        
        public static Vector2i operator -(Vector2b v)
        {
            return new Vector2i (-v.X, -v.Y);
        }
        
        public static int Dot(Vector2b a, Vector2b b)
        {
            return a.X * b.X + a.Y * b.Y;
        }
        
        public int SquaredLength
        {
            get { return X * X + Y * Y; }
        }
        
        public float Length
        {
            get { return (float)System.Math.Sqrt(X * X + Y * Y); }
        }
        
        public Vector2 Normalize()
        {
            var l = Length;
            return new Vector2(X / l, Y / l);
        }
        
        public static readonly Vector2b Zero = new Vector2b(0, 0);
        public static readonly Vector2b One = new Vector2b(1, 1);
        public static readonly Vector2b UnitX = new Vector2b(1, 0);
        public static readonly Vector2b UnitY = new Vector2b(0, 1);
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Vector3b : System.IEquatable<Vector3b>
    {
        public readonly sbyte X;
        public readonly sbyte Y;
        public readonly sbyte Z;
        
        public Vector3b(sbyte x, sbyte y, sbyte z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        
        public Vector3b(Vector2b v, sbyte z)
        {
            X = v.X;
            Y = v.Y;
            Z = z;
        }
        
        public static explicit operator Vector3ub(Vector3b v)
        {
            return new Vector3ub((byte)v.X, (byte)v.Y, (byte)v.Z);
        }
        
        public static implicit operator Vector3s(Vector3b v)
        {
            return new Vector3s(v.X, v.Y, v.Z);
        }
        
        public static explicit operator Vector3us(Vector3b v)
        {
            return new Vector3us((ushort)v.X, (ushort)v.Y, (ushort)v.Z);
        }
        
        public static implicit operator Vector3i(Vector3b v)
        {
            return new Vector3i(v.X, v.Y, v.Z);
        }
        
        public static explicit operator Vector3ui(Vector3b v)
        {
            return new Vector3ui((uint)v.X, (uint)v.Y, (uint)v.Z);
        }
        
        public static implicit operator Vector3(Vector3b v)
        {
            return new Vector3(v.X, v.Y, v.Z);
        }
        
        public static implicit operator Vector3d(Vector3b v)
        {
            return new Vector3d(v.X, v.Y, v.Z);
        }
        
        public override string ToString()
        {
            return string.Format("[{0}, {1}, {2}]", X, Y, Z);
        }
        
        public static bool operator ==(Vector3b a, Vector3b b)
        {
            return a.X == b.X && a.Y == b.Y && a.Z == b.Z;
        }
        
        public static bool operator !=(Vector3b a, Vector3b b)
        {
            return a.X != b.X || a.Y != b.Y || a.Z != b.Z;
        }
        
        public bool Equals(Vector3b other)
        {
            return X == other.X && Y == other.Y && Z == other.Z;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Vector3b)) return false;
            var v = (Vector3b)other;
            return X == v.X && Y == v.Y && Z == v.Z;
        }
        
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode();
        }
        
        public static Vector3i operator +(Vector3b a, Vector3i b)
        {
            return new Vector3i(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }
        
        public static Vector3i operator +(Vector3b a, int b)
        {
            return new Vector3i(a.X + b, a.Y + b, a.Z + b);
        }
        
        public static Vector3i operator -(Vector3b a, Vector3i b)
        {
            return new Vector3i(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }
        
        public static Vector3i operator -(Vector3b a, int b)
        {
            return new Vector3i(a.X - b, a.Y - b, a.Z - b);
        }
        
        public static Vector3i operator *(Vector3b a, Vector3i b)
        {
            return new Vector3i(a.X * b.X, a.Y * b.Y, a.Z * b.Z);
        }
        
        public static Vector3i operator *(Vector3b a, int b)
        {
            return new Vector3i(a.X * b, a.Y * b, a.Z * b);
        }
        
        public static Vector3i operator /(Vector3b a, Vector3i b)
        {
            return new Vector3i(a.X / b.X, a.Y / b.Y, a.Z / b.Z);
        }
        
        public static Vector3i operator /(Vector3b a, int b)
        {
            return new Vector3i(a.X / b, a.Y / b, a.Z / b);
        }
        
        public static Vector3i operator -(Vector3b v)
        {
            return new Vector3i (-v.X, -v.Y, -v.Z);
        }
        
        public static int Dot(Vector3b a, Vector3b b)
        {
            return a.X * b.X + a.Y * b.Y + a.Z * b.Z;
        }
        
        public static Vector3i Cross(Vector3b a, Vector3b b)
        {
            return new Vector3i(
                a.Y * b.Z - a.Z * b.Y,
                a.Z * b.X - a.X * b.Z,
                a.X * b.Y - a.Y * b.X
            );
        }
        
        public int SquaredLength
        {
            get { return X * X + Y * Y + Z * Z; }
        }
        
        public float Length
        {
            get { return (float)System.Math.Sqrt(X * X + Y * Y + Z * Z); }
        }
        
        public Vector3 Normalize()
        {
            var l = Length;
            return new Vector3(X / l, Y / l, Z / l);
        }
        
        public static readonly Vector3b Zero = new Vector3b(0, 0, 0);
        public static readonly Vector3b One = new Vector3b(1, 1, 1);
        public static readonly Vector3b UnitX = new Vector3b(1, 0, 0);
        public static readonly Vector3b UnitY = new Vector3b(0, 1, 0);
        public static readonly Vector3b UnitZ = new Vector3b(0, 0, 1);
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Vector4b : System.IEquatable<Vector4b>
    {
        public readonly sbyte X;
        public readonly sbyte Y;
        public readonly sbyte Z;
        public readonly sbyte W;
        
        public Vector4b(sbyte x, sbyte y, sbyte z, sbyte w)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }
        
        public Vector4b(Vector2b v, sbyte z, sbyte w)
        {
            X = v.X;
            Y = v.Y;
            Z = z;
            W = w;
        }
        
        public Vector4b(Vector3b v, sbyte w)
        {
            X = v.X;
            Y = v.Y;
            Z = v.Z;
            W = w;
        }
        
        public static explicit operator Vector4ub(Vector4b v)
        {
            return new Vector4ub((byte)v.X, (byte)v.Y, (byte)v.Z, (byte)v.W);
        }
        
        public static implicit operator Vector4s(Vector4b v)
        {
            return new Vector4s(v.X, v.Y, v.Z, v.W);
        }
        
        public static explicit operator Vector4us(Vector4b v)
        {
            return new Vector4us((ushort)v.X, (ushort)v.Y, (ushort)v.Z, (ushort)v.W);
        }
        
        public static implicit operator Vector4i(Vector4b v)
        {
            return new Vector4i(v.X, v.Y, v.Z, v.W);
        }
        
        public static explicit operator Vector4ui(Vector4b v)
        {
            return new Vector4ui((uint)v.X, (uint)v.Y, (uint)v.Z, (uint)v.W);
        }
        
        public static implicit operator Vector4(Vector4b v)
        {
            return new Vector4(v.X, v.Y, v.Z, v.W);
        }
        
        public static implicit operator Vector4d(Vector4b v)
        {
            return new Vector4d(v.X, v.Y, v.Z, v.W);
        }
        
        public override string ToString()
        {
            return string.Format("[{0}, {1}, {2}, {3}]", X, Y, Z, W);
        }
        
        public static bool operator ==(Vector4b a, Vector4b b)
        {
            return a.X == b.X && a.Y == b.Y && a.Z == b.Z && a.W == b.W;
        }
        
        public static bool operator !=(Vector4b a, Vector4b b)
        {
            return a.X != b.X || a.Y != b.Y || a.Z != b.Z || a.W != b.W;
        }
        
        public bool Equals(Vector4b other)
        {
            return X == other.X && Y == other.Y && Z == other.Z && W == other.W;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Vector4b)) return false;
            var v = (Vector4b)other;
            return X == v.X && Y == v.Y && Z == v.Z && W == v.W;
        }
        
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode() ^ W.GetHashCode();
        }
        
        public static Vector4i operator +(Vector4b a, Vector4i b)
        {
            return new Vector4i(a.X + b.X, a.Y + b.Y, a.Z + b.Z, a.W + b.W);
        }
        
        public static Vector4i operator +(Vector4b a, int b)
        {
            return new Vector4i(a.X + b, a.Y + b, a.Z + b, a.W + b);
        }
        
        public static Vector4i operator -(Vector4b a, Vector4i b)
        {
            return new Vector4i(a.X - b.X, a.Y - b.Y, a.Z - b.Z, a.W - b.W);
        }
        
        public static Vector4i operator -(Vector4b a, int b)
        {
            return new Vector4i(a.X - b, a.Y - b, a.Z - b, a.W - b);
        }
        
        public static Vector4i operator *(Vector4b a, Vector4i b)
        {
            return new Vector4i(a.X * b.X, a.Y * b.Y, a.Z * b.Z, a.W * b.W);
        }
        
        public static Vector4i operator *(Vector4b a, int b)
        {
            return new Vector4i(a.X * b, a.Y * b, a.Z * b, a.W * b);
        }
        
        public static Vector4i operator /(Vector4b a, Vector4i b)
        {
            return new Vector4i(a.X / b.X, a.Y / b.Y, a.Z / b.Z, a.W / b.W);
        }
        
        public static Vector4i operator /(Vector4b a, int b)
        {
            return new Vector4i(a.X / b, a.Y / b, a.Z / b, a.W / b);
        }
        
        public static Vector4i operator -(Vector4b v)
        {
            return new Vector4i (-v.X, -v.Y, -v.Z, -v.W);
        }
        
        public static int Dot(Vector4b a, Vector4b b)
        {
            return a.X * b.X + a.Y * b.Y + a.Z * b.Z + a.W * b.W;
        }
        
        public int SquaredLength
        {
            get { return X * X + Y * Y + Z * Z + W * W; }
        }
        
        public float Length
        {
            get { return (float)System.Math.Sqrt(X * X + Y * Y + Z * Z + W * W); }
        }
        
        public Vector4 Normalize()
        {
            var l = Length;
            return new Vector4(X / l, Y / l, Z / l, W / l);
        }
        
        public static readonly Vector4b Zero = new Vector4b(0, 0, 0, 0);
        public static readonly Vector4b One = new Vector4b(1, 1, 1, 1);
        public static readonly Vector4b UnitX = new Vector4b(1, 0, 0, 0);
        public static readonly Vector4b UnitY = new Vector4b(0, 1, 0, 0);
        public static readonly Vector4b UnitZ = new Vector4b(0, 0, 1, 0);
        public static readonly Vector4b UnitW = new Vector4b(0, 0, 0, 1);
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Vector2ub : System.IEquatable<Vector2ub>
    {
        public readonly byte X;
        public readonly byte Y;
        
        public Vector2ub(byte x, byte y)
        {
            X = x;
            Y = y;
        }
        
        public static explicit operator Vector2b(Vector2ub v)
        {
            return new Vector2b((sbyte)v.X, (sbyte)v.Y);
        }
        
        public static implicit operator Vector2s(Vector2ub v)
        {
            return new Vector2s(v.X, v.Y);
        }
        
        public static implicit operator Vector2us(Vector2ub v)
        {
            return new Vector2us(v.X, v.Y);
        }
        
        public static implicit operator Vector2i(Vector2ub v)
        {
            return new Vector2i(v.X, v.Y);
        }
        
        public static implicit operator Vector2ui(Vector2ub v)
        {
            return new Vector2ui(v.X, v.Y);
        }
        
        public static implicit operator Vector2(Vector2ub v)
        {
            return new Vector2(v.X, v.Y);
        }
        
        public static implicit operator Vector2d(Vector2ub v)
        {
            return new Vector2d(v.X, v.Y);
        }
        
        public override string ToString()
        {
            return string.Format("[{0}, {1}]", X, Y);
        }
        
        public static bool operator ==(Vector2ub a, Vector2ub b)
        {
            return a.X == b.X && a.Y == b.Y;
        }
        
        public static bool operator !=(Vector2ub a, Vector2ub b)
        {
            return a.X != b.X || a.Y != b.Y;
        }
        
        public bool Equals(Vector2ub other)
        {
            return X == other.X && Y == other.Y;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Vector2ub)) return false;
            var v = (Vector2ub)other;
            return X == v.X && Y == v.Y;
        }
        
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode();
        }
        
        public static Vector2i operator +(Vector2ub a, Vector2i b)
        {
            return new Vector2i(a.X + b.X, a.Y + b.Y);
        }
        
        public static Vector2i operator +(Vector2ub a, int b)
        {
            return new Vector2i(a.X + b, a.Y + b);
        }
        
        public static Vector2i operator -(Vector2ub a, Vector2i b)
        {
            return new Vector2i(a.X - b.X, a.Y - b.Y);
        }
        
        public static Vector2i operator -(Vector2ub a, int b)
        {
            return new Vector2i(a.X - b, a.Y - b);
        }
        
        public static Vector2i operator *(Vector2ub a, Vector2i b)
        {
            return new Vector2i(a.X * b.X, a.Y * b.Y);
        }
        
        public static Vector2i operator *(Vector2ub a, int b)
        {
            return new Vector2i(a.X * b, a.Y * b);
        }
        
        public static Vector2i operator /(Vector2ub a, Vector2i b)
        {
            return new Vector2i(a.X / b.X, a.Y / b.Y);
        }
        
        public static Vector2i operator /(Vector2ub a, int b)
        {
            return new Vector2i(a.X / b, a.Y / b);
        }
        
        public static int Dot(Vector2ub a, Vector2ub b)
        {
            return a.X * b.X + a.Y * b.Y;
        }
        
        public int SquaredLength
        {
            get { return X * X + Y * Y; }
        }
        
        public float Length
        {
            get { return (float)System.Math.Sqrt(X * X + Y * Y); }
        }
        
        public Vector2 Normalize()
        {
            var l = Length;
            return new Vector2(X / l, Y / l);
        }
        
        public static readonly Vector2ub Zero = new Vector2ub(0, 0);
        public static readonly Vector2ub One = new Vector2ub(1, 1);
        public static readonly Vector2ub UnitX = new Vector2ub(1, 0);
        public static readonly Vector2ub UnitY = new Vector2ub(0, 1);
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Vector3ub : System.IEquatable<Vector3ub>
    {
        public readonly byte X;
        public readonly byte Y;
        public readonly byte Z;
        
        public Vector3ub(byte x, byte y, byte z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        
        public Vector3ub(Vector2ub v, byte z)
        {
            X = v.X;
            Y = v.Y;
            Z = z;
        }
        
        public static explicit operator Vector3b(Vector3ub v)
        {
            return new Vector3b((sbyte)v.X, (sbyte)v.Y, (sbyte)v.Z);
        }
        
        public static implicit operator Vector3s(Vector3ub v)
        {
            return new Vector3s(v.X, v.Y, v.Z);
        }
        
        public static implicit operator Vector3us(Vector3ub v)
        {
            return new Vector3us(v.X, v.Y, v.Z);
        }
        
        public static implicit operator Vector3i(Vector3ub v)
        {
            return new Vector3i(v.X, v.Y, v.Z);
        }
        
        public static implicit operator Vector3ui(Vector3ub v)
        {
            return new Vector3ui(v.X, v.Y, v.Z);
        }
        
        public static implicit operator Vector3(Vector3ub v)
        {
            return new Vector3(v.X, v.Y, v.Z);
        }
        
        public static implicit operator Vector3d(Vector3ub v)
        {
            return new Vector3d(v.X, v.Y, v.Z);
        }
        
        public override string ToString()
        {
            return string.Format("[{0}, {1}, {2}]", X, Y, Z);
        }
        
        public static bool operator ==(Vector3ub a, Vector3ub b)
        {
            return a.X == b.X && a.Y == b.Y && a.Z == b.Z;
        }
        
        public static bool operator !=(Vector3ub a, Vector3ub b)
        {
            return a.X != b.X || a.Y != b.Y || a.Z != b.Z;
        }
        
        public bool Equals(Vector3ub other)
        {
            return X == other.X && Y == other.Y && Z == other.Z;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Vector3ub)) return false;
            var v = (Vector3ub)other;
            return X == v.X && Y == v.Y && Z == v.Z;
        }
        
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode();
        }
        
        public static Vector3i operator +(Vector3ub a, Vector3i b)
        {
            return new Vector3i(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }
        
        public static Vector3i operator +(Vector3ub a, int b)
        {
            return new Vector3i(a.X + b, a.Y + b, a.Z + b);
        }
        
        public static Vector3i operator -(Vector3ub a, Vector3i b)
        {
            return new Vector3i(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }
        
        public static Vector3i operator -(Vector3ub a, int b)
        {
            return new Vector3i(a.X - b, a.Y - b, a.Z - b);
        }
        
        public static Vector3i operator *(Vector3ub a, Vector3i b)
        {
            return new Vector3i(a.X * b.X, a.Y * b.Y, a.Z * b.Z);
        }
        
        public static Vector3i operator *(Vector3ub a, int b)
        {
            return new Vector3i(a.X * b, a.Y * b, a.Z * b);
        }
        
        public static Vector3i operator /(Vector3ub a, Vector3i b)
        {
            return new Vector3i(a.X / b.X, a.Y / b.Y, a.Z / b.Z);
        }
        
        public static Vector3i operator /(Vector3ub a, int b)
        {
            return new Vector3i(a.X / b, a.Y / b, a.Z / b);
        }
        
        public static int Dot(Vector3ub a, Vector3ub b)
        {
            return a.X * b.X + a.Y * b.Y + a.Z * b.Z;
        }
        
        public static Vector3i Cross(Vector3ub a, Vector3ub b)
        {
            return new Vector3i(
                a.Y * b.Z - a.Z * b.Y,
                a.Z * b.X - a.X * b.Z,
                a.X * b.Y - a.Y * b.X
            );
        }
        
        public int SquaredLength
        {
            get { return X * X + Y * Y + Z * Z; }
        }
        
        public float Length
        {
            get { return (float)System.Math.Sqrt(X * X + Y * Y + Z * Z); }
        }
        
        public Vector3 Normalize()
        {
            var l = Length;
            return new Vector3(X / l, Y / l, Z / l);
        }
        
        public static readonly Vector3ub Zero = new Vector3ub(0, 0, 0);
        public static readonly Vector3ub One = new Vector3ub(1, 1, 1);
        public static readonly Vector3ub UnitX = new Vector3ub(1, 0, 0);
        public static readonly Vector3ub UnitY = new Vector3ub(0, 1, 0);
        public static readonly Vector3ub UnitZ = new Vector3ub(0, 0, 1);
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Vector4ub : System.IEquatable<Vector4ub>
    {
        public readonly byte X;
        public readonly byte Y;
        public readonly byte Z;
        public readonly byte W;
        
        public Vector4ub(byte x, byte y, byte z, byte w)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }
        
        public Vector4ub(Vector2ub v, byte z, byte w)
        {
            X = v.X;
            Y = v.Y;
            Z = z;
            W = w;
        }
        
        public Vector4ub(Vector3ub v, byte w)
        {
            X = v.X;
            Y = v.Y;
            Z = v.Z;
            W = w;
        }
        
        public static explicit operator Vector4b(Vector4ub v)
        {
            return new Vector4b((sbyte)v.X, (sbyte)v.Y, (sbyte)v.Z, (sbyte)v.W);
        }
        
        public static implicit operator Vector4s(Vector4ub v)
        {
            return new Vector4s(v.X, v.Y, v.Z, v.W);
        }
        
        public static implicit operator Vector4us(Vector4ub v)
        {
            return new Vector4us(v.X, v.Y, v.Z, v.W);
        }
        
        public static implicit operator Vector4i(Vector4ub v)
        {
            return new Vector4i(v.X, v.Y, v.Z, v.W);
        }
        
        public static implicit operator Vector4ui(Vector4ub v)
        {
            return new Vector4ui(v.X, v.Y, v.Z, v.W);
        }
        
        public static implicit operator Vector4(Vector4ub v)
        {
            return new Vector4(v.X, v.Y, v.Z, v.W);
        }
        
        public static implicit operator Vector4d(Vector4ub v)
        {
            return new Vector4d(v.X, v.Y, v.Z, v.W);
        }
        
        public override string ToString()
        {
            return string.Format("[{0}, {1}, {2}, {3}]", X, Y, Z, W);
        }
        
        public static bool operator ==(Vector4ub a, Vector4ub b)
        {
            return a.X == b.X && a.Y == b.Y && a.Z == b.Z && a.W == b.W;
        }
        
        public static bool operator !=(Vector4ub a, Vector4ub b)
        {
            return a.X != b.X || a.Y != b.Y || a.Z != b.Z || a.W != b.W;
        }
        
        public bool Equals(Vector4ub other)
        {
            return X == other.X && Y == other.Y && Z == other.Z && W == other.W;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Vector4ub)) return false;
            var v = (Vector4ub)other;
            return X == v.X && Y == v.Y && Z == v.Z && W == v.W;
        }
        
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode() ^ W.GetHashCode();
        }
        
        public static Vector4i operator +(Vector4ub a, Vector4i b)
        {
            return new Vector4i(a.X + b.X, a.Y + b.Y, a.Z + b.Z, a.W + b.W);
        }
        
        public static Vector4i operator +(Vector4ub a, int b)
        {
            return new Vector4i(a.X + b, a.Y + b, a.Z + b, a.W + b);
        }
        
        public static Vector4i operator -(Vector4ub a, Vector4i b)
        {
            return new Vector4i(a.X - b.X, a.Y - b.Y, a.Z - b.Z, a.W - b.W);
        }
        
        public static Vector4i operator -(Vector4ub a, int b)
        {
            return new Vector4i(a.X - b, a.Y - b, a.Z - b, a.W - b);
        }
        
        public static Vector4i operator *(Vector4ub a, Vector4i b)
        {
            return new Vector4i(a.X * b.X, a.Y * b.Y, a.Z * b.Z, a.W * b.W);
        }
        
        public static Vector4i operator *(Vector4ub a, int b)
        {
            return new Vector4i(a.X * b, a.Y * b, a.Z * b, a.W * b);
        }
        
        public static Vector4i operator /(Vector4ub a, Vector4i b)
        {
            return new Vector4i(a.X / b.X, a.Y / b.Y, a.Z / b.Z, a.W / b.W);
        }
        
        public static Vector4i operator /(Vector4ub a, int b)
        {
            return new Vector4i(a.X / b, a.Y / b, a.Z / b, a.W / b);
        }
        
        public static int Dot(Vector4ub a, Vector4ub b)
        {
            return a.X * b.X + a.Y * b.Y + a.Z * b.Z + a.W * b.W;
        }
        
        public int SquaredLength
        {
            get { return X * X + Y * Y + Z * Z + W * W; }
        }
        
        public float Length
        {
            get { return (float)System.Math.Sqrt(X * X + Y * Y + Z * Z + W * W); }
        }
        
        public Vector4 Normalize()
        {
            var l = Length;
            return new Vector4(X / l, Y / l, Z / l, W / l);
        }
        
        public static readonly Vector4ub Zero = new Vector4ub(0, 0, 0, 0);
        public static readonly Vector4ub One = new Vector4ub(1, 1, 1, 1);
        public static readonly Vector4ub UnitX = new Vector4ub(1, 0, 0, 0);
        public static readonly Vector4ub UnitY = new Vector4ub(0, 1, 0, 0);
        public static readonly Vector4ub UnitZ = new Vector4ub(0, 0, 1, 0);
        public static readonly Vector4ub UnitW = new Vector4ub(0, 0, 0, 1);
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Vector2s : System.IEquatable<Vector2s>
    {
        public readonly short X;
        public readonly short Y;
        
        public Vector2s(short x, short y)
        {
            X = x;
            Y = y;
        }
        
        public static explicit operator Vector2b(Vector2s v)
        {
            return new Vector2b((sbyte)v.X, (sbyte)v.Y);
        }
        
        public static explicit operator Vector2ub(Vector2s v)
        {
            return new Vector2ub((byte)v.X, (byte)v.Y);
        }
        
        public static explicit operator Vector2us(Vector2s v)
        {
            return new Vector2us((ushort)v.X, (ushort)v.Y);
        }
        
        public static implicit operator Vector2i(Vector2s v)
        {
            return new Vector2i(v.X, v.Y);
        }
        
        public static explicit operator Vector2ui(Vector2s v)
        {
            return new Vector2ui((uint)v.X, (uint)v.Y);
        }
        
        public static implicit operator Vector2(Vector2s v)
        {
            return new Vector2(v.X, v.Y);
        }
        
        public static implicit operator Vector2d(Vector2s v)
        {
            return new Vector2d(v.X, v.Y);
        }
        
        public override string ToString()
        {
            return string.Format("[{0}, {1}]", X, Y);
        }
        
        public static bool operator ==(Vector2s a, Vector2s b)
        {
            return a.X == b.X && a.Y == b.Y;
        }
        
        public static bool operator !=(Vector2s a, Vector2s b)
        {
            return a.X != b.X || a.Y != b.Y;
        }
        
        public bool Equals(Vector2s other)
        {
            return X == other.X && Y == other.Y;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Vector2s)) return false;
            var v = (Vector2s)other;
            return X == v.X && Y == v.Y;
        }
        
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode();
        }
        
        public static Vector2i operator +(Vector2s a, Vector2i b)
        {
            return new Vector2i(a.X + b.X, a.Y + b.Y);
        }
        
        public static Vector2i operator +(Vector2s a, int b)
        {
            return new Vector2i(a.X + b, a.Y + b);
        }
        
        public static Vector2i operator -(Vector2s a, Vector2i b)
        {
            return new Vector2i(a.X - b.X, a.Y - b.Y);
        }
        
        public static Vector2i operator -(Vector2s a, int b)
        {
            return new Vector2i(a.X - b, a.Y - b);
        }
        
        public static Vector2i operator *(Vector2s a, Vector2i b)
        {
            return new Vector2i(a.X * b.X, a.Y * b.Y);
        }
        
        public static Vector2i operator *(Vector2s a, int b)
        {
            return new Vector2i(a.X * b, a.Y * b);
        }
        
        public static Vector2i operator /(Vector2s a, Vector2i b)
        {
            return new Vector2i(a.X / b.X, a.Y / b.Y);
        }
        
        public static Vector2i operator /(Vector2s a, int b)
        {
            return new Vector2i(a.X / b, a.Y / b);
        }
        
        public static Vector2i operator -(Vector2s v)
        {
            return new Vector2i (-v.X, -v.Y);
        }
        
        public static int Dot(Vector2s a, Vector2s b)
        {
            return a.X * b.X + a.Y * b.Y;
        }
        
        public int SquaredLength
        {
            get { return X * X + Y * Y; }
        }
        
        public float Length
        {
            get { return (float)System.Math.Sqrt(X * X + Y * Y); }
        }
        
        public Vector2 Normalize()
        {
            var l = Length;
            return new Vector2(X / l, Y / l);
        }
        
        public static readonly Vector2s Zero = new Vector2s(0, 0);
        public static readonly Vector2s One = new Vector2s(1, 1);
        public static readonly Vector2s UnitX = new Vector2s(1, 0);
        public static readonly Vector2s UnitY = new Vector2s(0, 1);
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Vector3s : System.IEquatable<Vector3s>
    {
        public readonly short X;
        public readonly short Y;
        public readonly short Z;
        
        public Vector3s(short x, short y, short z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        
        public Vector3s(Vector2s v, short z)
        {
            X = v.X;
            Y = v.Y;
            Z = z;
        }
        
        public static explicit operator Vector3b(Vector3s v)
        {
            return new Vector3b((sbyte)v.X, (sbyte)v.Y, (sbyte)v.Z);
        }
        
        public static explicit operator Vector3ub(Vector3s v)
        {
            return new Vector3ub((byte)v.X, (byte)v.Y, (byte)v.Z);
        }
        
        public static explicit operator Vector3us(Vector3s v)
        {
            return new Vector3us((ushort)v.X, (ushort)v.Y, (ushort)v.Z);
        }
        
        public static implicit operator Vector3i(Vector3s v)
        {
            return new Vector3i(v.X, v.Y, v.Z);
        }
        
        public static explicit operator Vector3ui(Vector3s v)
        {
            return new Vector3ui((uint)v.X, (uint)v.Y, (uint)v.Z);
        }
        
        public static implicit operator Vector3(Vector3s v)
        {
            return new Vector3(v.X, v.Y, v.Z);
        }
        
        public static implicit operator Vector3d(Vector3s v)
        {
            return new Vector3d(v.X, v.Y, v.Z);
        }
        
        public override string ToString()
        {
            return string.Format("[{0}, {1}, {2}]", X, Y, Z);
        }
        
        public static bool operator ==(Vector3s a, Vector3s b)
        {
            return a.X == b.X && a.Y == b.Y && a.Z == b.Z;
        }
        
        public static bool operator !=(Vector3s a, Vector3s b)
        {
            return a.X != b.X || a.Y != b.Y || a.Z != b.Z;
        }
        
        public bool Equals(Vector3s other)
        {
            return X == other.X && Y == other.Y && Z == other.Z;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Vector3s)) return false;
            var v = (Vector3s)other;
            return X == v.X && Y == v.Y && Z == v.Z;
        }
        
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode();
        }
        
        public static Vector3i operator +(Vector3s a, Vector3i b)
        {
            return new Vector3i(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }
        
        public static Vector3i operator +(Vector3s a, int b)
        {
            return new Vector3i(a.X + b, a.Y + b, a.Z + b);
        }
        
        public static Vector3i operator -(Vector3s a, Vector3i b)
        {
            return new Vector3i(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }
        
        public static Vector3i operator -(Vector3s a, int b)
        {
            return new Vector3i(a.X - b, a.Y - b, a.Z - b);
        }
        
        public static Vector3i operator *(Vector3s a, Vector3i b)
        {
            return new Vector3i(a.X * b.X, a.Y * b.Y, a.Z * b.Z);
        }
        
        public static Vector3i operator *(Vector3s a, int b)
        {
            return new Vector3i(a.X * b, a.Y * b, a.Z * b);
        }
        
        public static Vector3i operator /(Vector3s a, Vector3i b)
        {
            return new Vector3i(a.X / b.X, a.Y / b.Y, a.Z / b.Z);
        }
        
        public static Vector3i operator /(Vector3s a, int b)
        {
            return new Vector3i(a.X / b, a.Y / b, a.Z / b);
        }
        
        public static Vector3i operator -(Vector3s v)
        {
            return new Vector3i (-v.X, -v.Y, -v.Z);
        }
        
        public static int Dot(Vector3s a, Vector3s b)
        {
            return a.X * b.X + a.Y * b.Y + a.Z * b.Z;
        }
        
        public static Vector3i Cross(Vector3s a, Vector3s b)
        {
            return new Vector3i(
                a.Y * b.Z - a.Z * b.Y,
                a.Z * b.X - a.X * b.Z,
                a.X * b.Y - a.Y * b.X
            );
        }
        
        public int SquaredLength
        {
            get { return X * X + Y * Y + Z * Z; }
        }
        
        public float Length
        {
            get { return (float)System.Math.Sqrt(X * X + Y * Y + Z * Z); }
        }
        
        public Vector3 Normalize()
        {
            var l = Length;
            return new Vector3(X / l, Y / l, Z / l);
        }
        
        public static readonly Vector3s Zero = new Vector3s(0, 0, 0);
        public static readonly Vector3s One = new Vector3s(1, 1, 1);
        public static readonly Vector3s UnitX = new Vector3s(1, 0, 0);
        public static readonly Vector3s UnitY = new Vector3s(0, 1, 0);
        public static readonly Vector3s UnitZ = new Vector3s(0, 0, 1);
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Vector4s : System.IEquatable<Vector4s>
    {
        public readonly short X;
        public readonly short Y;
        public readonly short Z;
        public readonly short W;
        
        public Vector4s(short x, short y, short z, short w)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }
        
        public Vector4s(Vector2s v, short z, short w)
        {
            X = v.X;
            Y = v.Y;
            Z = z;
            W = w;
        }
        
        public Vector4s(Vector3s v, short w)
        {
            X = v.X;
            Y = v.Y;
            Z = v.Z;
            W = w;
        }
        
        public static explicit operator Vector4b(Vector4s v)
        {
            return new Vector4b((sbyte)v.X, (sbyte)v.Y, (sbyte)v.Z, (sbyte)v.W);
        }
        
        public static explicit operator Vector4ub(Vector4s v)
        {
            return new Vector4ub((byte)v.X, (byte)v.Y, (byte)v.Z, (byte)v.W);
        }
        
        public static explicit operator Vector4us(Vector4s v)
        {
            return new Vector4us((ushort)v.X, (ushort)v.Y, (ushort)v.Z, (ushort)v.W);
        }
        
        public static implicit operator Vector4i(Vector4s v)
        {
            return new Vector4i(v.X, v.Y, v.Z, v.W);
        }
        
        public static explicit operator Vector4ui(Vector4s v)
        {
            return new Vector4ui((uint)v.X, (uint)v.Y, (uint)v.Z, (uint)v.W);
        }
        
        public static implicit operator Vector4(Vector4s v)
        {
            return new Vector4(v.X, v.Y, v.Z, v.W);
        }
        
        public static implicit operator Vector4d(Vector4s v)
        {
            return new Vector4d(v.X, v.Y, v.Z, v.W);
        }
        
        public override string ToString()
        {
            return string.Format("[{0}, {1}, {2}, {3}]", X, Y, Z, W);
        }
        
        public static bool operator ==(Vector4s a, Vector4s b)
        {
            return a.X == b.X && a.Y == b.Y && a.Z == b.Z && a.W == b.W;
        }
        
        public static bool operator !=(Vector4s a, Vector4s b)
        {
            return a.X != b.X || a.Y != b.Y || a.Z != b.Z || a.W != b.W;
        }
        
        public bool Equals(Vector4s other)
        {
            return X == other.X && Y == other.Y && Z == other.Z && W == other.W;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Vector4s)) return false;
            var v = (Vector4s)other;
            return X == v.X && Y == v.Y && Z == v.Z && W == v.W;
        }
        
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode() ^ W.GetHashCode();
        }
        
        public static Vector4i operator +(Vector4s a, Vector4i b)
        {
            return new Vector4i(a.X + b.X, a.Y + b.Y, a.Z + b.Z, a.W + b.W);
        }
        
        public static Vector4i operator +(Vector4s a, int b)
        {
            return new Vector4i(a.X + b, a.Y + b, a.Z + b, a.W + b);
        }
        
        public static Vector4i operator -(Vector4s a, Vector4i b)
        {
            return new Vector4i(a.X - b.X, a.Y - b.Y, a.Z - b.Z, a.W - b.W);
        }
        
        public static Vector4i operator -(Vector4s a, int b)
        {
            return new Vector4i(a.X - b, a.Y - b, a.Z - b, a.W - b);
        }
        
        public static Vector4i operator *(Vector4s a, Vector4i b)
        {
            return new Vector4i(a.X * b.X, a.Y * b.Y, a.Z * b.Z, a.W * b.W);
        }
        
        public static Vector4i operator *(Vector4s a, int b)
        {
            return new Vector4i(a.X * b, a.Y * b, a.Z * b, a.W * b);
        }
        
        public static Vector4i operator /(Vector4s a, Vector4i b)
        {
            return new Vector4i(a.X / b.X, a.Y / b.Y, a.Z / b.Z, a.W / b.W);
        }
        
        public static Vector4i operator /(Vector4s a, int b)
        {
            return new Vector4i(a.X / b, a.Y / b, a.Z / b, a.W / b);
        }
        
        public static Vector4i operator -(Vector4s v)
        {
            return new Vector4i (-v.X, -v.Y, -v.Z, -v.W);
        }
        
        public static int Dot(Vector4s a, Vector4s b)
        {
            return a.X * b.X + a.Y * b.Y + a.Z * b.Z + a.W * b.W;
        }
        
        public int SquaredLength
        {
            get { return X * X + Y * Y + Z * Z + W * W; }
        }
        
        public float Length
        {
            get { return (float)System.Math.Sqrt(X * X + Y * Y + Z * Z + W * W); }
        }
        
        public Vector4 Normalize()
        {
            var l = Length;
            return new Vector4(X / l, Y / l, Z / l, W / l);
        }
        
        public static readonly Vector4s Zero = new Vector4s(0, 0, 0, 0);
        public static readonly Vector4s One = new Vector4s(1, 1, 1, 1);
        public static readonly Vector4s UnitX = new Vector4s(1, 0, 0, 0);
        public static readonly Vector4s UnitY = new Vector4s(0, 1, 0, 0);
        public static readonly Vector4s UnitZ = new Vector4s(0, 0, 1, 0);
        public static readonly Vector4s UnitW = new Vector4s(0, 0, 0, 1);
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Vector2us : System.IEquatable<Vector2us>
    {
        public readonly ushort X;
        public readonly ushort Y;
        
        public Vector2us(ushort x, ushort y)
        {
            X = x;
            Y = y;
        }
        
        public static explicit operator Vector2b(Vector2us v)
        {
            return new Vector2b((sbyte)v.X, (sbyte)v.Y);
        }
        
        public static explicit operator Vector2ub(Vector2us v)
        {
            return new Vector2ub((byte)v.X, (byte)v.Y);
        }
        
        public static explicit operator Vector2s(Vector2us v)
        {
            return new Vector2s((short)v.X, (short)v.Y);
        }
        
        public static implicit operator Vector2i(Vector2us v)
        {
            return new Vector2i(v.X, v.Y);
        }
        
        public static implicit operator Vector2ui(Vector2us v)
        {
            return new Vector2ui(v.X, v.Y);
        }
        
        public static implicit operator Vector2(Vector2us v)
        {
            return new Vector2(v.X, v.Y);
        }
        
        public static implicit operator Vector2d(Vector2us v)
        {
            return new Vector2d(v.X, v.Y);
        }
        
        public override string ToString()
        {
            return string.Format("[{0}, {1}]", X, Y);
        }
        
        public static bool operator ==(Vector2us a, Vector2us b)
        {
            return a.X == b.X && a.Y == b.Y;
        }
        
        public static bool operator !=(Vector2us a, Vector2us b)
        {
            return a.X != b.X || a.Y != b.Y;
        }
        
        public bool Equals(Vector2us other)
        {
            return X == other.X && Y == other.Y;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Vector2us)) return false;
            var v = (Vector2us)other;
            return X == v.X && Y == v.Y;
        }
        
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode();
        }
        
        public static Vector2i operator +(Vector2us a, Vector2i b)
        {
            return new Vector2i(a.X + b.X, a.Y + b.Y);
        }
        
        public static Vector2i operator +(Vector2us a, int b)
        {
            return new Vector2i(a.X + b, a.Y + b);
        }
        
        public static Vector2i operator -(Vector2us a, Vector2i b)
        {
            return new Vector2i(a.X - b.X, a.Y - b.Y);
        }
        
        public static Vector2i operator -(Vector2us a, int b)
        {
            return new Vector2i(a.X - b, a.Y - b);
        }
        
        public static Vector2i operator *(Vector2us a, Vector2i b)
        {
            return new Vector2i(a.X * b.X, a.Y * b.Y);
        }
        
        public static Vector2i operator *(Vector2us a, int b)
        {
            return new Vector2i(a.X * b, a.Y * b);
        }
        
        public static Vector2i operator /(Vector2us a, Vector2i b)
        {
            return new Vector2i(a.X / b.X, a.Y / b.Y);
        }
        
        public static Vector2i operator /(Vector2us a, int b)
        {
            return new Vector2i(a.X / b, a.Y / b);
        }
        
        public static int Dot(Vector2us a, Vector2us b)
        {
            return a.X * b.X + a.Y * b.Y;
        }
        
        public int SquaredLength
        {
            get { return X * X + Y * Y; }
        }
        
        public float Length
        {
            get { return (float)System.Math.Sqrt(X * X + Y * Y); }
        }
        
        public Vector2 Normalize()
        {
            var l = Length;
            return new Vector2(X / l, Y / l);
        }
        
        public static readonly Vector2us Zero = new Vector2us(0, 0);
        public static readonly Vector2us One = new Vector2us(1, 1);
        public static readonly Vector2us UnitX = new Vector2us(1, 0);
        public static readonly Vector2us UnitY = new Vector2us(0, 1);
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Vector3us : System.IEquatable<Vector3us>
    {
        public readonly ushort X;
        public readonly ushort Y;
        public readonly ushort Z;
        
        public Vector3us(ushort x, ushort y, ushort z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        
        public Vector3us(Vector2us v, ushort z)
        {
            X = v.X;
            Y = v.Y;
            Z = z;
        }
        
        public static explicit operator Vector3b(Vector3us v)
        {
            return new Vector3b((sbyte)v.X, (sbyte)v.Y, (sbyte)v.Z);
        }
        
        public static explicit operator Vector3ub(Vector3us v)
        {
            return new Vector3ub((byte)v.X, (byte)v.Y, (byte)v.Z);
        }
        
        public static explicit operator Vector3s(Vector3us v)
        {
            return new Vector3s((short)v.X, (short)v.Y, (short)v.Z);
        }
        
        public static implicit operator Vector3i(Vector3us v)
        {
            return new Vector3i(v.X, v.Y, v.Z);
        }
        
        public static implicit operator Vector3ui(Vector3us v)
        {
            return new Vector3ui(v.X, v.Y, v.Z);
        }
        
        public static implicit operator Vector3(Vector3us v)
        {
            return new Vector3(v.X, v.Y, v.Z);
        }
        
        public static implicit operator Vector3d(Vector3us v)
        {
            return new Vector3d(v.X, v.Y, v.Z);
        }
        
        public override string ToString()
        {
            return string.Format("[{0}, {1}, {2}]", X, Y, Z);
        }
        
        public static bool operator ==(Vector3us a, Vector3us b)
        {
            return a.X == b.X && a.Y == b.Y && a.Z == b.Z;
        }
        
        public static bool operator !=(Vector3us a, Vector3us b)
        {
            return a.X != b.X || a.Y != b.Y || a.Z != b.Z;
        }
        
        public bool Equals(Vector3us other)
        {
            return X == other.X && Y == other.Y && Z == other.Z;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Vector3us)) return false;
            var v = (Vector3us)other;
            return X == v.X && Y == v.Y && Z == v.Z;
        }
        
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode();
        }
        
        public static Vector3i operator +(Vector3us a, Vector3i b)
        {
            return new Vector3i(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }
        
        public static Vector3i operator +(Vector3us a, int b)
        {
            return new Vector3i(a.X + b, a.Y + b, a.Z + b);
        }
        
        public static Vector3i operator -(Vector3us a, Vector3i b)
        {
            return new Vector3i(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }
        
        public static Vector3i operator -(Vector3us a, int b)
        {
            return new Vector3i(a.X - b, a.Y - b, a.Z - b);
        }
        
        public static Vector3i operator *(Vector3us a, Vector3i b)
        {
            return new Vector3i(a.X * b.X, a.Y * b.Y, a.Z * b.Z);
        }
        
        public static Vector3i operator *(Vector3us a, int b)
        {
            return new Vector3i(a.X * b, a.Y * b, a.Z * b);
        }
        
        public static Vector3i operator /(Vector3us a, Vector3i b)
        {
            return new Vector3i(a.X / b.X, a.Y / b.Y, a.Z / b.Z);
        }
        
        public static Vector3i operator /(Vector3us a, int b)
        {
            return new Vector3i(a.X / b, a.Y / b, a.Z / b);
        }
        
        public static int Dot(Vector3us a, Vector3us b)
        {
            return a.X * b.X + a.Y * b.Y + a.Z * b.Z;
        }
        
        public static Vector3i Cross(Vector3us a, Vector3us b)
        {
            return new Vector3i(
                a.Y * b.Z - a.Z * b.Y,
                a.Z * b.X - a.X * b.Z,
                a.X * b.Y - a.Y * b.X
            );
        }
        
        public int SquaredLength
        {
            get { return X * X + Y * Y + Z * Z; }
        }
        
        public float Length
        {
            get { return (float)System.Math.Sqrt(X * X + Y * Y + Z * Z); }
        }
        
        public Vector3 Normalize()
        {
            var l = Length;
            return new Vector3(X / l, Y / l, Z / l);
        }
        
        public static readonly Vector3us Zero = new Vector3us(0, 0, 0);
        public static readonly Vector3us One = new Vector3us(1, 1, 1);
        public static readonly Vector3us UnitX = new Vector3us(1, 0, 0);
        public static readonly Vector3us UnitY = new Vector3us(0, 1, 0);
        public static readonly Vector3us UnitZ = new Vector3us(0, 0, 1);
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Vector4us : System.IEquatable<Vector4us>
    {
        public readonly ushort X;
        public readonly ushort Y;
        public readonly ushort Z;
        public readonly ushort W;
        
        public Vector4us(ushort x, ushort y, ushort z, ushort w)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }
        
        public Vector4us(Vector2us v, ushort z, ushort w)
        {
            X = v.X;
            Y = v.Y;
            Z = z;
            W = w;
        }
        
        public Vector4us(Vector3us v, ushort w)
        {
            X = v.X;
            Y = v.Y;
            Z = v.Z;
            W = w;
        }
        
        public static explicit operator Vector4b(Vector4us v)
        {
            return new Vector4b((sbyte)v.X, (sbyte)v.Y, (sbyte)v.Z, (sbyte)v.W);
        }
        
        public static explicit operator Vector4ub(Vector4us v)
        {
            return new Vector4ub((byte)v.X, (byte)v.Y, (byte)v.Z, (byte)v.W);
        }
        
        public static explicit operator Vector4s(Vector4us v)
        {
            return new Vector4s((short)v.X, (short)v.Y, (short)v.Z, (short)v.W);
        }
        
        public static implicit operator Vector4i(Vector4us v)
        {
            return new Vector4i(v.X, v.Y, v.Z, v.W);
        }
        
        public static implicit operator Vector4ui(Vector4us v)
        {
            return new Vector4ui(v.X, v.Y, v.Z, v.W);
        }
        
        public static implicit operator Vector4(Vector4us v)
        {
            return new Vector4(v.X, v.Y, v.Z, v.W);
        }
        
        public static implicit operator Vector4d(Vector4us v)
        {
            return new Vector4d(v.X, v.Y, v.Z, v.W);
        }
        
        public override string ToString()
        {
            return string.Format("[{0}, {1}, {2}, {3}]", X, Y, Z, W);
        }
        
        public static bool operator ==(Vector4us a, Vector4us b)
        {
            return a.X == b.X && a.Y == b.Y && a.Z == b.Z && a.W == b.W;
        }
        
        public static bool operator !=(Vector4us a, Vector4us b)
        {
            return a.X != b.X || a.Y != b.Y || a.Z != b.Z || a.W != b.W;
        }
        
        public bool Equals(Vector4us other)
        {
            return X == other.X && Y == other.Y && Z == other.Z && W == other.W;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Vector4us)) return false;
            var v = (Vector4us)other;
            return X == v.X && Y == v.Y && Z == v.Z && W == v.W;
        }
        
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode() ^ W.GetHashCode();
        }
        
        public static Vector4i operator +(Vector4us a, Vector4i b)
        {
            return new Vector4i(a.X + b.X, a.Y + b.Y, a.Z + b.Z, a.W + b.W);
        }
        
        public static Vector4i operator +(Vector4us a, int b)
        {
            return new Vector4i(a.X + b, a.Y + b, a.Z + b, a.W + b);
        }
        
        public static Vector4i operator -(Vector4us a, Vector4i b)
        {
            return new Vector4i(a.X - b.X, a.Y - b.Y, a.Z - b.Z, a.W - b.W);
        }
        
        public static Vector4i operator -(Vector4us a, int b)
        {
            return new Vector4i(a.X - b, a.Y - b, a.Z - b, a.W - b);
        }
        
        public static Vector4i operator *(Vector4us a, Vector4i b)
        {
            return new Vector4i(a.X * b.X, a.Y * b.Y, a.Z * b.Z, a.W * b.W);
        }
        
        public static Vector4i operator *(Vector4us a, int b)
        {
            return new Vector4i(a.X * b, a.Y * b, a.Z * b, a.W * b);
        }
        
        public static Vector4i operator /(Vector4us a, Vector4i b)
        {
            return new Vector4i(a.X / b.X, a.Y / b.Y, a.Z / b.Z, a.W / b.W);
        }
        
        public static Vector4i operator /(Vector4us a, int b)
        {
            return new Vector4i(a.X / b, a.Y / b, a.Z / b, a.W / b);
        }
        
        public static int Dot(Vector4us a, Vector4us b)
        {
            return a.X * b.X + a.Y * b.Y + a.Z * b.Z + a.W * b.W;
        }
        
        public int SquaredLength
        {
            get { return X * X + Y * Y + Z * Z + W * W; }
        }
        
        public float Length
        {
            get { return (float)System.Math.Sqrt(X * X + Y * Y + Z * Z + W * W); }
        }
        
        public Vector4 Normalize()
        {
            var l = Length;
            return new Vector4(X / l, Y / l, Z / l, W / l);
        }
        
        public static readonly Vector4us Zero = new Vector4us(0, 0, 0, 0);
        public static readonly Vector4us One = new Vector4us(1, 1, 1, 1);
        public static readonly Vector4us UnitX = new Vector4us(1, 0, 0, 0);
        public static readonly Vector4us UnitY = new Vector4us(0, 1, 0, 0);
        public static readonly Vector4us UnitZ = new Vector4us(0, 0, 1, 0);
        public static readonly Vector4us UnitW = new Vector4us(0, 0, 0, 1);
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Vector2i : System.IEquatable<Vector2i>
    {
        public readonly int X;
        public readonly int Y;
        
        public Vector2i(int x, int y)
        {
            X = x;
            Y = y;
        }
        
        public static explicit operator Vector2b(Vector2i v)
        {
            return new Vector2b((sbyte)v.X, (sbyte)v.Y);
        }
        
        public static explicit operator Vector2ub(Vector2i v)
        {
            return new Vector2ub((byte)v.X, (byte)v.Y);
        }
        
        public static explicit operator Vector2s(Vector2i v)
        {
            return new Vector2s((short)v.X, (short)v.Y);
        }
        
        public static explicit operator Vector2us(Vector2i v)
        {
            return new Vector2us((ushort)v.X, (ushort)v.Y);
        }
        
        public static explicit operator Vector2ui(Vector2i v)
        {
            return new Vector2ui((uint)v.X, (uint)v.Y);
        }
        
        public static implicit operator Vector2(Vector2i v)
        {
            return new Vector2(v.X, v.Y);
        }
        
        public static implicit operator Vector2d(Vector2i v)
        {
            return new Vector2d(v.X, v.Y);
        }
        
        public override string ToString()
        {
            return string.Format("[{0}, {1}]", X, Y);
        }
        
        public static bool operator ==(Vector2i a, Vector2i b)
        {
            return a.X == b.X && a.Y == b.Y;
        }
        
        public static bool operator !=(Vector2i a, Vector2i b)
        {
            return a.X != b.X || a.Y != b.Y;
        }
        
        public bool Equals(Vector2i other)
        {
            return X == other.X && Y == other.Y;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Vector2i)) return false;
            var v = (Vector2i)other;
            return X == v.X && Y == v.Y;
        }
        
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode();
        }
        
        public static Vector2i operator +(Vector2i a, Vector2i b)
        {
            return new Vector2i(a.X + b.X, a.Y + b.Y);
        }
        
        public static Vector2i operator +(Vector2i a, int b)
        {
            return new Vector2i(a.X + b, a.Y + b);
        }
        
        public static Vector2i operator -(Vector2i a, Vector2i b)
        {
            return new Vector2i(a.X - b.X, a.Y - b.Y);
        }
        
        public static Vector2i operator -(Vector2i a, int b)
        {
            return new Vector2i(a.X - b, a.Y - b);
        }
        
        public static Vector2i operator *(Vector2i a, Vector2i b)
        {
            return new Vector2i(a.X * b.X, a.Y * b.Y);
        }
        
        public static Vector2i operator *(Vector2i a, int b)
        {
            return new Vector2i(a.X * b, a.Y * b);
        }
        
        public static Vector2i operator /(Vector2i a, Vector2i b)
        {
            return new Vector2i(a.X / b.X, a.Y / b.Y);
        }
        
        public static Vector2i operator /(Vector2i a, int b)
        {
            return new Vector2i(a.X / b, a.Y / b);
        }
        
        public static Vector2i operator -(Vector2i v)
        {
            return new Vector2i (-v.X, -v.Y);
        }
        
        public static int Dot(Vector2i a, Vector2i b)
        {
            return a.X * b.X + a.Y * b.Y;
        }
        
        public int SquaredLength
        {
            get { return X * X + Y * Y; }
        }
        
        public float Length
        {
            get { return (float)System.Math.Sqrt(X * X + Y * Y); }
        }
        
        public Vector2 Normalize()
        {
            var l = Length;
            return new Vector2(X / l, Y / l);
        }
        
        public static readonly Vector2i Zero = new Vector2i(0, 0);
        public static readonly Vector2i One = new Vector2i(1, 1);
        public static readonly Vector2i UnitX = new Vector2i(1, 0);
        public static readonly Vector2i UnitY = new Vector2i(0, 1);
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Vector3i : System.IEquatable<Vector3i>
    {
        public readonly int X;
        public readonly int Y;
        public readonly int Z;
        
        public Vector3i(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        
        public Vector3i(Vector2i v, int z)
        {
            X = v.X;
            Y = v.Y;
            Z = z;
        }
        
        public static explicit operator Vector3b(Vector3i v)
        {
            return new Vector3b((sbyte)v.X, (sbyte)v.Y, (sbyte)v.Z);
        }
        
        public static explicit operator Vector3ub(Vector3i v)
        {
            return new Vector3ub((byte)v.X, (byte)v.Y, (byte)v.Z);
        }
        
        public static explicit operator Vector3s(Vector3i v)
        {
            return new Vector3s((short)v.X, (short)v.Y, (short)v.Z);
        }
        
        public static explicit operator Vector3us(Vector3i v)
        {
            return new Vector3us((ushort)v.X, (ushort)v.Y, (ushort)v.Z);
        }
        
        public static explicit operator Vector3ui(Vector3i v)
        {
            return new Vector3ui((uint)v.X, (uint)v.Y, (uint)v.Z);
        }
        
        public static implicit operator Vector3(Vector3i v)
        {
            return new Vector3(v.X, v.Y, v.Z);
        }
        
        public static implicit operator Vector3d(Vector3i v)
        {
            return new Vector3d(v.X, v.Y, v.Z);
        }
        
        public override string ToString()
        {
            return string.Format("[{0}, {1}, {2}]", X, Y, Z);
        }
        
        public static bool operator ==(Vector3i a, Vector3i b)
        {
            return a.X == b.X && a.Y == b.Y && a.Z == b.Z;
        }
        
        public static bool operator !=(Vector3i a, Vector3i b)
        {
            return a.X != b.X || a.Y != b.Y || a.Z != b.Z;
        }
        
        public bool Equals(Vector3i other)
        {
            return X == other.X && Y == other.Y && Z == other.Z;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Vector3i)) return false;
            var v = (Vector3i)other;
            return X == v.X && Y == v.Y && Z == v.Z;
        }
        
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode();
        }
        
        public static Vector3i operator +(Vector3i a, Vector3i b)
        {
            return new Vector3i(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }
        
        public static Vector3i operator +(Vector3i a, int b)
        {
            return new Vector3i(a.X + b, a.Y + b, a.Z + b);
        }
        
        public static Vector3i operator -(Vector3i a, Vector3i b)
        {
            return new Vector3i(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }
        
        public static Vector3i operator -(Vector3i a, int b)
        {
            return new Vector3i(a.X - b, a.Y - b, a.Z - b);
        }
        
        public static Vector3i operator *(Vector3i a, Vector3i b)
        {
            return new Vector3i(a.X * b.X, a.Y * b.Y, a.Z * b.Z);
        }
        
        public static Vector3i operator *(Vector3i a, int b)
        {
            return new Vector3i(a.X * b, a.Y * b, a.Z * b);
        }
        
        public static Vector3i operator /(Vector3i a, Vector3i b)
        {
            return new Vector3i(a.X / b.X, a.Y / b.Y, a.Z / b.Z);
        }
        
        public static Vector3i operator /(Vector3i a, int b)
        {
            return new Vector3i(a.X / b, a.Y / b, a.Z / b);
        }
        
        public static Vector3i operator -(Vector3i v)
        {
            return new Vector3i (-v.X, -v.Y, -v.Z);
        }
        
        public static int Dot(Vector3i a, Vector3i b)
        {
            return a.X * b.X + a.Y * b.Y + a.Z * b.Z;
        }
        
        public static Vector3i Cross(Vector3i a, Vector3i b)
        {
            return new Vector3i(
                a.Y * b.Z - a.Z * b.Y,
                a.Z * b.X - a.X * b.Z,
                a.X * b.Y - a.Y * b.X
            );
        }
        
        public int SquaredLength
        {
            get { return X * X + Y * Y + Z * Z; }
        }
        
        public float Length
        {
            get { return (float)System.Math.Sqrt(X * X + Y * Y + Z * Z); }
        }
        
        public Vector3 Normalize()
        {
            var l = Length;
            return new Vector3(X / l, Y / l, Z / l);
        }
        
        public static readonly Vector3i Zero = new Vector3i(0, 0, 0);
        public static readonly Vector3i One = new Vector3i(1, 1, 1);
        public static readonly Vector3i UnitX = new Vector3i(1, 0, 0);
        public static readonly Vector3i UnitY = new Vector3i(0, 1, 0);
        public static readonly Vector3i UnitZ = new Vector3i(0, 0, 1);
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Vector4i : System.IEquatable<Vector4i>
    {
        public readonly int X;
        public readonly int Y;
        public readonly int Z;
        public readonly int W;
        
        public Vector4i(int x, int y, int z, int w)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }
        
        public Vector4i(Vector2i v, int z, int w)
        {
            X = v.X;
            Y = v.Y;
            Z = z;
            W = w;
        }
        
        public Vector4i(Vector3i v, int w)
        {
            X = v.X;
            Y = v.Y;
            Z = v.Z;
            W = w;
        }
        
        public static explicit operator Vector4b(Vector4i v)
        {
            return new Vector4b((sbyte)v.X, (sbyte)v.Y, (sbyte)v.Z, (sbyte)v.W);
        }
        
        public static explicit operator Vector4ub(Vector4i v)
        {
            return new Vector4ub((byte)v.X, (byte)v.Y, (byte)v.Z, (byte)v.W);
        }
        
        public static explicit operator Vector4s(Vector4i v)
        {
            return new Vector4s((short)v.X, (short)v.Y, (short)v.Z, (short)v.W);
        }
        
        public static explicit operator Vector4us(Vector4i v)
        {
            return new Vector4us((ushort)v.X, (ushort)v.Y, (ushort)v.Z, (ushort)v.W);
        }
        
        public static explicit operator Vector4ui(Vector4i v)
        {
            return new Vector4ui((uint)v.X, (uint)v.Y, (uint)v.Z, (uint)v.W);
        }
        
        public static implicit operator Vector4(Vector4i v)
        {
            return new Vector4(v.X, v.Y, v.Z, v.W);
        }
        
        public static implicit operator Vector4d(Vector4i v)
        {
            return new Vector4d(v.X, v.Y, v.Z, v.W);
        }
        
        public override string ToString()
        {
            return string.Format("[{0}, {1}, {2}, {3}]", X, Y, Z, W);
        }
        
        public static bool operator ==(Vector4i a, Vector4i b)
        {
            return a.X == b.X && a.Y == b.Y && a.Z == b.Z && a.W == b.W;
        }
        
        public static bool operator !=(Vector4i a, Vector4i b)
        {
            return a.X != b.X || a.Y != b.Y || a.Z != b.Z || a.W != b.W;
        }
        
        public bool Equals(Vector4i other)
        {
            return X == other.X && Y == other.Y && Z == other.Z && W == other.W;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Vector4i)) return false;
            var v = (Vector4i)other;
            return X == v.X && Y == v.Y && Z == v.Z && W == v.W;
        }
        
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode() ^ W.GetHashCode();
        }
        
        public static Vector4i operator +(Vector4i a, Vector4i b)
        {
            return new Vector4i(a.X + b.X, a.Y + b.Y, a.Z + b.Z, a.W + b.W);
        }
        
        public static Vector4i operator +(Vector4i a, int b)
        {
            return new Vector4i(a.X + b, a.Y + b, a.Z + b, a.W + b);
        }
        
        public static Vector4i operator -(Vector4i a, Vector4i b)
        {
            return new Vector4i(a.X - b.X, a.Y - b.Y, a.Z - b.Z, a.W - b.W);
        }
        
        public static Vector4i operator -(Vector4i a, int b)
        {
            return new Vector4i(a.X - b, a.Y - b, a.Z - b, a.W - b);
        }
        
        public static Vector4i operator *(Vector4i a, Vector4i b)
        {
            return new Vector4i(a.X * b.X, a.Y * b.Y, a.Z * b.Z, a.W * b.W);
        }
        
        public static Vector4i operator *(Vector4i a, int b)
        {
            return new Vector4i(a.X * b, a.Y * b, a.Z * b, a.W * b);
        }
        
        public static Vector4i operator /(Vector4i a, Vector4i b)
        {
            return new Vector4i(a.X / b.X, a.Y / b.Y, a.Z / b.Z, a.W / b.W);
        }
        
        public static Vector4i operator /(Vector4i a, int b)
        {
            return new Vector4i(a.X / b, a.Y / b, a.Z / b, a.W / b);
        }
        
        public static Vector4i operator -(Vector4i v)
        {
            return new Vector4i (-v.X, -v.Y, -v.Z, -v.W);
        }
        
        public static int Dot(Vector4i a, Vector4i b)
        {
            return a.X * b.X + a.Y * b.Y + a.Z * b.Z + a.W * b.W;
        }
        
        public int SquaredLength
        {
            get { return X * X + Y * Y + Z * Z + W * W; }
        }
        
        public float Length
        {
            get { return (float)System.Math.Sqrt(X * X + Y * Y + Z * Z + W * W); }
        }
        
        public Vector4 Normalize()
        {
            var l = Length;
            return new Vector4(X / l, Y / l, Z / l, W / l);
        }
        
        public static readonly Vector4i Zero = new Vector4i(0, 0, 0, 0);
        public static readonly Vector4i One = new Vector4i(1, 1, 1, 1);
        public static readonly Vector4i UnitX = new Vector4i(1, 0, 0, 0);
        public static readonly Vector4i UnitY = new Vector4i(0, 1, 0, 0);
        public static readonly Vector4i UnitZ = new Vector4i(0, 0, 1, 0);
        public static readonly Vector4i UnitW = new Vector4i(0, 0, 0, 1);
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Vector2ui : System.IEquatable<Vector2ui>
    {
        public readonly uint X;
        public readonly uint Y;
        
        public Vector2ui(uint x, uint y)
        {
            X = x;
            Y = y;
        }
        
        public static explicit operator Vector2b(Vector2ui v)
        {
            return new Vector2b((sbyte)v.X, (sbyte)v.Y);
        }
        
        public static explicit operator Vector2ub(Vector2ui v)
        {
            return new Vector2ub((byte)v.X, (byte)v.Y);
        }
        
        public static explicit operator Vector2s(Vector2ui v)
        {
            return new Vector2s((short)v.X, (short)v.Y);
        }
        
        public static explicit operator Vector2us(Vector2ui v)
        {
            return new Vector2us((ushort)v.X, (ushort)v.Y);
        }
        
        public static explicit operator Vector2i(Vector2ui v)
        {
            return new Vector2i((int)v.X, (int)v.Y);
        }
        
        public static implicit operator Vector2(Vector2ui v)
        {
            return new Vector2(v.X, v.Y);
        }
        
        public static implicit operator Vector2d(Vector2ui v)
        {
            return new Vector2d(v.X, v.Y);
        }
        
        public override string ToString()
        {
            return string.Format("[{0}, {1}]", X, Y);
        }
        
        public static bool operator ==(Vector2ui a, Vector2ui b)
        {
            return a.X == b.X && a.Y == b.Y;
        }
        
        public static bool operator !=(Vector2ui a, Vector2ui b)
        {
            return a.X != b.X || a.Y != b.Y;
        }
        
        public bool Equals(Vector2ui other)
        {
            return X == other.X && Y == other.Y;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Vector2ui)) return false;
            var v = (Vector2ui)other;
            return X == v.X && Y == v.Y;
        }
        
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode();
        }
        
        public static Vector2ui operator +(Vector2ui a, Vector2ui b)
        {
            return new Vector2ui(a.X + b.X, a.Y + b.Y);
        }
        
        public static Vector2ui operator +(Vector2ui a, uint b)
        {
            return new Vector2ui(a.X + b, a.Y + b);
        }
        
        public static Vector2ui operator -(Vector2ui a, Vector2ui b)
        {
            return new Vector2ui(a.X - b.X, a.Y - b.Y);
        }
        
        public static Vector2ui operator -(Vector2ui a, uint b)
        {
            return new Vector2ui(a.X - b, a.Y - b);
        }
        
        public static Vector2ui operator *(Vector2ui a, Vector2ui b)
        {
            return new Vector2ui(a.X * b.X, a.Y * b.Y);
        }
        
        public static Vector2ui operator *(Vector2ui a, uint b)
        {
            return new Vector2ui(a.X * b, a.Y * b);
        }
        
        public static Vector2ui operator /(Vector2ui a, Vector2ui b)
        {
            return new Vector2ui(a.X / b.X, a.Y / b.Y);
        }
        
        public static Vector2ui operator /(Vector2ui a, uint b)
        {
            return new Vector2ui(a.X / b, a.Y / b);
        }
        
        public static uint Dot(Vector2ui a, Vector2ui b)
        {
            return a.X * b.X + a.Y * b.Y;
        }
        
        public uint SquaredLength
        {
            get { return X * X + Y * Y; }
        }
        
        public float Length
        {
            get { return (float)System.Math.Sqrt(X * X + Y * Y); }
        }
        
        public Vector2 Normalize()
        {
            var l = Length;
            return new Vector2(X / l, Y / l);
        }
        
        public static readonly Vector2ui Zero = new Vector2ui(0u, 0u);
        public static readonly Vector2ui One = new Vector2ui(1u, 1u);
        public static readonly Vector2ui UnitX = new Vector2ui(1u, 0u);
        public static readonly Vector2ui UnitY = new Vector2ui(0u, 1u);
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Vector3ui : System.IEquatable<Vector3ui>
    {
        public readonly uint X;
        public readonly uint Y;
        public readonly uint Z;
        
        public Vector3ui(uint x, uint y, uint z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        
        public Vector3ui(Vector2ui v, uint z)
        {
            X = v.X;
            Y = v.Y;
            Z = z;
        }
        
        public static explicit operator Vector3b(Vector3ui v)
        {
            return new Vector3b((sbyte)v.X, (sbyte)v.Y, (sbyte)v.Z);
        }
        
        public static explicit operator Vector3ub(Vector3ui v)
        {
            return new Vector3ub((byte)v.X, (byte)v.Y, (byte)v.Z);
        }
        
        public static explicit operator Vector3s(Vector3ui v)
        {
            return new Vector3s((short)v.X, (short)v.Y, (short)v.Z);
        }
        
        public static explicit operator Vector3us(Vector3ui v)
        {
            return new Vector3us((ushort)v.X, (ushort)v.Y, (ushort)v.Z);
        }
        
        public static explicit operator Vector3i(Vector3ui v)
        {
            return new Vector3i((int)v.X, (int)v.Y, (int)v.Z);
        }
        
        public static implicit operator Vector3(Vector3ui v)
        {
            return new Vector3(v.X, v.Y, v.Z);
        }
        
        public static implicit operator Vector3d(Vector3ui v)
        {
            return new Vector3d(v.X, v.Y, v.Z);
        }
        
        public override string ToString()
        {
            return string.Format("[{0}, {1}, {2}]", X, Y, Z);
        }
        
        public static bool operator ==(Vector3ui a, Vector3ui b)
        {
            return a.X == b.X && a.Y == b.Y && a.Z == b.Z;
        }
        
        public static bool operator !=(Vector3ui a, Vector3ui b)
        {
            return a.X != b.X || a.Y != b.Y || a.Z != b.Z;
        }
        
        public bool Equals(Vector3ui other)
        {
            return X == other.X && Y == other.Y && Z == other.Z;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Vector3ui)) return false;
            var v = (Vector3ui)other;
            return X == v.X && Y == v.Y && Z == v.Z;
        }
        
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode();
        }
        
        public static Vector3ui operator +(Vector3ui a, Vector3ui b)
        {
            return new Vector3ui(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }
        
        public static Vector3ui operator +(Vector3ui a, uint b)
        {
            return new Vector3ui(a.X + b, a.Y + b, a.Z + b);
        }
        
        public static Vector3ui operator -(Vector3ui a, Vector3ui b)
        {
            return new Vector3ui(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }
        
        public static Vector3ui operator -(Vector3ui a, uint b)
        {
            return new Vector3ui(a.X - b, a.Y - b, a.Z - b);
        }
        
        public static Vector3ui operator *(Vector3ui a, Vector3ui b)
        {
            return new Vector3ui(a.X * b.X, a.Y * b.Y, a.Z * b.Z);
        }
        
        public static Vector3ui operator *(Vector3ui a, uint b)
        {
            return new Vector3ui(a.X * b, a.Y * b, a.Z * b);
        }
        
        public static Vector3ui operator /(Vector3ui a, Vector3ui b)
        {
            return new Vector3ui(a.X / b.X, a.Y / b.Y, a.Z / b.Z);
        }
        
        public static Vector3ui operator /(Vector3ui a, uint b)
        {
            return new Vector3ui(a.X / b, a.Y / b, a.Z / b);
        }
        
        public static uint Dot(Vector3ui a, Vector3ui b)
        {
            return a.X * b.X + a.Y * b.Y + a.Z * b.Z;
        }
        
        public static Vector3ui Cross(Vector3ui a, Vector3ui b)
        {
            return new Vector3ui(
                a.Y * b.Z - a.Z * b.Y,
                a.Z * b.X - a.X * b.Z,
                a.X * b.Y - a.Y * b.X
            );
        }
        
        public uint SquaredLength
        {
            get { return X * X + Y * Y + Z * Z; }
        }
        
        public float Length
        {
            get { return (float)System.Math.Sqrt(X * X + Y * Y + Z * Z); }
        }
        
        public Vector3 Normalize()
        {
            var l = Length;
            return new Vector3(X / l, Y / l, Z / l);
        }
        
        public static readonly Vector3ui Zero = new Vector3ui(0u, 0u, 0u);
        public static readonly Vector3ui One = new Vector3ui(1u, 1u, 1u);
        public static readonly Vector3ui UnitX = new Vector3ui(1u, 0u, 0u);
        public static readonly Vector3ui UnitY = new Vector3ui(0u, 1u, 0u);
        public static readonly Vector3ui UnitZ = new Vector3ui(0u, 0u, 1u);
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Vector4ui : System.IEquatable<Vector4ui>
    {
        public readonly uint X;
        public readonly uint Y;
        public readonly uint Z;
        public readonly uint W;
        
        public Vector4ui(uint x, uint y, uint z, uint w)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }
        
        public Vector4ui(Vector2ui v, uint z, uint w)
        {
            X = v.X;
            Y = v.Y;
            Z = z;
            W = w;
        }
        
        public Vector4ui(Vector3ui v, uint w)
        {
            X = v.X;
            Y = v.Y;
            Z = v.Z;
            W = w;
        }
        
        public static explicit operator Vector4b(Vector4ui v)
        {
            return new Vector4b((sbyte)v.X, (sbyte)v.Y, (sbyte)v.Z, (sbyte)v.W);
        }
        
        public static explicit operator Vector4ub(Vector4ui v)
        {
            return new Vector4ub((byte)v.X, (byte)v.Y, (byte)v.Z, (byte)v.W);
        }
        
        public static explicit operator Vector4s(Vector4ui v)
        {
            return new Vector4s((short)v.X, (short)v.Y, (short)v.Z, (short)v.W);
        }
        
        public static explicit operator Vector4us(Vector4ui v)
        {
            return new Vector4us((ushort)v.X, (ushort)v.Y, (ushort)v.Z, (ushort)v.W);
        }
        
        public static explicit operator Vector4i(Vector4ui v)
        {
            return new Vector4i((int)v.X, (int)v.Y, (int)v.Z, (int)v.W);
        }
        
        public static implicit operator Vector4(Vector4ui v)
        {
            return new Vector4(v.X, v.Y, v.Z, v.W);
        }
        
        public static implicit operator Vector4d(Vector4ui v)
        {
            return new Vector4d(v.X, v.Y, v.Z, v.W);
        }
        
        public override string ToString()
        {
            return string.Format("[{0}, {1}, {2}, {3}]", X, Y, Z, W);
        }
        
        public static bool operator ==(Vector4ui a, Vector4ui b)
        {
            return a.X == b.X && a.Y == b.Y && a.Z == b.Z && a.W == b.W;
        }
        
        public static bool operator !=(Vector4ui a, Vector4ui b)
        {
            return a.X != b.X || a.Y != b.Y || a.Z != b.Z || a.W != b.W;
        }
        
        public bool Equals(Vector4ui other)
        {
            return X == other.X && Y == other.Y && Z == other.Z && W == other.W;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Vector4ui)) return false;
            var v = (Vector4ui)other;
            return X == v.X && Y == v.Y && Z == v.Z && W == v.W;
        }
        
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode() ^ W.GetHashCode();
        }
        
        public static Vector4ui operator +(Vector4ui a, Vector4ui b)
        {
            return new Vector4ui(a.X + b.X, a.Y + b.Y, a.Z + b.Z, a.W + b.W);
        }
        
        public static Vector4ui operator +(Vector4ui a, uint b)
        {
            return new Vector4ui(a.X + b, a.Y + b, a.Z + b, a.W + b);
        }
        
        public static Vector4ui operator -(Vector4ui a, Vector4ui b)
        {
            return new Vector4ui(a.X - b.X, a.Y - b.Y, a.Z - b.Z, a.W - b.W);
        }
        
        public static Vector4ui operator -(Vector4ui a, uint b)
        {
            return new Vector4ui(a.X - b, a.Y - b, a.Z - b, a.W - b);
        }
        
        public static Vector4ui operator *(Vector4ui a, Vector4ui b)
        {
            return new Vector4ui(a.X * b.X, a.Y * b.Y, a.Z * b.Z, a.W * b.W);
        }
        
        public static Vector4ui operator *(Vector4ui a, uint b)
        {
            return new Vector4ui(a.X * b, a.Y * b, a.Z * b, a.W * b);
        }
        
        public static Vector4ui operator /(Vector4ui a, Vector4ui b)
        {
            return new Vector4ui(a.X / b.X, a.Y / b.Y, a.Z / b.Z, a.W / b.W);
        }
        
        public static Vector4ui operator /(Vector4ui a, uint b)
        {
            return new Vector4ui(a.X / b, a.Y / b, a.Z / b, a.W / b);
        }
        
        public static uint Dot(Vector4ui a, Vector4ui b)
        {
            return a.X * b.X + a.Y * b.Y + a.Z * b.Z + a.W * b.W;
        }
        
        public uint SquaredLength
        {
            get { return X * X + Y * Y + Z * Z + W * W; }
        }
        
        public float Length
        {
            get { return (float)System.Math.Sqrt(X * X + Y * Y + Z * Z + W * W); }
        }
        
        public Vector4 Normalize()
        {
            var l = Length;
            return new Vector4(X / l, Y / l, Z / l, W / l);
        }
        
        public static readonly Vector4ui Zero = new Vector4ui(0u, 0u, 0u, 0u);
        public static readonly Vector4ui One = new Vector4ui(1u, 1u, 1u, 1u);
        public static readonly Vector4ui UnitX = new Vector4ui(1u, 0u, 0u, 0u);
        public static readonly Vector4ui UnitY = new Vector4ui(0u, 1u, 0u, 0u);
        public static readonly Vector4ui UnitZ = new Vector4ui(0u, 0u, 1u, 0u);
        public static readonly Vector4ui UnitW = new Vector4ui(0u, 0u, 0u, 1u);
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Vector2 : System.IEquatable<Vector2>
    {
        public readonly float X;
        public readonly float Y;
        
        public Vector2(float x, float y)
        {
            X = x;
            Y = y;
        }
        
        public static explicit operator Vector2b(Vector2 v)
        {
            return new Vector2b((sbyte)v.X, (sbyte)v.Y);
        }
        
        public static explicit operator Vector2ub(Vector2 v)
        {
            return new Vector2ub((byte)v.X, (byte)v.Y);
        }
        
        public static explicit operator Vector2s(Vector2 v)
        {
            return new Vector2s((short)v.X, (short)v.Y);
        }
        
        public static explicit operator Vector2us(Vector2 v)
        {
            return new Vector2us((ushort)v.X, (ushort)v.Y);
        }
        
        public static explicit operator Vector2i(Vector2 v)
        {
            return new Vector2i((int)v.X, (int)v.Y);
        }
        
        public static explicit operator Vector2ui(Vector2 v)
        {
            return new Vector2ui((uint)v.X, (uint)v.Y);
        }
        
        public static implicit operator Vector2d(Vector2 v)
        {
            return new Vector2d(v.X, v.Y);
        }
        
        public override string ToString()
        {
            return string.Format("[{0}, {1}]", X, Y);
        }
        
        public static bool operator ==(Vector2 a, Vector2 b)
        {
            return a.X == b.X && a.Y == b.Y;
        }
        
        public static bool operator !=(Vector2 a, Vector2 b)
        {
            return a.X != b.X || a.Y != b.Y;
        }
        
        public bool Equals(Vector2 other)
        {
            return X == other.X && Y == other.Y;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Vector2)) return false;
            var v = (Vector2)other;
            return X == v.X && Y == v.Y;
        }
        
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode();
        }
        
        public static Vector2 operator +(Vector2 a, Vector2 b)
        {
            return new Vector2(a.X + b.X, a.Y + b.Y);
        }
        
        public static Vector2 operator +(Vector2 a, float b)
        {
            return new Vector2(a.X + b, a.Y + b);
        }
        
        public static Vector2 operator -(Vector2 a, Vector2 b)
        {
            return new Vector2(a.X - b.X, a.Y - b.Y);
        }
        
        public static Vector2 operator -(Vector2 a, float b)
        {
            return new Vector2(a.X - b, a.Y - b);
        }
        
        public static Vector2 operator *(Vector2 a, Vector2 b)
        {
            return new Vector2(a.X * b.X, a.Y * b.Y);
        }
        
        public static Vector2 operator *(Vector2 a, float b)
        {
            return new Vector2(a.X * b, a.Y * b);
        }
        
        public static Vector2 operator /(Vector2 a, Vector2 b)
        {
            return new Vector2(a.X / b.X, a.Y / b.Y);
        }
        
        public static Vector2 operator /(Vector2 a, float b)
        {
            return new Vector2(a.X / b, a.Y / b);
        }
        
        public static Vector2 operator -(Vector2 v)
        {
            return new Vector2 (-v.X, -v.Y);
        }
        
        public static float Dot(Vector2 a, Vector2 b)
        {
            return a.X * b.X + a.Y * b.Y;
        }
        
        public float SquaredLength
        {
            get { return X * X + Y * Y; }
        }
        
        public float Length
        {
            get { return (float)System.Math.Sqrt(X * X + Y * Y); }
        }
        
        public Vector2 Normalize()
        {
            var l = Length;
            return new Vector2(X / l, Y / l);
        }
        
        public static readonly Vector2 Zero = new Vector2(0f, 0f);
        public static readonly Vector2 One = new Vector2(1f, 1f);
        public static readonly Vector2 UnitX = new Vector2(1f, 0f);
        public static readonly Vector2 UnitY = new Vector2(0f, 1f);
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Vector3 : System.IEquatable<Vector3>
    {
        public readonly float X;
        public readonly float Y;
        public readonly float Z;
        
        public Vector3(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        
        public Vector3(Vector2 v, float z)
        {
            X = v.X;
            Y = v.Y;
            Z = z;
        }
        
        public static explicit operator Vector3b(Vector3 v)
        {
            return new Vector3b((sbyte)v.X, (sbyte)v.Y, (sbyte)v.Z);
        }
        
        public static explicit operator Vector3ub(Vector3 v)
        {
            return new Vector3ub((byte)v.X, (byte)v.Y, (byte)v.Z);
        }
        
        public static explicit operator Vector3s(Vector3 v)
        {
            return new Vector3s((short)v.X, (short)v.Y, (short)v.Z);
        }
        
        public static explicit operator Vector3us(Vector3 v)
        {
            return new Vector3us((ushort)v.X, (ushort)v.Y, (ushort)v.Z);
        }
        
        public static explicit operator Vector3i(Vector3 v)
        {
            return new Vector3i((int)v.X, (int)v.Y, (int)v.Z);
        }
        
        public static explicit operator Vector3ui(Vector3 v)
        {
            return new Vector3ui((uint)v.X, (uint)v.Y, (uint)v.Z);
        }
        
        public static implicit operator Vector3d(Vector3 v)
        {
            return new Vector3d(v.X, v.Y, v.Z);
        }
        
        public override string ToString()
        {
            return string.Format("[{0}, {1}, {2}]", X, Y, Z);
        }
        
        public static bool operator ==(Vector3 a, Vector3 b)
        {
            return a.X == b.X && a.Y == b.Y && a.Z == b.Z;
        }
        
        public static bool operator !=(Vector3 a, Vector3 b)
        {
            return a.X != b.X || a.Y != b.Y || a.Z != b.Z;
        }
        
        public bool Equals(Vector3 other)
        {
            return X == other.X && Y == other.Y && Z == other.Z;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Vector3)) return false;
            var v = (Vector3)other;
            return X == v.X && Y == v.Y && Z == v.Z;
        }
        
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode();
        }
        
        public static Vector3 operator +(Vector3 a, Vector3 b)
        {
            return new Vector3(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }
        
        public static Vector3 operator +(Vector3 a, float b)
        {
            return new Vector3(a.X + b, a.Y + b, a.Z + b);
        }
        
        public static Vector3 operator -(Vector3 a, Vector3 b)
        {
            return new Vector3(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }
        
        public static Vector3 operator -(Vector3 a, float b)
        {
            return new Vector3(a.X - b, a.Y - b, a.Z - b);
        }
        
        public static Vector3 operator *(Vector3 a, Vector3 b)
        {
            return new Vector3(a.X * b.X, a.Y * b.Y, a.Z * b.Z);
        }
        
        public static Vector3 operator *(Vector3 a, float b)
        {
            return new Vector3(a.X * b, a.Y * b, a.Z * b);
        }
        
        public static Vector3 operator /(Vector3 a, Vector3 b)
        {
            return new Vector3(a.X / b.X, a.Y / b.Y, a.Z / b.Z);
        }
        
        public static Vector3 operator /(Vector3 a, float b)
        {
            return new Vector3(a.X / b, a.Y / b, a.Z / b);
        }
        
        public static Vector3 operator -(Vector3 v)
        {
            return new Vector3 (-v.X, -v.Y, -v.Z);
        }
        
        public static float Dot(Vector3 a, Vector3 b)
        {
            return a.X * b.X + a.Y * b.Y + a.Z * b.Z;
        }
        
        public static Vector3 Cross(Vector3 a, Vector3 b)
        {
            return new Vector3(
                a.Y * b.Z - a.Z * b.Y,
                a.Z * b.X - a.X * b.Z,
                a.X * b.Y - a.Y * b.X
            );
        }
        
        public float SquaredLength
        {
            get { return X * X + Y * Y + Z * Z; }
        }
        
        public float Length
        {
            get { return (float)System.Math.Sqrt(X * X + Y * Y + Z * Z); }
        }
        
        public Vector3 Normalize()
        {
            var l = Length;
            return new Vector3(X / l, Y / l, Z / l);
        }
        
        public static readonly Vector3 Zero = new Vector3(0f, 0f, 0f);
        public static readonly Vector3 One = new Vector3(1f, 1f, 1f);
        public static readonly Vector3 UnitX = new Vector3(1f, 0f, 0f);
        public static readonly Vector3 UnitY = new Vector3(0f, 1f, 0f);
        public static readonly Vector3 UnitZ = new Vector3(0f, 0f, 1f);
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Vector4 : System.IEquatable<Vector4>
    {
        public readonly float X;
        public readonly float Y;
        public readonly float Z;
        public readonly float W;
        
        public Vector4(float x, float y, float z, float w)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }
        
        public Vector4(Vector2 v, float z, float w)
        {
            X = v.X;
            Y = v.Y;
            Z = z;
            W = w;
        }
        
        public Vector4(Vector3 v, float w)
        {
            X = v.X;
            Y = v.Y;
            Z = v.Z;
            W = w;
        }
        
        public static explicit operator Vector4b(Vector4 v)
        {
            return new Vector4b((sbyte)v.X, (sbyte)v.Y, (sbyte)v.Z, (sbyte)v.W);
        }
        
        public static explicit operator Vector4ub(Vector4 v)
        {
            return new Vector4ub((byte)v.X, (byte)v.Y, (byte)v.Z, (byte)v.W);
        }
        
        public static explicit operator Vector4s(Vector4 v)
        {
            return new Vector4s((short)v.X, (short)v.Y, (short)v.Z, (short)v.W);
        }
        
        public static explicit operator Vector4us(Vector4 v)
        {
            return new Vector4us((ushort)v.X, (ushort)v.Y, (ushort)v.Z, (ushort)v.W);
        }
        
        public static explicit operator Vector4i(Vector4 v)
        {
            return new Vector4i((int)v.X, (int)v.Y, (int)v.Z, (int)v.W);
        }
        
        public static explicit operator Vector4ui(Vector4 v)
        {
            return new Vector4ui((uint)v.X, (uint)v.Y, (uint)v.Z, (uint)v.W);
        }
        
        public static implicit operator Vector4d(Vector4 v)
        {
            return new Vector4d(v.X, v.Y, v.Z, v.W);
        }
        
        public override string ToString()
        {
            return string.Format("[{0}, {1}, {2}, {3}]", X, Y, Z, W);
        }
        
        public static bool operator ==(Vector4 a, Vector4 b)
        {
            return a.X == b.X && a.Y == b.Y && a.Z == b.Z && a.W == b.W;
        }
        
        public static bool operator !=(Vector4 a, Vector4 b)
        {
            return a.X != b.X || a.Y != b.Y || a.Z != b.Z || a.W != b.W;
        }
        
        public bool Equals(Vector4 other)
        {
            return X == other.X && Y == other.Y && Z == other.Z && W == other.W;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Vector4)) return false;
            var v = (Vector4)other;
            return X == v.X && Y == v.Y && Z == v.Z && W == v.W;
        }
        
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode() ^ W.GetHashCode();
        }
        
        public static Vector4 operator +(Vector4 a, Vector4 b)
        {
            return new Vector4(a.X + b.X, a.Y + b.Y, a.Z + b.Z, a.W + b.W);
        }
        
        public static Vector4 operator +(Vector4 a, float b)
        {
            return new Vector4(a.X + b, a.Y + b, a.Z + b, a.W + b);
        }
        
        public static Vector4 operator -(Vector4 a, Vector4 b)
        {
            return new Vector4(a.X - b.X, a.Y - b.Y, a.Z - b.Z, a.W - b.W);
        }
        
        public static Vector4 operator -(Vector4 a, float b)
        {
            return new Vector4(a.X - b, a.Y - b, a.Z - b, a.W - b);
        }
        
        public static Vector4 operator *(Vector4 a, Vector4 b)
        {
            return new Vector4(a.X * b.X, a.Y * b.Y, a.Z * b.Z, a.W * b.W);
        }
        
        public static Vector4 operator *(Vector4 a, float b)
        {
            return new Vector4(a.X * b, a.Y * b, a.Z * b, a.W * b);
        }
        
        public static Vector4 operator /(Vector4 a, Vector4 b)
        {
            return new Vector4(a.X / b.X, a.Y / b.Y, a.Z / b.Z, a.W / b.W);
        }
        
        public static Vector4 operator /(Vector4 a, float b)
        {
            return new Vector4(a.X / b, a.Y / b, a.Z / b, a.W / b);
        }
        
        public static Vector4 operator -(Vector4 v)
        {
            return new Vector4 (-v.X, -v.Y, -v.Z, -v.W);
        }
        
        public static float Dot(Vector4 a, Vector4 b)
        {
            return a.X * b.X + a.Y * b.Y + a.Z * b.Z + a.W * b.W;
        }
        
        public float SquaredLength
        {
            get { return X * X + Y * Y + Z * Z + W * W; }
        }
        
        public float Length
        {
            get { return (float)System.Math.Sqrt(X * X + Y * Y + Z * Z + W * W); }
        }
        
        public Vector4 Normalize()
        {
            var l = Length;
            return new Vector4(X / l, Y / l, Z / l, W / l);
        }
        
        public static readonly Vector4 Zero = new Vector4(0f, 0f, 0f, 0f);
        public static readonly Vector4 One = new Vector4(1f, 1f, 1f, 1f);
        public static readonly Vector4 UnitX = new Vector4(1f, 0f, 0f, 0f);
        public static readonly Vector4 UnitY = new Vector4(0f, 1f, 0f, 0f);
        public static readonly Vector4 UnitZ = new Vector4(0f, 0f, 1f, 0f);
        public static readonly Vector4 UnitW = new Vector4(0f, 0f, 0f, 1f);
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Vector2d : System.IEquatable<Vector2d>
    {
        public readonly double X;
        public readonly double Y;
        
        public Vector2d(double x, double y)
        {
            X = x;
            Y = y;
        }
        
        public static explicit operator Vector2b(Vector2d v)
        {
            return new Vector2b((sbyte)v.X, (sbyte)v.Y);
        }
        
        public static explicit operator Vector2ub(Vector2d v)
        {
            return new Vector2ub((byte)v.X, (byte)v.Y);
        }
        
        public static explicit operator Vector2s(Vector2d v)
        {
            return new Vector2s((short)v.X, (short)v.Y);
        }
        
        public static explicit operator Vector2us(Vector2d v)
        {
            return new Vector2us((ushort)v.X, (ushort)v.Y);
        }
        
        public static explicit operator Vector2i(Vector2d v)
        {
            return new Vector2i((int)v.X, (int)v.Y);
        }
        
        public static explicit operator Vector2ui(Vector2d v)
        {
            return new Vector2ui((uint)v.X, (uint)v.Y);
        }
        
        public static explicit operator Vector2(Vector2d v)
        {
            return new Vector2((float)v.X, (float)v.Y);
        }
        
        public override string ToString()
        {
            return string.Format("[{0}, {1}]", X, Y);
        }
        
        public static bool operator ==(Vector2d a, Vector2d b)
        {
            return a.X == b.X && a.Y == b.Y;
        }
        
        public static bool operator !=(Vector2d a, Vector2d b)
        {
            return a.X != b.X || a.Y != b.Y;
        }
        
        public bool Equals(Vector2d other)
        {
            return X == other.X && Y == other.Y;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Vector2d)) return false;
            var v = (Vector2d)other;
            return X == v.X && Y == v.Y;
        }
        
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode();
        }
        
        public static Vector2d operator +(Vector2d a, Vector2d b)
        {
            return new Vector2d(a.X + b.X, a.Y + b.Y);
        }
        
        public static Vector2d operator +(Vector2d a, double b)
        {
            return new Vector2d(a.X + b, a.Y + b);
        }
        
        public static Vector2d operator -(Vector2d a, Vector2d b)
        {
            return new Vector2d(a.X - b.X, a.Y - b.Y);
        }
        
        public static Vector2d operator -(Vector2d a, double b)
        {
            return new Vector2d(a.X - b, a.Y - b);
        }
        
        public static Vector2d operator *(Vector2d a, Vector2d b)
        {
            return new Vector2d(a.X * b.X, a.Y * b.Y);
        }
        
        public static Vector2d operator *(Vector2d a, double b)
        {
            return new Vector2d(a.X * b, a.Y * b);
        }
        
        public static Vector2d operator /(Vector2d a, Vector2d b)
        {
            return new Vector2d(a.X / b.X, a.Y / b.Y);
        }
        
        public static Vector2d operator /(Vector2d a, double b)
        {
            return new Vector2d(a.X / b, a.Y / b);
        }
        
        public static Vector2d operator -(Vector2d v)
        {
            return new Vector2d (-v.X, -v.Y);
        }
        
        public static double Dot(Vector2d a, Vector2d b)
        {
            return a.X * b.X + a.Y * b.Y;
        }
        
        public double SquaredLength
        {
            get { return X * X + Y * Y; }
        }
        
        public double Length
        {
            get { return System.Math.Sqrt(X * X + Y * Y); }
        }
        
        public Vector2d Normalize()
        {
            var l = Length;
            return new Vector2d(X / l, Y / l);
        }
        
        public static readonly Vector2d Zero = new Vector2d(0d, 0d);
        public static readonly Vector2d One = new Vector2d(1d, 1d);
        public static readonly Vector2d UnitX = new Vector2d(1d, 0d);
        public static readonly Vector2d UnitY = new Vector2d(0d, 1d);
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Vector3d : System.IEquatable<Vector3d>
    {
        public readonly double X;
        public readonly double Y;
        public readonly double Z;
        
        public Vector3d(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        
        public Vector3d(Vector2d v, double z)
        {
            X = v.X;
            Y = v.Y;
            Z = z;
        }
        
        public static explicit operator Vector3b(Vector3d v)
        {
            return new Vector3b((sbyte)v.X, (sbyte)v.Y, (sbyte)v.Z);
        }
        
        public static explicit operator Vector3ub(Vector3d v)
        {
            return new Vector3ub((byte)v.X, (byte)v.Y, (byte)v.Z);
        }
        
        public static explicit operator Vector3s(Vector3d v)
        {
            return new Vector3s((short)v.X, (short)v.Y, (short)v.Z);
        }
        
        public static explicit operator Vector3us(Vector3d v)
        {
            return new Vector3us((ushort)v.X, (ushort)v.Y, (ushort)v.Z);
        }
        
        public static explicit operator Vector3i(Vector3d v)
        {
            return new Vector3i((int)v.X, (int)v.Y, (int)v.Z);
        }
        
        public static explicit operator Vector3ui(Vector3d v)
        {
            return new Vector3ui((uint)v.X, (uint)v.Y, (uint)v.Z);
        }
        
        public static explicit operator Vector3(Vector3d v)
        {
            return new Vector3((float)v.X, (float)v.Y, (float)v.Z);
        }
        
        public override string ToString()
        {
            return string.Format("[{0}, {1}, {2}]", X, Y, Z);
        }
        
        public static bool operator ==(Vector3d a, Vector3d b)
        {
            return a.X == b.X && a.Y == b.Y && a.Z == b.Z;
        }
        
        public static bool operator !=(Vector3d a, Vector3d b)
        {
            return a.X != b.X || a.Y != b.Y || a.Z != b.Z;
        }
        
        public bool Equals(Vector3d other)
        {
            return X == other.X && Y == other.Y && Z == other.Z;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Vector3d)) return false;
            var v = (Vector3d)other;
            return X == v.X && Y == v.Y && Z == v.Z;
        }
        
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode();
        }
        
        public static Vector3d operator +(Vector3d a, Vector3d b)
        {
            return new Vector3d(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }
        
        public static Vector3d operator +(Vector3d a, double b)
        {
            return new Vector3d(a.X + b, a.Y + b, a.Z + b);
        }
        
        public static Vector3d operator -(Vector3d a, Vector3d b)
        {
            return new Vector3d(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }
        
        public static Vector3d operator -(Vector3d a, double b)
        {
            return new Vector3d(a.X - b, a.Y - b, a.Z - b);
        }
        
        public static Vector3d operator *(Vector3d a, Vector3d b)
        {
            return new Vector3d(a.X * b.X, a.Y * b.Y, a.Z * b.Z);
        }
        
        public static Vector3d operator *(Vector3d a, double b)
        {
            return new Vector3d(a.X * b, a.Y * b, a.Z * b);
        }
        
        public static Vector3d operator /(Vector3d a, Vector3d b)
        {
            return new Vector3d(a.X / b.X, a.Y / b.Y, a.Z / b.Z);
        }
        
        public static Vector3d operator /(Vector3d a, double b)
        {
            return new Vector3d(a.X / b, a.Y / b, a.Z / b);
        }
        
        public static Vector3d operator -(Vector3d v)
        {
            return new Vector3d (-v.X, -v.Y, -v.Z);
        }
        
        public static double Dot(Vector3d a, Vector3d b)
        {
            return a.X * b.X + a.Y * b.Y + a.Z * b.Z;
        }
        
        public static Vector3d Cross(Vector3d a, Vector3d b)
        {
            return new Vector3d(
                a.Y * b.Z - a.Z * b.Y,
                a.Z * b.X - a.X * b.Z,
                a.X * b.Y - a.Y * b.X
            );
        }
        
        public double SquaredLength
        {
            get { return X * X + Y * Y + Z * Z; }
        }
        
        public double Length
        {
            get { return System.Math.Sqrt(X * X + Y * Y + Z * Z); }
        }
        
        public Vector3d Normalize()
        {
            var l = Length;
            return new Vector3d(X / l, Y / l, Z / l);
        }
        
        public static readonly Vector3d Zero = new Vector3d(0d, 0d, 0d);
        public static readonly Vector3d One = new Vector3d(1d, 1d, 1d);
        public static readonly Vector3d UnitX = new Vector3d(1d, 0d, 0d);
        public static readonly Vector3d UnitY = new Vector3d(0d, 1d, 0d);
        public static readonly Vector3d UnitZ = new Vector3d(0d, 0d, 1d);
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Vector4d : System.IEquatable<Vector4d>
    {
        public readonly double X;
        public readonly double Y;
        public readonly double Z;
        public readonly double W;
        
        public Vector4d(double x, double y, double z, double w)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }
        
        public Vector4d(Vector2d v, double z, double w)
        {
            X = v.X;
            Y = v.Y;
            Z = z;
            W = w;
        }
        
        public Vector4d(Vector3d v, double w)
        {
            X = v.X;
            Y = v.Y;
            Z = v.Z;
            W = w;
        }
        
        public static explicit operator Vector4b(Vector4d v)
        {
            return new Vector4b((sbyte)v.X, (sbyte)v.Y, (sbyte)v.Z, (sbyte)v.W);
        }
        
        public static explicit operator Vector4ub(Vector4d v)
        {
            return new Vector4ub((byte)v.X, (byte)v.Y, (byte)v.Z, (byte)v.W);
        }
        
        public static explicit operator Vector4s(Vector4d v)
        {
            return new Vector4s((short)v.X, (short)v.Y, (short)v.Z, (short)v.W);
        }
        
        public static explicit operator Vector4us(Vector4d v)
        {
            return new Vector4us((ushort)v.X, (ushort)v.Y, (ushort)v.Z, (ushort)v.W);
        }
        
        public static explicit operator Vector4i(Vector4d v)
        {
            return new Vector4i((int)v.X, (int)v.Y, (int)v.Z, (int)v.W);
        }
        
        public static explicit operator Vector4ui(Vector4d v)
        {
            return new Vector4ui((uint)v.X, (uint)v.Y, (uint)v.Z, (uint)v.W);
        }
        
        public static explicit operator Vector4(Vector4d v)
        {
            return new Vector4((float)v.X, (float)v.Y, (float)v.Z, (float)v.W);
        }
        
        public override string ToString()
        {
            return string.Format("[{0}, {1}, {2}, {3}]", X, Y, Z, W);
        }
        
        public static bool operator ==(Vector4d a, Vector4d b)
        {
            return a.X == b.X && a.Y == b.Y && a.Z == b.Z && a.W == b.W;
        }
        
        public static bool operator !=(Vector4d a, Vector4d b)
        {
            return a.X != b.X || a.Y != b.Y || a.Z != b.Z || a.W != b.W;
        }
        
        public bool Equals(Vector4d other)
        {
            return X == other.X && Y == other.Y && Z == other.Z && W == other.W;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Vector4d)) return false;
            var v = (Vector4d)other;
            return X == v.X && Y == v.Y && Z == v.Z && W == v.W;
        }
        
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode() ^ W.GetHashCode();
        }
        
        public static Vector4d operator +(Vector4d a, Vector4d b)
        {
            return new Vector4d(a.X + b.X, a.Y + b.Y, a.Z + b.Z, a.W + b.W);
        }
        
        public static Vector4d operator +(Vector4d a, double b)
        {
            return new Vector4d(a.X + b, a.Y + b, a.Z + b, a.W + b);
        }
        
        public static Vector4d operator -(Vector4d a, Vector4d b)
        {
            return new Vector4d(a.X - b.X, a.Y - b.Y, a.Z - b.Z, a.W - b.W);
        }
        
        public static Vector4d operator -(Vector4d a, double b)
        {
            return new Vector4d(a.X - b, a.Y - b, a.Z - b, a.W - b);
        }
        
        public static Vector4d operator *(Vector4d a, Vector4d b)
        {
            return new Vector4d(a.X * b.X, a.Y * b.Y, a.Z * b.Z, a.W * b.W);
        }
        
        public static Vector4d operator *(Vector4d a, double b)
        {
            return new Vector4d(a.X * b, a.Y * b, a.Z * b, a.W * b);
        }
        
        public static Vector4d operator /(Vector4d a, Vector4d b)
        {
            return new Vector4d(a.X / b.X, a.Y / b.Y, a.Z / b.Z, a.W / b.W);
        }
        
        public static Vector4d operator /(Vector4d a, double b)
        {
            return new Vector4d(a.X / b, a.Y / b, a.Z / b, a.W / b);
        }
        
        public static Vector4d operator -(Vector4d v)
        {
            return new Vector4d (-v.X, -v.Y, -v.Z, -v.W);
        }
        
        public static double Dot(Vector4d a, Vector4d b)
        {
            return a.X * b.X + a.Y * b.Y + a.Z * b.Z + a.W * b.W;
        }
        
        public double SquaredLength
        {
            get { return X * X + Y * Y + Z * Z + W * W; }
        }
        
        public double Length
        {
            get { return System.Math.Sqrt(X * X + Y * Y + Z * Z + W * W); }
        }
        
        public Vector4d Normalize()
        {
            var l = Length;
            return new Vector4d(X / l, Y / l, Z / l, W / l);
        }
        
        public static readonly Vector4d Zero = new Vector4d(0d, 0d, 0d, 0d);
        public static readonly Vector4d One = new Vector4d(1d, 1d, 1d, 1d);
        public static readonly Vector4d UnitX = new Vector4d(1d, 0d, 0d, 0d);
        public static readonly Vector4d UnitY = new Vector4d(0d, 1d, 0d, 0d);
        public static readonly Vector4d UnitZ = new Vector4d(0d, 0d, 1d, 0d);
        public static readonly Vector4d UnitW = new Vector4d(0d, 0d, 0d, 1d);
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Matrix2 : System.IEquatable<Matrix2>
    {
        public readonly float M00;
        public readonly float M01;
        public readonly float M10;
        public readonly float M11;
        
        public Vector2 Column0 { get { return new Vector2(M00, M01); } }
        public Vector2 Column1 { get { return new Vector2(M10, M11); } }
        
        public Vector2 Row0 { get { return new Vector2(M00, M10); } }
        public Vector2 Row1 { get { return new Vector2(M01, M11); } }
        
        public Matrix2(Vector2 column0, Vector2 column1)
        {
            M00 = column0.X;
            M01 = column0.Y;
            M10 = column1.X;
            M11 = column1.Y;
        }
        
        public Matrix2(float m00, float m01, float m10, float m11)
        {
            M00 = m00;
            M01 = m01;
            M10 = m10;
            M11 = m11;
        }
        
        public static bool operator ==(Matrix2 a, Matrix2 b)
        {
            return a.M00 == b.M00 && a.M01 == b.M01 && a.M10 == b.M10 && a.M11 == b.M11;
        }
        
        public static bool operator !=(Matrix2 a, Matrix2 b)
        {
            return a.M00 != b.M00 || a.M01 != b.M01 || a.M10 != b.M10 || a.M11 != b.M11;
        }
        
        public bool Equals(Matrix2 other)
        {
            return M00 == other.M00 && M01 == other.M01 && M10 == other.M10 && M11 == other.M11;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Matrix2)) return false;
            var m = (Matrix2)other;
            return M00 == m.M00 && M01 == m.M01 && M10 == m.M10 && M11 == m.M11;
        }
        
        public override int GetHashCode()
        {
            return M00.GetHashCode() ^ M01.GetHashCode() ^ M10.GetHashCode() ^ M11.GetHashCode();
        }
        
        public override string ToString()
        {
            return "[" + M00.ToString() + M01.ToString() + "]"
             + "[" + M10.ToString() + M11.ToString() + "]"
            ;
        }
        
        public static readonly Matrix2 Identity = new Matrix2(Vector2.UnitX, Vector2.UnitY);
        
        public static Matrix2 operator *(Matrix2 left, Matrix2 right)
        {
            return new Matrix2(
                left.M00 * right.M00 + left.M10 * right.M01,
                left.M01 * right.M00 + left.M11 * right.M01,
                left.M00 * right.M10 + left.M10 * right.M11,
                left.M01 * right.M10 + left.M11 * right.M11
            );
        }
        
        public static Matrix3x2 operator *(Matrix2 left, Matrix3x2 right)
        {
            return new Matrix3x2(
                left.M00 * right.M00 + left.M10 * right.M01,
                left.M01 * right.M00 + left.M11 * right.M01,
                left.M00 * right.M10 + left.M10 * right.M11,
                left.M01 * right.M10 + left.M11 * right.M11,
                left.M00 * right.M20 + left.M10 * right.M21,
                left.M01 * right.M20 + left.M11 * right.M21
            );
        }
        
        public static Matrix4x2 operator *(Matrix2 left, Matrix4x2 right)
        {
            return new Matrix4x2(
                left.M00 * right.M00 + left.M10 * right.M01,
                left.M01 * right.M00 + left.M11 * right.M01,
                left.M00 * right.M10 + left.M10 * right.M11,
                left.M01 * right.M10 + left.M11 * right.M11,
                left.M00 * right.M20 + left.M10 * right.M21,
                left.M01 * right.M20 + left.M11 * right.M21,
                left.M00 * right.M30 + left.M10 * right.M31,
                left.M01 * right.M30 + left.M11 * right.M31
            );
        }
        
        public static Vector2 operator *(Matrix2 m, Vector2 v)
        {
            return new Vector2(
                m.M00 * v.X + m.M10 * v.Y,
                m.M01 * v.X + m.M11 * v.Y
            );
        }
        
        public Matrix2 Transpose
        {
            get {
                return new Matrix2(
                    M00, M10, 
                    M01, M11
                );
            }
        }
        
        public float Determinant
        {
            get {
                return M00 * M11 + M01 * M10 - M11 * M00 - M10 * M01;
            }
        }
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Matrix2x3 : System.IEquatable<Matrix2x3>
    {
        public readonly float M00;
        public readonly float M01;
        public readonly float M02;
        public readonly float M10;
        public readonly float M11;
        public readonly float M12;
        
        public Vector3 Column0 { get { return new Vector3(M00, M01, M02); } }
        public Vector3 Column1 { get { return new Vector3(M10, M11, M12); } }
        
        public Vector2 Row0 { get { return new Vector2(M00, M10); } }
        public Vector2 Row1 { get { return new Vector2(M01, M11); } }
        public Vector2 Row2 { get { return new Vector2(M02, M12); } }
        
        public Matrix2x3(Vector3 column0, Vector3 column1)
        {
            M00 = column0.X;
            M01 = column0.Y;
            M02 = column0.Z;
            M10 = column1.X;
            M11 = column1.Y;
            M12 = column1.Z;
        }
        
        public Matrix2x3(float m00, float m01, float m02, float m10, float m11, float m12)
        {
            M00 = m00;
            M01 = m01;
            M02 = m02;
            M10 = m10;
            M11 = m11;
            M12 = m12;
        }
        
        public static bool operator ==(Matrix2x3 a, Matrix2x3 b)
        {
            return a.M00 == b.M00 && a.M01 == b.M01 && a.M02 == b.M02 && a.M10 == b.M10 && a.M11 == b.M11 && a.M12 == b.M12;
        }
        
        public static bool operator !=(Matrix2x3 a, Matrix2x3 b)
        {
            return a.M00 != b.M00 || a.M01 != b.M01 || a.M02 != b.M02 || a.M10 != b.M10 || a.M11 != b.M11 || a.M12 != b.M12;
        }
        
        public bool Equals(Matrix2x3 other)
        {
            return M00 == other.M00 && M01 == other.M01 && M02 == other.M02 && M10 == other.M10 && M11 == other.M11 && M12 == other.M12;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Matrix2x3)) return false;
            var m = (Matrix2x3)other;
            return M00 == m.M00 && M01 == m.M01 && M02 == m.M02 && M10 == m.M10 && M11 == m.M11 && M12 == m.M12;
        }
        
        public override int GetHashCode()
        {
            return M00.GetHashCode() ^ M01.GetHashCode() ^ M02.GetHashCode() ^ M10.GetHashCode() ^ M11.GetHashCode() ^ M12.GetHashCode();
        }
        
        public override string ToString()
        {
            return "[" + M00.ToString() + M01.ToString() + M02.ToString() + "]"
             + "[" + M10.ToString() + M11.ToString() + M12.ToString() + "]"
            ;
        }
        
        public static Matrix2x3 operator *(Matrix2x3 left, Matrix2 right)
        {
            return new Matrix2x3(
                left.M00 * right.M00 + left.M10 * right.M01,
                left.M01 * right.M00 + left.M11 * right.M01,
                left.M02 * right.M00 + left.M12 * right.M01,
                left.M00 * right.M10 + left.M10 * right.M11,
                left.M01 * right.M10 + left.M11 * right.M11,
                left.M02 * right.M10 + left.M12 * right.M11
            );
        }
        
        public static Matrix3 operator *(Matrix2x3 left, Matrix3x2 right)
        {
            return new Matrix3(
                left.M00 * right.M00 + left.M10 * right.M01,
                left.M01 * right.M00 + left.M11 * right.M01,
                left.M02 * right.M00 + left.M12 * right.M01,
                left.M00 * right.M10 + left.M10 * right.M11,
                left.M01 * right.M10 + left.M11 * right.M11,
                left.M02 * right.M10 + left.M12 * right.M11,
                left.M00 * right.M20 + left.M10 * right.M21,
                left.M01 * right.M20 + left.M11 * right.M21,
                left.M02 * right.M20 + left.M12 * right.M21
            );
        }
        
        public static Matrix4x3 operator *(Matrix2x3 left, Matrix4x2 right)
        {
            return new Matrix4x3(
                left.M00 * right.M00 + left.M10 * right.M01,
                left.M01 * right.M00 + left.M11 * right.M01,
                left.M02 * right.M00 + left.M12 * right.M01,
                left.M00 * right.M10 + left.M10 * right.M11,
                left.M01 * right.M10 + left.M11 * right.M11,
                left.M02 * right.M10 + left.M12 * right.M11,
                left.M00 * right.M20 + left.M10 * right.M21,
                left.M01 * right.M20 + left.M11 * right.M21,
                left.M02 * right.M20 + left.M12 * right.M21,
                left.M00 * right.M30 + left.M10 * right.M31,
                left.M01 * right.M30 + left.M11 * right.M31,
                left.M02 * right.M30 + left.M12 * right.M31
            );
        }
        
        public static Vector3 operator *(Matrix2x3 m, Vector2 v)
        {
            return new Vector3(
                m.M00 * v.X + m.M10 * v.Y,
                m.M01 * v.X + m.M11 * v.Y,
                m.M02 * v.X + m.M12 * v.Y
            );
        }
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Matrix2x4 : System.IEquatable<Matrix2x4>
    {
        public readonly float M00;
        public readonly float M01;
        public readonly float M02;
        public readonly float M03;
        public readonly float M10;
        public readonly float M11;
        public readonly float M12;
        public readonly float M13;
        
        public Vector4 Column0 { get { return new Vector4(M00, M01, M02, M03); } }
        public Vector4 Column1 { get { return new Vector4(M10, M11, M12, M13); } }
        
        public Vector2 Row0 { get { return new Vector2(M00, M10); } }
        public Vector2 Row1 { get { return new Vector2(M01, M11); } }
        public Vector2 Row2 { get { return new Vector2(M02, M12); } }
        public Vector2 Row3 { get { return new Vector2(M03, M13); } }
        
        public Matrix2x4(Vector4 column0, Vector4 column1)
        {
            M00 = column0.X;
            M01 = column0.Y;
            M02 = column0.Z;
            M03 = column0.W;
            M10 = column1.X;
            M11 = column1.Y;
            M12 = column1.Z;
            M13 = column1.W;
        }
        
        public Matrix2x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13)
        {
            M00 = m00;
            M01 = m01;
            M02 = m02;
            M03 = m03;
            M10 = m10;
            M11 = m11;
            M12 = m12;
            M13 = m13;
        }
        
        public static bool operator ==(Matrix2x4 a, Matrix2x4 b)
        {
            return a.M00 == b.M00 && a.M01 == b.M01 && a.M02 == b.M02 && a.M03 == b.M03 && a.M10 == b.M10 && a.M11 == b.M11 && a.M12 == b.M12 && a.M13 == b.M13;
        }
        
        public static bool operator !=(Matrix2x4 a, Matrix2x4 b)
        {
            return a.M00 != b.M00 || a.M01 != b.M01 || a.M02 != b.M02 || a.M03 != b.M03 || a.M10 != b.M10 || a.M11 != b.M11 || a.M12 != b.M12 || a.M13 != b.M13;
        }
        
        public bool Equals(Matrix2x4 other)
        {
            return M00 == other.M00 && M01 == other.M01 && M02 == other.M02 && M03 == other.M03 && M10 == other.M10 && M11 == other.M11 && M12 == other.M12 && M13 == other.M13;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Matrix2x4)) return false;
            var m = (Matrix2x4)other;
            return M00 == m.M00 && M01 == m.M01 && M02 == m.M02 && M03 == m.M03 && M10 == m.M10 && M11 == m.M11 && M12 == m.M12 && M13 == m.M13;
        }
        
        public override int GetHashCode()
        {
            return M00.GetHashCode() ^ M01.GetHashCode() ^ M02.GetHashCode() ^ M03.GetHashCode() ^ M10.GetHashCode() ^ M11.GetHashCode() ^ M12.GetHashCode() ^ M13.GetHashCode();
        }
        
        public override string ToString()
        {
            return "[" + M00.ToString() + M01.ToString() + M02.ToString() + M03.ToString() + "]"
             + "[" + M10.ToString() + M11.ToString() + M12.ToString() + M13.ToString() + "]"
            ;
        }
        
        public static Matrix2x4 operator *(Matrix2x4 left, Matrix2 right)
        {
            return new Matrix2x4(
                left.M00 * right.M00 + left.M10 * right.M01,
                left.M01 * right.M00 + left.M11 * right.M01,
                left.M02 * right.M00 + left.M12 * right.M01,
                left.M03 * right.M00 + left.M13 * right.M01,
                left.M00 * right.M10 + left.M10 * right.M11,
                left.M01 * right.M10 + left.M11 * right.M11,
                left.M02 * right.M10 + left.M12 * right.M11,
                left.M03 * right.M10 + left.M13 * right.M11
            );
        }
        
        public static Matrix3x4 operator *(Matrix2x4 left, Matrix3x2 right)
        {
            return new Matrix3x4(
                left.M00 * right.M00 + left.M10 * right.M01,
                left.M01 * right.M00 + left.M11 * right.M01,
                left.M02 * right.M00 + left.M12 * right.M01,
                left.M03 * right.M00 + left.M13 * right.M01,
                left.M00 * right.M10 + left.M10 * right.M11,
                left.M01 * right.M10 + left.M11 * right.M11,
                left.M02 * right.M10 + left.M12 * right.M11,
                left.M03 * right.M10 + left.M13 * right.M11,
                left.M00 * right.M20 + left.M10 * right.M21,
                left.M01 * right.M20 + left.M11 * right.M21,
                left.M02 * right.M20 + left.M12 * right.M21,
                left.M03 * right.M20 + left.M13 * right.M21
            );
        }
        
        public static Matrix4 operator *(Matrix2x4 left, Matrix4x2 right)
        {
            return new Matrix4(
                left.M00 * right.M00 + left.M10 * right.M01,
                left.M01 * right.M00 + left.M11 * right.M01,
                left.M02 * right.M00 + left.M12 * right.M01,
                left.M03 * right.M00 + left.M13 * right.M01,
                left.M00 * right.M10 + left.M10 * right.M11,
                left.M01 * right.M10 + left.M11 * right.M11,
                left.M02 * right.M10 + left.M12 * right.M11,
                left.M03 * right.M10 + left.M13 * right.M11,
                left.M00 * right.M20 + left.M10 * right.M21,
                left.M01 * right.M20 + left.M11 * right.M21,
                left.M02 * right.M20 + left.M12 * right.M21,
                left.M03 * right.M20 + left.M13 * right.M21,
                left.M00 * right.M30 + left.M10 * right.M31,
                left.M01 * right.M30 + left.M11 * right.M31,
                left.M02 * right.M30 + left.M12 * right.M31,
                left.M03 * right.M30 + left.M13 * right.M31
            );
        }
        
        public static Vector4 operator *(Matrix2x4 m, Vector2 v)
        {
            return new Vector4(
                m.M00 * v.X + m.M10 * v.Y,
                m.M01 * v.X + m.M11 * v.Y,
                m.M02 * v.X + m.M12 * v.Y,
                m.M03 * v.X + m.M13 * v.Y
            );
        }
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Matrix3x2 : System.IEquatable<Matrix3x2>
    {
        public readonly float M00;
        public readonly float M01;
        public readonly float M10;
        public readonly float M11;
        public readonly float M20;
        public readonly float M21;
        
        public Vector2 Column0 { get { return new Vector2(M00, M01); } }
        public Vector2 Column1 { get { return new Vector2(M10, M11); } }
        public Vector2 Column2 { get { return new Vector2(M20, M21); } }
        
        public Vector3 Row0 { get { return new Vector3(M00, M10, M20); } }
        public Vector3 Row1 { get { return new Vector3(M01, M11, M21); } }
        
        public Matrix3x2(Vector2 column0, Vector2 column1, Vector2 column2)
        {
            M00 = column0.X;
            M01 = column0.Y;
            M10 = column1.X;
            M11 = column1.Y;
            M20 = column2.X;
            M21 = column2.Y;
        }
        
        public Matrix3x2(float m00, float m01, float m10, float m11, float m20, float m21)
        {
            M00 = m00;
            M01 = m01;
            M10 = m10;
            M11 = m11;
            M20 = m20;
            M21 = m21;
        }
        
        public static bool operator ==(Matrix3x2 a, Matrix3x2 b)
        {
            return a.M00 == b.M00 && a.M01 == b.M01 && a.M10 == b.M10 && a.M11 == b.M11 && a.M20 == b.M20 && a.M21 == b.M21;
        }
        
        public static bool operator !=(Matrix3x2 a, Matrix3x2 b)
        {
            return a.M00 != b.M00 || a.M01 != b.M01 || a.M10 != b.M10 || a.M11 != b.M11 || a.M20 != b.M20 || a.M21 != b.M21;
        }
        
        public bool Equals(Matrix3x2 other)
        {
            return M00 == other.M00 && M01 == other.M01 && M10 == other.M10 && M11 == other.M11 && M20 == other.M20 && M21 == other.M21;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Matrix3x2)) return false;
            var m = (Matrix3x2)other;
            return M00 == m.M00 && M01 == m.M01 && M10 == m.M10 && M11 == m.M11 && M20 == m.M20 && M21 == m.M21;
        }
        
        public override int GetHashCode()
        {
            return M00.GetHashCode() ^ M01.GetHashCode() ^ M10.GetHashCode() ^ M11.GetHashCode() ^ M20.GetHashCode() ^ M21.GetHashCode();
        }
        
        public override string ToString()
        {
            return "[" + M00.ToString() + M01.ToString() + "]"
             + "[" + M10.ToString() + M11.ToString() + "]"
             + "[" + M20.ToString() + M21.ToString() + "]"
            ;
        }
        
        public static Matrix2 operator *(Matrix3x2 left, Matrix2x3 right)
        {
            return new Matrix2(
                left.M00 * right.M00 + left.M10 * right.M01 + left.M20 * right.M02,
                left.M01 * right.M00 + left.M11 * right.M01 + left.M21 * right.M02,
                left.M00 * right.M10 + left.M10 * right.M11 + left.M20 * right.M12,
                left.M01 * right.M10 + left.M11 * right.M11 + left.M21 * right.M12
            );
        }
        
        public static Matrix3x2 operator *(Matrix3x2 left, Matrix3 right)
        {
            return new Matrix3x2(
                left.M00 * right.M00 + left.M10 * right.M01 + left.M20 * right.M02,
                left.M01 * right.M00 + left.M11 * right.M01 + left.M21 * right.M02,
                left.M00 * right.M10 + left.M10 * right.M11 + left.M20 * right.M12,
                left.M01 * right.M10 + left.M11 * right.M11 + left.M21 * right.M12,
                left.M00 * right.M20 + left.M10 * right.M21 + left.M20 * right.M22,
                left.M01 * right.M20 + left.M11 * right.M21 + left.M21 * right.M22
            );
        }
        
        public static Matrix4x2 operator *(Matrix3x2 left, Matrix4x3 right)
        {
            return new Matrix4x2(
                left.M00 * right.M00 + left.M10 * right.M01 + left.M20 * right.M02,
                left.M01 * right.M00 + left.M11 * right.M01 + left.M21 * right.M02,
                left.M00 * right.M10 + left.M10 * right.M11 + left.M20 * right.M12,
                left.M01 * right.M10 + left.M11 * right.M11 + left.M21 * right.M12,
                left.M00 * right.M20 + left.M10 * right.M21 + left.M20 * right.M22,
                left.M01 * right.M20 + left.M11 * right.M21 + left.M21 * right.M22,
                left.M00 * right.M30 + left.M10 * right.M31 + left.M20 * right.M32,
                left.M01 * right.M30 + left.M11 * right.M31 + left.M21 * right.M32
            );
        }
        
        public static Vector2 operator *(Matrix3x2 m, Vector3 v)
        {
            return new Vector2(
                m.M00 * v.X + m.M10 * v.Y + m.M20 * v.Z,
                m.M01 * v.X + m.M11 * v.Y + m.M21 * v.Z
            );
        }
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Matrix3 : System.IEquatable<Matrix3>
    {
        public readonly float M00;
        public readonly float M01;
        public readonly float M02;
        public readonly float M10;
        public readonly float M11;
        public readonly float M12;
        public readonly float M20;
        public readonly float M21;
        public readonly float M22;
        
        public Vector3 Column0 { get { return new Vector3(M00, M01, M02); } }
        public Vector3 Column1 { get { return new Vector3(M10, M11, M12); } }
        public Vector3 Column2 { get { return new Vector3(M20, M21, M22); } }
        
        public Vector3 Row0 { get { return new Vector3(M00, M10, M20); } }
        public Vector3 Row1 { get { return new Vector3(M01, M11, M21); } }
        public Vector3 Row2 { get { return new Vector3(M02, M12, M22); } }
        
        public Matrix3(Vector3 column0, Vector3 column1, Vector3 column2)
        {
            M00 = column0.X;
            M01 = column0.Y;
            M02 = column0.Z;
            M10 = column1.X;
            M11 = column1.Y;
            M12 = column1.Z;
            M20 = column2.X;
            M21 = column2.Y;
            M22 = column2.Z;
        }
        
        public Matrix3(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22)
        {
            M00 = m00;
            M01 = m01;
            M02 = m02;
            M10 = m10;
            M11 = m11;
            M12 = m12;
            M20 = m20;
            M21 = m21;
            M22 = m22;
        }
        
        public static bool operator ==(Matrix3 a, Matrix3 b)
        {
            return a.M00 == b.M00 && a.M01 == b.M01 && a.M02 == b.M02 && a.M10 == b.M10 && a.M11 == b.M11 && a.M12 == b.M12 && a.M20 == b.M20 && a.M21 == b.M21 && a.M22 == b.M22;
        }
        
        public static bool operator !=(Matrix3 a, Matrix3 b)
        {
            return a.M00 != b.M00 || a.M01 != b.M01 || a.M02 != b.M02 || a.M10 != b.M10 || a.M11 != b.M11 || a.M12 != b.M12 || a.M20 != b.M20 || a.M21 != b.M21 || a.M22 != b.M22;
        }
        
        public bool Equals(Matrix3 other)
        {
            return M00 == other.M00 && M01 == other.M01 && M02 == other.M02 && M10 == other.M10 && M11 == other.M11 && M12 == other.M12 && M20 == other.M20 && M21 == other.M21 && M22 == other.M22;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Matrix3)) return false;
            var m = (Matrix3)other;
            return M00 == m.M00 && M01 == m.M01 && M02 == m.M02 && M10 == m.M10 && M11 == m.M11 && M12 == m.M12 && M20 == m.M20 && M21 == m.M21 && M22 == m.M22;
        }
        
        public override int GetHashCode()
        {
            return M00.GetHashCode() ^ M01.GetHashCode() ^ M02.GetHashCode() ^ M10.GetHashCode() ^ M11.GetHashCode() ^ M12.GetHashCode() ^ M20.GetHashCode() ^ M21.GetHashCode() ^ M22.GetHashCode();
        }
        
        public override string ToString()
        {
            return "[" + M00.ToString() + M01.ToString() + M02.ToString() + "]"
             + "[" + M10.ToString() + M11.ToString() + M12.ToString() + "]"
             + "[" + M20.ToString() + M21.ToString() + M22.ToString() + "]"
            ;
        }
        
        public static readonly Matrix3 Identity = new Matrix3(Vector3.UnitX, Vector3.UnitY, Vector3.UnitZ);
        
        public static Matrix2x3 operator *(Matrix3 left, Matrix2x3 right)
        {
            return new Matrix2x3(
                left.M00 * right.M00 + left.M10 * right.M01 + left.M20 * right.M02,
                left.M01 * right.M00 + left.M11 * right.M01 + left.M21 * right.M02,
                left.M02 * right.M00 + left.M12 * right.M01 + left.M22 * right.M02,
                left.M00 * right.M10 + left.M10 * right.M11 + left.M20 * right.M12,
                left.M01 * right.M10 + left.M11 * right.M11 + left.M21 * right.M12,
                left.M02 * right.M10 + left.M12 * right.M11 + left.M22 * right.M12
            );
        }
        
        public static Matrix3 operator *(Matrix3 left, Matrix3 right)
        {
            return new Matrix3(
                left.M00 * right.M00 + left.M10 * right.M01 + left.M20 * right.M02,
                left.M01 * right.M00 + left.M11 * right.M01 + left.M21 * right.M02,
                left.M02 * right.M00 + left.M12 * right.M01 + left.M22 * right.M02,
                left.M00 * right.M10 + left.M10 * right.M11 + left.M20 * right.M12,
                left.M01 * right.M10 + left.M11 * right.M11 + left.M21 * right.M12,
                left.M02 * right.M10 + left.M12 * right.M11 + left.M22 * right.M12,
                left.M00 * right.M20 + left.M10 * right.M21 + left.M20 * right.M22,
                left.M01 * right.M20 + left.M11 * right.M21 + left.M21 * right.M22,
                left.M02 * right.M20 + left.M12 * right.M21 + left.M22 * right.M22
            );
        }
        
        public static Matrix4x3 operator *(Matrix3 left, Matrix4x3 right)
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
                left.M00 * right.M30 + left.M10 * right.M31 + left.M20 * right.M32,
                left.M01 * right.M30 + left.M11 * right.M31 + left.M21 * right.M32,
                left.M02 * right.M30 + left.M12 * right.M31 + left.M22 * right.M32
            );
        }
        
        public static Vector3 operator *(Matrix3 m, Vector3 v)
        {
            return new Vector3(
                m.M00 * v.X + m.M10 * v.Y + m.M20 * v.Z,
                m.M01 * v.X + m.M11 * v.Y + m.M21 * v.Z,
                m.M02 * v.X + m.M12 * v.Y + m.M22 * v.Z
            );
        }
        
        public Matrix3 Transpose
        {
            get {
                return new Matrix3(
                    M00, M10, M20, 
                    M01, M11, M21, 
                    M02, M12, M22
                );
            }
        }
        
        public float Determinant
        {
            get {
                return M00 * M11 * M22 + M01 * M12 * M20 + M02 * M10 * M21 - M21 * M12 * M00 - M22 * M10 * M01 - M20 * M11 * M02;
            }
        }
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Matrix3x4 : System.IEquatable<Matrix3x4>
    {
        public readonly float M00;
        public readonly float M01;
        public readonly float M02;
        public readonly float M03;
        public readonly float M10;
        public readonly float M11;
        public readonly float M12;
        public readonly float M13;
        public readonly float M20;
        public readonly float M21;
        public readonly float M22;
        public readonly float M23;
        
        public Vector4 Column0 { get { return new Vector4(M00, M01, M02, M03); } }
        public Vector4 Column1 { get { return new Vector4(M10, M11, M12, M13); } }
        public Vector4 Column2 { get { return new Vector4(M20, M21, M22, M23); } }
        
        public Vector3 Row0 { get { return new Vector3(M00, M10, M20); } }
        public Vector3 Row1 { get { return new Vector3(M01, M11, M21); } }
        public Vector3 Row2 { get { return new Vector3(M02, M12, M22); } }
        public Vector3 Row3 { get { return new Vector3(M03, M13, M23); } }
        
        public Matrix3x4(Vector4 column0, Vector4 column1, Vector4 column2)
        {
            M00 = column0.X;
            M01 = column0.Y;
            M02 = column0.Z;
            M03 = column0.W;
            M10 = column1.X;
            M11 = column1.Y;
            M12 = column1.Z;
            M13 = column1.W;
            M20 = column2.X;
            M21 = column2.Y;
            M22 = column2.Z;
            M23 = column2.W;
        }
        
        public Matrix3x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23)
        {
            M00 = m00;
            M01 = m01;
            M02 = m02;
            M03 = m03;
            M10 = m10;
            M11 = m11;
            M12 = m12;
            M13 = m13;
            M20 = m20;
            M21 = m21;
            M22 = m22;
            M23 = m23;
        }
        
        public static bool operator ==(Matrix3x4 a, Matrix3x4 b)
        {
            return a.M00 == b.M00 && a.M01 == b.M01 && a.M02 == b.M02 && a.M03 == b.M03 && a.M10 == b.M10 && a.M11 == b.M11 && a.M12 == b.M12 && a.M13 == b.M13 && a.M20 == b.M20 && a.M21 == b.M21 && a.M22 == b.M22 && a.M23 == b.M23;
        }
        
        public static bool operator !=(Matrix3x4 a, Matrix3x4 b)
        {
            return a.M00 != b.M00 || a.M01 != b.M01 || a.M02 != b.M02 || a.M03 != b.M03 || a.M10 != b.M10 || a.M11 != b.M11 || a.M12 != b.M12 || a.M13 != b.M13 || a.M20 != b.M20 || a.M21 != b.M21 || a.M22 != b.M22 || a.M23 != b.M23;
        }
        
        public bool Equals(Matrix3x4 other)
        {
            return M00 == other.M00 && M01 == other.M01 && M02 == other.M02 && M03 == other.M03 && M10 == other.M10 && M11 == other.M11 && M12 == other.M12 && M13 == other.M13 && M20 == other.M20 && M21 == other.M21 && M22 == other.M22 && M23 == other.M23;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Matrix3x4)) return false;
            var m = (Matrix3x4)other;
            return M00 == m.M00 && M01 == m.M01 && M02 == m.M02 && M03 == m.M03 && M10 == m.M10 && M11 == m.M11 && M12 == m.M12 && M13 == m.M13 && M20 == m.M20 && M21 == m.M21 && M22 == m.M22 && M23 == m.M23;
        }
        
        public override int GetHashCode()
        {
            return M00.GetHashCode() ^ M01.GetHashCode() ^ M02.GetHashCode() ^ M03.GetHashCode() ^ M10.GetHashCode() ^ M11.GetHashCode() ^ M12.GetHashCode() ^ M13.GetHashCode() ^ M20.GetHashCode() ^ M21.GetHashCode() ^ M22.GetHashCode() ^ M23.GetHashCode();
        }
        
        public override string ToString()
        {
            return "[" + M00.ToString() + M01.ToString() + M02.ToString() + M03.ToString() + "]"
             + "[" + M10.ToString() + M11.ToString() + M12.ToString() + M13.ToString() + "]"
             + "[" + M20.ToString() + M21.ToString() + M22.ToString() + M23.ToString() + "]"
            ;
        }
        
        public static Matrix2x4 operator *(Matrix3x4 left, Matrix2x3 right)
        {
            return new Matrix2x4(
                left.M00 * right.M00 + left.M10 * right.M01 + left.M20 * right.M02,
                left.M01 * right.M00 + left.M11 * right.M01 + left.M21 * right.M02,
                left.M02 * right.M00 + left.M12 * right.M01 + left.M22 * right.M02,
                left.M03 * right.M00 + left.M13 * right.M01 + left.M23 * right.M02,
                left.M00 * right.M10 + left.M10 * right.M11 + left.M20 * right.M12,
                left.M01 * right.M10 + left.M11 * right.M11 + left.M21 * right.M12,
                left.M02 * right.M10 + left.M12 * right.M11 + left.M22 * right.M12,
                left.M03 * right.M10 + left.M13 * right.M11 + left.M23 * right.M12
            );
        }
        
        public static Matrix3x4 operator *(Matrix3x4 left, Matrix3 right)
        {
            return new Matrix3x4(
                left.M00 * right.M00 + left.M10 * right.M01 + left.M20 * right.M02,
                left.M01 * right.M00 + left.M11 * right.M01 + left.M21 * right.M02,
                left.M02 * right.M00 + left.M12 * right.M01 + left.M22 * right.M02,
                left.M03 * right.M00 + left.M13 * right.M01 + left.M23 * right.M02,
                left.M00 * right.M10 + left.M10 * right.M11 + left.M20 * right.M12,
                left.M01 * right.M10 + left.M11 * right.M11 + left.M21 * right.M12,
                left.M02 * right.M10 + left.M12 * right.M11 + left.M22 * right.M12,
                left.M03 * right.M10 + left.M13 * right.M11 + left.M23 * right.M12,
                left.M00 * right.M20 + left.M10 * right.M21 + left.M20 * right.M22,
                left.M01 * right.M20 + left.M11 * right.M21 + left.M21 * right.M22,
                left.M02 * right.M20 + left.M12 * right.M21 + left.M22 * right.M22,
                left.M03 * right.M20 + left.M13 * right.M21 + left.M23 * right.M22
            );
        }
        
        public static Matrix4 operator *(Matrix3x4 left, Matrix4x3 right)
        {
            return new Matrix4(
                left.M00 * right.M00 + left.M10 * right.M01 + left.M20 * right.M02,
                left.M01 * right.M00 + left.M11 * right.M01 + left.M21 * right.M02,
                left.M02 * right.M00 + left.M12 * right.M01 + left.M22 * right.M02,
                left.M03 * right.M00 + left.M13 * right.M01 + left.M23 * right.M02,
                left.M00 * right.M10 + left.M10 * right.M11 + left.M20 * right.M12,
                left.M01 * right.M10 + left.M11 * right.M11 + left.M21 * right.M12,
                left.M02 * right.M10 + left.M12 * right.M11 + left.M22 * right.M12,
                left.M03 * right.M10 + left.M13 * right.M11 + left.M23 * right.M12,
                left.M00 * right.M20 + left.M10 * right.M21 + left.M20 * right.M22,
                left.M01 * right.M20 + left.M11 * right.M21 + left.M21 * right.M22,
                left.M02 * right.M20 + left.M12 * right.M21 + left.M22 * right.M22,
                left.M03 * right.M20 + left.M13 * right.M21 + left.M23 * right.M22,
                left.M00 * right.M30 + left.M10 * right.M31 + left.M20 * right.M32,
                left.M01 * right.M30 + left.M11 * right.M31 + left.M21 * right.M32,
                left.M02 * right.M30 + left.M12 * right.M31 + left.M22 * right.M32,
                left.M03 * right.M30 + left.M13 * right.M31 + left.M23 * right.M32
            );
        }
        
        public static Vector4 operator *(Matrix3x4 m, Vector3 v)
        {
            return new Vector4(
                m.M00 * v.X + m.M10 * v.Y + m.M20 * v.Z,
                m.M01 * v.X + m.M11 * v.Y + m.M21 * v.Z,
                m.M02 * v.X + m.M12 * v.Y + m.M22 * v.Z,
                m.M03 * v.X + m.M13 * v.Y + m.M23 * v.Z
            );
        }
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Matrix4x2 : System.IEquatable<Matrix4x2>
    {
        public readonly float M00;
        public readonly float M01;
        public readonly float M10;
        public readonly float M11;
        public readonly float M20;
        public readonly float M21;
        public readonly float M30;
        public readonly float M31;
        
        public Vector2 Column0 { get { return new Vector2(M00, M01); } }
        public Vector2 Column1 { get { return new Vector2(M10, M11); } }
        public Vector2 Column2 { get { return new Vector2(M20, M21); } }
        public Vector2 Column3 { get { return new Vector2(M30, M31); } }
        
        public Vector4 Row0 { get { return new Vector4(M00, M10, M20, M30); } }
        public Vector4 Row1 { get { return new Vector4(M01, M11, M21, M31); } }
        
        public Matrix4x2(Vector2 column0, Vector2 column1, Vector2 column2, Vector2 column3)
        {
            M00 = column0.X;
            M01 = column0.Y;
            M10 = column1.X;
            M11 = column1.Y;
            M20 = column2.X;
            M21 = column2.Y;
            M30 = column3.X;
            M31 = column3.Y;
        }
        
        public Matrix4x2(float m00, float m01, float m10, float m11, float m20, float m21, float m30, float m31)
        {
            M00 = m00;
            M01 = m01;
            M10 = m10;
            M11 = m11;
            M20 = m20;
            M21 = m21;
            M30 = m30;
            M31 = m31;
        }
        
        public static bool operator ==(Matrix4x2 a, Matrix4x2 b)
        {
            return a.M00 == b.M00 && a.M01 == b.M01 && a.M10 == b.M10 && a.M11 == b.M11 && a.M20 == b.M20 && a.M21 == b.M21 && a.M30 == b.M30 && a.M31 == b.M31;
        }
        
        public static bool operator !=(Matrix4x2 a, Matrix4x2 b)
        {
            return a.M00 != b.M00 || a.M01 != b.M01 || a.M10 != b.M10 || a.M11 != b.M11 || a.M20 != b.M20 || a.M21 != b.M21 || a.M30 != b.M30 || a.M31 != b.M31;
        }
        
        public bool Equals(Matrix4x2 other)
        {
            return M00 == other.M00 && M01 == other.M01 && M10 == other.M10 && M11 == other.M11 && M20 == other.M20 && M21 == other.M21 && M30 == other.M30 && M31 == other.M31;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Matrix4x2)) return false;
            var m = (Matrix4x2)other;
            return M00 == m.M00 && M01 == m.M01 && M10 == m.M10 && M11 == m.M11 && M20 == m.M20 && M21 == m.M21 && M30 == m.M30 && M31 == m.M31;
        }
        
        public override int GetHashCode()
        {
            return M00.GetHashCode() ^ M01.GetHashCode() ^ M10.GetHashCode() ^ M11.GetHashCode() ^ M20.GetHashCode() ^ M21.GetHashCode() ^ M30.GetHashCode() ^ M31.GetHashCode();
        }
        
        public override string ToString()
        {
            return "[" + M00.ToString() + M01.ToString() + "]"
             + "[" + M10.ToString() + M11.ToString() + "]"
             + "[" + M20.ToString() + M21.ToString() + "]"
             + "[" + M30.ToString() + M31.ToString() + "]"
            ;
        }
        
        public static Matrix2 operator *(Matrix4x2 left, Matrix2x4 right)
        {
            return new Matrix2(
                left.M00 * right.M00 + left.M10 * right.M01 + left.M20 * right.M02 + left.M30 * right.M03,
                left.M01 * right.M00 + left.M11 * right.M01 + left.M21 * right.M02 + left.M31 * right.M03,
                left.M00 * right.M10 + left.M10 * right.M11 + left.M20 * right.M12 + left.M30 * right.M13,
                left.M01 * right.M10 + left.M11 * right.M11 + left.M21 * right.M12 + left.M31 * right.M13
            );
        }
        
        public static Matrix3x2 operator *(Matrix4x2 left, Matrix3x4 right)
        {
            return new Matrix3x2(
                left.M00 * right.M00 + left.M10 * right.M01 + left.M20 * right.M02 + left.M30 * right.M03,
                left.M01 * right.M00 + left.M11 * right.M01 + left.M21 * right.M02 + left.M31 * right.M03,
                left.M00 * right.M10 + left.M10 * right.M11 + left.M20 * right.M12 + left.M30 * right.M13,
                left.M01 * right.M10 + left.M11 * right.M11 + left.M21 * right.M12 + left.M31 * right.M13,
                left.M00 * right.M20 + left.M10 * right.M21 + left.M20 * right.M22 + left.M30 * right.M23,
                left.M01 * right.M20 + left.M11 * right.M21 + left.M21 * right.M22 + left.M31 * right.M23
            );
        }
        
        public static Matrix4x2 operator *(Matrix4x2 left, Matrix4 right)
        {
            return new Matrix4x2(
                left.M00 * right.M00 + left.M10 * right.M01 + left.M20 * right.M02 + left.M30 * right.M03,
                left.M01 * right.M00 + left.M11 * right.M01 + left.M21 * right.M02 + left.M31 * right.M03,
                left.M00 * right.M10 + left.M10 * right.M11 + left.M20 * right.M12 + left.M30 * right.M13,
                left.M01 * right.M10 + left.M11 * right.M11 + left.M21 * right.M12 + left.M31 * right.M13,
                left.M00 * right.M20 + left.M10 * right.M21 + left.M20 * right.M22 + left.M30 * right.M23,
                left.M01 * right.M20 + left.M11 * right.M21 + left.M21 * right.M22 + left.M31 * right.M23,
                left.M00 * right.M30 + left.M10 * right.M31 + left.M20 * right.M32 + left.M30 * right.M33,
                left.M01 * right.M30 + left.M11 * right.M31 + left.M21 * right.M32 + left.M31 * right.M33
            );
        }
        
        public static Vector2 operator *(Matrix4x2 m, Vector4 v)
        {
            return new Vector2(
                m.M00 * v.X + m.M10 * v.Y + m.M20 * v.Z + m.M30 * v.W,
                m.M01 * v.X + m.M11 * v.Y + m.M21 * v.Z + m.M31 * v.W
            );
        }
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Matrix4x3 : System.IEquatable<Matrix4x3>
    {
        public readonly float M00;
        public readonly float M01;
        public readonly float M02;
        public readonly float M10;
        public readonly float M11;
        public readonly float M12;
        public readonly float M20;
        public readonly float M21;
        public readonly float M22;
        public readonly float M30;
        public readonly float M31;
        public readonly float M32;
        
        public Vector3 Column0 { get { return new Vector3(M00, M01, M02); } }
        public Vector3 Column1 { get { return new Vector3(M10, M11, M12); } }
        public Vector3 Column2 { get { return new Vector3(M20, M21, M22); } }
        public Vector3 Column3 { get { return new Vector3(M30, M31, M32); } }
        
        public Vector4 Row0 { get { return new Vector4(M00, M10, M20, M30); } }
        public Vector4 Row1 { get { return new Vector4(M01, M11, M21, M31); } }
        public Vector4 Row2 { get { return new Vector4(M02, M12, M22, M32); } }
        
        public Matrix4x3(Vector3 column0, Vector3 column1, Vector3 column2, Vector3 column3)
        {
            M00 = column0.X;
            M01 = column0.Y;
            M02 = column0.Z;
            M10 = column1.X;
            M11 = column1.Y;
            M12 = column1.Z;
            M20 = column2.X;
            M21 = column2.Y;
            M22 = column2.Z;
            M30 = column3.X;
            M31 = column3.Y;
            M32 = column3.Z;
        }
        
        public Matrix4x3(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22, float m30, float m31, float m32)
        {
            M00 = m00;
            M01 = m01;
            M02 = m02;
            M10 = m10;
            M11 = m11;
            M12 = m12;
            M20 = m20;
            M21 = m21;
            M22 = m22;
            M30 = m30;
            M31 = m31;
            M32 = m32;
        }
        
        public static bool operator ==(Matrix4x3 a, Matrix4x3 b)
        {
            return a.M00 == b.M00 && a.M01 == b.M01 && a.M02 == b.M02 && a.M10 == b.M10 && a.M11 == b.M11 && a.M12 == b.M12 && a.M20 == b.M20 && a.M21 == b.M21 && a.M22 == b.M22 && a.M30 == b.M30 && a.M31 == b.M31 && a.M32 == b.M32;
        }
        
        public static bool operator !=(Matrix4x3 a, Matrix4x3 b)
        {
            return a.M00 != b.M00 || a.M01 != b.M01 || a.M02 != b.M02 || a.M10 != b.M10 || a.M11 != b.M11 || a.M12 != b.M12 || a.M20 != b.M20 || a.M21 != b.M21 || a.M22 != b.M22 || a.M30 != b.M30 || a.M31 != b.M31 || a.M32 != b.M32;
        }
        
        public bool Equals(Matrix4x3 other)
        {
            return M00 == other.M00 && M01 == other.M01 && M02 == other.M02 && M10 == other.M10 && M11 == other.M11 && M12 == other.M12 && M20 == other.M20 && M21 == other.M21 && M22 == other.M22 && M30 == other.M30 && M31 == other.M31 && M32 == other.M32;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Matrix4x3)) return false;
            var m = (Matrix4x3)other;
            return M00 == m.M00 && M01 == m.M01 && M02 == m.M02 && M10 == m.M10 && M11 == m.M11 && M12 == m.M12 && M20 == m.M20 && M21 == m.M21 && M22 == m.M22 && M30 == m.M30 && M31 == m.M31 && M32 == m.M32;
        }
        
        public override int GetHashCode()
        {
            return M00.GetHashCode() ^ M01.GetHashCode() ^ M02.GetHashCode() ^ M10.GetHashCode() ^ M11.GetHashCode() ^ M12.GetHashCode() ^ M20.GetHashCode() ^ M21.GetHashCode() ^ M22.GetHashCode() ^ M30.GetHashCode() ^ M31.GetHashCode() ^ M32.GetHashCode();
        }
        
        public override string ToString()
        {
            return "[" + M00.ToString() + M01.ToString() + M02.ToString() + "]"
             + "[" + M10.ToString() + M11.ToString() + M12.ToString() + "]"
             + "[" + M20.ToString() + M21.ToString() + M22.ToString() + "]"
             + "[" + M30.ToString() + M31.ToString() + M32.ToString() + "]"
            ;
        }
        
        public static Matrix2x3 operator *(Matrix4x3 left, Matrix2x4 right)
        {
            return new Matrix2x3(
                left.M00 * right.M00 + left.M10 * right.M01 + left.M20 * right.M02 + left.M30 * right.M03,
                left.M01 * right.M00 + left.M11 * right.M01 + left.M21 * right.M02 + left.M31 * right.M03,
                left.M02 * right.M00 + left.M12 * right.M01 + left.M22 * right.M02 + left.M32 * right.M03,
                left.M00 * right.M10 + left.M10 * right.M11 + left.M20 * right.M12 + left.M30 * right.M13,
                left.M01 * right.M10 + left.M11 * right.M11 + left.M21 * right.M12 + left.M31 * right.M13,
                left.M02 * right.M10 + left.M12 * right.M11 + left.M22 * right.M12 + left.M32 * right.M13
            );
        }
        
        public static Matrix3 operator *(Matrix4x3 left, Matrix3x4 right)
        {
            return new Matrix3(
                left.M00 * right.M00 + left.M10 * right.M01 + left.M20 * right.M02 + left.M30 * right.M03,
                left.M01 * right.M00 + left.M11 * right.M01 + left.M21 * right.M02 + left.M31 * right.M03,
                left.M02 * right.M00 + left.M12 * right.M01 + left.M22 * right.M02 + left.M32 * right.M03,
                left.M00 * right.M10 + left.M10 * right.M11 + left.M20 * right.M12 + left.M30 * right.M13,
                left.M01 * right.M10 + left.M11 * right.M11 + left.M21 * right.M12 + left.M31 * right.M13,
                left.M02 * right.M10 + left.M12 * right.M11 + left.M22 * right.M12 + left.M32 * right.M13,
                left.M00 * right.M20 + left.M10 * right.M21 + left.M20 * right.M22 + left.M30 * right.M23,
                left.M01 * right.M20 + left.M11 * right.M21 + left.M21 * right.M22 + left.M31 * right.M23,
                left.M02 * right.M20 + left.M12 * right.M21 + left.M22 * right.M22 + left.M32 * right.M23
            );
        }
        
        public static Matrix4x3 operator *(Matrix4x3 left, Matrix4 right)
        {
            return new Matrix4x3(
                left.M00 * right.M00 + left.M10 * right.M01 + left.M20 * right.M02 + left.M30 * right.M03,
                left.M01 * right.M00 + left.M11 * right.M01 + left.M21 * right.M02 + left.M31 * right.M03,
                left.M02 * right.M00 + left.M12 * right.M01 + left.M22 * right.M02 + left.M32 * right.M03,
                left.M00 * right.M10 + left.M10 * right.M11 + left.M20 * right.M12 + left.M30 * right.M13,
                left.M01 * right.M10 + left.M11 * right.M11 + left.M21 * right.M12 + left.M31 * right.M13,
                left.M02 * right.M10 + left.M12 * right.M11 + left.M22 * right.M12 + left.M32 * right.M13,
                left.M00 * right.M20 + left.M10 * right.M21 + left.M20 * right.M22 + left.M30 * right.M23,
                left.M01 * right.M20 + left.M11 * right.M21 + left.M21 * right.M22 + left.M31 * right.M23,
                left.M02 * right.M20 + left.M12 * right.M21 + left.M22 * right.M22 + left.M32 * right.M23,
                left.M00 * right.M30 + left.M10 * right.M31 + left.M20 * right.M32 + left.M30 * right.M33,
                left.M01 * right.M30 + left.M11 * right.M31 + left.M21 * right.M32 + left.M31 * right.M33,
                left.M02 * right.M30 + left.M12 * right.M31 + left.M22 * right.M32 + left.M32 * right.M33
            );
        }
        
        public static Vector3 operator *(Matrix4x3 m, Vector4 v)
        {
            return new Vector3(
                m.M00 * v.X + m.M10 * v.Y + m.M20 * v.Z + m.M30 * v.W,
                m.M01 * v.X + m.M11 * v.Y + m.M21 * v.Z + m.M31 * v.W,
                m.M02 * v.X + m.M12 * v.Y + m.M22 * v.Z + m.M32 * v.W
            );
        }
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Matrix4 : System.IEquatable<Matrix4>
    {
        public readonly float M00;
        public readonly float M01;
        public readonly float M02;
        public readonly float M03;
        public readonly float M10;
        public readonly float M11;
        public readonly float M12;
        public readonly float M13;
        public readonly float M20;
        public readonly float M21;
        public readonly float M22;
        public readonly float M23;
        public readonly float M30;
        public readonly float M31;
        public readonly float M32;
        public readonly float M33;
        
        public Vector4 Column0 { get { return new Vector4(M00, M01, M02, M03); } }
        public Vector4 Column1 { get { return new Vector4(M10, M11, M12, M13); } }
        public Vector4 Column2 { get { return new Vector4(M20, M21, M22, M23); } }
        public Vector4 Column3 { get { return new Vector4(M30, M31, M32, M33); } }
        
        public Vector4 Row0 { get { return new Vector4(M00, M10, M20, M30); } }
        public Vector4 Row1 { get { return new Vector4(M01, M11, M21, M31); } }
        public Vector4 Row2 { get { return new Vector4(M02, M12, M22, M32); } }
        public Vector4 Row3 { get { return new Vector4(M03, M13, M23, M33); } }
        
        public Matrix4(Vector4 column0, Vector4 column1, Vector4 column2, Vector4 column3)
        {
            M00 = column0.X;
            M01 = column0.Y;
            M02 = column0.Z;
            M03 = column0.W;
            M10 = column1.X;
            M11 = column1.Y;
            M12 = column1.Z;
            M13 = column1.W;
            M20 = column2.X;
            M21 = column2.Y;
            M22 = column2.Z;
            M23 = column2.W;
            M30 = column3.X;
            M31 = column3.Y;
            M32 = column3.Z;
            M33 = column3.W;
        }
        
        public Matrix4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23, float m30, float m31, float m32, float m33)
        {
            M00 = m00;
            M01 = m01;
            M02 = m02;
            M03 = m03;
            M10 = m10;
            M11 = m11;
            M12 = m12;
            M13 = m13;
            M20 = m20;
            M21 = m21;
            M22 = m22;
            M23 = m23;
            M30 = m30;
            M31 = m31;
            M32 = m32;
            M33 = m33;
        }
        
        public static bool operator ==(Matrix4 a, Matrix4 b)
        {
            return a.M00 == b.M00 && a.M01 == b.M01 && a.M02 == b.M02 && a.M03 == b.M03 && a.M10 == b.M10 && a.M11 == b.M11 && a.M12 == b.M12 && a.M13 == b.M13 && a.M20 == b.M20 && a.M21 == b.M21 && a.M22 == b.M22 && a.M23 == b.M23 && a.M30 == b.M30 && a.M31 == b.M31 && a.M32 == b.M32 && a.M33 == b.M33;
        }
        
        public static bool operator !=(Matrix4 a, Matrix4 b)
        {
            return a.M00 != b.M00 || a.M01 != b.M01 || a.M02 != b.M02 || a.M03 != b.M03 || a.M10 != b.M10 || a.M11 != b.M11 || a.M12 != b.M12 || a.M13 != b.M13 || a.M20 != b.M20 || a.M21 != b.M21 || a.M22 != b.M22 || a.M23 != b.M23 || a.M30 != b.M30 || a.M31 != b.M31 || a.M32 != b.M32 || a.M33 != b.M33;
        }
        
        public bool Equals(Matrix4 other)
        {
            return M00 == other.M00 && M01 == other.M01 && M02 == other.M02 && M03 == other.M03 && M10 == other.M10 && M11 == other.M11 && M12 == other.M12 && M13 == other.M13 && M20 == other.M20 && M21 == other.M21 && M22 == other.M22 && M23 == other.M23 && M30 == other.M30 && M31 == other.M31 && M32 == other.M32 && M33 == other.M33;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Matrix4)) return false;
            var m = (Matrix4)other;
            return M00 == m.M00 && M01 == m.M01 && M02 == m.M02 && M03 == m.M03 && M10 == m.M10 && M11 == m.M11 && M12 == m.M12 && M13 == m.M13 && M20 == m.M20 && M21 == m.M21 && M22 == m.M22 && M23 == m.M23 && M30 == m.M30 && M31 == m.M31 && M32 == m.M32 && M33 == m.M33;
        }
        
        public override int GetHashCode()
        {
            return M00.GetHashCode() ^ M01.GetHashCode() ^ M02.GetHashCode() ^ M03.GetHashCode() ^ M10.GetHashCode() ^ M11.GetHashCode() ^ M12.GetHashCode() ^ M13.GetHashCode() ^ M20.GetHashCode() ^ M21.GetHashCode() ^ M22.GetHashCode() ^ M23.GetHashCode() ^ M30.GetHashCode() ^ M31.GetHashCode() ^ M32.GetHashCode() ^ M33.GetHashCode();
        }
        
        public override string ToString()
        {
            return "[" + M00.ToString() + M01.ToString() + M02.ToString() + M03.ToString() + "]"
             + "[" + M10.ToString() + M11.ToString() + M12.ToString() + M13.ToString() + "]"
             + "[" + M20.ToString() + M21.ToString() + M22.ToString() + M23.ToString() + "]"
             + "[" + M30.ToString() + M31.ToString() + M32.ToString() + M33.ToString() + "]"
            ;
        }
        
        public static readonly Matrix4 Identity = new Matrix4(Vector4.UnitX, Vector4.UnitY, Vector4.UnitZ, Vector4.UnitW);
        
        public static Matrix2x4 operator *(Matrix4 left, Matrix2x4 right)
        {
            return new Matrix2x4(
                left.M00 * right.M00 + left.M10 * right.M01 + left.M20 * right.M02 + left.M30 * right.M03,
                left.M01 * right.M00 + left.M11 * right.M01 + left.M21 * right.M02 + left.M31 * right.M03,
                left.M02 * right.M00 + left.M12 * right.M01 + left.M22 * right.M02 + left.M32 * right.M03,
                left.M03 * right.M00 + left.M13 * right.M01 + left.M23 * right.M02 + left.M33 * right.M03,
                left.M00 * right.M10 + left.M10 * right.M11 + left.M20 * right.M12 + left.M30 * right.M13,
                left.M01 * right.M10 + left.M11 * right.M11 + left.M21 * right.M12 + left.M31 * right.M13,
                left.M02 * right.M10 + left.M12 * right.M11 + left.M22 * right.M12 + left.M32 * right.M13,
                left.M03 * right.M10 + left.M13 * right.M11 + left.M23 * right.M12 + left.M33 * right.M13
            );
        }
        
        public static Matrix3x4 operator *(Matrix4 left, Matrix3x4 right)
        {
            return new Matrix3x4(
                left.M00 * right.M00 + left.M10 * right.M01 + left.M20 * right.M02 + left.M30 * right.M03,
                left.M01 * right.M00 + left.M11 * right.M01 + left.M21 * right.M02 + left.M31 * right.M03,
                left.M02 * right.M00 + left.M12 * right.M01 + left.M22 * right.M02 + left.M32 * right.M03,
                left.M03 * right.M00 + left.M13 * right.M01 + left.M23 * right.M02 + left.M33 * right.M03,
                left.M00 * right.M10 + left.M10 * right.M11 + left.M20 * right.M12 + left.M30 * right.M13,
                left.M01 * right.M10 + left.M11 * right.M11 + left.M21 * right.M12 + left.M31 * right.M13,
                left.M02 * right.M10 + left.M12 * right.M11 + left.M22 * right.M12 + left.M32 * right.M13,
                left.M03 * right.M10 + left.M13 * right.M11 + left.M23 * right.M12 + left.M33 * right.M13,
                left.M00 * right.M20 + left.M10 * right.M21 + left.M20 * right.M22 + left.M30 * right.M23,
                left.M01 * right.M20 + left.M11 * right.M21 + left.M21 * right.M22 + left.M31 * right.M23,
                left.M02 * right.M20 + left.M12 * right.M21 + left.M22 * right.M22 + left.M32 * right.M23,
                left.M03 * right.M20 + left.M13 * right.M21 + left.M23 * right.M22 + left.M33 * right.M23
            );
        }
        
        public static Matrix4 operator *(Matrix4 left, Matrix4 right)
        {
            return new Matrix4(
                left.M00 * right.M00 + left.M10 * right.M01 + left.M20 * right.M02 + left.M30 * right.M03,
                left.M01 * right.M00 + left.M11 * right.M01 + left.M21 * right.M02 + left.M31 * right.M03,
                left.M02 * right.M00 + left.M12 * right.M01 + left.M22 * right.M02 + left.M32 * right.M03,
                left.M03 * right.M00 + left.M13 * right.M01 + left.M23 * right.M02 + left.M33 * right.M03,
                left.M00 * right.M10 + left.M10 * right.M11 + left.M20 * right.M12 + left.M30 * right.M13,
                left.M01 * right.M10 + left.M11 * right.M11 + left.M21 * right.M12 + left.M31 * right.M13,
                left.M02 * right.M10 + left.M12 * right.M11 + left.M22 * right.M12 + left.M32 * right.M13,
                left.M03 * right.M10 + left.M13 * right.M11 + left.M23 * right.M12 + left.M33 * right.M13,
                left.M00 * right.M20 + left.M10 * right.M21 + left.M20 * right.M22 + left.M30 * right.M23,
                left.M01 * right.M20 + left.M11 * right.M21 + left.M21 * right.M22 + left.M31 * right.M23,
                left.M02 * right.M20 + left.M12 * right.M21 + left.M22 * right.M22 + left.M32 * right.M23,
                left.M03 * right.M20 + left.M13 * right.M21 + left.M23 * right.M22 + left.M33 * right.M23,
                left.M00 * right.M30 + left.M10 * right.M31 + left.M20 * right.M32 + left.M30 * right.M33,
                left.M01 * right.M30 + left.M11 * right.M31 + left.M21 * right.M32 + left.M31 * right.M33,
                left.M02 * right.M30 + left.M12 * right.M31 + left.M22 * right.M32 + left.M32 * right.M33,
                left.M03 * right.M30 + left.M13 * right.M31 + left.M23 * right.M32 + left.M33 * right.M33
            );
        }
        
        public static Vector4 operator *(Matrix4 m, Vector4 v)
        {
            return new Vector4(
                m.M00 * v.X + m.M10 * v.Y + m.M20 * v.Z + m.M30 * v.W,
                m.M01 * v.X + m.M11 * v.Y + m.M21 * v.Z + m.M31 * v.W,
                m.M02 * v.X + m.M12 * v.Y + m.M22 * v.Z + m.M32 * v.W,
                m.M03 * v.X + m.M13 * v.Y + m.M23 * v.Z + m.M33 * v.W
            );
        }
        
        public Matrix4 Transpose
        {
            get {
                return new Matrix4(
                    M00, M10, M20, M30, 
                    M01, M11, M21, M31, 
                    M02, M12, M22, M32, 
                    M03, M13, M23, M33
                );
            }
        }
        
        public float Determinant
        {
            get {
                return M00 * M11 * M22 * M33 + M01 * M12 * M23 * M30 + M02 * M13 * M20 * M31 + M03 * M10 * M21 * M32 - M31 * M22 * M13 * M00 - M32 * M23 * M10 * M01 - M33 * M20 * M11 * M02 - M30 * M21 * M12 * M03;
            }
        }
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Matrix2d : System.IEquatable<Matrix2d>
    {
        public readonly double M00;
        public readonly double M01;
        public readonly double M10;
        public readonly double M11;
        
        public Vector2d Column0 { get { return new Vector2d(M00, M01); } }
        public Vector2d Column1 { get { return new Vector2d(M10, M11); } }
        
        public Vector2d Row0 { get { return new Vector2d(M00, M10); } }
        public Vector2d Row1 { get { return new Vector2d(M01, M11); } }
        
        public Matrix2d(Vector2d column0, Vector2d column1)
        {
            M00 = column0.X;
            M01 = column0.Y;
            M10 = column1.X;
            M11 = column1.Y;
        }
        
        public Matrix2d(double m00, double m01, double m10, double m11)
        {
            M00 = m00;
            M01 = m01;
            M10 = m10;
            M11 = m11;
        }
        
        public static bool operator ==(Matrix2d a, Matrix2d b)
        {
            return a.M00 == b.M00 && a.M01 == b.M01 && a.M10 == b.M10 && a.M11 == b.M11;
        }
        
        public static bool operator !=(Matrix2d a, Matrix2d b)
        {
            return a.M00 != b.M00 || a.M01 != b.M01 || a.M10 != b.M10 || a.M11 != b.M11;
        }
        
        public bool Equals(Matrix2d other)
        {
            return M00 == other.M00 && M01 == other.M01 && M10 == other.M10 && M11 == other.M11;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Matrix2d)) return false;
            var m = (Matrix2d)other;
            return M00 == m.M00 && M01 == m.M01 && M10 == m.M10 && M11 == m.M11;
        }
        
        public override int GetHashCode()
        {
            return M00.GetHashCode() ^ M01.GetHashCode() ^ M10.GetHashCode() ^ M11.GetHashCode();
        }
        
        public override string ToString()
        {
            return "[" + M00.ToString() + M01.ToString() + "]"
             + "[" + M10.ToString() + M11.ToString() + "]"
            ;
        }
        
        public static readonly Matrix2d Identity = new Matrix2d(Vector2d.UnitX, Vector2d.UnitY);
        
        public static Matrix2d operator *(Matrix2d left, Matrix2d right)
        {
            return new Matrix2d(
                left.M00 * right.M00 + left.M10 * right.M01,
                left.M01 * right.M00 + left.M11 * right.M01,
                left.M00 * right.M10 + left.M10 * right.M11,
                left.M01 * right.M10 + left.M11 * right.M11
            );
        }
        
        public static Matrix3x2d operator *(Matrix2d left, Matrix3x2d right)
        {
            return new Matrix3x2d(
                left.M00 * right.M00 + left.M10 * right.M01,
                left.M01 * right.M00 + left.M11 * right.M01,
                left.M00 * right.M10 + left.M10 * right.M11,
                left.M01 * right.M10 + left.M11 * right.M11,
                left.M00 * right.M20 + left.M10 * right.M21,
                left.M01 * right.M20 + left.M11 * right.M21
            );
        }
        
        public static Matrix4x2d operator *(Matrix2d left, Matrix4x2d right)
        {
            return new Matrix4x2d(
                left.M00 * right.M00 + left.M10 * right.M01,
                left.M01 * right.M00 + left.M11 * right.M01,
                left.M00 * right.M10 + left.M10 * right.M11,
                left.M01 * right.M10 + left.M11 * right.M11,
                left.M00 * right.M20 + left.M10 * right.M21,
                left.M01 * right.M20 + left.M11 * right.M21,
                left.M00 * right.M30 + left.M10 * right.M31,
                left.M01 * right.M30 + left.M11 * right.M31
            );
        }
        
        public static Vector2d operator *(Matrix2d m, Vector2d v)
        {
            return new Vector2d(
                m.M00 * v.X + m.M10 * v.Y,
                m.M01 * v.X + m.M11 * v.Y
            );
        }
        
        public Matrix2d Transpose
        {
            get {
                return new Matrix2d(
                    M00, M10, 
                    M01, M11
                );
            }
        }
        
        public double Determinant
        {
            get {
                return M00 * M11 + M01 * M10 - M11 * M00 - M10 * M01;
            }
        }
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Matrix2x3d : System.IEquatable<Matrix2x3d>
    {
        public readonly double M00;
        public readonly double M01;
        public readonly double M02;
        public readonly double M10;
        public readonly double M11;
        public readonly double M12;
        
        public Vector3d Column0 { get { return new Vector3d(M00, M01, M02); } }
        public Vector3d Column1 { get { return new Vector3d(M10, M11, M12); } }
        
        public Vector2d Row0 { get { return new Vector2d(M00, M10); } }
        public Vector2d Row1 { get { return new Vector2d(M01, M11); } }
        public Vector2d Row2 { get { return new Vector2d(M02, M12); } }
        
        public Matrix2x3d(Vector3d column0, Vector3d column1)
        {
            M00 = column0.X;
            M01 = column0.Y;
            M02 = column0.Z;
            M10 = column1.X;
            M11 = column1.Y;
            M12 = column1.Z;
        }
        
        public Matrix2x3d(double m00, double m01, double m02, double m10, double m11, double m12)
        {
            M00 = m00;
            M01 = m01;
            M02 = m02;
            M10 = m10;
            M11 = m11;
            M12 = m12;
        }
        
        public static bool operator ==(Matrix2x3d a, Matrix2x3d b)
        {
            return a.M00 == b.M00 && a.M01 == b.M01 && a.M02 == b.M02 && a.M10 == b.M10 && a.M11 == b.M11 && a.M12 == b.M12;
        }
        
        public static bool operator !=(Matrix2x3d a, Matrix2x3d b)
        {
            return a.M00 != b.M00 || a.M01 != b.M01 || a.M02 != b.M02 || a.M10 != b.M10 || a.M11 != b.M11 || a.M12 != b.M12;
        }
        
        public bool Equals(Matrix2x3d other)
        {
            return M00 == other.M00 && M01 == other.M01 && M02 == other.M02 && M10 == other.M10 && M11 == other.M11 && M12 == other.M12;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Matrix2x3d)) return false;
            var m = (Matrix2x3d)other;
            return M00 == m.M00 && M01 == m.M01 && M02 == m.M02 && M10 == m.M10 && M11 == m.M11 && M12 == m.M12;
        }
        
        public override int GetHashCode()
        {
            return M00.GetHashCode() ^ M01.GetHashCode() ^ M02.GetHashCode() ^ M10.GetHashCode() ^ M11.GetHashCode() ^ M12.GetHashCode();
        }
        
        public override string ToString()
        {
            return "[" + M00.ToString() + M01.ToString() + M02.ToString() + "]"
             + "[" + M10.ToString() + M11.ToString() + M12.ToString() + "]"
            ;
        }
        
        public static Matrix2x3d operator *(Matrix2x3d left, Matrix2d right)
        {
            return new Matrix2x3d(
                left.M00 * right.M00 + left.M10 * right.M01,
                left.M01 * right.M00 + left.M11 * right.M01,
                left.M02 * right.M00 + left.M12 * right.M01,
                left.M00 * right.M10 + left.M10 * right.M11,
                left.M01 * right.M10 + left.M11 * right.M11,
                left.M02 * right.M10 + left.M12 * right.M11
            );
        }
        
        public static Matrix3d operator *(Matrix2x3d left, Matrix3x2d right)
        {
            return new Matrix3d(
                left.M00 * right.M00 + left.M10 * right.M01,
                left.M01 * right.M00 + left.M11 * right.M01,
                left.M02 * right.M00 + left.M12 * right.M01,
                left.M00 * right.M10 + left.M10 * right.M11,
                left.M01 * right.M10 + left.M11 * right.M11,
                left.M02 * right.M10 + left.M12 * right.M11,
                left.M00 * right.M20 + left.M10 * right.M21,
                left.M01 * right.M20 + left.M11 * right.M21,
                left.M02 * right.M20 + left.M12 * right.M21
            );
        }
        
        public static Matrix4x3d operator *(Matrix2x3d left, Matrix4x2d right)
        {
            return new Matrix4x3d(
                left.M00 * right.M00 + left.M10 * right.M01,
                left.M01 * right.M00 + left.M11 * right.M01,
                left.M02 * right.M00 + left.M12 * right.M01,
                left.M00 * right.M10 + left.M10 * right.M11,
                left.M01 * right.M10 + left.M11 * right.M11,
                left.M02 * right.M10 + left.M12 * right.M11,
                left.M00 * right.M20 + left.M10 * right.M21,
                left.M01 * right.M20 + left.M11 * right.M21,
                left.M02 * right.M20 + left.M12 * right.M21,
                left.M00 * right.M30 + left.M10 * right.M31,
                left.M01 * right.M30 + left.M11 * right.M31,
                left.M02 * right.M30 + left.M12 * right.M31
            );
        }
        
        public static Vector3d operator *(Matrix2x3d m, Vector2d v)
        {
            return new Vector3d(
                m.M00 * v.X + m.M10 * v.Y,
                m.M01 * v.X + m.M11 * v.Y,
                m.M02 * v.X + m.M12 * v.Y
            );
        }
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Matrix2x4d : System.IEquatable<Matrix2x4d>
    {
        public readonly double M00;
        public readonly double M01;
        public readonly double M02;
        public readonly double M03;
        public readonly double M10;
        public readonly double M11;
        public readonly double M12;
        public readonly double M13;
        
        public Vector4d Column0 { get { return new Vector4d(M00, M01, M02, M03); } }
        public Vector4d Column1 { get { return new Vector4d(M10, M11, M12, M13); } }
        
        public Vector2d Row0 { get { return new Vector2d(M00, M10); } }
        public Vector2d Row1 { get { return new Vector2d(M01, M11); } }
        public Vector2d Row2 { get { return new Vector2d(M02, M12); } }
        public Vector2d Row3 { get { return new Vector2d(M03, M13); } }
        
        public Matrix2x4d(Vector4d column0, Vector4d column1)
        {
            M00 = column0.X;
            M01 = column0.Y;
            M02 = column0.Z;
            M03 = column0.W;
            M10 = column1.X;
            M11 = column1.Y;
            M12 = column1.Z;
            M13 = column1.W;
        }
        
        public Matrix2x4d(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13)
        {
            M00 = m00;
            M01 = m01;
            M02 = m02;
            M03 = m03;
            M10 = m10;
            M11 = m11;
            M12 = m12;
            M13 = m13;
        }
        
        public static bool operator ==(Matrix2x4d a, Matrix2x4d b)
        {
            return a.M00 == b.M00 && a.M01 == b.M01 && a.M02 == b.M02 && a.M03 == b.M03 && a.M10 == b.M10 && a.M11 == b.M11 && a.M12 == b.M12 && a.M13 == b.M13;
        }
        
        public static bool operator !=(Matrix2x4d a, Matrix2x4d b)
        {
            return a.M00 != b.M00 || a.M01 != b.M01 || a.M02 != b.M02 || a.M03 != b.M03 || a.M10 != b.M10 || a.M11 != b.M11 || a.M12 != b.M12 || a.M13 != b.M13;
        }
        
        public bool Equals(Matrix2x4d other)
        {
            return M00 == other.M00 && M01 == other.M01 && M02 == other.M02 && M03 == other.M03 && M10 == other.M10 && M11 == other.M11 && M12 == other.M12 && M13 == other.M13;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Matrix2x4d)) return false;
            var m = (Matrix2x4d)other;
            return M00 == m.M00 && M01 == m.M01 && M02 == m.M02 && M03 == m.M03 && M10 == m.M10 && M11 == m.M11 && M12 == m.M12 && M13 == m.M13;
        }
        
        public override int GetHashCode()
        {
            return M00.GetHashCode() ^ M01.GetHashCode() ^ M02.GetHashCode() ^ M03.GetHashCode() ^ M10.GetHashCode() ^ M11.GetHashCode() ^ M12.GetHashCode() ^ M13.GetHashCode();
        }
        
        public override string ToString()
        {
            return "[" + M00.ToString() + M01.ToString() + M02.ToString() + M03.ToString() + "]"
             + "[" + M10.ToString() + M11.ToString() + M12.ToString() + M13.ToString() + "]"
            ;
        }
        
        public static Matrix2x4d operator *(Matrix2x4d left, Matrix2d right)
        {
            return new Matrix2x4d(
                left.M00 * right.M00 + left.M10 * right.M01,
                left.M01 * right.M00 + left.M11 * right.M01,
                left.M02 * right.M00 + left.M12 * right.M01,
                left.M03 * right.M00 + left.M13 * right.M01,
                left.M00 * right.M10 + left.M10 * right.M11,
                left.M01 * right.M10 + left.M11 * right.M11,
                left.M02 * right.M10 + left.M12 * right.M11,
                left.M03 * right.M10 + left.M13 * right.M11
            );
        }
        
        public static Matrix3x4d operator *(Matrix2x4d left, Matrix3x2d right)
        {
            return new Matrix3x4d(
                left.M00 * right.M00 + left.M10 * right.M01,
                left.M01 * right.M00 + left.M11 * right.M01,
                left.M02 * right.M00 + left.M12 * right.M01,
                left.M03 * right.M00 + left.M13 * right.M01,
                left.M00 * right.M10 + left.M10 * right.M11,
                left.M01 * right.M10 + left.M11 * right.M11,
                left.M02 * right.M10 + left.M12 * right.M11,
                left.M03 * right.M10 + left.M13 * right.M11,
                left.M00 * right.M20 + left.M10 * right.M21,
                left.M01 * right.M20 + left.M11 * right.M21,
                left.M02 * right.M20 + left.M12 * right.M21,
                left.M03 * right.M20 + left.M13 * right.M21
            );
        }
        
        public static Matrix4d operator *(Matrix2x4d left, Matrix4x2d right)
        {
            return new Matrix4d(
                left.M00 * right.M00 + left.M10 * right.M01,
                left.M01 * right.M00 + left.M11 * right.M01,
                left.M02 * right.M00 + left.M12 * right.M01,
                left.M03 * right.M00 + left.M13 * right.M01,
                left.M00 * right.M10 + left.M10 * right.M11,
                left.M01 * right.M10 + left.M11 * right.M11,
                left.M02 * right.M10 + left.M12 * right.M11,
                left.M03 * right.M10 + left.M13 * right.M11,
                left.M00 * right.M20 + left.M10 * right.M21,
                left.M01 * right.M20 + left.M11 * right.M21,
                left.M02 * right.M20 + left.M12 * right.M21,
                left.M03 * right.M20 + left.M13 * right.M21,
                left.M00 * right.M30 + left.M10 * right.M31,
                left.M01 * right.M30 + left.M11 * right.M31,
                left.M02 * right.M30 + left.M12 * right.M31,
                left.M03 * right.M30 + left.M13 * right.M31
            );
        }
        
        public static Vector4d operator *(Matrix2x4d m, Vector2d v)
        {
            return new Vector4d(
                m.M00 * v.X + m.M10 * v.Y,
                m.M01 * v.X + m.M11 * v.Y,
                m.M02 * v.X + m.M12 * v.Y,
                m.M03 * v.X + m.M13 * v.Y
            );
        }
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Matrix3x2d : System.IEquatable<Matrix3x2d>
    {
        public readonly double M00;
        public readonly double M01;
        public readonly double M10;
        public readonly double M11;
        public readonly double M20;
        public readonly double M21;
        
        public Vector2d Column0 { get { return new Vector2d(M00, M01); } }
        public Vector2d Column1 { get { return new Vector2d(M10, M11); } }
        public Vector2d Column2 { get { return new Vector2d(M20, M21); } }
        
        public Vector3d Row0 { get { return new Vector3d(M00, M10, M20); } }
        public Vector3d Row1 { get { return new Vector3d(M01, M11, M21); } }
        
        public Matrix3x2d(Vector2d column0, Vector2d column1, Vector2d column2)
        {
            M00 = column0.X;
            M01 = column0.Y;
            M10 = column1.X;
            M11 = column1.Y;
            M20 = column2.X;
            M21 = column2.Y;
        }
        
        public Matrix3x2d(double m00, double m01, double m10, double m11, double m20, double m21)
        {
            M00 = m00;
            M01 = m01;
            M10 = m10;
            M11 = m11;
            M20 = m20;
            M21 = m21;
        }
        
        public static bool operator ==(Matrix3x2d a, Matrix3x2d b)
        {
            return a.M00 == b.M00 && a.M01 == b.M01 && a.M10 == b.M10 && a.M11 == b.M11 && a.M20 == b.M20 && a.M21 == b.M21;
        }
        
        public static bool operator !=(Matrix3x2d a, Matrix3x2d b)
        {
            return a.M00 != b.M00 || a.M01 != b.M01 || a.M10 != b.M10 || a.M11 != b.M11 || a.M20 != b.M20 || a.M21 != b.M21;
        }
        
        public bool Equals(Matrix3x2d other)
        {
            return M00 == other.M00 && M01 == other.M01 && M10 == other.M10 && M11 == other.M11 && M20 == other.M20 && M21 == other.M21;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Matrix3x2d)) return false;
            var m = (Matrix3x2d)other;
            return M00 == m.M00 && M01 == m.M01 && M10 == m.M10 && M11 == m.M11 && M20 == m.M20 && M21 == m.M21;
        }
        
        public override int GetHashCode()
        {
            return M00.GetHashCode() ^ M01.GetHashCode() ^ M10.GetHashCode() ^ M11.GetHashCode() ^ M20.GetHashCode() ^ M21.GetHashCode();
        }
        
        public override string ToString()
        {
            return "[" + M00.ToString() + M01.ToString() + "]"
             + "[" + M10.ToString() + M11.ToString() + "]"
             + "[" + M20.ToString() + M21.ToString() + "]"
            ;
        }
        
        public static Matrix2d operator *(Matrix3x2d left, Matrix2x3d right)
        {
            return new Matrix2d(
                left.M00 * right.M00 + left.M10 * right.M01 + left.M20 * right.M02,
                left.M01 * right.M00 + left.M11 * right.M01 + left.M21 * right.M02,
                left.M00 * right.M10 + left.M10 * right.M11 + left.M20 * right.M12,
                left.M01 * right.M10 + left.M11 * right.M11 + left.M21 * right.M12
            );
        }
        
        public static Matrix3x2d operator *(Matrix3x2d left, Matrix3d right)
        {
            return new Matrix3x2d(
                left.M00 * right.M00 + left.M10 * right.M01 + left.M20 * right.M02,
                left.M01 * right.M00 + left.M11 * right.M01 + left.M21 * right.M02,
                left.M00 * right.M10 + left.M10 * right.M11 + left.M20 * right.M12,
                left.M01 * right.M10 + left.M11 * right.M11 + left.M21 * right.M12,
                left.M00 * right.M20 + left.M10 * right.M21 + left.M20 * right.M22,
                left.M01 * right.M20 + left.M11 * right.M21 + left.M21 * right.M22
            );
        }
        
        public static Matrix4x2d operator *(Matrix3x2d left, Matrix4x3d right)
        {
            return new Matrix4x2d(
                left.M00 * right.M00 + left.M10 * right.M01 + left.M20 * right.M02,
                left.M01 * right.M00 + left.M11 * right.M01 + left.M21 * right.M02,
                left.M00 * right.M10 + left.M10 * right.M11 + left.M20 * right.M12,
                left.M01 * right.M10 + left.M11 * right.M11 + left.M21 * right.M12,
                left.M00 * right.M20 + left.M10 * right.M21 + left.M20 * right.M22,
                left.M01 * right.M20 + left.M11 * right.M21 + left.M21 * right.M22,
                left.M00 * right.M30 + left.M10 * right.M31 + left.M20 * right.M32,
                left.M01 * right.M30 + left.M11 * right.M31 + left.M21 * right.M32
            );
        }
        
        public static Vector2d operator *(Matrix3x2d m, Vector3d v)
        {
            return new Vector2d(
                m.M00 * v.X + m.M10 * v.Y + m.M20 * v.Z,
                m.M01 * v.X + m.M11 * v.Y + m.M21 * v.Z
            );
        }
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Matrix3d : System.IEquatable<Matrix3d>
    {
        public readonly double M00;
        public readonly double M01;
        public readonly double M02;
        public readonly double M10;
        public readonly double M11;
        public readonly double M12;
        public readonly double M20;
        public readonly double M21;
        public readonly double M22;
        
        public Vector3d Column0 { get { return new Vector3d(M00, M01, M02); } }
        public Vector3d Column1 { get { return new Vector3d(M10, M11, M12); } }
        public Vector3d Column2 { get { return new Vector3d(M20, M21, M22); } }
        
        public Vector3d Row0 { get { return new Vector3d(M00, M10, M20); } }
        public Vector3d Row1 { get { return new Vector3d(M01, M11, M21); } }
        public Vector3d Row2 { get { return new Vector3d(M02, M12, M22); } }
        
        public Matrix3d(Vector3d column0, Vector3d column1, Vector3d column2)
        {
            M00 = column0.X;
            M01 = column0.Y;
            M02 = column0.Z;
            M10 = column1.X;
            M11 = column1.Y;
            M12 = column1.Z;
            M20 = column2.X;
            M21 = column2.Y;
            M22 = column2.Z;
        }
        
        public Matrix3d(double m00, double m01, double m02, double m10, double m11, double m12, double m20, double m21, double m22)
        {
            M00 = m00;
            M01 = m01;
            M02 = m02;
            M10 = m10;
            M11 = m11;
            M12 = m12;
            M20 = m20;
            M21 = m21;
            M22 = m22;
        }
        
        public static bool operator ==(Matrix3d a, Matrix3d b)
        {
            return a.M00 == b.M00 && a.M01 == b.M01 && a.M02 == b.M02 && a.M10 == b.M10 && a.M11 == b.M11 && a.M12 == b.M12 && a.M20 == b.M20 && a.M21 == b.M21 && a.M22 == b.M22;
        }
        
        public static bool operator !=(Matrix3d a, Matrix3d b)
        {
            return a.M00 != b.M00 || a.M01 != b.M01 || a.M02 != b.M02 || a.M10 != b.M10 || a.M11 != b.M11 || a.M12 != b.M12 || a.M20 != b.M20 || a.M21 != b.M21 || a.M22 != b.M22;
        }
        
        public bool Equals(Matrix3d other)
        {
            return M00 == other.M00 && M01 == other.M01 && M02 == other.M02 && M10 == other.M10 && M11 == other.M11 && M12 == other.M12 && M20 == other.M20 && M21 == other.M21 && M22 == other.M22;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Matrix3d)) return false;
            var m = (Matrix3d)other;
            return M00 == m.M00 && M01 == m.M01 && M02 == m.M02 && M10 == m.M10 && M11 == m.M11 && M12 == m.M12 && M20 == m.M20 && M21 == m.M21 && M22 == m.M22;
        }
        
        public override int GetHashCode()
        {
            return M00.GetHashCode() ^ M01.GetHashCode() ^ M02.GetHashCode() ^ M10.GetHashCode() ^ M11.GetHashCode() ^ M12.GetHashCode() ^ M20.GetHashCode() ^ M21.GetHashCode() ^ M22.GetHashCode();
        }
        
        public override string ToString()
        {
            return "[" + M00.ToString() + M01.ToString() + M02.ToString() + "]"
             + "[" + M10.ToString() + M11.ToString() + M12.ToString() + "]"
             + "[" + M20.ToString() + M21.ToString() + M22.ToString() + "]"
            ;
        }
        
        public static readonly Matrix3d Identity = new Matrix3d(Vector3d.UnitX, Vector3d.UnitY, Vector3d.UnitZ);
        
        public static Matrix2x3d operator *(Matrix3d left, Matrix2x3d right)
        {
            return new Matrix2x3d(
                left.M00 * right.M00 + left.M10 * right.M01 + left.M20 * right.M02,
                left.M01 * right.M00 + left.M11 * right.M01 + left.M21 * right.M02,
                left.M02 * right.M00 + left.M12 * right.M01 + left.M22 * right.M02,
                left.M00 * right.M10 + left.M10 * right.M11 + left.M20 * right.M12,
                left.M01 * right.M10 + left.M11 * right.M11 + left.M21 * right.M12,
                left.M02 * right.M10 + left.M12 * right.M11 + left.M22 * right.M12
            );
        }
        
        public static Matrix3d operator *(Matrix3d left, Matrix3d right)
        {
            return new Matrix3d(
                left.M00 * right.M00 + left.M10 * right.M01 + left.M20 * right.M02,
                left.M01 * right.M00 + left.M11 * right.M01 + left.M21 * right.M02,
                left.M02 * right.M00 + left.M12 * right.M01 + left.M22 * right.M02,
                left.M00 * right.M10 + left.M10 * right.M11 + left.M20 * right.M12,
                left.M01 * right.M10 + left.M11 * right.M11 + left.M21 * right.M12,
                left.M02 * right.M10 + left.M12 * right.M11 + left.M22 * right.M12,
                left.M00 * right.M20 + left.M10 * right.M21 + left.M20 * right.M22,
                left.M01 * right.M20 + left.M11 * right.M21 + left.M21 * right.M22,
                left.M02 * right.M20 + left.M12 * right.M21 + left.M22 * right.M22
            );
        }
        
        public static Matrix4x3d operator *(Matrix3d left, Matrix4x3d right)
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
                left.M00 * right.M30 + left.M10 * right.M31 + left.M20 * right.M32,
                left.M01 * right.M30 + left.M11 * right.M31 + left.M21 * right.M32,
                left.M02 * right.M30 + left.M12 * right.M31 + left.M22 * right.M32
            );
        }
        
        public static Vector3d operator *(Matrix3d m, Vector3d v)
        {
            return new Vector3d(
                m.M00 * v.X + m.M10 * v.Y + m.M20 * v.Z,
                m.M01 * v.X + m.M11 * v.Y + m.M21 * v.Z,
                m.M02 * v.X + m.M12 * v.Y + m.M22 * v.Z
            );
        }
        
        public Matrix3d Transpose
        {
            get {
                return new Matrix3d(
                    M00, M10, M20, 
                    M01, M11, M21, 
                    M02, M12, M22
                );
            }
        }
        
        public double Determinant
        {
            get {
                return M00 * M11 * M22 + M01 * M12 * M20 + M02 * M10 * M21 - M21 * M12 * M00 - M22 * M10 * M01 - M20 * M11 * M02;
            }
        }
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Matrix3x4d : System.IEquatable<Matrix3x4d>
    {
        public readonly double M00;
        public readonly double M01;
        public readonly double M02;
        public readonly double M03;
        public readonly double M10;
        public readonly double M11;
        public readonly double M12;
        public readonly double M13;
        public readonly double M20;
        public readonly double M21;
        public readonly double M22;
        public readonly double M23;
        
        public Vector4d Column0 { get { return new Vector4d(M00, M01, M02, M03); } }
        public Vector4d Column1 { get { return new Vector4d(M10, M11, M12, M13); } }
        public Vector4d Column2 { get { return new Vector4d(M20, M21, M22, M23); } }
        
        public Vector3d Row0 { get { return new Vector3d(M00, M10, M20); } }
        public Vector3d Row1 { get { return new Vector3d(M01, M11, M21); } }
        public Vector3d Row2 { get { return new Vector3d(M02, M12, M22); } }
        public Vector3d Row3 { get { return new Vector3d(M03, M13, M23); } }
        
        public Matrix3x4d(Vector4d column0, Vector4d column1, Vector4d column2)
        {
            M00 = column0.X;
            M01 = column0.Y;
            M02 = column0.Z;
            M03 = column0.W;
            M10 = column1.X;
            M11 = column1.Y;
            M12 = column1.Z;
            M13 = column1.W;
            M20 = column2.X;
            M21 = column2.Y;
            M22 = column2.Z;
            M23 = column2.W;
        }
        
        public Matrix3x4d(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13, double m20, double m21, double m22, double m23)
        {
            M00 = m00;
            M01 = m01;
            M02 = m02;
            M03 = m03;
            M10 = m10;
            M11 = m11;
            M12 = m12;
            M13 = m13;
            M20 = m20;
            M21 = m21;
            M22 = m22;
            M23 = m23;
        }
        
        public static bool operator ==(Matrix3x4d a, Matrix3x4d b)
        {
            return a.M00 == b.M00 && a.M01 == b.M01 && a.M02 == b.M02 && a.M03 == b.M03 && a.M10 == b.M10 && a.M11 == b.M11 && a.M12 == b.M12 && a.M13 == b.M13 && a.M20 == b.M20 && a.M21 == b.M21 && a.M22 == b.M22 && a.M23 == b.M23;
        }
        
        public static bool operator !=(Matrix3x4d a, Matrix3x4d b)
        {
            return a.M00 != b.M00 || a.M01 != b.M01 || a.M02 != b.M02 || a.M03 != b.M03 || a.M10 != b.M10 || a.M11 != b.M11 || a.M12 != b.M12 || a.M13 != b.M13 || a.M20 != b.M20 || a.M21 != b.M21 || a.M22 != b.M22 || a.M23 != b.M23;
        }
        
        public bool Equals(Matrix3x4d other)
        {
            return M00 == other.M00 && M01 == other.M01 && M02 == other.M02 && M03 == other.M03 && M10 == other.M10 && M11 == other.M11 && M12 == other.M12 && M13 == other.M13 && M20 == other.M20 && M21 == other.M21 && M22 == other.M22 && M23 == other.M23;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Matrix3x4d)) return false;
            var m = (Matrix3x4d)other;
            return M00 == m.M00 && M01 == m.M01 && M02 == m.M02 && M03 == m.M03 && M10 == m.M10 && M11 == m.M11 && M12 == m.M12 && M13 == m.M13 && M20 == m.M20 && M21 == m.M21 && M22 == m.M22 && M23 == m.M23;
        }
        
        public override int GetHashCode()
        {
            return M00.GetHashCode() ^ M01.GetHashCode() ^ M02.GetHashCode() ^ M03.GetHashCode() ^ M10.GetHashCode() ^ M11.GetHashCode() ^ M12.GetHashCode() ^ M13.GetHashCode() ^ M20.GetHashCode() ^ M21.GetHashCode() ^ M22.GetHashCode() ^ M23.GetHashCode();
        }
        
        public override string ToString()
        {
            return "[" + M00.ToString() + M01.ToString() + M02.ToString() + M03.ToString() + "]"
             + "[" + M10.ToString() + M11.ToString() + M12.ToString() + M13.ToString() + "]"
             + "[" + M20.ToString() + M21.ToString() + M22.ToString() + M23.ToString() + "]"
            ;
        }
        
        public static Matrix2x4d operator *(Matrix3x4d left, Matrix2x3d right)
        {
            return new Matrix2x4d(
                left.M00 * right.M00 + left.M10 * right.M01 + left.M20 * right.M02,
                left.M01 * right.M00 + left.M11 * right.M01 + left.M21 * right.M02,
                left.M02 * right.M00 + left.M12 * right.M01 + left.M22 * right.M02,
                left.M03 * right.M00 + left.M13 * right.M01 + left.M23 * right.M02,
                left.M00 * right.M10 + left.M10 * right.M11 + left.M20 * right.M12,
                left.M01 * right.M10 + left.M11 * right.M11 + left.M21 * right.M12,
                left.M02 * right.M10 + left.M12 * right.M11 + left.M22 * right.M12,
                left.M03 * right.M10 + left.M13 * right.M11 + left.M23 * right.M12
            );
        }
        
        public static Matrix3x4d operator *(Matrix3x4d left, Matrix3d right)
        {
            return new Matrix3x4d(
                left.M00 * right.M00 + left.M10 * right.M01 + left.M20 * right.M02,
                left.M01 * right.M00 + left.M11 * right.M01 + left.M21 * right.M02,
                left.M02 * right.M00 + left.M12 * right.M01 + left.M22 * right.M02,
                left.M03 * right.M00 + left.M13 * right.M01 + left.M23 * right.M02,
                left.M00 * right.M10 + left.M10 * right.M11 + left.M20 * right.M12,
                left.M01 * right.M10 + left.M11 * right.M11 + left.M21 * right.M12,
                left.M02 * right.M10 + left.M12 * right.M11 + left.M22 * right.M12,
                left.M03 * right.M10 + left.M13 * right.M11 + left.M23 * right.M12,
                left.M00 * right.M20 + left.M10 * right.M21 + left.M20 * right.M22,
                left.M01 * right.M20 + left.M11 * right.M21 + left.M21 * right.M22,
                left.M02 * right.M20 + left.M12 * right.M21 + left.M22 * right.M22,
                left.M03 * right.M20 + left.M13 * right.M21 + left.M23 * right.M22
            );
        }
        
        public static Matrix4d operator *(Matrix3x4d left, Matrix4x3d right)
        {
            return new Matrix4d(
                left.M00 * right.M00 + left.M10 * right.M01 + left.M20 * right.M02,
                left.M01 * right.M00 + left.M11 * right.M01 + left.M21 * right.M02,
                left.M02 * right.M00 + left.M12 * right.M01 + left.M22 * right.M02,
                left.M03 * right.M00 + left.M13 * right.M01 + left.M23 * right.M02,
                left.M00 * right.M10 + left.M10 * right.M11 + left.M20 * right.M12,
                left.M01 * right.M10 + left.M11 * right.M11 + left.M21 * right.M12,
                left.M02 * right.M10 + left.M12 * right.M11 + left.M22 * right.M12,
                left.M03 * right.M10 + left.M13 * right.M11 + left.M23 * right.M12,
                left.M00 * right.M20 + left.M10 * right.M21 + left.M20 * right.M22,
                left.M01 * right.M20 + left.M11 * right.M21 + left.M21 * right.M22,
                left.M02 * right.M20 + left.M12 * right.M21 + left.M22 * right.M22,
                left.M03 * right.M20 + left.M13 * right.M21 + left.M23 * right.M22,
                left.M00 * right.M30 + left.M10 * right.M31 + left.M20 * right.M32,
                left.M01 * right.M30 + left.M11 * right.M31 + left.M21 * right.M32,
                left.M02 * right.M30 + left.M12 * right.M31 + left.M22 * right.M32,
                left.M03 * right.M30 + left.M13 * right.M31 + left.M23 * right.M32
            );
        }
        
        public static Vector4d operator *(Matrix3x4d m, Vector3d v)
        {
            return new Vector4d(
                m.M00 * v.X + m.M10 * v.Y + m.M20 * v.Z,
                m.M01 * v.X + m.M11 * v.Y + m.M21 * v.Z,
                m.M02 * v.X + m.M12 * v.Y + m.M22 * v.Z,
                m.M03 * v.X + m.M13 * v.Y + m.M23 * v.Z
            );
        }
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Matrix4x2d : System.IEquatable<Matrix4x2d>
    {
        public readonly double M00;
        public readonly double M01;
        public readonly double M10;
        public readonly double M11;
        public readonly double M20;
        public readonly double M21;
        public readonly double M30;
        public readonly double M31;
        
        public Vector2d Column0 { get { return new Vector2d(M00, M01); } }
        public Vector2d Column1 { get { return new Vector2d(M10, M11); } }
        public Vector2d Column2 { get { return new Vector2d(M20, M21); } }
        public Vector2d Column3 { get { return new Vector2d(M30, M31); } }
        
        public Vector4d Row0 { get { return new Vector4d(M00, M10, M20, M30); } }
        public Vector4d Row1 { get { return new Vector4d(M01, M11, M21, M31); } }
        
        public Matrix4x2d(Vector2d column0, Vector2d column1, Vector2d column2, Vector2d column3)
        {
            M00 = column0.X;
            M01 = column0.Y;
            M10 = column1.X;
            M11 = column1.Y;
            M20 = column2.X;
            M21 = column2.Y;
            M30 = column3.X;
            M31 = column3.Y;
        }
        
        public Matrix4x2d(double m00, double m01, double m10, double m11, double m20, double m21, double m30, double m31)
        {
            M00 = m00;
            M01 = m01;
            M10 = m10;
            M11 = m11;
            M20 = m20;
            M21 = m21;
            M30 = m30;
            M31 = m31;
        }
        
        public static bool operator ==(Matrix4x2d a, Matrix4x2d b)
        {
            return a.M00 == b.M00 && a.M01 == b.M01 && a.M10 == b.M10 && a.M11 == b.M11 && a.M20 == b.M20 && a.M21 == b.M21 && a.M30 == b.M30 && a.M31 == b.M31;
        }
        
        public static bool operator !=(Matrix4x2d a, Matrix4x2d b)
        {
            return a.M00 != b.M00 || a.M01 != b.M01 || a.M10 != b.M10 || a.M11 != b.M11 || a.M20 != b.M20 || a.M21 != b.M21 || a.M30 != b.M30 || a.M31 != b.M31;
        }
        
        public bool Equals(Matrix4x2d other)
        {
            return M00 == other.M00 && M01 == other.M01 && M10 == other.M10 && M11 == other.M11 && M20 == other.M20 && M21 == other.M21 && M30 == other.M30 && M31 == other.M31;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Matrix4x2d)) return false;
            var m = (Matrix4x2d)other;
            return M00 == m.M00 && M01 == m.M01 && M10 == m.M10 && M11 == m.M11 && M20 == m.M20 && M21 == m.M21 && M30 == m.M30 && M31 == m.M31;
        }
        
        public override int GetHashCode()
        {
            return M00.GetHashCode() ^ M01.GetHashCode() ^ M10.GetHashCode() ^ M11.GetHashCode() ^ M20.GetHashCode() ^ M21.GetHashCode() ^ M30.GetHashCode() ^ M31.GetHashCode();
        }
        
        public override string ToString()
        {
            return "[" + M00.ToString() + M01.ToString() + "]"
             + "[" + M10.ToString() + M11.ToString() + "]"
             + "[" + M20.ToString() + M21.ToString() + "]"
             + "[" + M30.ToString() + M31.ToString() + "]"
            ;
        }
        
        public static Matrix2d operator *(Matrix4x2d left, Matrix2x4d right)
        {
            return new Matrix2d(
                left.M00 * right.M00 + left.M10 * right.M01 + left.M20 * right.M02 + left.M30 * right.M03,
                left.M01 * right.M00 + left.M11 * right.M01 + left.M21 * right.M02 + left.M31 * right.M03,
                left.M00 * right.M10 + left.M10 * right.M11 + left.M20 * right.M12 + left.M30 * right.M13,
                left.M01 * right.M10 + left.M11 * right.M11 + left.M21 * right.M12 + left.M31 * right.M13
            );
        }
        
        public static Matrix3x2d operator *(Matrix4x2d left, Matrix3x4d right)
        {
            return new Matrix3x2d(
                left.M00 * right.M00 + left.M10 * right.M01 + left.M20 * right.M02 + left.M30 * right.M03,
                left.M01 * right.M00 + left.M11 * right.M01 + left.M21 * right.M02 + left.M31 * right.M03,
                left.M00 * right.M10 + left.M10 * right.M11 + left.M20 * right.M12 + left.M30 * right.M13,
                left.M01 * right.M10 + left.M11 * right.M11 + left.M21 * right.M12 + left.M31 * right.M13,
                left.M00 * right.M20 + left.M10 * right.M21 + left.M20 * right.M22 + left.M30 * right.M23,
                left.M01 * right.M20 + left.M11 * right.M21 + left.M21 * right.M22 + left.M31 * right.M23
            );
        }
        
        public static Matrix4x2d operator *(Matrix4x2d left, Matrix4d right)
        {
            return new Matrix4x2d(
                left.M00 * right.M00 + left.M10 * right.M01 + left.M20 * right.M02 + left.M30 * right.M03,
                left.M01 * right.M00 + left.M11 * right.M01 + left.M21 * right.M02 + left.M31 * right.M03,
                left.M00 * right.M10 + left.M10 * right.M11 + left.M20 * right.M12 + left.M30 * right.M13,
                left.M01 * right.M10 + left.M11 * right.M11 + left.M21 * right.M12 + left.M31 * right.M13,
                left.M00 * right.M20 + left.M10 * right.M21 + left.M20 * right.M22 + left.M30 * right.M23,
                left.M01 * right.M20 + left.M11 * right.M21 + left.M21 * right.M22 + left.M31 * right.M23,
                left.M00 * right.M30 + left.M10 * right.M31 + left.M20 * right.M32 + left.M30 * right.M33,
                left.M01 * right.M30 + left.M11 * right.M31 + left.M21 * right.M32 + left.M31 * right.M33
            );
        }
        
        public static Vector2d operator *(Matrix4x2d m, Vector4d v)
        {
            return new Vector2d(
                m.M00 * v.X + m.M10 * v.Y + m.M20 * v.Z + m.M30 * v.W,
                m.M01 * v.X + m.M11 * v.Y + m.M21 * v.Z + m.M31 * v.W
            );
        }
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Matrix4x3d : System.IEquatable<Matrix4x3d>
    {
        public readonly double M00;
        public readonly double M01;
        public readonly double M02;
        public readonly double M10;
        public readonly double M11;
        public readonly double M12;
        public readonly double M20;
        public readonly double M21;
        public readonly double M22;
        public readonly double M30;
        public readonly double M31;
        public readonly double M32;
        
        public Vector3d Column0 { get { return new Vector3d(M00, M01, M02); } }
        public Vector3d Column1 { get { return new Vector3d(M10, M11, M12); } }
        public Vector3d Column2 { get { return new Vector3d(M20, M21, M22); } }
        public Vector3d Column3 { get { return new Vector3d(M30, M31, M32); } }
        
        public Vector4d Row0 { get { return new Vector4d(M00, M10, M20, M30); } }
        public Vector4d Row1 { get { return new Vector4d(M01, M11, M21, M31); } }
        public Vector4d Row2 { get { return new Vector4d(M02, M12, M22, M32); } }
        
        public Matrix4x3d(Vector3d column0, Vector3d column1, Vector3d column2, Vector3d column3)
        {
            M00 = column0.X;
            M01 = column0.Y;
            M02 = column0.Z;
            M10 = column1.X;
            M11 = column1.Y;
            M12 = column1.Z;
            M20 = column2.X;
            M21 = column2.Y;
            M22 = column2.Z;
            M30 = column3.X;
            M31 = column3.Y;
            M32 = column3.Z;
        }
        
        public Matrix4x3d(double m00, double m01, double m02, double m10, double m11, double m12, double m20, double m21, double m22, double m30, double m31, double m32)
        {
            M00 = m00;
            M01 = m01;
            M02 = m02;
            M10 = m10;
            M11 = m11;
            M12 = m12;
            M20 = m20;
            M21 = m21;
            M22 = m22;
            M30 = m30;
            M31 = m31;
            M32 = m32;
        }
        
        public static bool operator ==(Matrix4x3d a, Matrix4x3d b)
        {
            return a.M00 == b.M00 && a.M01 == b.M01 && a.M02 == b.M02 && a.M10 == b.M10 && a.M11 == b.M11 && a.M12 == b.M12 && a.M20 == b.M20 && a.M21 == b.M21 && a.M22 == b.M22 && a.M30 == b.M30 && a.M31 == b.M31 && a.M32 == b.M32;
        }
        
        public static bool operator !=(Matrix4x3d a, Matrix4x3d b)
        {
            return a.M00 != b.M00 || a.M01 != b.M01 || a.M02 != b.M02 || a.M10 != b.M10 || a.M11 != b.M11 || a.M12 != b.M12 || a.M20 != b.M20 || a.M21 != b.M21 || a.M22 != b.M22 || a.M30 != b.M30 || a.M31 != b.M31 || a.M32 != b.M32;
        }
        
        public bool Equals(Matrix4x3d other)
        {
            return M00 == other.M00 && M01 == other.M01 && M02 == other.M02 && M10 == other.M10 && M11 == other.M11 && M12 == other.M12 && M20 == other.M20 && M21 == other.M21 && M22 == other.M22 && M30 == other.M30 && M31 == other.M31 && M32 == other.M32;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Matrix4x3d)) return false;
            var m = (Matrix4x3d)other;
            return M00 == m.M00 && M01 == m.M01 && M02 == m.M02 && M10 == m.M10 && M11 == m.M11 && M12 == m.M12 && M20 == m.M20 && M21 == m.M21 && M22 == m.M22 && M30 == m.M30 && M31 == m.M31 && M32 == m.M32;
        }
        
        public override int GetHashCode()
        {
            return M00.GetHashCode() ^ M01.GetHashCode() ^ M02.GetHashCode() ^ M10.GetHashCode() ^ M11.GetHashCode() ^ M12.GetHashCode() ^ M20.GetHashCode() ^ M21.GetHashCode() ^ M22.GetHashCode() ^ M30.GetHashCode() ^ M31.GetHashCode() ^ M32.GetHashCode();
        }
        
        public override string ToString()
        {
            return "[" + M00.ToString() + M01.ToString() + M02.ToString() + "]"
             + "[" + M10.ToString() + M11.ToString() + M12.ToString() + "]"
             + "[" + M20.ToString() + M21.ToString() + M22.ToString() + "]"
             + "[" + M30.ToString() + M31.ToString() + M32.ToString() + "]"
            ;
        }
        
        public static Matrix2x3d operator *(Matrix4x3d left, Matrix2x4d right)
        {
            return new Matrix2x3d(
                left.M00 * right.M00 + left.M10 * right.M01 + left.M20 * right.M02 + left.M30 * right.M03,
                left.M01 * right.M00 + left.M11 * right.M01 + left.M21 * right.M02 + left.M31 * right.M03,
                left.M02 * right.M00 + left.M12 * right.M01 + left.M22 * right.M02 + left.M32 * right.M03,
                left.M00 * right.M10 + left.M10 * right.M11 + left.M20 * right.M12 + left.M30 * right.M13,
                left.M01 * right.M10 + left.M11 * right.M11 + left.M21 * right.M12 + left.M31 * right.M13,
                left.M02 * right.M10 + left.M12 * right.M11 + left.M22 * right.M12 + left.M32 * right.M13
            );
        }
        
        public static Matrix3d operator *(Matrix4x3d left, Matrix3x4d right)
        {
            return new Matrix3d(
                left.M00 * right.M00 + left.M10 * right.M01 + left.M20 * right.M02 + left.M30 * right.M03,
                left.M01 * right.M00 + left.M11 * right.M01 + left.M21 * right.M02 + left.M31 * right.M03,
                left.M02 * right.M00 + left.M12 * right.M01 + left.M22 * right.M02 + left.M32 * right.M03,
                left.M00 * right.M10 + left.M10 * right.M11 + left.M20 * right.M12 + left.M30 * right.M13,
                left.M01 * right.M10 + left.M11 * right.M11 + left.M21 * right.M12 + left.M31 * right.M13,
                left.M02 * right.M10 + left.M12 * right.M11 + left.M22 * right.M12 + left.M32 * right.M13,
                left.M00 * right.M20 + left.M10 * right.M21 + left.M20 * right.M22 + left.M30 * right.M23,
                left.M01 * right.M20 + left.M11 * right.M21 + left.M21 * right.M22 + left.M31 * right.M23,
                left.M02 * right.M20 + left.M12 * right.M21 + left.M22 * right.M22 + left.M32 * right.M23
            );
        }
        
        public static Matrix4x3d operator *(Matrix4x3d left, Matrix4d right)
        {
            return new Matrix4x3d(
                left.M00 * right.M00 + left.M10 * right.M01 + left.M20 * right.M02 + left.M30 * right.M03,
                left.M01 * right.M00 + left.M11 * right.M01 + left.M21 * right.M02 + left.M31 * right.M03,
                left.M02 * right.M00 + left.M12 * right.M01 + left.M22 * right.M02 + left.M32 * right.M03,
                left.M00 * right.M10 + left.M10 * right.M11 + left.M20 * right.M12 + left.M30 * right.M13,
                left.M01 * right.M10 + left.M11 * right.M11 + left.M21 * right.M12 + left.M31 * right.M13,
                left.M02 * right.M10 + left.M12 * right.M11 + left.M22 * right.M12 + left.M32 * right.M13,
                left.M00 * right.M20 + left.M10 * right.M21 + left.M20 * right.M22 + left.M30 * right.M23,
                left.M01 * right.M20 + left.M11 * right.M21 + left.M21 * right.M22 + left.M31 * right.M23,
                left.M02 * right.M20 + left.M12 * right.M21 + left.M22 * right.M22 + left.M32 * right.M23,
                left.M00 * right.M30 + left.M10 * right.M31 + left.M20 * right.M32 + left.M30 * right.M33,
                left.M01 * right.M30 + left.M11 * right.M31 + left.M21 * right.M32 + left.M31 * right.M33,
                left.M02 * right.M30 + left.M12 * right.M31 + left.M22 * right.M32 + left.M32 * right.M33
            );
        }
        
        public static Vector3d operator *(Matrix4x3d m, Vector4d v)
        {
            return new Vector3d(
                m.M00 * v.X + m.M10 * v.Y + m.M20 * v.Z + m.M30 * v.W,
                m.M01 * v.X + m.M11 * v.Y + m.M21 * v.Z + m.M31 * v.W,
                m.M02 * v.X + m.M12 * v.Y + m.M22 * v.Z + m.M32 * v.W
            );
        }
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Matrix4d : System.IEquatable<Matrix4d>
    {
        public readonly double M00;
        public readonly double M01;
        public readonly double M02;
        public readonly double M03;
        public readonly double M10;
        public readonly double M11;
        public readonly double M12;
        public readonly double M13;
        public readonly double M20;
        public readonly double M21;
        public readonly double M22;
        public readonly double M23;
        public readonly double M30;
        public readonly double M31;
        public readonly double M32;
        public readonly double M33;
        
        public Vector4d Column0 { get { return new Vector4d(M00, M01, M02, M03); } }
        public Vector4d Column1 { get { return new Vector4d(M10, M11, M12, M13); } }
        public Vector4d Column2 { get { return new Vector4d(M20, M21, M22, M23); } }
        public Vector4d Column3 { get { return new Vector4d(M30, M31, M32, M33); } }
        
        public Vector4d Row0 { get { return new Vector4d(M00, M10, M20, M30); } }
        public Vector4d Row1 { get { return new Vector4d(M01, M11, M21, M31); } }
        public Vector4d Row2 { get { return new Vector4d(M02, M12, M22, M32); } }
        public Vector4d Row3 { get { return new Vector4d(M03, M13, M23, M33); } }
        
        public Matrix4d(Vector4d column0, Vector4d column1, Vector4d column2, Vector4d column3)
        {
            M00 = column0.X;
            M01 = column0.Y;
            M02 = column0.Z;
            M03 = column0.W;
            M10 = column1.X;
            M11 = column1.Y;
            M12 = column1.Z;
            M13 = column1.W;
            M20 = column2.X;
            M21 = column2.Y;
            M22 = column2.Z;
            M23 = column2.W;
            M30 = column3.X;
            M31 = column3.Y;
            M32 = column3.Z;
            M33 = column3.W;
        }
        
        public Matrix4d(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13, double m20, double m21, double m22, double m23, double m30, double m31, double m32, double m33)
        {
            M00 = m00;
            M01 = m01;
            M02 = m02;
            M03 = m03;
            M10 = m10;
            M11 = m11;
            M12 = m12;
            M13 = m13;
            M20 = m20;
            M21 = m21;
            M22 = m22;
            M23 = m23;
            M30 = m30;
            M31 = m31;
            M32 = m32;
            M33 = m33;
        }
        
        public static bool operator ==(Matrix4d a, Matrix4d b)
        {
            return a.M00 == b.M00 && a.M01 == b.M01 && a.M02 == b.M02 && a.M03 == b.M03 && a.M10 == b.M10 && a.M11 == b.M11 && a.M12 == b.M12 && a.M13 == b.M13 && a.M20 == b.M20 && a.M21 == b.M21 && a.M22 == b.M22 && a.M23 == b.M23 && a.M30 == b.M30 && a.M31 == b.M31 && a.M32 == b.M32 && a.M33 == b.M33;
        }
        
        public static bool operator !=(Matrix4d a, Matrix4d b)
        {
            return a.M00 != b.M00 || a.M01 != b.M01 || a.M02 != b.M02 || a.M03 != b.M03 || a.M10 != b.M10 || a.M11 != b.M11 || a.M12 != b.M12 || a.M13 != b.M13 || a.M20 != b.M20 || a.M21 != b.M21 || a.M22 != b.M22 || a.M23 != b.M23 || a.M30 != b.M30 || a.M31 != b.M31 || a.M32 != b.M32 || a.M33 != b.M33;
        }
        
        public bool Equals(Matrix4d other)
        {
            return M00 == other.M00 && M01 == other.M01 && M02 == other.M02 && M03 == other.M03 && M10 == other.M10 && M11 == other.M11 && M12 == other.M12 && M13 == other.M13 && M20 == other.M20 && M21 == other.M21 && M22 == other.M22 && M23 == other.M23 && M30 == other.M30 && M31 == other.M31 && M32 == other.M32 && M33 == other.M33;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Matrix4d)) return false;
            var m = (Matrix4d)other;
            return M00 == m.M00 && M01 == m.M01 && M02 == m.M02 && M03 == m.M03 && M10 == m.M10 && M11 == m.M11 && M12 == m.M12 && M13 == m.M13 && M20 == m.M20 && M21 == m.M21 && M22 == m.M22 && M23 == m.M23 && M30 == m.M30 && M31 == m.M31 && M32 == m.M32 && M33 == m.M33;
        }
        
        public override int GetHashCode()
        {
            return M00.GetHashCode() ^ M01.GetHashCode() ^ M02.GetHashCode() ^ M03.GetHashCode() ^ M10.GetHashCode() ^ M11.GetHashCode() ^ M12.GetHashCode() ^ M13.GetHashCode() ^ M20.GetHashCode() ^ M21.GetHashCode() ^ M22.GetHashCode() ^ M23.GetHashCode() ^ M30.GetHashCode() ^ M31.GetHashCode() ^ M32.GetHashCode() ^ M33.GetHashCode();
        }
        
        public override string ToString()
        {
            return "[" + M00.ToString() + M01.ToString() + M02.ToString() + M03.ToString() + "]"
             + "[" + M10.ToString() + M11.ToString() + M12.ToString() + M13.ToString() + "]"
             + "[" + M20.ToString() + M21.ToString() + M22.ToString() + M23.ToString() + "]"
             + "[" + M30.ToString() + M31.ToString() + M32.ToString() + M33.ToString() + "]"
            ;
        }
        
        public static readonly Matrix4d Identity = new Matrix4d(Vector4d.UnitX, Vector4d.UnitY, Vector4d.UnitZ, Vector4d.UnitW);
        
        public static Matrix2x4d operator *(Matrix4d left, Matrix2x4d right)
        {
            return new Matrix2x4d(
                left.M00 * right.M00 + left.M10 * right.M01 + left.M20 * right.M02 + left.M30 * right.M03,
                left.M01 * right.M00 + left.M11 * right.M01 + left.M21 * right.M02 + left.M31 * right.M03,
                left.M02 * right.M00 + left.M12 * right.M01 + left.M22 * right.M02 + left.M32 * right.M03,
                left.M03 * right.M00 + left.M13 * right.M01 + left.M23 * right.M02 + left.M33 * right.M03,
                left.M00 * right.M10 + left.M10 * right.M11 + left.M20 * right.M12 + left.M30 * right.M13,
                left.M01 * right.M10 + left.M11 * right.M11 + left.M21 * right.M12 + left.M31 * right.M13,
                left.M02 * right.M10 + left.M12 * right.M11 + left.M22 * right.M12 + left.M32 * right.M13,
                left.M03 * right.M10 + left.M13 * right.M11 + left.M23 * right.M12 + left.M33 * right.M13
            );
        }
        
        public static Matrix3x4d operator *(Matrix4d left, Matrix3x4d right)
        {
            return new Matrix3x4d(
                left.M00 * right.M00 + left.M10 * right.M01 + left.M20 * right.M02 + left.M30 * right.M03,
                left.M01 * right.M00 + left.M11 * right.M01 + left.M21 * right.M02 + left.M31 * right.M03,
                left.M02 * right.M00 + left.M12 * right.M01 + left.M22 * right.M02 + left.M32 * right.M03,
                left.M03 * right.M00 + left.M13 * right.M01 + left.M23 * right.M02 + left.M33 * right.M03,
                left.M00 * right.M10 + left.M10 * right.M11 + left.M20 * right.M12 + left.M30 * right.M13,
                left.M01 * right.M10 + left.M11 * right.M11 + left.M21 * right.M12 + left.M31 * right.M13,
                left.M02 * right.M10 + left.M12 * right.M11 + left.M22 * right.M12 + left.M32 * right.M13,
                left.M03 * right.M10 + left.M13 * right.M11 + left.M23 * right.M12 + left.M33 * right.M13,
                left.M00 * right.M20 + left.M10 * right.M21 + left.M20 * right.M22 + left.M30 * right.M23,
                left.M01 * right.M20 + left.M11 * right.M21 + left.M21 * right.M22 + left.M31 * right.M23,
                left.M02 * right.M20 + left.M12 * right.M21 + left.M22 * right.M22 + left.M32 * right.M23,
                left.M03 * right.M20 + left.M13 * right.M21 + left.M23 * right.M22 + left.M33 * right.M23
            );
        }
        
        public static Matrix4d operator *(Matrix4d left, Matrix4d right)
        {
            return new Matrix4d(
                left.M00 * right.M00 + left.M10 * right.M01 + left.M20 * right.M02 + left.M30 * right.M03,
                left.M01 * right.M00 + left.M11 * right.M01 + left.M21 * right.M02 + left.M31 * right.M03,
                left.M02 * right.M00 + left.M12 * right.M01 + left.M22 * right.M02 + left.M32 * right.M03,
                left.M03 * right.M00 + left.M13 * right.M01 + left.M23 * right.M02 + left.M33 * right.M03,
                left.M00 * right.M10 + left.M10 * right.M11 + left.M20 * right.M12 + left.M30 * right.M13,
                left.M01 * right.M10 + left.M11 * right.M11 + left.M21 * right.M12 + left.M31 * right.M13,
                left.M02 * right.M10 + left.M12 * right.M11 + left.M22 * right.M12 + left.M32 * right.M13,
                left.M03 * right.M10 + left.M13 * right.M11 + left.M23 * right.M12 + left.M33 * right.M13,
                left.M00 * right.M20 + left.M10 * right.M21 + left.M20 * right.M22 + left.M30 * right.M23,
                left.M01 * right.M20 + left.M11 * right.M21 + left.M21 * right.M22 + left.M31 * right.M23,
                left.M02 * right.M20 + left.M12 * right.M21 + left.M22 * right.M22 + left.M32 * right.M23,
                left.M03 * right.M20 + left.M13 * right.M21 + left.M23 * right.M22 + left.M33 * right.M23,
                left.M00 * right.M30 + left.M10 * right.M31 + left.M20 * right.M32 + left.M30 * right.M33,
                left.M01 * right.M30 + left.M11 * right.M31 + left.M21 * right.M32 + left.M31 * right.M33,
                left.M02 * right.M30 + left.M12 * right.M31 + left.M22 * right.M32 + left.M32 * right.M33,
                left.M03 * right.M30 + left.M13 * right.M31 + left.M23 * right.M32 + left.M33 * right.M33
            );
        }
        
        public static Vector4d operator *(Matrix4d m, Vector4d v)
        {
            return new Vector4d(
                m.M00 * v.X + m.M10 * v.Y + m.M20 * v.Z + m.M30 * v.W,
                m.M01 * v.X + m.M11 * v.Y + m.M21 * v.Z + m.M31 * v.W,
                m.M02 * v.X + m.M12 * v.Y + m.M22 * v.Z + m.M32 * v.W,
                m.M03 * v.X + m.M13 * v.Y + m.M23 * v.Z + m.M33 * v.W
            );
        }
        
        public Matrix4d Transpose
        {
            get {
                return new Matrix4d(
                    M00, M10, M20, M30, 
                    M01, M11, M21, M31, 
                    M02, M12, M22, M32, 
                    M03, M13, M23, M33
                );
            }
        }
        
        public double Determinant
        {
            get {
                return M00 * M11 * M22 * M33 + M01 * M12 * M23 * M30 + M02 * M13 * M20 * M31 + M03 * M10 * M21 * M32 - M31 * M22 * M13 * M00 - M32 * M23 * M10 * M01 - M33 * M20 * M11 * M02 - M30 * M21 * M12 * M03;
            }
        }
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Box2b : System.IEquatable<Box2b>
    {
        public readonly Vector2b Position;
        public readonly Vector2b Size;
        
        public Box2b(Vector2b position, Vector2b size){
            Position = position;
            Size = size;
        }
        
        public Box2b(sbyte x, sbyte y, sbyte sx, sbyte sy){
            Position = new Vector2b(x, y);
            Size = new Vector2b(sx, sy);
        }
        
        public static explicit operator Box2ub(Box2b v)
        {
            return new Box2ub((Vector2ub)v.Position, (Vector2ub)v.Size);
        }
        
        public static implicit operator Box2s(Box2b v)
        {
            return new Box2s(v.Position, v.Size);
        }
        
        public static explicit operator Box2us(Box2b v)
        {
            return new Box2us((Vector2us)v.Position, (Vector2us)v.Size);
        }
        
        public static implicit operator Box2i(Box2b v)
        {
            return new Box2i(v.Position, v.Size);
        }
        
        public static explicit operator Box2ui(Box2b v)
        {
            return new Box2ui((Vector2ui)v.Position, (Vector2ui)v.Size);
        }
        
        public static implicit operator Box2(Box2b v)
        {
            return new Box2(v.Position, v.Size);
        }
        
        public static implicit operator Box2d(Box2b v)
        {
            return new Box2d(v.Position, v.Size);
        }
        
        public override string ToString()
        {
            return Position.ToString() + Size.ToString();}
        
        public static bool operator ==(Box2b a, Box2b b)
        {
            return a.Position == b.Position && a.Size == b.Size;
        }
        
        public static bool operator !=(Box2b a, Box2b b)
        {
            return a.Position != b.Position || a.Size != b.Size;
        }
        
        public bool Equals(Box2b other)
        {
            return Position == other.Position && Size == other.Size;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Box2b)) return false;
            var b = (Box2b)other;
            return Position == b.Position && Size == b.Size;
        }
        
        public override int GetHashCode()
        {
            return Position.GetHashCode() ^ Size.GetHashCode();
        }
        
        public sbyte MinX { get { return System.Math.Min(Position.X, (sbyte)(Position.X + Size.X)); } }
        public sbyte MaxX { get { return System.Math.Max(Position.X, (sbyte)(Position.X + Size.X)); } }
        public sbyte MinY { get { return System.Math.Min(Position.Y, (sbyte)(Position.Y + Size.Y)); } }
        public sbyte MaxY { get { return System.Math.Max(Position.Y, (sbyte)(Position.Y + Size.Y)); } }
        
        public Vector2 Center {
            get {
                return new Vector2(
                Position.X + Size.X / 2f,
                Position.Y + Size.Y / 2f
                );
            }
        }
        
        public Box2i Translate(Vector2i v)
        {
            return new Box2i(Position + v, Size);
        }
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Box3b : System.IEquatable<Box3b>
    {
        public readonly Vector3b Position;
        public readonly Vector3b Size;
        
        public Box3b(Vector3b position, Vector3b size){
            Position = position;
            Size = size;
        }
        
        public Box3b(sbyte x, sbyte y, sbyte z, sbyte sx, sbyte sy, sbyte sz){
            Position = new Vector3b(x, y, z);
            Size = new Vector3b(sx, sy, sz);
        }
        
        public static explicit operator Box3ub(Box3b v)
        {
            return new Box3ub((Vector3ub)v.Position, (Vector3ub)v.Size);
        }
        
        public static implicit operator Box3s(Box3b v)
        {
            return new Box3s(v.Position, v.Size);
        }
        
        public static explicit operator Box3us(Box3b v)
        {
            return new Box3us((Vector3us)v.Position, (Vector3us)v.Size);
        }
        
        public static implicit operator Box3i(Box3b v)
        {
            return new Box3i(v.Position, v.Size);
        }
        
        public static explicit operator Box3ui(Box3b v)
        {
            return new Box3ui((Vector3ui)v.Position, (Vector3ui)v.Size);
        }
        
        public static implicit operator Box3(Box3b v)
        {
            return new Box3(v.Position, v.Size);
        }
        
        public static implicit operator Box3d(Box3b v)
        {
            return new Box3d(v.Position, v.Size);
        }
        
        public override string ToString()
        {
            return Position.ToString() + Size.ToString();}
        
        public static bool operator ==(Box3b a, Box3b b)
        {
            return a.Position == b.Position && a.Size == b.Size;
        }
        
        public static bool operator !=(Box3b a, Box3b b)
        {
            return a.Position != b.Position || a.Size != b.Size;
        }
        
        public bool Equals(Box3b other)
        {
            return Position == other.Position && Size == other.Size;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Box3b)) return false;
            var b = (Box3b)other;
            return Position == b.Position && Size == b.Size;
        }
        
        public override int GetHashCode()
        {
            return Position.GetHashCode() ^ Size.GetHashCode();
        }
        
        public sbyte MinX { get { return System.Math.Min(Position.X, (sbyte)(Position.X + Size.X)); } }
        public sbyte MaxX { get { return System.Math.Max(Position.X, (sbyte)(Position.X + Size.X)); } }
        public sbyte MinY { get { return System.Math.Min(Position.Y, (sbyte)(Position.Y + Size.Y)); } }
        public sbyte MaxY { get { return System.Math.Max(Position.Y, (sbyte)(Position.Y + Size.Y)); } }
        public sbyte MinZ { get { return System.Math.Min(Position.Z, (sbyte)(Position.Z + Size.Z)); } }
        public sbyte MaxZ { get { return System.Math.Max(Position.Z, (sbyte)(Position.Z + Size.Z)); } }
        
        public Vector3 Center {
            get {
                return new Vector3(
                Position.X + Size.X / 2f,
                Position.Y + Size.Y / 2f,
                Position.Z + Size.Z / 2f
                );
            }
        }
        
        public Box3i Translate(Vector3i v)
        {
            return new Box3i(Position + v, Size);
        }
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Box2ub : System.IEquatable<Box2ub>
    {
        public readonly Vector2ub Position;
        public readonly Vector2ub Size;
        
        public Box2ub(Vector2ub position, Vector2ub size){
            Position = position;
            Size = size;
        }
        
        public Box2ub(byte x, byte y, byte sx, byte sy){
            Position = new Vector2ub(x, y);
            Size = new Vector2ub(sx, sy);
        }
        
        public static explicit operator Box2b(Box2ub v)
        {
            return new Box2b((Vector2b)v.Position, (Vector2b)v.Size);
        }
        
        public static implicit operator Box2s(Box2ub v)
        {
            return new Box2s(v.Position, v.Size);
        }
        
        public static implicit operator Box2us(Box2ub v)
        {
            return new Box2us(v.Position, v.Size);
        }
        
        public static implicit operator Box2i(Box2ub v)
        {
            return new Box2i(v.Position, v.Size);
        }
        
        public static implicit operator Box2ui(Box2ub v)
        {
            return new Box2ui(v.Position, v.Size);
        }
        
        public static implicit operator Box2(Box2ub v)
        {
            return new Box2(v.Position, v.Size);
        }
        
        public static implicit operator Box2d(Box2ub v)
        {
            return new Box2d(v.Position, v.Size);
        }
        
        public override string ToString()
        {
            return Position.ToString() + Size.ToString();}
        
        public static bool operator ==(Box2ub a, Box2ub b)
        {
            return a.Position == b.Position && a.Size == b.Size;
        }
        
        public static bool operator !=(Box2ub a, Box2ub b)
        {
            return a.Position != b.Position || a.Size != b.Size;
        }
        
        public bool Equals(Box2ub other)
        {
            return Position == other.Position && Size == other.Size;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Box2ub)) return false;
            var b = (Box2ub)other;
            return Position == b.Position && Size == b.Size;
        }
        
        public override int GetHashCode()
        {
            return Position.GetHashCode() ^ Size.GetHashCode();
        }
        
        public byte MinX { get { return System.Math.Min(Position.X, (byte)(Position.X + Size.X)); } }
        public byte MaxX { get { return System.Math.Max(Position.X, (byte)(Position.X + Size.X)); } }
        public byte MinY { get { return System.Math.Min(Position.Y, (byte)(Position.Y + Size.Y)); } }
        public byte MaxY { get { return System.Math.Max(Position.Y, (byte)(Position.Y + Size.Y)); } }
        
        public Vector2 Center {
            get {
                return new Vector2(
                Position.X + Size.X / 2f,
                Position.Y + Size.Y / 2f
                );
            }
        }
        
        public Box2i Translate(Vector2i v)
        {
            return new Box2i(Position + v, Size);
        }
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Box3ub : System.IEquatable<Box3ub>
    {
        public readonly Vector3ub Position;
        public readonly Vector3ub Size;
        
        public Box3ub(Vector3ub position, Vector3ub size){
            Position = position;
            Size = size;
        }
        
        public Box3ub(byte x, byte y, byte z, byte sx, byte sy, byte sz){
            Position = new Vector3ub(x, y, z);
            Size = new Vector3ub(sx, sy, sz);
        }
        
        public static explicit operator Box3b(Box3ub v)
        {
            return new Box3b((Vector3b)v.Position, (Vector3b)v.Size);
        }
        
        public static implicit operator Box3s(Box3ub v)
        {
            return new Box3s(v.Position, v.Size);
        }
        
        public static implicit operator Box3us(Box3ub v)
        {
            return new Box3us(v.Position, v.Size);
        }
        
        public static implicit operator Box3i(Box3ub v)
        {
            return new Box3i(v.Position, v.Size);
        }
        
        public static implicit operator Box3ui(Box3ub v)
        {
            return new Box3ui(v.Position, v.Size);
        }
        
        public static implicit operator Box3(Box3ub v)
        {
            return new Box3(v.Position, v.Size);
        }
        
        public static implicit operator Box3d(Box3ub v)
        {
            return new Box3d(v.Position, v.Size);
        }
        
        public override string ToString()
        {
            return Position.ToString() + Size.ToString();}
        
        public static bool operator ==(Box3ub a, Box3ub b)
        {
            return a.Position == b.Position && a.Size == b.Size;
        }
        
        public static bool operator !=(Box3ub a, Box3ub b)
        {
            return a.Position != b.Position || a.Size != b.Size;
        }
        
        public bool Equals(Box3ub other)
        {
            return Position == other.Position && Size == other.Size;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Box3ub)) return false;
            var b = (Box3ub)other;
            return Position == b.Position && Size == b.Size;
        }
        
        public override int GetHashCode()
        {
            return Position.GetHashCode() ^ Size.GetHashCode();
        }
        
        public byte MinX { get { return System.Math.Min(Position.X, (byte)(Position.X + Size.X)); } }
        public byte MaxX { get { return System.Math.Max(Position.X, (byte)(Position.X + Size.X)); } }
        public byte MinY { get { return System.Math.Min(Position.Y, (byte)(Position.Y + Size.Y)); } }
        public byte MaxY { get { return System.Math.Max(Position.Y, (byte)(Position.Y + Size.Y)); } }
        public byte MinZ { get { return System.Math.Min(Position.Z, (byte)(Position.Z + Size.Z)); } }
        public byte MaxZ { get { return System.Math.Max(Position.Z, (byte)(Position.Z + Size.Z)); } }
        
        public Vector3 Center {
            get {
                return new Vector3(
                Position.X + Size.X / 2f,
                Position.Y + Size.Y / 2f,
                Position.Z + Size.Z / 2f
                );
            }
        }
        
        public Box3i Translate(Vector3i v)
        {
            return new Box3i(Position + v, Size);
        }
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Box2s : System.IEquatable<Box2s>
    {
        public readonly Vector2s Position;
        public readonly Vector2s Size;
        
        public Box2s(Vector2s position, Vector2s size){
            Position = position;
            Size = size;
        }
        
        public Box2s(short x, short y, short sx, short sy){
            Position = new Vector2s(x, y);
            Size = new Vector2s(sx, sy);
        }
        
        public static explicit operator Box2b(Box2s v)
        {
            return new Box2b((Vector2b)v.Position, (Vector2b)v.Size);
        }
        
        public static explicit operator Box2ub(Box2s v)
        {
            return new Box2ub((Vector2ub)v.Position, (Vector2ub)v.Size);
        }
        
        public static explicit operator Box2us(Box2s v)
        {
            return new Box2us((Vector2us)v.Position, (Vector2us)v.Size);
        }
        
        public static implicit operator Box2i(Box2s v)
        {
            return new Box2i(v.Position, v.Size);
        }
        
        public static explicit operator Box2ui(Box2s v)
        {
            return new Box2ui((Vector2ui)v.Position, (Vector2ui)v.Size);
        }
        
        public static implicit operator Box2(Box2s v)
        {
            return new Box2(v.Position, v.Size);
        }
        
        public static implicit operator Box2d(Box2s v)
        {
            return new Box2d(v.Position, v.Size);
        }
        
        public override string ToString()
        {
            return Position.ToString() + Size.ToString();}
        
        public static bool operator ==(Box2s a, Box2s b)
        {
            return a.Position == b.Position && a.Size == b.Size;
        }
        
        public static bool operator !=(Box2s a, Box2s b)
        {
            return a.Position != b.Position || a.Size != b.Size;
        }
        
        public bool Equals(Box2s other)
        {
            return Position == other.Position && Size == other.Size;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Box2s)) return false;
            var b = (Box2s)other;
            return Position == b.Position && Size == b.Size;
        }
        
        public override int GetHashCode()
        {
            return Position.GetHashCode() ^ Size.GetHashCode();
        }
        
        public short MinX { get { return System.Math.Min(Position.X, (short)(Position.X + Size.X)); } }
        public short MaxX { get { return System.Math.Max(Position.X, (short)(Position.X + Size.X)); } }
        public short MinY { get { return System.Math.Min(Position.Y, (short)(Position.Y + Size.Y)); } }
        public short MaxY { get { return System.Math.Max(Position.Y, (short)(Position.Y + Size.Y)); } }
        
        public Vector2 Center {
            get {
                return new Vector2(
                Position.X + Size.X / 2f,
                Position.Y + Size.Y / 2f
                );
            }
        }
        
        public Box2i Translate(Vector2i v)
        {
            return new Box2i(Position + v, Size);
        }
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Box3s : System.IEquatable<Box3s>
    {
        public readonly Vector3s Position;
        public readonly Vector3s Size;
        
        public Box3s(Vector3s position, Vector3s size){
            Position = position;
            Size = size;
        }
        
        public Box3s(short x, short y, short z, short sx, short sy, short sz){
            Position = new Vector3s(x, y, z);
            Size = new Vector3s(sx, sy, sz);
        }
        
        public static explicit operator Box3b(Box3s v)
        {
            return new Box3b((Vector3b)v.Position, (Vector3b)v.Size);
        }
        
        public static explicit operator Box3ub(Box3s v)
        {
            return new Box3ub((Vector3ub)v.Position, (Vector3ub)v.Size);
        }
        
        public static explicit operator Box3us(Box3s v)
        {
            return new Box3us((Vector3us)v.Position, (Vector3us)v.Size);
        }
        
        public static implicit operator Box3i(Box3s v)
        {
            return new Box3i(v.Position, v.Size);
        }
        
        public static explicit operator Box3ui(Box3s v)
        {
            return new Box3ui((Vector3ui)v.Position, (Vector3ui)v.Size);
        }
        
        public static implicit operator Box3(Box3s v)
        {
            return new Box3(v.Position, v.Size);
        }
        
        public static implicit operator Box3d(Box3s v)
        {
            return new Box3d(v.Position, v.Size);
        }
        
        public override string ToString()
        {
            return Position.ToString() + Size.ToString();}
        
        public static bool operator ==(Box3s a, Box3s b)
        {
            return a.Position == b.Position && a.Size == b.Size;
        }
        
        public static bool operator !=(Box3s a, Box3s b)
        {
            return a.Position != b.Position || a.Size != b.Size;
        }
        
        public bool Equals(Box3s other)
        {
            return Position == other.Position && Size == other.Size;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Box3s)) return false;
            var b = (Box3s)other;
            return Position == b.Position && Size == b.Size;
        }
        
        public override int GetHashCode()
        {
            return Position.GetHashCode() ^ Size.GetHashCode();
        }
        
        public short MinX { get { return System.Math.Min(Position.X, (short)(Position.X + Size.X)); } }
        public short MaxX { get { return System.Math.Max(Position.X, (short)(Position.X + Size.X)); } }
        public short MinY { get { return System.Math.Min(Position.Y, (short)(Position.Y + Size.Y)); } }
        public short MaxY { get { return System.Math.Max(Position.Y, (short)(Position.Y + Size.Y)); } }
        public short MinZ { get { return System.Math.Min(Position.Z, (short)(Position.Z + Size.Z)); } }
        public short MaxZ { get { return System.Math.Max(Position.Z, (short)(Position.Z + Size.Z)); } }
        
        public Vector3 Center {
            get {
                return new Vector3(
                Position.X + Size.X / 2f,
                Position.Y + Size.Y / 2f,
                Position.Z + Size.Z / 2f
                );
            }
        }
        
        public Box3i Translate(Vector3i v)
        {
            return new Box3i(Position + v, Size);
        }
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Box2us : System.IEquatable<Box2us>
    {
        public readonly Vector2us Position;
        public readonly Vector2us Size;
        
        public Box2us(Vector2us position, Vector2us size){
            Position = position;
            Size = size;
        }
        
        public Box2us(ushort x, ushort y, ushort sx, ushort sy){
            Position = new Vector2us(x, y);
            Size = new Vector2us(sx, sy);
        }
        
        public static explicit operator Box2b(Box2us v)
        {
            return new Box2b((Vector2b)v.Position, (Vector2b)v.Size);
        }
        
        public static explicit operator Box2ub(Box2us v)
        {
            return new Box2ub((Vector2ub)v.Position, (Vector2ub)v.Size);
        }
        
        public static explicit operator Box2s(Box2us v)
        {
            return new Box2s((Vector2s)v.Position, (Vector2s)v.Size);
        }
        
        public static implicit operator Box2i(Box2us v)
        {
            return new Box2i(v.Position, v.Size);
        }
        
        public static implicit operator Box2ui(Box2us v)
        {
            return new Box2ui(v.Position, v.Size);
        }
        
        public static implicit operator Box2(Box2us v)
        {
            return new Box2(v.Position, v.Size);
        }
        
        public static implicit operator Box2d(Box2us v)
        {
            return new Box2d(v.Position, v.Size);
        }
        
        public override string ToString()
        {
            return Position.ToString() + Size.ToString();}
        
        public static bool operator ==(Box2us a, Box2us b)
        {
            return a.Position == b.Position && a.Size == b.Size;
        }
        
        public static bool operator !=(Box2us a, Box2us b)
        {
            return a.Position != b.Position || a.Size != b.Size;
        }
        
        public bool Equals(Box2us other)
        {
            return Position == other.Position && Size == other.Size;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Box2us)) return false;
            var b = (Box2us)other;
            return Position == b.Position && Size == b.Size;
        }
        
        public override int GetHashCode()
        {
            return Position.GetHashCode() ^ Size.GetHashCode();
        }
        
        public ushort MinX { get { return System.Math.Min(Position.X, (ushort)(Position.X + Size.X)); } }
        public ushort MaxX { get { return System.Math.Max(Position.X, (ushort)(Position.X + Size.X)); } }
        public ushort MinY { get { return System.Math.Min(Position.Y, (ushort)(Position.Y + Size.Y)); } }
        public ushort MaxY { get { return System.Math.Max(Position.Y, (ushort)(Position.Y + Size.Y)); } }
        
        public Vector2 Center {
            get {
                return new Vector2(
                Position.X + Size.X / 2f,
                Position.Y + Size.Y / 2f
                );
            }
        }
        
        public Box2i Translate(Vector2i v)
        {
            return new Box2i(Position + v, Size);
        }
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Box3us : System.IEquatable<Box3us>
    {
        public readonly Vector3us Position;
        public readonly Vector3us Size;
        
        public Box3us(Vector3us position, Vector3us size){
            Position = position;
            Size = size;
        }
        
        public Box3us(ushort x, ushort y, ushort z, ushort sx, ushort sy, ushort sz){
            Position = new Vector3us(x, y, z);
            Size = new Vector3us(sx, sy, sz);
        }
        
        public static explicit operator Box3b(Box3us v)
        {
            return new Box3b((Vector3b)v.Position, (Vector3b)v.Size);
        }
        
        public static explicit operator Box3ub(Box3us v)
        {
            return new Box3ub((Vector3ub)v.Position, (Vector3ub)v.Size);
        }
        
        public static explicit operator Box3s(Box3us v)
        {
            return new Box3s((Vector3s)v.Position, (Vector3s)v.Size);
        }
        
        public static implicit operator Box3i(Box3us v)
        {
            return new Box3i(v.Position, v.Size);
        }
        
        public static implicit operator Box3ui(Box3us v)
        {
            return new Box3ui(v.Position, v.Size);
        }
        
        public static implicit operator Box3(Box3us v)
        {
            return new Box3(v.Position, v.Size);
        }
        
        public static implicit operator Box3d(Box3us v)
        {
            return new Box3d(v.Position, v.Size);
        }
        
        public override string ToString()
        {
            return Position.ToString() + Size.ToString();}
        
        public static bool operator ==(Box3us a, Box3us b)
        {
            return a.Position == b.Position && a.Size == b.Size;
        }
        
        public static bool operator !=(Box3us a, Box3us b)
        {
            return a.Position != b.Position || a.Size != b.Size;
        }
        
        public bool Equals(Box3us other)
        {
            return Position == other.Position && Size == other.Size;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Box3us)) return false;
            var b = (Box3us)other;
            return Position == b.Position && Size == b.Size;
        }
        
        public override int GetHashCode()
        {
            return Position.GetHashCode() ^ Size.GetHashCode();
        }
        
        public ushort MinX { get { return System.Math.Min(Position.X, (ushort)(Position.X + Size.X)); } }
        public ushort MaxX { get { return System.Math.Max(Position.X, (ushort)(Position.X + Size.X)); } }
        public ushort MinY { get { return System.Math.Min(Position.Y, (ushort)(Position.Y + Size.Y)); } }
        public ushort MaxY { get { return System.Math.Max(Position.Y, (ushort)(Position.Y + Size.Y)); } }
        public ushort MinZ { get { return System.Math.Min(Position.Z, (ushort)(Position.Z + Size.Z)); } }
        public ushort MaxZ { get { return System.Math.Max(Position.Z, (ushort)(Position.Z + Size.Z)); } }
        
        public Vector3 Center {
            get {
                return new Vector3(
                Position.X + Size.X / 2f,
                Position.Y + Size.Y / 2f,
                Position.Z + Size.Z / 2f
                );
            }
        }
        
        public Box3i Translate(Vector3i v)
        {
            return new Box3i(Position + v, Size);
        }
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Box2i : System.IEquatable<Box2i>
    {
        public readonly Vector2i Position;
        public readonly Vector2i Size;
        
        public Box2i(Vector2i position, Vector2i size){
            Position = position;
            Size = size;
        }
        
        public Box2i(int x, int y, int sx, int sy){
            Position = new Vector2i(x, y);
            Size = new Vector2i(sx, sy);
        }
        
        public static explicit operator Box2b(Box2i v)
        {
            return new Box2b((Vector2b)v.Position, (Vector2b)v.Size);
        }
        
        public static explicit operator Box2ub(Box2i v)
        {
            return new Box2ub((Vector2ub)v.Position, (Vector2ub)v.Size);
        }
        
        public static explicit operator Box2s(Box2i v)
        {
            return new Box2s((Vector2s)v.Position, (Vector2s)v.Size);
        }
        
        public static explicit operator Box2us(Box2i v)
        {
            return new Box2us((Vector2us)v.Position, (Vector2us)v.Size);
        }
        
        public static explicit operator Box2ui(Box2i v)
        {
            return new Box2ui((Vector2ui)v.Position, (Vector2ui)v.Size);
        }
        
        public static implicit operator Box2(Box2i v)
        {
            return new Box2(v.Position, v.Size);
        }
        
        public static implicit operator Box2d(Box2i v)
        {
            return new Box2d(v.Position, v.Size);
        }
        
        public override string ToString()
        {
            return Position.ToString() + Size.ToString();}
        
        public static bool operator ==(Box2i a, Box2i b)
        {
            return a.Position == b.Position && a.Size == b.Size;
        }
        
        public static bool operator !=(Box2i a, Box2i b)
        {
            return a.Position != b.Position || a.Size != b.Size;
        }
        
        public bool Equals(Box2i other)
        {
            return Position == other.Position && Size == other.Size;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Box2i)) return false;
            var b = (Box2i)other;
            return Position == b.Position && Size == b.Size;
        }
        
        public override int GetHashCode()
        {
            return Position.GetHashCode() ^ Size.GetHashCode();
        }
        
        public int MinX { get { return System.Math.Min(Position.X, (int)(Position.X + Size.X)); } }
        public int MaxX { get { return System.Math.Max(Position.X, (int)(Position.X + Size.X)); } }
        public int MinY { get { return System.Math.Min(Position.Y, (int)(Position.Y + Size.Y)); } }
        public int MaxY { get { return System.Math.Max(Position.Y, (int)(Position.Y + Size.Y)); } }
        
        public Vector2 Center {
            get {
                return new Vector2(
                Position.X + Size.X / 2f,
                Position.Y + Size.Y / 2f
                );
            }
        }
        
        public Box2i Translate(Vector2i v)
        {
            return new Box2i(Position + v, Size);
        }
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Box3i : System.IEquatable<Box3i>
    {
        public readonly Vector3i Position;
        public readonly Vector3i Size;
        
        public Box3i(Vector3i position, Vector3i size){
            Position = position;
            Size = size;
        }
        
        public Box3i(int x, int y, int z, int sx, int sy, int sz){
            Position = new Vector3i(x, y, z);
            Size = new Vector3i(sx, sy, sz);
        }
        
        public static explicit operator Box3b(Box3i v)
        {
            return new Box3b((Vector3b)v.Position, (Vector3b)v.Size);
        }
        
        public static explicit operator Box3ub(Box3i v)
        {
            return new Box3ub((Vector3ub)v.Position, (Vector3ub)v.Size);
        }
        
        public static explicit operator Box3s(Box3i v)
        {
            return new Box3s((Vector3s)v.Position, (Vector3s)v.Size);
        }
        
        public static explicit operator Box3us(Box3i v)
        {
            return new Box3us((Vector3us)v.Position, (Vector3us)v.Size);
        }
        
        public static explicit operator Box3ui(Box3i v)
        {
            return new Box3ui((Vector3ui)v.Position, (Vector3ui)v.Size);
        }
        
        public static implicit operator Box3(Box3i v)
        {
            return new Box3(v.Position, v.Size);
        }
        
        public static implicit operator Box3d(Box3i v)
        {
            return new Box3d(v.Position, v.Size);
        }
        
        public override string ToString()
        {
            return Position.ToString() + Size.ToString();}
        
        public static bool operator ==(Box3i a, Box3i b)
        {
            return a.Position == b.Position && a.Size == b.Size;
        }
        
        public static bool operator !=(Box3i a, Box3i b)
        {
            return a.Position != b.Position || a.Size != b.Size;
        }
        
        public bool Equals(Box3i other)
        {
            return Position == other.Position && Size == other.Size;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Box3i)) return false;
            var b = (Box3i)other;
            return Position == b.Position && Size == b.Size;
        }
        
        public override int GetHashCode()
        {
            return Position.GetHashCode() ^ Size.GetHashCode();
        }
        
        public int MinX { get { return System.Math.Min(Position.X, (int)(Position.X + Size.X)); } }
        public int MaxX { get { return System.Math.Max(Position.X, (int)(Position.X + Size.X)); } }
        public int MinY { get { return System.Math.Min(Position.Y, (int)(Position.Y + Size.Y)); } }
        public int MaxY { get { return System.Math.Max(Position.Y, (int)(Position.Y + Size.Y)); } }
        public int MinZ { get { return System.Math.Min(Position.Z, (int)(Position.Z + Size.Z)); } }
        public int MaxZ { get { return System.Math.Max(Position.Z, (int)(Position.Z + Size.Z)); } }
        
        public Vector3 Center {
            get {
                return new Vector3(
                Position.X + Size.X / 2f,
                Position.Y + Size.Y / 2f,
                Position.Z + Size.Z / 2f
                );
            }
        }
        
        public Box3i Translate(Vector3i v)
        {
            return new Box3i(Position + v, Size);
        }
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Box2ui : System.IEquatable<Box2ui>
    {
        public readonly Vector2ui Position;
        public readonly Vector2ui Size;
        
        public Box2ui(Vector2ui position, Vector2ui size){
            Position = position;
            Size = size;
        }
        
        public Box2ui(uint x, uint y, uint sx, uint sy){
            Position = new Vector2ui(x, y);
            Size = new Vector2ui(sx, sy);
        }
        
        public static explicit operator Box2b(Box2ui v)
        {
            return new Box2b((Vector2b)v.Position, (Vector2b)v.Size);
        }
        
        public static explicit operator Box2ub(Box2ui v)
        {
            return new Box2ub((Vector2ub)v.Position, (Vector2ub)v.Size);
        }
        
        public static explicit operator Box2s(Box2ui v)
        {
            return new Box2s((Vector2s)v.Position, (Vector2s)v.Size);
        }
        
        public static explicit operator Box2us(Box2ui v)
        {
            return new Box2us((Vector2us)v.Position, (Vector2us)v.Size);
        }
        
        public static explicit operator Box2i(Box2ui v)
        {
            return new Box2i((Vector2i)v.Position, (Vector2i)v.Size);
        }
        
        public static implicit operator Box2(Box2ui v)
        {
            return new Box2(v.Position, v.Size);
        }
        
        public static implicit operator Box2d(Box2ui v)
        {
            return new Box2d(v.Position, v.Size);
        }
        
        public override string ToString()
        {
            return Position.ToString() + Size.ToString();}
        
        public static bool operator ==(Box2ui a, Box2ui b)
        {
            return a.Position == b.Position && a.Size == b.Size;
        }
        
        public static bool operator !=(Box2ui a, Box2ui b)
        {
            return a.Position != b.Position || a.Size != b.Size;
        }
        
        public bool Equals(Box2ui other)
        {
            return Position == other.Position && Size == other.Size;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Box2ui)) return false;
            var b = (Box2ui)other;
            return Position == b.Position && Size == b.Size;
        }
        
        public override int GetHashCode()
        {
            return Position.GetHashCode() ^ Size.GetHashCode();
        }
        
        public uint MinX { get { return System.Math.Min(Position.X, (uint)(Position.X + Size.X)); } }
        public uint MaxX { get { return System.Math.Max(Position.X, (uint)(Position.X + Size.X)); } }
        public uint MinY { get { return System.Math.Min(Position.Y, (uint)(Position.Y + Size.Y)); } }
        public uint MaxY { get { return System.Math.Max(Position.Y, (uint)(Position.Y + Size.Y)); } }
        
        public Vector2 Center {
            get {
                return new Vector2(
                Position.X + Size.X / 2f,
                Position.Y + Size.Y / 2f
                );
            }
        }
        
        public Box2ui Translate(Vector2ui v)
        {
            return new Box2ui(Position + v, Size);
        }
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Box3ui : System.IEquatable<Box3ui>
    {
        public readonly Vector3ui Position;
        public readonly Vector3ui Size;
        
        public Box3ui(Vector3ui position, Vector3ui size){
            Position = position;
            Size = size;
        }
        
        public Box3ui(uint x, uint y, uint z, uint sx, uint sy, uint sz){
            Position = new Vector3ui(x, y, z);
            Size = new Vector3ui(sx, sy, sz);
        }
        
        public static explicit operator Box3b(Box3ui v)
        {
            return new Box3b((Vector3b)v.Position, (Vector3b)v.Size);
        }
        
        public static explicit operator Box3ub(Box3ui v)
        {
            return new Box3ub((Vector3ub)v.Position, (Vector3ub)v.Size);
        }
        
        public static explicit operator Box3s(Box3ui v)
        {
            return new Box3s((Vector3s)v.Position, (Vector3s)v.Size);
        }
        
        public static explicit operator Box3us(Box3ui v)
        {
            return new Box3us((Vector3us)v.Position, (Vector3us)v.Size);
        }
        
        public static explicit operator Box3i(Box3ui v)
        {
            return new Box3i((Vector3i)v.Position, (Vector3i)v.Size);
        }
        
        public static implicit operator Box3(Box3ui v)
        {
            return new Box3(v.Position, v.Size);
        }
        
        public static implicit operator Box3d(Box3ui v)
        {
            return new Box3d(v.Position, v.Size);
        }
        
        public override string ToString()
        {
            return Position.ToString() + Size.ToString();}
        
        public static bool operator ==(Box3ui a, Box3ui b)
        {
            return a.Position == b.Position && a.Size == b.Size;
        }
        
        public static bool operator !=(Box3ui a, Box3ui b)
        {
            return a.Position != b.Position || a.Size != b.Size;
        }
        
        public bool Equals(Box3ui other)
        {
            return Position == other.Position && Size == other.Size;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Box3ui)) return false;
            var b = (Box3ui)other;
            return Position == b.Position && Size == b.Size;
        }
        
        public override int GetHashCode()
        {
            return Position.GetHashCode() ^ Size.GetHashCode();
        }
        
        public uint MinX { get { return System.Math.Min(Position.X, (uint)(Position.X + Size.X)); } }
        public uint MaxX { get { return System.Math.Max(Position.X, (uint)(Position.X + Size.X)); } }
        public uint MinY { get { return System.Math.Min(Position.Y, (uint)(Position.Y + Size.Y)); } }
        public uint MaxY { get { return System.Math.Max(Position.Y, (uint)(Position.Y + Size.Y)); } }
        public uint MinZ { get { return System.Math.Min(Position.Z, (uint)(Position.Z + Size.Z)); } }
        public uint MaxZ { get { return System.Math.Max(Position.Z, (uint)(Position.Z + Size.Z)); } }
        
        public Vector3 Center {
            get {
                return new Vector3(
                Position.X + Size.X / 2f,
                Position.Y + Size.Y / 2f,
                Position.Z + Size.Z / 2f
                );
            }
        }
        
        public Box3ui Translate(Vector3ui v)
        {
            return new Box3ui(Position + v, Size);
        }
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Box2 : System.IEquatable<Box2>
    {
        public readonly Vector2 Position;
        public readonly Vector2 Size;
        
        public Box2(Vector2 position, Vector2 size){
            Position = position;
            Size = size;
        }
        
        public Box2(float x, float y, float sx, float sy){
            Position = new Vector2(x, y);
            Size = new Vector2(sx, sy);
        }
        
        public static explicit operator Box2b(Box2 v)
        {
            return new Box2b((Vector2b)v.Position, (Vector2b)v.Size);
        }
        
        public static explicit operator Box2ub(Box2 v)
        {
            return new Box2ub((Vector2ub)v.Position, (Vector2ub)v.Size);
        }
        
        public static explicit operator Box2s(Box2 v)
        {
            return new Box2s((Vector2s)v.Position, (Vector2s)v.Size);
        }
        
        public static explicit operator Box2us(Box2 v)
        {
            return new Box2us((Vector2us)v.Position, (Vector2us)v.Size);
        }
        
        public static explicit operator Box2i(Box2 v)
        {
            return new Box2i((Vector2i)v.Position, (Vector2i)v.Size);
        }
        
        public static explicit operator Box2ui(Box2 v)
        {
            return new Box2ui((Vector2ui)v.Position, (Vector2ui)v.Size);
        }
        
        public static implicit operator Box2d(Box2 v)
        {
            return new Box2d(v.Position, v.Size);
        }
        
        public override string ToString()
        {
            return Position.ToString() + Size.ToString();}
        
        public static bool operator ==(Box2 a, Box2 b)
        {
            return a.Position == b.Position && a.Size == b.Size;
        }
        
        public static bool operator !=(Box2 a, Box2 b)
        {
            return a.Position != b.Position || a.Size != b.Size;
        }
        
        public bool Equals(Box2 other)
        {
            return Position == other.Position && Size == other.Size;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Box2)) return false;
            var b = (Box2)other;
            return Position == b.Position && Size == b.Size;
        }
        
        public override int GetHashCode()
        {
            return Position.GetHashCode() ^ Size.GetHashCode();
        }
        
        public float MinX { get { return System.Math.Min(Position.X, (float)(Position.X + Size.X)); } }
        public float MaxX { get { return System.Math.Max(Position.X, (float)(Position.X + Size.X)); } }
        public float MinY { get { return System.Math.Min(Position.Y, (float)(Position.Y + Size.Y)); } }
        public float MaxY { get { return System.Math.Max(Position.Y, (float)(Position.Y + Size.Y)); } }
        
        public Vector2 Center {
            get {
                return new Vector2(
                Position.X + Size.X / 2f,
                Position.Y + Size.Y / 2f
                );
            }
        }
        
        public Box2 Translate(Vector2 v)
        {
            return new Box2(Position + v, Size);
        }
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Box3 : System.IEquatable<Box3>
    {
        public readonly Vector3 Position;
        public readonly Vector3 Size;
        
        public Box3(Vector3 position, Vector3 size){
            Position = position;
            Size = size;
        }
        
        public Box3(float x, float y, float z, float sx, float sy, float sz){
            Position = new Vector3(x, y, z);
            Size = new Vector3(sx, sy, sz);
        }
        
        public static explicit operator Box3b(Box3 v)
        {
            return new Box3b((Vector3b)v.Position, (Vector3b)v.Size);
        }
        
        public static explicit operator Box3ub(Box3 v)
        {
            return new Box3ub((Vector3ub)v.Position, (Vector3ub)v.Size);
        }
        
        public static explicit operator Box3s(Box3 v)
        {
            return new Box3s((Vector3s)v.Position, (Vector3s)v.Size);
        }
        
        public static explicit operator Box3us(Box3 v)
        {
            return new Box3us((Vector3us)v.Position, (Vector3us)v.Size);
        }
        
        public static explicit operator Box3i(Box3 v)
        {
            return new Box3i((Vector3i)v.Position, (Vector3i)v.Size);
        }
        
        public static explicit operator Box3ui(Box3 v)
        {
            return new Box3ui((Vector3ui)v.Position, (Vector3ui)v.Size);
        }
        
        public static implicit operator Box3d(Box3 v)
        {
            return new Box3d(v.Position, v.Size);
        }
        
        public override string ToString()
        {
            return Position.ToString() + Size.ToString();}
        
        public static bool operator ==(Box3 a, Box3 b)
        {
            return a.Position == b.Position && a.Size == b.Size;
        }
        
        public static bool operator !=(Box3 a, Box3 b)
        {
            return a.Position != b.Position || a.Size != b.Size;
        }
        
        public bool Equals(Box3 other)
        {
            return Position == other.Position && Size == other.Size;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Box3)) return false;
            var b = (Box3)other;
            return Position == b.Position && Size == b.Size;
        }
        
        public override int GetHashCode()
        {
            return Position.GetHashCode() ^ Size.GetHashCode();
        }
        
        public float MinX { get { return System.Math.Min(Position.X, (float)(Position.X + Size.X)); } }
        public float MaxX { get { return System.Math.Max(Position.X, (float)(Position.X + Size.X)); } }
        public float MinY { get { return System.Math.Min(Position.Y, (float)(Position.Y + Size.Y)); } }
        public float MaxY { get { return System.Math.Max(Position.Y, (float)(Position.Y + Size.Y)); } }
        public float MinZ { get { return System.Math.Min(Position.Z, (float)(Position.Z + Size.Z)); } }
        public float MaxZ { get { return System.Math.Max(Position.Z, (float)(Position.Z + Size.Z)); } }
        
        public Vector3 Center {
            get {
                return new Vector3(
                Position.X + Size.X / 2f,
                Position.Y + Size.Y / 2f,
                Position.Z + Size.Z / 2f
                );
            }
        }
        
        public Box3 Translate(Vector3 v)
        {
            return new Box3(Position + v, Size);
        }
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Box2d : System.IEquatable<Box2d>
    {
        public readonly Vector2d Position;
        public readonly Vector2d Size;
        
        public Box2d(Vector2d position, Vector2d size){
            Position = position;
            Size = size;
        }
        
        public Box2d(double x, double y, double sx, double sy){
            Position = new Vector2d(x, y);
            Size = new Vector2d(sx, sy);
        }
        
        public static explicit operator Box2b(Box2d v)
        {
            return new Box2b((Vector2b)v.Position, (Vector2b)v.Size);
        }
        
        public static explicit operator Box2ub(Box2d v)
        {
            return new Box2ub((Vector2ub)v.Position, (Vector2ub)v.Size);
        }
        
        public static explicit operator Box2s(Box2d v)
        {
            return new Box2s((Vector2s)v.Position, (Vector2s)v.Size);
        }
        
        public static explicit operator Box2us(Box2d v)
        {
            return new Box2us((Vector2us)v.Position, (Vector2us)v.Size);
        }
        
        public static explicit operator Box2i(Box2d v)
        {
            return new Box2i((Vector2i)v.Position, (Vector2i)v.Size);
        }
        
        public static explicit operator Box2ui(Box2d v)
        {
            return new Box2ui((Vector2ui)v.Position, (Vector2ui)v.Size);
        }
        
        public static explicit operator Box2(Box2d v)
        {
            return new Box2((Vector2)v.Position, (Vector2)v.Size);
        }
        
        public override string ToString()
        {
            return Position.ToString() + Size.ToString();}
        
        public static bool operator ==(Box2d a, Box2d b)
        {
            return a.Position == b.Position && a.Size == b.Size;
        }
        
        public static bool operator !=(Box2d a, Box2d b)
        {
            return a.Position != b.Position || a.Size != b.Size;
        }
        
        public bool Equals(Box2d other)
        {
            return Position == other.Position && Size == other.Size;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Box2d)) return false;
            var b = (Box2d)other;
            return Position == b.Position && Size == b.Size;
        }
        
        public override int GetHashCode()
        {
            return Position.GetHashCode() ^ Size.GetHashCode();
        }
        
        public double MinX { get { return System.Math.Min(Position.X, (double)(Position.X + Size.X)); } }
        public double MaxX { get { return System.Math.Max(Position.X, (double)(Position.X + Size.X)); } }
        public double MinY { get { return System.Math.Min(Position.Y, (double)(Position.Y + Size.Y)); } }
        public double MaxY { get { return System.Math.Max(Position.Y, (double)(Position.Y + Size.Y)); } }
        
        public Vector2d Center {
            get {
                return new Vector2d(
                Position.X + Size.X / 2d,
                Position.Y + Size.Y / 2d
                );
            }
        }
        
        public Box2d Translate(Vector2d v)
        {
            return new Box2d(Position + v, Size);
        }
        
    }
    
    
    [System.Serializable]
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Box3d : System.IEquatable<Box3d>
    {
        public readonly Vector3d Position;
        public readonly Vector3d Size;
        
        public Box3d(Vector3d position, Vector3d size){
            Position = position;
            Size = size;
        }
        
        public Box3d(double x, double y, double z, double sx, double sy, double sz){
            Position = new Vector3d(x, y, z);
            Size = new Vector3d(sx, sy, sz);
        }
        
        public static explicit operator Box3b(Box3d v)
        {
            return new Box3b((Vector3b)v.Position, (Vector3b)v.Size);
        }
        
        public static explicit operator Box3ub(Box3d v)
        {
            return new Box3ub((Vector3ub)v.Position, (Vector3ub)v.Size);
        }
        
        public static explicit operator Box3s(Box3d v)
        {
            return new Box3s((Vector3s)v.Position, (Vector3s)v.Size);
        }
        
        public static explicit operator Box3us(Box3d v)
        {
            return new Box3us((Vector3us)v.Position, (Vector3us)v.Size);
        }
        
        public static explicit operator Box3i(Box3d v)
        {
            return new Box3i((Vector3i)v.Position, (Vector3i)v.Size);
        }
        
        public static explicit operator Box3ui(Box3d v)
        {
            return new Box3ui((Vector3ui)v.Position, (Vector3ui)v.Size);
        }
        
        public static explicit operator Box3(Box3d v)
        {
            return new Box3((Vector3)v.Position, (Vector3)v.Size);
        }
        
        public override string ToString()
        {
            return Position.ToString() + Size.ToString();}
        
        public static bool operator ==(Box3d a, Box3d b)
        {
            return a.Position == b.Position && a.Size == b.Size;
        }
        
        public static bool operator !=(Box3d a, Box3d b)
        {
            return a.Position != b.Position || a.Size != b.Size;
        }
        
        public bool Equals(Box3d other)
        {
            return Position == other.Position && Size == other.Size;
        }
        
        public override bool Equals(object other)
        {
            if(!(other is Box3d)) return false;
            var b = (Box3d)other;
            return Position == b.Position && Size == b.Size;
        }
        
        public override int GetHashCode()
        {
            return Position.GetHashCode() ^ Size.GetHashCode();
        }
        
        public double MinX { get { return System.Math.Min(Position.X, (double)(Position.X + Size.X)); } }
        public double MaxX { get { return System.Math.Max(Position.X, (double)(Position.X + Size.X)); } }
        public double MinY { get { return System.Math.Min(Position.Y, (double)(Position.Y + Size.Y)); } }
        public double MaxY { get { return System.Math.Max(Position.Y, (double)(Position.Y + Size.Y)); } }
        public double MinZ { get { return System.Math.Min(Position.Z, (double)(Position.Z + Size.Z)); } }
        public double MaxZ { get { return System.Math.Max(Position.Z, (double)(Position.Z + Size.Z)); } }
        
        public Vector3d Center {
            get {
                return new Vector3d(
                Position.X + Size.X / 2d,
                Position.Y + Size.Y / 2d,
                Position.Z + Size.Z / 2d
                );
            }
        }
        
        public Box3d Translate(Vector3d v)
        {
            return new Box3d(Position + v, Size);
        }
        
    }
    
    
}
