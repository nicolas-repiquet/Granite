
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Granite3D
{


	[StructLayout(LayoutKind.Sequential)]
	public struct Color3ub : IEquatable<Color3ub>
	{

		private readonly byte m_r;
		public byte R { get { return m_r; } }

		private readonly byte m_g;
		public byte G { get { return m_g; } }

		private readonly byte m_b;
		public byte B { get { return m_b; } }

		public Color3ub(byte r, byte g, byte b)
		{
			m_r = r;
			m_g = g;
			m_b = b;
		}

		public bool Equals(Color3ub other)
		{
			return m_r == other.m_r && m_g == other.m_g && m_b == other.m_b;
		}

		public override bool Equals(object other)
		{
			return other is Color3ub ? Equals((Color3ub)other) : false;
		}

		public override int GetHashCode()
		{
			return m_r.GetHashCode() ^ m_g.GetHashCode() ^ m_b.GetHashCode();
		}

		public static bool operator == (Color3ub a, Color3ub b)
		{
			return a.m_r == b.m_r && a.m_g == b.m_g && a.m_b == b.m_b;
		}

		public static bool operator != (Color3ub a, Color3ub b)
		{
			return a.m_r != b.m_r || a.m_g != b.m_g || a.m_b != b.m_b;
		}

		public static Color3ub Mix(Color3ub a, Color3ub b, float ratio)
		{
			var oneminusratio = 1f - ratio;
			return new Color3ub((byte)(a.m_r * oneminusratio + b.m_r * ratio), (byte)(a.m_g * oneminusratio + b.m_g * ratio), (byte)(a.m_b * oneminusratio + b.m_b * ratio));
		}
	}


	[StructLayout(LayoutKind.Sequential)]
	public struct Color4ub : IEquatable<Color4ub>
	{

		private readonly byte m_r;
		public byte R { get { return m_r; } }

		private readonly byte m_g;
		public byte G { get { return m_g; } }

		private readonly byte m_b;
		public byte B { get { return m_b; } }

		private readonly byte m_a;
		public byte A { get { return m_a; } }

		public Color4ub(byte r, byte g, byte b, byte a)
		{
			m_r = r;
			m_g = g;
			m_b = b;
			m_a = a;
		}

		public bool Equals(Color4ub other)
		{
			return m_r == other.m_r && m_g == other.m_g && m_b == other.m_b && m_a == other.m_a;
		}

		public override bool Equals(object other)
		{
			return other is Color4ub ? Equals((Color4ub)other) : false;
		}

		public override int GetHashCode()
		{
			return m_r.GetHashCode() ^ m_g.GetHashCode() ^ m_b.GetHashCode() ^ m_a.GetHashCode();
		}

		public static bool operator == (Color4ub a, Color4ub b)
		{
			return a.m_r == b.m_r && a.m_g == b.m_g && a.m_b == b.m_b && a.m_a == b.m_a;
		}

		public static bool operator != (Color4ub a, Color4ub b)
		{
			return a.m_r != b.m_r || a.m_g != b.m_g || a.m_b != b.m_b || a.m_a != b.m_a;
		}

		public static Color4ub Mix(Color4ub a, Color4ub b, float ratio)
		{
			var oneminusratio = 1f - ratio;
			return new Color4ub((byte)(a.m_r * oneminusratio + b.m_r * ratio), (byte)(a.m_g * oneminusratio + b.m_g * ratio), (byte)(a.m_b * oneminusratio + b.m_b * ratio), (byte)(a.m_a * oneminusratio + b.m_a * ratio));
		}
	}


	[StructLayout(LayoutKind.Sequential)]
	public struct Color3us : IEquatable<Color3us>
	{

		private readonly ushort m_r;
		public ushort R { get { return m_r; } }

		private readonly ushort m_g;
		public ushort G { get { return m_g; } }

		private readonly ushort m_b;
		public ushort B { get { return m_b; } }

		public Color3us(ushort r, ushort g, ushort b)
		{
			m_r = r;
			m_g = g;
			m_b = b;
		}

		public bool Equals(Color3us other)
		{
			return m_r == other.m_r && m_g == other.m_g && m_b == other.m_b;
		}

		public override bool Equals(object other)
		{
			return other is Color3us ? Equals((Color3us)other) : false;
		}

		public override int GetHashCode()
		{
			return m_r.GetHashCode() ^ m_g.GetHashCode() ^ m_b.GetHashCode();
		}

		public static bool operator == (Color3us a, Color3us b)
		{
			return a.m_r == b.m_r && a.m_g == b.m_g && a.m_b == b.m_b;
		}

		public static bool operator != (Color3us a, Color3us b)
		{
			return a.m_r != b.m_r || a.m_g != b.m_g || a.m_b != b.m_b;
		}

		public static Color3us Mix(Color3us a, Color3us b, float ratio)
		{
			var oneminusratio = 1f - ratio;
			return new Color3us((ushort)(a.m_r * oneminusratio + b.m_r * ratio), (ushort)(a.m_g * oneminusratio + b.m_g * ratio), (ushort)(a.m_b * oneminusratio + b.m_b * ratio));
		}
	}


	[StructLayout(LayoutKind.Sequential)]
	public struct Color4us : IEquatable<Color4us>
	{

		private readonly ushort m_r;
		public ushort R { get { return m_r; } }

		private readonly ushort m_g;
		public ushort G { get { return m_g; } }

		private readonly ushort m_b;
		public ushort B { get { return m_b; } }

		private readonly ushort m_a;
		public ushort A { get { return m_a; } }

		public Color4us(ushort r, ushort g, ushort b, ushort a)
		{
			m_r = r;
			m_g = g;
			m_b = b;
			m_a = a;
		}

		public bool Equals(Color4us other)
		{
			return m_r == other.m_r && m_g == other.m_g && m_b == other.m_b && m_a == other.m_a;
		}

		public override bool Equals(object other)
		{
			return other is Color4us ? Equals((Color4us)other) : false;
		}

		public override int GetHashCode()
		{
			return m_r.GetHashCode() ^ m_g.GetHashCode() ^ m_b.GetHashCode() ^ m_a.GetHashCode();
		}

		public static bool operator == (Color4us a, Color4us b)
		{
			return a.m_r == b.m_r && a.m_g == b.m_g && a.m_b == b.m_b && a.m_a == b.m_a;
		}

		public static bool operator != (Color4us a, Color4us b)
		{
			return a.m_r != b.m_r || a.m_g != b.m_g || a.m_b != b.m_b || a.m_a != b.m_a;
		}

		public static Color4us Mix(Color4us a, Color4us b, float ratio)
		{
			var oneminusratio = 1f - ratio;
			return new Color4us((ushort)(a.m_r * oneminusratio + b.m_r * ratio), (ushort)(a.m_g * oneminusratio + b.m_g * ratio), (ushort)(a.m_b * oneminusratio + b.m_b * ratio), (ushort)(a.m_a * oneminusratio + b.m_a * ratio));
		}
	}


	[StructLayout(LayoutKind.Sequential)]
	public struct Color3 : IEquatable<Color3>
	{

		private readonly float m_r;
		public float R { get { return m_r; } }

		private readonly float m_g;
		public float G { get { return m_g; } }

		private readonly float m_b;
		public float B { get { return m_b; } }

		public Color3(float r, float g, float b)
		{
			m_r = r;
			m_g = g;
			m_b = b;
		}

		public bool Equals(Color3 other)
		{
			return m_r == other.m_r && m_g == other.m_g && m_b == other.m_b;
		}

		public override bool Equals(object other)
		{
			return other is Color3 ? Equals((Color3)other) : false;
		}

		public override int GetHashCode()
		{
			return m_r.GetHashCode() ^ m_g.GetHashCode() ^ m_b.GetHashCode();
		}

		public static bool operator == (Color3 a, Color3 b)
		{
			return a.m_r == b.m_r && a.m_g == b.m_g && a.m_b == b.m_b;
		}

		public static bool operator != (Color3 a, Color3 b)
		{
			return a.m_r != b.m_r || a.m_g != b.m_g || a.m_b != b.m_b;
		}

		public static Color3 Mix(Color3 a, Color3 b, float ratio)
		{
			var oneminusratio = 1f - ratio;
			return new Color3((float)(a.m_r * oneminusratio + b.m_r * ratio), (float)(a.m_g * oneminusratio + b.m_g * ratio), (float)(a.m_b * oneminusratio + b.m_b * ratio));
		}
	}


	[StructLayout(LayoutKind.Sequential)]
	public struct Color4 : IEquatable<Color4>
	{

		private readonly float m_r;
		public float R { get { return m_r; } }

		private readonly float m_g;
		public float G { get { return m_g; } }

		private readonly float m_b;
		public float B { get { return m_b; } }

		private readonly float m_a;
		public float A { get { return m_a; } }

		public Color4(float r, float g, float b, float a)
		{
			m_r = r;
			m_g = g;
			m_b = b;
			m_a = a;
		}

		public bool Equals(Color4 other)
		{
			return m_r == other.m_r && m_g == other.m_g && m_b == other.m_b && m_a == other.m_a;
		}

		public override bool Equals(object other)
		{
			return other is Color4 ? Equals((Color4)other) : false;
		}

		public override int GetHashCode()
		{
			return m_r.GetHashCode() ^ m_g.GetHashCode() ^ m_b.GetHashCode() ^ m_a.GetHashCode();
		}

		public static bool operator == (Color4 a, Color4 b)
		{
			return a.m_r == b.m_r && a.m_g == b.m_g && a.m_b == b.m_b && a.m_a == b.m_a;
		}

		public static bool operator != (Color4 a, Color4 b)
		{
			return a.m_r != b.m_r || a.m_g != b.m_g || a.m_b != b.m_b || a.m_a != b.m_a;
		}

		public static Color4 Mix(Color4 a, Color4 b, float ratio)
		{
			var oneminusratio = 1f - ratio;
			return new Color4((float)(a.m_r * oneminusratio + b.m_r * ratio), (float)(a.m_g * oneminusratio + b.m_g * ratio), (float)(a.m_b * oneminusratio + b.m_b * ratio), (float)(a.m_a * oneminusratio + b.m_a * ratio));
		}
	}


}