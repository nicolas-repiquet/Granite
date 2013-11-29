
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Granite3D
{


	[DebuggerDisplay("[{m_x}, {m_y}]")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct Vector2i : IEquatable<Vector2i>
	{
		public static Vector2i Zero { get { return new Vector2i(0, 0); } }

		
		public static Vector2i UnitX { get { return new Vector2i(1, 0); } }
		private readonly int m_x;
		public int X { get { return m_x; } }
		
		public static Vector2i UnitY { get { return new Vector2i(0, 1); } }
		private readonly int m_y;
		public int Y { get { return m_y; } }
		
		public Vector2i(int x, int y)
		{
		
			m_x = x;
		
			m_y = y;
		
		}

		public int Length { get { return (int)System.Math.Sqrt(m_x * m_x + m_y * m_y); } }

		public int SquaredLength { get { return m_x * m_x + m_y * m_y; } }

		public Vector2i Normalize()
		{
			return this / Length;
		}

		public bool Equals(Vector2i other)
		{
			return m_x == other.m_x && m_y == other.m_y;
		}

		public override bool Equals(object other)
		{
			return other is Vector2i ? Equals((Vector2i)other) : false;
		}

		public override int GetHashCode()
		{
			return m_x.GetHashCode() + m_y.GetHashCode();
		}

		public static bool operator == (Vector2i a, Vector2i b)
		{
			return a.m_x == b.m_x && a.m_y == b.m_y;
		}

		public static bool operator != (Vector2i a, Vector2i b)
		{
			return a.m_x != b.m_x || a.m_y != b.m_y;
		}

		public static Vector2i operator + (Vector2i a, Vector2i b)
		{
			return new Vector2i(a.m_x + b.m_x, a.m_y + b.m_y);
		}

		public static Vector2i operator - (Vector2i a, Vector2i b)
		{
			return new Vector2i(a.m_x - b.m_x, a.m_y - b.m_y);
		}

		public static Vector2i operator - (Vector2i a)
		{
			return new Vector2i(-a.m_x, -a.m_y);
		}

		public static Vector2i operator / (Vector2i a, int b)
		{
			return new Vector2i(a.m_x / b, a.m_y / b);
		}

		public static Vector2i operator * (Vector2i a, int b)
		{
			return new Vector2i(a.m_x * b, a.m_y * b);
		}

		
		public static int Dot(Vector2i a, Vector2i b)
		{
			return a.m_x * b.m_x + a.m_y * b.m_y;
		}
	}


	[DebuggerDisplay("[{m_x}, {m_y}, {m_z}]")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct Vector3i : IEquatable<Vector3i>
	{
		public static Vector3i Zero { get { return new Vector3i(0, 0, 0); } }

		
		public static Vector3i UnitX { get { return new Vector3i(1, 0, 0); } }
		private readonly int m_x;
		public int X { get { return m_x; } }
		
		public static Vector3i UnitY { get { return new Vector3i(0, 1, 0); } }
		private readonly int m_y;
		public int Y { get { return m_y; } }
		
		public static Vector3i UnitZ { get { return new Vector3i(0, 0, 1); } }
		private readonly int m_z;
		public int Z { get { return m_z; } }
		
		public Vector3i(int x, int y, int z)
		{
		
			m_x = x;
		
			m_y = y;
		
			m_z = z;
		
		}

		public int Length { get { return (int)System.Math.Sqrt(m_x * m_x + m_y * m_y + m_z * m_z); } }

		public int SquaredLength { get { return m_x * m_x + m_y * m_y + m_z * m_z; } }

		public Vector3i Normalize()
		{
			return this / Length;
		}

		public bool Equals(Vector3i other)
		{
			return m_x == other.m_x && m_y == other.m_y && m_z == other.m_z;
		}

		public override bool Equals(object other)
		{
			return other is Vector3i ? Equals((Vector3i)other) : false;
		}

		public override int GetHashCode()
		{
			return m_x.GetHashCode() + m_y.GetHashCode() + m_z.GetHashCode();
		}

		public static bool operator == (Vector3i a, Vector3i b)
		{
			return a.m_x == b.m_x && a.m_y == b.m_y && a.m_z == b.m_z;
		}

		public static bool operator != (Vector3i a, Vector3i b)
		{
			return a.m_x != b.m_x || a.m_y != b.m_y || a.m_z != b.m_z;
		}

		public static Vector3i operator + (Vector3i a, Vector3i b)
		{
			return new Vector3i(a.m_x + b.m_x, a.m_y + b.m_y, a.m_z + b.m_z);
		}

		public static Vector3i operator - (Vector3i a, Vector3i b)
		{
			return new Vector3i(a.m_x - b.m_x, a.m_y - b.m_y, a.m_z - b.m_z);
		}

		public static Vector3i operator - (Vector3i a)
		{
			return new Vector3i(-a.m_x, -a.m_y, -a.m_z);
		}

		public static Vector3i operator / (Vector3i a, int b)
		{
			return new Vector3i(a.m_x / b, a.m_y / b, a.m_z / b);
		}

		public static Vector3i operator * (Vector3i a, int b)
		{
			return new Vector3i(a.m_x * b, a.m_y * b, a.m_z * b);
		}

		
		public static Vector3i Cross(Vector3i a, Vector3i b)
		{
			return new Vector3i(

				a.m_y * b.m_z - a.m_z * b.m_y,
				a.m_z * b.m_x - a.m_x * b.m_z,
				a.m_x * b.m_y - a.m_y * b.m_x
			);
		}
		
		public static int Dot(Vector3i a, Vector3i b)
		{
			return a.m_x * b.m_x + a.m_y * b.m_y + a.m_z * b.m_z;
		}
	}


	[DebuggerDisplay("[{m_x}, {m_y}, {m_z}, {m_w}]")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct Vector4i : IEquatable<Vector4i>
	{
		public static Vector4i Zero { get { return new Vector4i(0, 0, 0, 0); } }

		
		public static Vector4i UnitX { get { return new Vector4i(1, 0, 0, 0); } }
		private readonly int m_x;
		public int X { get { return m_x; } }
		
		public static Vector4i UnitY { get { return new Vector4i(0, 1, 0, 0); } }
		private readonly int m_y;
		public int Y { get { return m_y; } }
		
		public static Vector4i UnitZ { get { return new Vector4i(0, 0, 1, 0); } }
		private readonly int m_z;
		public int Z { get { return m_z; } }
		
		public static Vector4i UnitW { get { return new Vector4i(0, 0, 0, 1); } }
		private readonly int m_w;
		public int W { get { return m_w; } }
		
		public Vector4i(int x, int y, int z, int w)
		{
		
			m_x = x;
		
			m_y = y;
		
			m_z = z;
		
			m_w = w;
		
		}

		public int Length { get { return (int)System.Math.Sqrt(m_x * m_x + m_y * m_y + m_z * m_z + m_w * m_w); } }

		public int SquaredLength { get { return m_x * m_x + m_y * m_y + m_z * m_z + m_w * m_w; } }

		public Vector4i Normalize()
		{
			return this / Length;
		}

		public bool Equals(Vector4i other)
		{
			return m_x == other.m_x && m_y == other.m_y && m_z == other.m_z && m_w == other.m_w;
		}

		public override bool Equals(object other)
		{
			return other is Vector4i ? Equals((Vector4i)other) : false;
		}

		public override int GetHashCode()
		{
			return m_x.GetHashCode() + m_y.GetHashCode() + m_z.GetHashCode() + m_w.GetHashCode();
		}

		public static bool operator == (Vector4i a, Vector4i b)
		{
			return a.m_x == b.m_x && a.m_y == b.m_y && a.m_z == b.m_z && a.m_w == b.m_w;
		}

		public static bool operator != (Vector4i a, Vector4i b)
		{
			return a.m_x != b.m_x || a.m_y != b.m_y || a.m_z != b.m_z || a.m_w != b.m_w;
		}

		public static Vector4i operator + (Vector4i a, Vector4i b)
		{
			return new Vector4i(a.m_x + b.m_x, a.m_y + b.m_y, a.m_z + b.m_z, a.m_w + b.m_w);
		}

		public static Vector4i operator - (Vector4i a, Vector4i b)
		{
			return new Vector4i(a.m_x - b.m_x, a.m_y - b.m_y, a.m_z - b.m_z, a.m_w - b.m_w);
		}

		public static Vector4i operator - (Vector4i a)
		{
			return new Vector4i(-a.m_x, -a.m_y, -a.m_z, -a.m_w);
		}

		public static Vector4i operator / (Vector4i a, int b)
		{
			return new Vector4i(a.m_x / b, a.m_y / b, a.m_z / b, a.m_w / b);
		}

		public static Vector4i operator * (Vector4i a, int b)
		{
			return new Vector4i(a.m_x * b, a.m_y * b, a.m_z * b, a.m_w * b);
		}

		
		public static int Dot(Vector4i a, Vector4i b)
		{
			return a.m_x * b.m_x + a.m_y * b.m_y + a.m_z * b.m_z + a.m_w * b.m_w;
		}
	}




	[StructLayout(LayoutKind.Sequential)]
	public partial struct Box2i : IEquatable<Box2i>
	{
		private readonly Vector2i m_position;
		private readonly Vector2i m_size;

		public Vector2i Position { get { return m_position; } }
		public Vector2i Size { get { return m_size; } }

		public Box2i(Vector2i position, Vector2i size)
		{
			m_position = position;
			m_size = size;
		}

		public Box2i(
			int positionX, int positionY,
			int sizeX, int sizeY)
		{
			m_position = new Vector2i(positionX, positionY);
			m_size = new Vector2i(sizeX, sizeY);
		}

	
		public int MinX { get { return System.Math.Min(m_position.X, m_position.X + m_size.X); } }
		public int MaxX { get { return System.Math.Max(m_position.X, m_position.X + m_size.X); } }

	
		public int MinY { get { return System.Math.Min(m_position.Y, m_position.Y + m_size.Y); } }
		public int MaxY { get { return System.Math.Max(m_position.Y, m_position.Y + m_size.Y); } }


		public bool Equals(Box2i other)
		{
			return m_position == other.m_position && m_size == other.m_size;
		}

		public override bool Equals(object other)
		{
			return other is Box2i ? Equals((Box2i)other) : false;
		}

		public override int GetHashCode()
		{
			return m_position.GetHashCode() + m_size.GetHashCode();
		}

		public bool Contains(Vector2i p)
		{
			return p.X >= MinX && p.X <= MaxX && p.Y >= MinY && p.Y <= MaxY;
		}

		public static bool operator == (Box2i a, Box2i b)
		{
			return a.m_position == b.m_position && a.m_size == b.m_size;
		}

		public static bool operator != (Box2i a, Box2i b)
		{
			return a.m_position != b.m_position || a.m_size != b.m_size;
		}
	}


	[StructLayout(LayoutKind.Sequential)]
	public partial struct Box3i : IEquatable<Box3i>
	{
		private readonly Vector3i m_position;
		private readonly Vector3i m_size;

		public Vector3i Position { get { return m_position; } }
		public Vector3i Size { get { return m_size; } }

		public Box3i(Vector3i position, Vector3i size)
		{
			m_position = position;
			m_size = size;
		}

		public Box3i(
			int positionX, int positionY, int positionZ,
			int sizeX, int sizeY, int sizeZ)
		{
			m_position = new Vector3i(positionX, positionY, positionZ);
			m_size = new Vector3i(sizeX, sizeY, sizeZ);
		}

	
		public int MinX { get { return System.Math.Min(m_position.X, m_position.X + m_size.X); } }
		public int MaxX { get { return System.Math.Max(m_position.X, m_position.X + m_size.X); } }

	
		public int MinY { get { return System.Math.Min(m_position.Y, m_position.Y + m_size.Y); } }
		public int MaxY { get { return System.Math.Max(m_position.Y, m_position.Y + m_size.Y); } }

	
		public int MinZ { get { return System.Math.Min(m_position.Z, m_position.Z + m_size.Z); } }
		public int MaxZ { get { return System.Math.Max(m_position.Z, m_position.Z + m_size.Z); } }


		public bool Equals(Box3i other)
		{
			return m_position == other.m_position && m_size == other.m_size;
		}

		public override bool Equals(object other)
		{
			return other is Box3i ? Equals((Box3i)other) : false;
		}

		public override int GetHashCode()
		{
			return m_position.GetHashCode() + m_size.GetHashCode();
		}

		public bool Contains(Vector3i p)
		{
			return p.X >= MinX && p.X <= MaxX && p.Y >= MinY && p.Y <= MaxY && p.Z >= MinZ && p.Z <= MaxZ;
		}

		public static bool operator == (Box3i a, Box3i b)
		{
			return a.m_position == b.m_position && a.m_size == b.m_size;
		}

		public static bool operator != (Box3i a, Box3i b)
		{
			return a.m_position != b.m_position || a.m_size != b.m_size;
		}
	}




	[DebuggerDisplay("[{m_x}, {m_y}]")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct Vector2 : IEquatable<Vector2>
	{
		public static Vector2 Zero { get { return new Vector2(0.0f, 0.0f); } }

		
		public static Vector2 UnitX { get { return new Vector2(1.0f, 0.0f); } }
		private readonly float m_x;
		public float X { get { return m_x; } }
		
		public static Vector2 UnitY { get { return new Vector2(0.0f, 1.0f); } }
		private readonly float m_y;
		public float Y { get { return m_y; } }
		
		public Vector2(float x, float y)
		{
		
			m_x = x;
		
			m_y = y;
		
		}

		public float Length { get { return (float)System.Math.Sqrt(m_x * m_x + m_y * m_y); } }

		public float SquaredLength { get { return m_x * m_x + m_y * m_y; } }

		public Vector2 Normalize()
		{
			return this / Length;
		}

		public bool Equals(Vector2 other)
		{
			return m_x == other.m_x && m_y == other.m_y;
		}

		public override bool Equals(object other)
		{
			return other is Vector2 ? Equals((Vector2)other) : false;
		}

		public override int GetHashCode()
		{
			return m_x.GetHashCode() + m_y.GetHashCode();
		}

		public static bool operator == (Vector2 a, Vector2 b)
		{
			return a.m_x == b.m_x && a.m_y == b.m_y;
		}

		public static bool operator != (Vector2 a, Vector2 b)
		{
			return a.m_x != b.m_x || a.m_y != b.m_y;
		}

		public static Vector2 operator + (Vector2 a, Vector2 b)
		{
			return new Vector2(a.m_x + b.m_x, a.m_y + b.m_y);
		}

		public static Vector2 operator - (Vector2 a, Vector2 b)
		{
			return new Vector2(a.m_x - b.m_x, a.m_y - b.m_y);
		}

		public static Vector2 operator - (Vector2 a)
		{
			return new Vector2(-a.m_x, -a.m_y);
		}

		public static Vector2 operator / (Vector2 a, float b)
		{
			return new Vector2(a.m_x / b, a.m_y / b);
		}

		public static Vector2 operator * (Vector2 a, float b)
		{
			return new Vector2(a.m_x * b, a.m_y * b);
		}

		
		public static float Dot(Vector2 a, Vector2 b)
		{
			return a.m_x * b.m_x + a.m_y * b.m_y;
		}
	}


	[DebuggerDisplay("[{m_x}, {m_y}, {m_z}]")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct Vector3 : IEquatable<Vector3>
	{
		public static Vector3 Zero { get { return new Vector3(0.0f, 0.0f, 0.0f); } }

		
		public static Vector3 UnitX { get { return new Vector3(1.0f, 0.0f, 0.0f); } }
		private readonly float m_x;
		public float X { get { return m_x; } }
		
		public static Vector3 UnitY { get { return new Vector3(0.0f, 1.0f, 0.0f); } }
		private readonly float m_y;
		public float Y { get { return m_y; } }
		
		public static Vector3 UnitZ { get { return new Vector3(0.0f, 0.0f, 1.0f); } }
		private readonly float m_z;
		public float Z { get { return m_z; } }
		
		public Vector3(float x, float y, float z)
		{
		
			m_x = x;
		
			m_y = y;
		
			m_z = z;
		
		}

		public float Length { get { return (float)System.Math.Sqrt(m_x * m_x + m_y * m_y + m_z * m_z); } }

		public float SquaredLength { get { return m_x * m_x + m_y * m_y + m_z * m_z; } }

		public Vector3 Normalize()
		{
			return this / Length;
		}

		public bool Equals(Vector3 other)
		{
			return m_x == other.m_x && m_y == other.m_y && m_z == other.m_z;
		}

		public override bool Equals(object other)
		{
			return other is Vector3 ? Equals((Vector3)other) : false;
		}

		public override int GetHashCode()
		{
			return m_x.GetHashCode() + m_y.GetHashCode() + m_z.GetHashCode();
		}

		public static bool operator == (Vector3 a, Vector3 b)
		{
			return a.m_x == b.m_x && a.m_y == b.m_y && a.m_z == b.m_z;
		}

		public static bool operator != (Vector3 a, Vector3 b)
		{
			return a.m_x != b.m_x || a.m_y != b.m_y || a.m_z != b.m_z;
		}

		public static Vector3 operator + (Vector3 a, Vector3 b)
		{
			return new Vector3(a.m_x + b.m_x, a.m_y + b.m_y, a.m_z + b.m_z);
		}

		public static Vector3 operator - (Vector3 a, Vector3 b)
		{
			return new Vector3(a.m_x - b.m_x, a.m_y - b.m_y, a.m_z - b.m_z);
		}

		public static Vector3 operator - (Vector3 a)
		{
			return new Vector3(-a.m_x, -a.m_y, -a.m_z);
		}

		public static Vector3 operator / (Vector3 a, float b)
		{
			return new Vector3(a.m_x / b, a.m_y / b, a.m_z / b);
		}

		public static Vector3 operator * (Vector3 a, float b)
		{
			return new Vector3(a.m_x * b, a.m_y * b, a.m_z * b);
		}

		
		public static Vector3 Cross(Vector3 a, Vector3 b)
		{
			return new Vector3(

				a.m_y * b.m_z - a.m_z * b.m_y,
				a.m_z * b.m_x - a.m_x * b.m_z,
				a.m_x * b.m_y - a.m_y * b.m_x
			);
		}
		
		public static float Dot(Vector3 a, Vector3 b)
		{
			return a.m_x * b.m_x + a.m_y * b.m_y + a.m_z * b.m_z;
		}
	}


	[DebuggerDisplay("[{m_x}, {m_y}, {m_z}, {m_w}]")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct Vector4 : IEquatable<Vector4>
	{
		public static Vector4 Zero { get { return new Vector4(0.0f, 0.0f, 0.0f, 0.0f); } }

		
		public static Vector4 UnitX { get { return new Vector4(1.0f, 0.0f, 0.0f, 0.0f); } }
		private readonly float m_x;
		public float X { get { return m_x; } }
		
		public static Vector4 UnitY { get { return new Vector4(0.0f, 1.0f, 0.0f, 0.0f); } }
		private readonly float m_y;
		public float Y { get { return m_y; } }
		
		public static Vector4 UnitZ { get { return new Vector4(0.0f, 0.0f, 1.0f, 0.0f); } }
		private readonly float m_z;
		public float Z { get { return m_z; } }
		
		public static Vector4 UnitW { get { return new Vector4(0.0f, 0.0f, 0.0f, 1.0f); } }
		private readonly float m_w;
		public float W { get { return m_w; } }
		
		public Vector4(float x, float y, float z, float w)
		{
		
			m_x = x;
		
			m_y = y;
		
			m_z = z;
		
			m_w = w;
		
		}

		public float Length { get { return (float)System.Math.Sqrt(m_x * m_x + m_y * m_y + m_z * m_z + m_w * m_w); } }

		public float SquaredLength { get { return m_x * m_x + m_y * m_y + m_z * m_z + m_w * m_w; } }

		public Vector4 Normalize()
		{
			return this / Length;
		}

		public bool Equals(Vector4 other)
		{
			return m_x == other.m_x && m_y == other.m_y && m_z == other.m_z && m_w == other.m_w;
		}

		public override bool Equals(object other)
		{
			return other is Vector4 ? Equals((Vector4)other) : false;
		}

		public override int GetHashCode()
		{
			return m_x.GetHashCode() + m_y.GetHashCode() + m_z.GetHashCode() + m_w.GetHashCode();
		}

		public static bool operator == (Vector4 a, Vector4 b)
		{
			return a.m_x == b.m_x && a.m_y == b.m_y && a.m_z == b.m_z && a.m_w == b.m_w;
		}

		public static bool operator != (Vector4 a, Vector4 b)
		{
			return a.m_x != b.m_x || a.m_y != b.m_y || a.m_z != b.m_z || a.m_w != b.m_w;
		}

		public static Vector4 operator + (Vector4 a, Vector4 b)
		{
			return new Vector4(a.m_x + b.m_x, a.m_y + b.m_y, a.m_z + b.m_z, a.m_w + b.m_w);
		}

		public static Vector4 operator - (Vector4 a, Vector4 b)
		{
			return new Vector4(a.m_x - b.m_x, a.m_y - b.m_y, a.m_z - b.m_z, a.m_w - b.m_w);
		}

		public static Vector4 operator - (Vector4 a)
		{
			return new Vector4(-a.m_x, -a.m_y, -a.m_z, -a.m_w);
		}

		public static Vector4 operator / (Vector4 a, float b)
		{
			return new Vector4(a.m_x / b, a.m_y / b, a.m_z / b, a.m_w / b);
		}

		public static Vector4 operator * (Vector4 a, float b)
		{
			return new Vector4(a.m_x * b, a.m_y * b, a.m_z * b, a.m_w * b);
		}

		
		public static float Dot(Vector4 a, Vector4 b)
		{
			return a.m_x * b.m_x + a.m_y * b.m_y + a.m_z * b.m_z + a.m_w * b.m_w;
		}
	}




	[StructLayout(LayoutKind.Sequential)]
	public partial struct Box2 : IEquatable<Box2>
	{
		private readonly Vector2 m_position;
		private readonly Vector2 m_size;

		public Vector2 Position { get { return m_position; } }
		public Vector2 Size { get { return m_size; } }

		public Box2(Vector2 position, Vector2 size)
		{
			m_position = position;
			m_size = size;
		}

		public Box2(
			float positionX, float positionY,
			float sizeX, float sizeY)
		{
			m_position = new Vector2(positionX, positionY);
			m_size = new Vector2(sizeX, sizeY);
		}

	
		public float MinX { get { return System.Math.Min(m_position.X, m_position.X + m_size.X); } }
		public float MaxX { get { return System.Math.Max(m_position.X, m_position.X + m_size.X); } }

	
		public float MinY { get { return System.Math.Min(m_position.Y, m_position.Y + m_size.Y); } }
		public float MaxY { get { return System.Math.Max(m_position.Y, m_position.Y + m_size.Y); } }


		public bool Equals(Box2 other)
		{
			return m_position == other.m_position && m_size == other.m_size;
		}

		public override bool Equals(object other)
		{
			return other is Box2 ? Equals((Box2)other) : false;
		}

		public override int GetHashCode()
		{
			return m_position.GetHashCode() + m_size.GetHashCode();
		}

		public bool Contains(Vector2 p)
		{
			return p.X >= MinX && p.X <= MaxX && p.Y >= MinY && p.Y <= MaxY;
		}

		public static bool operator == (Box2 a, Box2 b)
		{
			return a.m_position == b.m_position && a.m_size == b.m_size;
		}

		public static bool operator != (Box2 a, Box2 b)
		{
			return a.m_position != b.m_position || a.m_size != b.m_size;
		}
	}


	[StructLayout(LayoutKind.Sequential)]
	public partial struct Box3 : IEquatable<Box3>
	{
		private readonly Vector3 m_position;
		private readonly Vector3 m_size;

		public Vector3 Position { get { return m_position; } }
		public Vector3 Size { get { return m_size; } }

		public Box3(Vector3 position, Vector3 size)
		{
			m_position = position;
			m_size = size;
		}

		public Box3(
			float positionX, float positionY, float positionZ,
			float sizeX, float sizeY, float sizeZ)
		{
			m_position = new Vector3(positionX, positionY, positionZ);
			m_size = new Vector3(sizeX, sizeY, sizeZ);
		}

	
		public float MinX { get { return System.Math.Min(m_position.X, m_position.X + m_size.X); } }
		public float MaxX { get { return System.Math.Max(m_position.X, m_position.X + m_size.X); } }

	
		public float MinY { get { return System.Math.Min(m_position.Y, m_position.Y + m_size.Y); } }
		public float MaxY { get { return System.Math.Max(m_position.Y, m_position.Y + m_size.Y); } }

	
		public float MinZ { get { return System.Math.Min(m_position.Z, m_position.Z + m_size.Z); } }
		public float MaxZ { get { return System.Math.Max(m_position.Z, m_position.Z + m_size.Z); } }


		public bool Equals(Box3 other)
		{
			return m_position == other.m_position && m_size == other.m_size;
		}

		public override bool Equals(object other)
		{
			return other is Box3 ? Equals((Box3)other) : false;
		}

		public override int GetHashCode()
		{
			return m_position.GetHashCode() + m_size.GetHashCode();
		}

		public bool Contains(Vector3 p)
		{
			return p.X >= MinX && p.X <= MaxX && p.Y >= MinY && p.Y <= MaxY && p.Z >= MinZ && p.Z <= MaxZ;
		}

		public static bool operator == (Box3 a, Box3 b)
		{
			return a.m_position == b.m_position && a.m_size == b.m_size;
		}

		public static bool operator != (Box3 a, Box3 b)
		{
			return a.m_position != b.m_position || a.m_size != b.m_size;
		}
	}



	[StructLayout(LayoutKind.Sequential)]
	public partial struct Matrix2 : IEquatable<Matrix2>
	{

		private static readonly Matrix2 s_identity = new Matrix2(1.0f, 0.0f, 0.0f, 1.0f);
		public static Matrix2 Identity { get { return s_identity; } }


		private readonly float m_m00;
		public float M00 { get { return m_m00; } }
		private readonly float m_m10;
		public float M10 { get { return m_m10; } }
		private readonly float m_m01;
		public float M01 { get { return m_m01; } }
		private readonly float m_m11;
		public float M11 { get { return m_m11; } }

		public Matrix2(float m00, float m01, float m10, float m11)
		{
			m_m00 = m00;
			m_m01 = m01;
			m_m10 = m10;
			m_m11 = m11;
		}

		public bool Equals(Matrix2 other)
		{
			return m_m00 == other.m_m00 && m_m01 == other.m_m01 && m_m10 == other.m_m10 && m_m11 == other.m_m11;
		}

		public override bool Equals(object other)
		{
			return other is Matrix2 ? Equals((Matrix2)other) : false;
		}

		public override int GetHashCode()
		{
			return m_m00.GetHashCode() + m_m01.GetHashCode() + m_m10.GetHashCode() + m_m11.GetHashCode();
		}

		public static Matrix2 operator * (Matrix2 a, Matrix2 b)
		{
			return new Matrix2(
				a.m_m00 * b.m_m00 + a.m_m01 * b.m_m10,
				a.m_m00 * b.m_m01 + a.m_m01 * b.m_m11,
				a.m_m10 * b.m_m00 + a.m_m11 * b.m_m10,
				a.m_m10 * b.m_m01 + a.m_m11 * b.m_m11
			);
		}

		public static Vector2 operator * (Matrix2 a, Vector2 b)
		{
			return new Vector2(
				a.m_m00 * b.X + a.m_m01 * b.Y,
				a.m_m10 * b.X + a.m_m11 * b.Y
			);
		}
	}


	[StructLayout(LayoutKind.Sequential)]
	public partial struct Matrix3 : IEquatable<Matrix3>
	{

		private static readonly Matrix3 s_identity = new Matrix3(1.0f, 0.0f, 0.0f, 0.0f, 1.0f, 0.0f, 0.0f, 0.0f, 1.0f);
		public static Matrix3 Identity { get { return s_identity; } }


		private readonly float m_m00;
		public float M00 { get { return m_m00; } }
		private readonly float m_m10;
		public float M10 { get { return m_m10; } }
		private readonly float m_m20;
		public float M20 { get { return m_m20; } }
		private readonly float m_m01;
		public float M01 { get { return m_m01; } }
		private readonly float m_m11;
		public float M11 { get { return m_m11; } }
		private readonly float m_m21;
		public float M21 { get { return m_m21; } }
		private readonly float m_m02;
		public float M02 { get { return m_m02; } }
		private readonly float m_m12;
		public float M12 { get { return m_m12; } }
		private readonly float m_m22;
		public float M22 { get { return m_m22; } }

		public Matrix3(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22)
		{
			m_m00 = m00;
			m_m01 = m01;
			m_m02 = m02;
			m_m10 = m10;
			m_m11 = m11;
			m_m12 = m12;
			m_m20 = m20;
			m_m21 = m21;
			m_m22 = m22;
		}

		public bool Equals(Matrix3 other)
		{
			return m_m00 == other.m_m00 && m_m01 == other.m_m01 && m_m02 == other.m_m02 && m_m10 == other.m_m10 && m_m11 == other.m_m11 && m_m12 == other.m_m12 && m_m20 == other.m_m20 && m_m21 == other.m_m21 && m_m22 == other.m_m22;
		}

		public override bool Equals(object other)
		{
			return other is Matrix3 ? Equals((Matrix3)other) : false;
		}

		public override int GetHashCode()
		{
			return m_m00.GetHashCode() + m_m01.GetHashCode() + m_m02.GetHashCode() + m_m10.GetHashCode() + m_m11.GetHashCode() + m_m12.GetHashCode() + m_m20.GetHashCode() + m_m21.GetHashCode() + m_m22.GetHashCode();
		}

		public static Matrix3 operator * (Matrix3 a, Matrix3 b)
		{
			return new Matrix3(
				a.m_m00 * b.m_m00 + a.m_m01 * b.m_m10 + a.m_m02 * b.m_m20,
				a.m_m00 * b.m_m01 + a.m_m01 * b.m_m11 + a.m_m02 * b.m_m21,
				a.m_m00 * b.m_m02 + a.m_m01 * b.m_m12 + a.m_m02 * b.m_m22,
				a.m_m10 * b.m_m00 + a.m_m11 * b.m_m10 + a.m_m12 * b.m_m20,
				a.m_m10 * b.m_m01 + a.m_m11 * b.m_m11 + a.m_m12 * b.m_m21,
				a.m_m10 * b.m_m02 + a.m_m11 * b.m_m12 + a.m_m12 * b.m_m22,
				a.m_m20 * b.m_m00 + a.m_m21 * b.m_m10 + a.m_m22 * b.m_m20,
				a.m_m20 * b.m_m01 + a.m_m21 * b.m_m11 + a.m_m22 * b.m_m21,
				a.m_m20 * b.m_m02 + a.m_m21 * b.m_m12 + a.m_m22 * b.m_m22
			);
		}

		public static Vector3 operator * (Matrix3 a, Vector3 b)
		{
			return new Vector3(
				a.m_m00 * b.X + a.m_m01 * b.Y + a.m_m02 * b.Z,
				a.m_m10 * b.X + a.m_m11 * b.Y + a.m_m12 * b.Z,
				a.m_m20 * b.X + a.m_m21 * b.Y + a.m_m22 * b.Z
			);
		}
	}


	[StructLayout(LayoutKind.Sequential)]
	public partial struct Matrix4 : IEquatable<Matrix4>
	{

		private static readonly Matrix4 s_identity = new Matrix4(1.0f, 0.0f, 0.0f, 0.0f, 0.0f, 1.0f, 0.0f, 0.0f, 0.0f, 0.0f, 1.0f, 0.0f, 0.0f, 0.0f, 0.0f, 1.0f);
		public static Matrix4 Identity { get { return s_identity; } }


		private readonly float m_m00;
		public float M00 { get { return m_m00; } }
		private readonly float m_m10;
		public float M10 { get { return m_m10; } }
		private readonly float m_m20;
		public float M20 { get { return m_m20; } }
		private readonly float m_m30;
		public float M30 { get { return m_m30; } }
		private readonly float m_m01;
		public float M01 { get { return m_m01; } }
		private readonly float m_m11;
		public float M11 { get { return m_m11; } }
		private readonly float m_m21;
		public float M21 { get { return m_m21; } }
		private readonly float m_m31;
		public float M31 { get { return m_m31; } }
		private readonly float m_m02;
		public float M02 { get { return m_m02; } }
		private readonly float m_m12;
		public float M12 { get { return m_m12; } }
		private readonly float m_m22;
		public float M22 { get { return m_m22; } }
		private readonly float m_m32;
		public float M32 { get { return m_m32; } }
		private readonly float m_m03;
		public float M03 { get { return m_m03; } }
		private readonly float m_m13;
		public float M13 { get { return m_m13; } }
		private readonly float m_m23;
		public float M23 { get { return m_m23; } }
		private readonly float m_m33;
		public float M33 { get { return m_m33; } }

		public Matrix4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23, float m30, float m31, float m32, float m33)
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

		public bool Equals(Matrix4 other)
		{
			return m_m00 == other.m_m00 && m_m01 == other.m_m01 && m_m02 == other.m_m02 && m_m03 == other.m_m03 && m_m10 == other.m_m10 && m_m11 == other.m_m11 && m_m12 == other.m_m12 && m_m13 == other.m_m13 && m_m20 == other.m_m20 && m_m21 == other.m_m21 && m_m22 == other.m_m22 && m_m23 == other.m_m23 && m_m30 == other.m_m30 && m_m31 == other.m_m31 && m_m32 == other.m_m32 && m_m33 == other.m_m33;
		}

		public override bool Equals(object other)
		{
			return other is Matrix4 ? Equals((Matrix4)other) : false;
		}

		public override int GetHashCode()
		{
			return m_m00.GetHashCode() + m_m01.GetHashCode() + m_m02.GetHashCode() + m_m03.GetHashCode() + m_m10.GetHashCode() + m_m11.GetHashCode() + m_m12.GetHashCode() + m_m13.GetHashCode() + m_m20.GetHashCode() + m_m21.GetHashCode() + m_m22.GetHashCode() + m_m23.GetHashCode() + m_m30.GetHashCode() + m_m31.GetHashCode() + m_m32.GetHashCode() + m_m33.GetHashCode();
		}

		public static Matrix4 operator * (Matrix4 a, Matrix4 b)
		{
			return new Matrix4(
				a.m_m00 * b.m_m00 + a.m_m01 * b.m_m10 + a.m_m02 * b.m_m20 + a.m_m03 * b.m_m30,
				a.m_m00 * b.m_m01 + a.m_m01 * b.m_m11 + a.m_m02 * b.m_m21 + a.m_m03 * b.m_m31,
				a.m_m00 * b.m_m02 + a.m_m01 * b.m_m12 + a.m_m02 * b.m_m22 + a.m_m03 * b.m_m32,
				a.m_m00 * b.m_m03 + a.m_m01 * b.m_m13 + a.m_m02 * b.m_m23 + a.m_m03 * b.m_m33,
				a.m_m10 * b.m_m00 + a.m_m11 * b.m_m10 + a.m_m12 * b.m_m20 + a.m_m13 * b.m_m30,
				a.m_m10 * b.m_m01 + a.m_m11 * b.m_m11 + a.m_m12 * b.m_m21 + a.m_m13 * b.m_m31,
				a.m_m10 * b.m_m02 + a.m_m11 * b.m_m12 + a.m_m12 * b.m_m22 + a.m_m13 * b.m_m32,
				a.m_m10 * b.m_m03 + a.m_m11 * b.m_m13 + a.m_m12 * b.m_m23 + a.m_m13 * b.m_m33,
				a.m_m20 * b.m_m00 + a.m_m21 * b.m_m10 + a.m_m22 * b.m_m20 + a.m_m23 * b.m_m30,
				a.m_m20 * b.m_m01 + a.m_m21 * b.m_m11 + a.m_m22 * b.m_m21 + a.m_m23 * b.m_m31,
				a.m_m20 * b.m_m02 + a.m_m21 * b.m_m12 + a.m_m22 * b.m_m22 + a.m_m23 * b.m_m32,
				a.m_m20 * b.m_m03 + a.m_m21 * b.m_m13 + a.m_m22 * b.m_m23 + a.m_m23 * b.m_m33,
				a.m_m30 * b.m_m00 + a.m_m31 * b.m_m10 + a.m_m32 * b.m_m20 + a.m_m33 * b.m_m30,
				a.m_m30 * b.m_m01 + a.m_m31 * b.m_m11 + a.m_m32 * b.m_m21 + a.m_m33 * b.m_m31,
				a.m_m30 * b.m_m02 + a.m_m31 * b.m_m12 + a.m_m32 * b.m_m22 + a.m_m33 * b.m_m32,
				a.m_m30 * b.m_m03 + a.m_m31 * b.m_m13 + a.m_m32 * b.m_m23 + a.m_m33 * b.m_m33
			);
		}

		public static Vector4 operator * (Matrix4 a, Vector4 b)
		{
			return new Vector4(
				a.m_m00 * b.X + a.m_m01 * b.Y + a.m_m02 * b.Z + a.m_m03 * b.W,
				a.m_m10 * b.X + a.m_m11 * b.Y + a.m_m12 * b.Z + a.m_m13 * b.W,
				a.m_m20 * b.X + a.m_m21 * b.Y + a.m_m22 * b.Z + a.m_m23 * b.W,
				a.m_m30 * b.X + a.m_m31 * b.Y + a.m_m32 * b.Z + a.m_m33 * b.W
			);
		}
	}



	[DebuggerDisplay("[{m_x}, {m_y}]")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct Vector2d : IEquatable<Vector2d>
	{
		public static Vector2d Zero { get { return new Vector2d(0.0, 0.0); } }

		
		public static Vector2d UnitX { get { return new Vector2d(1.0, 0.0); } }
		private readonly double m_x;
		public double X { get { return m_x; } }
		
		public static Vector2d UnitY { get { return new Vector2d(0.0, 1.0); } }
		private readonly double m_y;
		public double Y { get { return m_y; } }
		
		public Vector2d(double x, double y)
		{
		
			m_x = x;
		
			m_y = y;
		
		}

		public double Length { get { return (double)System.Math.Sqrt(m_x * m_x + m_y * m_y); } }

		public double SquaredLength { get { return m_x * m_x + m_y * m_y; } }

		public Vector2d Normalize()
		{
			return this / Length;
		}

		public bool Equals(Vector2d other)
		{
			return m_x == other.m_x && m_y == other.m_y;
		}

		public override bool Equals(object other)
		{
			return other is Vector2d ? Equals((Vector2d)other) : false;
		}

		public override int GetHashCode()
		{
			return m_x.GetHashCode() + m_y.GetHashCode();
		}

		public static bool operator == (Vector2d a, Vector2d b)
		{
			return a.m_x == b.m_x && a.m_y == b.m_y;
		}

		public static bool operator != (Vector2d a, Vector2d b)
		{
			return a.m_x != b.m_x || a.m_y != b.m_y;
		}

		public static Vector2d operator + (Vector2d a, Vector2d b)
		{
			return new Vector2d(a.m_x + b.m_x, a.m_y + b.m_y);
		}

		public static Vector2d operator - (Vector2d a, Vector2d b)
		{
			return new Vector2d(a.m_x - b.m_x, a.m_y - b.m_y);
		}

		public static Vector2d operator - (Vector2d a)
		{
			return new Vector2d(-a.m_x, -a.m_y);
		}

		public static Vector2d operator / (Vector2d a, double b)
		{
			return new Vector2d(a.m_x / b, a.m_y / b);
		}

		public static Vector2d operator * (Vector2d a, double b)
		{
			return new Vector2d(a.m_x * b, a.m_y * b);
		}

		
		public static double Dot(Vector2d a, Vector2d b)
		{
			return a.m_x * b.m_x + a.m_y * b.m_y;
		}
	}


	[DebuggerDisplay("[{m_x}, {m_y}, {m_z}]")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct Vector3d : IEquatable<Vector3d>
	{
		public static Vector3d Zero { get { return new Vector3d(0.0, 0.0, 0.0); } }

		
		public static Vector3d UnitX { get { return new Vector3d(1.0, 0.0, 0.0); } }
		private readonly double m_x;
		public double X { get { return m_x; } }
		
		public static Vector3d UnitY { get { return new Vector3d(0.0, 1.0, 0.0); } }
		private readonly double m_y;
		public double Y { get { return m_y; } }
		
		public static Vector3d UnitZ { get { return new Vector3d(0.0, 0.0, 1.0); } }
		private readonly double m_z;
		public double Z { get { return m_z; } }
		
		public Vector3d(double x, double y, double z)
		{
		
			m_x = x;
		
			m_y = y;
		
			m_z = z;
		
		}

		public double Length { get { return (double)System.Math.Sqrt(m_x * m_x + m_y * m_y + m_z * m_z); } }

		public double SquaredLength { get { return m_x * m_x + m_y * m_y + m_z * m_z; } }

		public Vector3d Normalize()
		{
			return this / Length;
		}

		public bool Equals(Vector3d other)
		{
			return m_x == other.m_x && m_y == other.m_y && m_z == other.m_z;
		}

		public override bool Equals(object other)
		{
			return other is Vector3d ? Equals((Vector3d)other) : false;
		}

		public override int GetHashCode()
		{
			return m_x.GetHashCode() + m_y.GetHashCode() + m_z.GetHashCode();
		}

		public static bool operator == (Vector3d a, Vector3d b)
		{
			return a.m_x == b.m_x && a.m_y == b.m_y && a.m_z == b.m_z;
		}

		public static bool operator != (Vector3d a, Vector3d b)
		{
			return a.m_x != b.m_x || a.m_y != b.m_y || a.m_z != b.m_z;
		}

		public static Vector3d operator + (Vector3d a, Vector3d b)
		{
			return new Vector3d(a.m_x + b.m_x, a.m_y + b.m_y, a.m_z + b.m_z);
		}

		public static Vector3d operator - (Vector3d a, Vector3d b)
		{
			return new Vector3d(a.m_x - b.m_x, a.m_y - b.m_y, a.m_z - b.m_z);
		}

		public static Vector3d operator - (Vector3d a)
		{
			return new Vector3d(-a.m_x, -a.m_y, -a.m_z);
		}

		public static Vector3d operator / (Vector3d a, double b)
		{
			return new Vector3d(a.m_x / b, a.m_y / b, a.m_z / b);
		}

		public static Vector3d operator * (Vector3d a, double b)
		{
			return new Vector3d(a.m_x * b, a.m_y * b, a.m_z * b);
		}

		
		public static Vector3d Cross(Vector3d a, Vector3d b)
		{
			return new Vector3d(

				a.m_y * b.m_z - a.m_z * b.m_y,
				a.m_z * b.m_x - a.m_x * b.m_z,
				a.m_x * b.m_y - a.m_y * b.m_x
			);
		}
		
		public static double Dot(Vector3d a, Vector3d b)
		{
			return a.m_x * b.m_x + a.m_y * b.m_y + a.m_z * b.m_z;
		}
	}


	[DebuggerDisplay("[{m_x}, {m_y}, {m_z}, {m_w}]")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct Vector4d : IEquatable<Vector4d>
	{
		public static Vector4d Zero { get { return new Vector4d(0.0, 0.0, 0.0, 0.0); } }

		
		public static Vector4d UnitX { get { return new Vector4d(1.0, 0.0, 0.0, 0.0); } }
		private readonly double m_x;
		public double X { get { return m_x; } }
		
		public static Vector4d UnitY { get { return new Vector4d(0.0, 1.0, 0.0, 0.0); } }
		private readonly double m_y;
		public double Y { get { return m_y; } }
		
		public static Vector4d UnitZ { get { return new Vector4d(0.0, 0.0, 1.0, 0.0); } }
		private readonly double m_z;
		public double Z { get { return m_z; } }
		
		public static Vector4d UnitW { get { return new Vector4d(0.0, 0.0, 0.0, 1.0); } }
		private readonly double m_w;
		public double W { get { return m_w; } }
		
		public Vector4d(double x, double y, double z, double w)
		{
		
			m_x = x;
		
			m_y = y;
		
			m_z = z;
		
			m_w = w;
		
		}

		public double Length { get { return (double)System.Math.Sqrt(m_x * m_x + m_y * m_y + m_z * m_z + m_w * m_w); } }

		public double SquaredLength { get { return m_x * m_x + m_y * m_y + m_z * m_z + m_w * m_w; } }

		public Vector4d Normalize()
		{
			return this / Length;
		}

		public bool Equals(Vector4d other)
		{
			return m_x == other.m_x && m_y == other.m_y && m_z == other.m_z && m_w == other.m_w;
		}

		public override bool Equals(object other)
		{
			return other is Vector4d ? Equals((Vector4d)other) : false;
		}

		public override int GetHashCode()
		{
			return m_x.GetHashCode() + m_y.GetHashCode() + m_z.GetHashCode() + m_w.GetHashCode();
		}

		public static bool operator == (Vector4d a, Vector4d b)
		{
			return a.m_x == b.m_x && a.m_y == b.m_y && a.m_z == b.m_z && a.m_w == b.m_w;
		}

		public static bool operator != (Vector4d a, Vector4d b)
		{
			return a.m_x != b.m_x || a.m_y != b.m_y || a.m_z != b.m_z || a.m_w != b.m_w;
		}

		public static Vector4d operator + (Vector4d a, Vector4d b)
		{
			return new Vector4d(a.m_x + b.m_x, a.m_y + b.m_y, a.m_z + b.m_z, a.m_w + b.m_w);
		}

		public static Vector4d operator - (Vector4d a, Vector4d b)
		{
			return new Vector4d(a.m_x - b.m_x, a.m_y - b.m_y, a.m_z - b.m_z, a.m_w - b.m_w);
		}

		public static Vector4d operator - (Vector4d a)
		{
			return new Vector4d(-a.m_x, -a.m_y, -a.m_z, -a.m_w);
		}

		public static Vector4d operator / (Vector4d a, double b)
		{
			return new Vector4d(a.m_x / b, a.m_y / b, a.m_z / b, a.m_w / b);
		}

		public static Vector4d operator * (Vector4d a, double b)
		{
			return new Vector4d(a.m_x * b, a.m_y * b, a.m_z * b, a.m_w * b);
		}

		
		public static double Dot(Vector4d a, Vector4d b)
		{
			return a.m_x * b.m_x + a.m_y * b.m_y + a.m_z * b.m_z + a.m_w * b.m_w;
		}
	}




	[StructLayout(LayoutKind.Sequential)]
	public partial struct Box2d : IEquatable<Box2d>
	{
		private readonly Vector2d m_position;
		private readonly Vector2d m_size;

		public Vector2d Position { get { return m_position; } }
		public Vector2d Size { get { return m_size; } }

		public Box2d(Vector2d position, Vector2d size)
		{
			m_position = position;
			m_size = size;
		}

		public Box2d(
			double positionX, double positionY,
			double sizeX, double sizeY)
		{
			m_position = new Vector2d(positionX, positionY);
			m_size = new Vector2d(sizeX, sizeY);
		}

	
		public double MinX { get { return System.Math.Min(m_position.X, m_position.X + m_size.X); } }
		public double MaxX { get { return System.Math.Max(m_position.X, m_position.X + m_size.X); } }

	
		public double MinY { get { return System.Math.Min(m_position.Y, m_position.Y + m_size.Y); } }
		public double MaxY { get { return System.Math.Max(m_position.Y, m_position.Y + m_size.Y); } }


		public bool Equals(Box2d other)
		{
			return m_position == other.m_position && m_size == other.m_size;
		}

		public override bool Equals(object other)
		{
			return other is Box2d ? Equals((Box2d)other) : false;
		}

		public override int GetHashCode()
		{
			return m_position.GetHashCode() + m_size.GetHashCode();
		}

		public bool Contains(Vector2d p)
		{
			return p.X >= MinX && p.X <= MaxX && p.Y >= MinY && p.Y <= MaxY;
		}

		public static bool operator == (Box2d a, Box2d b)
		{
			return a.m_position == b.m_position && a.m_size == b.m_size;
		}

		public static bool operator != (Box2d a, Box2d b)
		{
			return a.m_position != b.m_position || a.m_size != b.m_size;
		}
	}


	[StructLayout(LayoutKind.Sequential)]
	public partial struct Box3d : IEquatable<Box3d>
	{
		private readonly Vector3d m_position;
		private readonly Vector3d m_size;

		public Vector3d Position { get { return m_position; } }
		public Vector3d Size { get { return m_size; } }

		public Box3d(Vector3d position, Vector3d size)
		{
			m_position = position;
			m_size = size;
		}

		public Box3d(
			double positionX, double positionY, double positionZ,
			double sizeX, double sizeY, double sizeZ)
		{
			m_position = new Vector3d(positionX, positionY, positionZ);
			m_size = new Vector3d(sizeX, sizeY, sizeZ);
		}

	
		public double MinX { get { return System.Math.Min(m_position.X, m_position.X + m_size.X); } }
		public double MaxX { get { return System.Math.Max(m_position.X, m_position.X + m_size.X); } }

	
		public double MinY { get { return System.Math.Min(m_position.Y, m_position.Y + m_size.Y); } }
		public double MaxY { get { return System.Math.Max(m_position.Y, m_position.Y + m_size.Y); } }

	
		public double MinZ { get { return System.Math.Min(m_position.Z, m_position.Z + m_size.Z); } }
		public double MaxZ { get { return System.Math.Max(m_position.Z, m_position.Z + m_size.Z); } }


		public bool Equals(Box3d other)
		{
			return m_position == other.m_position && m_size == other.m_size;
		}

		public override bool Equals(object other)
		{
			return other is Box3d ? Equals((Box3d)other) : false;
		}

		public override int GetHashCode()
		{
			return m_position.GetHashCode() + m_size.GetHashCode();
		}

		public bool Contains(Vector3d p)
		{
			return p.X >= MinX && p.X <= MaxX && p.Y >= MinY && p.Y <= MaxY && p.Z >= MinZ && p.Z <= MaxZ;
		}

		public static bool operator == (Box3d a, Box3d b)
		{
			return a.m_position == b.m_position && a.m_size == b.m_size;
		}

		public static bool operator != (Box3d a, Box3d b)
		{
			return a.m_position != b.m_position || a.m_size != b.m_size;
		}
	}



	[StructLayout(LayoutKind.Sequential)]
	public partial struct Matrix2d : IEquatable<Matrix2d>
	{

		private static readonly Matrix2d s_identity = new Matrix2d(1.0, 0.0, 0.0, 1.0);
		public static Matrix2d Identity { get { return s_identity; } }


		private readonly double m_m00;
		public double M00 { get { return m_m00; } }
		private readonly double m_m10;
		public double M10 { get { return m_m10; } }
		private readonly double m_m01;
		public double M01 { get { return m_m01; } }
		private readonly double m_m11;
		public double M11 { get { return m_m11; } }

		public Matrix2d(double m00, double m01, double m10, double m11)
		{
			m_m00 = m00;
			m_m01 = m01;
			m_m10 = m10;
			m_m11 = m11;
		}

		public bool Equals(Matrix2d other)
		{
			return m_m00 == other.m_m00 && m_m01 == other.m_m01 && m_m10 == other.m_m10 && m_m11 == other.m_m11;
		}

		public override bool Equals(object other)
		{
			return other is Matrix2d ? Equals((Matrix2d)other) : false;
		}

		public override int GetHashCode()
		{
			return m_m00.GetHashCode() + m_m01.GetHashCode() + m_m10.GetHashCode() + m_m11.GetHashCode();
		}

		public static Matrix2d operator * (Matrix2d a, Matrix2d b)
		{
			return new Matrix2d(
				a.m_m00 * b.m_m00 + a.m_m01 * b.m_m10,
				a.m_m00 * b.m_m01 + a.m_m01 * b.m_m11,
				a.m_m10 * b.m_m00 + a.m_m11 * b.m_m10,
				a.m_m10 * b.m_m01 + a.m_m11 * b.m_m11
			);
		}

		public static Vector2d operator * (Matrix2d a, Vector2d b)
		{
			return new Vector2d(
				a.m_m00 * b.X + a.m_m01 * b.Y,
				a.m_m10 * b.X + a.m_m11 * b.Y
			);
		}
	}


	[StructLayout(LayoutKind.Sequential)]
	public partial struct Matrix3d : IEquatable<Matrix3d>
	{

		private static readonly Matrix3d s_identity = new Matrix3d(1.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 1.0);
		public static Matrix3d Identity { get { return s_identity; } }


		private readonly double m_m00;
		public double M00 { get { return m_m00; } }
		private readonly double m_m10;
		public double M10 { get { return m_m10; } }
		private readonly double m_m20;
		public double M20 { get { return m_m20; } }
		private readonly double m_m01;
		public double M01 { get { return m_m01; } }
		private readonly double m_m11;
		public double M11 { get { return m_m11; } }
		private readonly double m_m21;
		public double M21 { get { return m_m21; } }
		private readonly double m_m02;
		public double M02 { get { return m_m02; } }
		private readonly double m_m12;
		public double M12 { get { return m_m12; } }
		private readonly double m_m22;
		public double M22 { get { return m_m22; } }

		public Matrix3d(double m00, double m01, double m02, double m10, double m11, double m12, double m20, double m21, double m22)
		{
			m_m00 = m00;
			m_m01 = m01;
			m_m02 = m02;
			m_m10 = m10;
			m_m11 = m11;
			m_m12 = m12;
			m_m20 = m20;
			m_m21 = m21;
			m_m22 = m22;
		}

		public bool Equals(Matrix3d other)
		{
			return m_m00 == other.m_m00 && m_m01 == other.m_m01 && m_m02 == other.m_m02 && m_m10 == other.m_m10 && m_m11 == other.m_m11 && m_m12 == other.m_m12 && m_m20 == other.m_m20 && m_m21 == other.m_m21 && m_m22 == other.m_m22;
		}

		public override bool Equals(object other)
		{
			return other is Matrix3d ? Equals((Matrix3d)other) : false;
		}

		public override int GetHashCode()
		{
			return m_m00.GetHashCode() + m_m01.GetHashCode() + m_m02.GetHashCode() + m_m10.GetHashCode() + m_m11.GetHashCode() + m_m12.GetHashCode() + m_m20.GetHashCode() + m_m21.GetHashCode() + m_m22.GetHashCode();
		}

		public static Matrix3d operator * (Matrix3d a, Matrix3d b)
		{
			return new Matrix3d(
				a.m_m00 * b.m_m00 + a.m_m01 * b.m_m10 + a.m_m02 * b.m_m20,
				a.m_m00 * b.m_m01 + a.m_m01 * b.m_m11 + a.m_m02 * b.m_m21,
				a.m_m00 * b.m_m02 + a.m_m01 * b.m_m12 + a.m_m02 * b.m_m22,
				a.m_m10 * b.m_m00 + a.m_m11 * b.m_m10 + a.m_m12 * b.m_m20,
				a.m_m10 * b.m_m01 + a.m_m11 * b.m_m11 + a.m_m12 * b.m_m21,
				a.m_m10 * b.m_m02 + a.m_m11 * b.m_m12 + a.m_m12 * b.m_m22,
				a.m_m20 * b.m_m00 + a.m_m21 * b.m_m10 + a.m_m22 * b.m_m20,
				a.m_m20 * b.m_m01 + a.m_m21 * b.m_m11 + a.m_m22 * b.m_m21,
				a.m_m20 * b.m_m02 + a.m_m21 * b.m_m12 + a.m_m22 * b.m_m22
			);
		}

		public static Vector3d operator * (Matrix3d a, Vector3d b)
		{
			return new Vector3d(
				a.m_m00 * b.X + a.m_m01 * b.Y + a.m_m02 * b.Z,
				a.m_m10 * b.X + a.m_m11 * b.Y + a.m_m12 * b.Z,
				a.m_m20 * b.X + a.m_m21 * b.Y + a.m_m22 * b.Z
			);
		}
	}


	[StructLayout(LayoutKind.Sequential)]
	public partial struct Matrix4d : IEquatable<Matrix4d>
	{

		private static readonly Matrix4d s_identity = new Matrix4d(1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 0.0, 1.0);
		public static Matrix4d Identity { get { return s_identity; } }


		private readonly double m_m00;
		public double M00 { get { return m_m00; } }
		private readonly double m_m10;
		public double M10 { get { return m_m10; } }
		private readonly double m_m20;
		public double M20 { get { return m_m20; } }
		private readonly double m_m30;
		public double M30 { get { return m_m30; } }
		private readonly double m_m01;
		public double M01 { get { return m_m01; } }
		private readonly double m_m11;
		public double M11 { get { return m_m11; } }
		private readonly double m_m21;
		public double M21 { get { return m_m21; } }
		private readonly double m_m31;
		public double M31 { get { return m_m31; } }
		private readonly double m_m02;
		public double M02 { get { return m_m02; } }
		private readonly double m_m12;
		public double M12 { get { return m_m12; } }
		private readonly double m_m22;
		public double M22 { get { return m_m22; } }
		private readonly double m_m32;
		public double M32 { get { return m_m32; } }
		private readonly double m_m03;
		public double M03 { get { return m_m03; } }
		private readonly double m_m13;
		public double M13 { get { return m_m13; } }
		private readonly double m_m23;
		public double M23 { get { return m_m23; } }
		private readonly double m_m33;
		public double M33 { get { return m_m33; } }

		public Matrix4d(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13, double m20, double m21, double m22, double m23, double m30, double m31, double m32, double m33)
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

		public bool Equals(Matrix4d other)
		{
			return m_m00 == other.m_m00 && m_m01 == other.m_m01 && m_m02 == other.m_m02 && m_m03 == other.m_m03 && m_m10 == other.m_m10 && m_m11 == other.m_m11 && m_m12 == other.m_m12 && m_m13 == other.m_m13 && m_m20 == other.m_m20 && m_m21 == other.m_m21 && m_m22 == other.m_m22 && m_m23 == other.m_m23 && m_m30 == other.m_m30 && m_m31 == other.m_m31 && m_m32 == other.m_m32 && m_m33 == other.m_m33;
		}

		public override bool Equals(object other)
		{
			return other is Matrix4d ? Equals((Matrix4d)other) : false;
		}

		public override int GetHashCode()
		{
			return m_m00.GetHashCode() + m_m01.GetHashCode() + m_m02.GetHashCode() + m_m03.GetHashCode() + m_m10.GetHashCode() + m_m11.GetHashCode() + m_m12.GetHashCode() + m_m13.GetHashCode() + m_m20.GetHashCode() + m_m21.GetHashCode() + m_m22.GetHashCode() + m_m23.GetHashCode() + m_m30.GetHashCode() + m_m31.GetHashCode() + m_m32.GetHashCode() + m_m33.GetHashCode();
		}

		public static Matrix4d operator * (Matrix4d a, Matrix4d b)
		{
			return new Matrix4d(
				a.m_m00 * b.m_m00 + a.m_m01 * b.m_m10 + a.m_m02 * b.m_m20 + a.m_m03 * b.m_m30,
				a.m_m00 * b.m_m01 + a.m_m01 * b.m_m11 + a.m_m02 * b.m_m21 + a.m_m03 * b.m_m31,
				a.m_m00 * b.m_m02 + a.m_m01 * b.m_m12 + a.m_m02 * b.m_m22 + a.m_m03 * b.m_m32,
				a.m_m00 * b.m_m03 + a.m_m01 * b.m_m13 + a.m_m02 * b.m_m23 + a.m_m03 * b.m_m33,
				a.m_m10 * b.m_m00 + a.m_m11 * b.m_m10 + a.m_m12 * b.m_m20 + a.m_m13 * b.m_m30,
				a.m_m10 * b.m_m01 + a.m_m11 * b.m_m11 + a.m_m12 * b.m_m21 + a.m_m13 * b.m_m31,
				a.m_m10 * b.m_m02 + a.m_m11 * b.m_m12 + a.m_m12 * b.m_m22 + a.m_m13 * b.m_m32,
				a.m_m10 * b.m_m03 + a.m_m11 * b.m_m13 + a.m_m12 * b.m_m23 + a.m_m13 * b.m_m33,
				a.m_m20 * b.m_m00 + a.m_m21 * b.m_m10 + a.m_m22 * b.m_m20 + a.m_m23 * b.m_m30,
				a.m_m20 * b.m_m01 + a.m_m21 * b.m_m11 + a.m_m22 * b.m_m21 + a.m_m23 * b.m_m31,
				a.m_m20 * b.m_m02 + a.m_m21 * b.m_m12 + a.m_m22 * b.m_m22 + a.m_m23 * b.m_m32,
				a.m_m20 * b.m_m03 + a.m_m21 * b.m_m13 + a.m_m22 * b.m_m23 + a.m_m23 * b.m_m33,
				a.m_m30 * b.m_m00 + a.m_m31 * b.m_m10 + a.m_m32 * b.m_m20 + a.m_m33 * b.m_m30,
				a.m_m30 * b.m_m01 + a.m_m31 * b.m_m11 + a.m_m32 * b.m_m21 + a.m_m33 * b.m_m31,
				a.m_m30 * b.m_m02 + a.m_m31 * b.m_m12 + a.m_m32 * b.m_m22 + a.m_m33 * b.m_m32,
				a.m_m30 * b.m_m03 + a.m_m31 * b.m_m13 + a.m_m32 * b.m_m23 + a.m_m33 * b.m_m33
			);
		}

		public static Vector4d operator * (Matrix4d a, Vector4d b)
		{
			return new Vector4d(
				a.m_m00 * b.X + a.m_m01 * b.Y + a.m_m02 * b.Z + a.m_m03 * b.W,
				a.m_m10 * b.X + a.m_m11 * b.Y + a.m_m12 * b.Z + a.m_m13 * b.W,
				a.m_m20 * b.X + a.m_m21 * b.Y + a.m_m22 * b.Z + a.m_m23 * b.W,
				a.m_m30 * b.X + a.m_m31 * b.Y + a.m_m32 * b.Z + a.m_m33 * b.W
			);
		}
	}



}

