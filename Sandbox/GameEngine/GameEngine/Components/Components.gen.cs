
using System;

namespace GameEngine.Components
{
    public class Component
    {
		private Guid m_componentId;
		public Guid ComponentId { get{ return m_componentId; } }

		private ComponentType m_componentType;
		public ComponentType ComponentType { get{ return m_componentType; } }

		public Component(ComponentType type)
		{
			m_componentId = Guid.NewGuid();
			m_componentType = type;
		}
	}

	public class LocationComponent : Component
	{
		public float X { get; set; }
		public float Y { get; set; }

		public LocationComponent()
			:base(ComponentType.Location)
		{

		}

		public string Serialize()
		{
			var str = "[ComponentId:" + ComponentId + ", ComponentType:" + ComponentType;
			str += ", X:" + X;
			str += ", Y:" + Y;
			str += "]";

			return str;
		}
		
	}

	public class OrientationComponent : Component
	{
		public float X { get; set; }
		public float Y { get; set; }

		public OrientationComponent()
			:base(ComponentType.Orientation)
		{

		}

		public string Serialize()
		{
			var str = "[ComponentId:" + ComponentId + ", ComponentType:" + ComponentType;
			str += ", X:" + X;
			str += ", Y:" + Y;
			str += "]";

			return str;
		}
		
	}

	public class HealthComponent : Component
	{
		public int Current { get; set; }
		public int Max { get; set; }
		public bool IsAlive { get; set; }

		public HealthComponent()
			:base(ComponentType.Health)
		{

		}

		public string Serialize()
		{
			var str = "[ComponentId:" + ComponentId + ", ComponentType:" + ComponentType;
			str += ", Current:" + Current;
			str += ", Max:" + Max;
			str += ", IsAlive:" + IsAlive;
			str += "]";

			return str;
		}
		
	}

	public class QuadComponent : Component
	{
		public float Width { get; set; }
		public float Height { get; set; }

		public QuadComponent()
			:base(ComponentType.Quad)
		{

		}

		public string Serialize()
		{
			var str = "[ComponentId:" + ComponentId + ", ComponentType:" + ComponentType;
			str += ", Width:" + Width;
			str += ", Height:" + Height;
			str += "]";

			return str;
		}
		
	}

	public class TriangleComponent : Component
	{
		public float X1 { get; set; }
		public float X2 { get; set; }
		public float X3 { get; set; }
		public float Y1 { get; set; }
		public float Y2 { get; set; }
		public float Y3 { get; set; }

		public TriangleComponent()
			:base(ComponentType.Triangle)
		{

		}

		public string Serialize()
		{
			var str = "[ComponentId:" + ComponentId + ", ComponentType:" + ComponentType;
			str += ", X1:" + X1;
			str += ", X2:" + X2;
			str += ", X3:" + X3;
			str += ", Y1:" + Y1;
			str += ", Y2:" + Y2;
			str += ", Y3:" + Y3;
			str += "]";

			return str;
		}
		
	}

	public class ConeComponent : Component
	{
		public float Radius { get; set; }

		public ConeComponent()
			:base(ComponentType.Cone)
		{

		}

		public string Serialize()
		{
			var str = "[ComponentId:" + ComponentId + ", ComponentType:" + ComponentType;
			str += ", Radius:" + Radius;
			str += "]";

			return str;
		}
		
	}

	public class ColorComponent : Component
	{
		public byte R { get; set; }
		public byte G { get; set; }
		public byte B { get; set; }
		public byte A { get; set; }

		public ColorComponent()
			:base(ComponentType.Color)
		{

		}

		public string Serialize()
		{
			var str = "[ComponentId:" + ComponentId + ", ComponentType:" + ComponentType;
			str += ", R:" + R;
			str += ", G:" + G;
			str += ", B:" + B;
			str += ", A:" + A;
			str += "]";

			return str;
		}
		
	}

	public class DurationComponent : Component
	{
		public double Start { get; set; }
		public double Current { get; set; }

		public DurationComponent()
			:base(ComponentType.Duration)
		{

		}

		public string Serialize()
		{
			var str = "[ComponentId:" + ComponentId + ", ComponentType:" + ComponentType;
			str += ", Start:" + Start;
			str += ", Current:" + Current;
			str += "]";

			return str;
		}
		
	}


	public enum ComponentType
	{
		Location = 0,
		Orientation = 1,
		Health = 2,
		Quad = 3,
		Triangle = 4,
		Cone = 5,
		Color = 6,
		Duration = 7,
	}
}