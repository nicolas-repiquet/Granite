
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameEngine.Components
{
    public class Component
    {
		private Guid m_componentId;
		public Guid ComponentId { get{ return m_componentId; } }

		private Guid m_componentParentId;
        public Guid ComponentParentId { get { return m_componentParentId; } }

		private ComponentType m_componentType;
		public ComponentType ComponentType { get{ return m_componentType; } }

		private List<IObserver<Component>> m_observers;

		public Component(ComponentType type)
		{
			m_componentId = Guid.NewGuid();
			m_componentType = type;
			m_observers = new List<IObserver<Component>>();
		}

		public IDisposable Subscribe(IObserver<Component> observer)
        {
            if (observer != null)
            {
                m_observers.Add(observer);
                observer.OnNext(this);
            }

            return null;
        }

		public void SetParent(Guid id)
        {
            m_componentParentId = id;
        }

        public void Notify()
        {
            if (m_observers != null)
            {
                Parallel.ForEach(m_observers, x => x.OnNext(this));
            }
        }

        public string Serialize()
        {
            var str = "[ComponentId:" + ComponentId + ", ComponentType:" + ComponentType + "]";

            return str;
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

		public new string Serialize()
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

		public new string Serialize()
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

		public new string Serialize()
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

		public new string Serialize()
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

		public new string Serialize()
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
		public float Angle { get; set; }

		public ConeComponent()
			:base(ComponentType.Cone)
		{

		}

		public new string Serialize()
		{
			var str = "[ComponentId:" + ComponentId + ", ComponentType:" + ComponentType;
			str += ", Radius:" + Radius;
			str += ", Angle:" + Angle;
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

		public new string Serialize()
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

		public new string Serialize()
		{
			var str = "[ComponentId:" + ComponentId + ", ComponentType:" + ComponentType;
			str += ", Start:" + Start;
			str += ", Current:" + Current;
			str += "]";

			return str;
		}
		
	}

	public class SpeedComponent : Component
	{
		public double Current { get; set; }
		public double Acceleration { get; set; }

		public SpeedComponent()
			:base(ComponentType.Speed)
		{

		}

		public new string Serialize()
		{
			var str = "[ComponentId:" + ComponentId + ", ComponentType:" + ComponentType;
			str += ", Current:" + Current;
			str += ", Acceleration:" + Acceleration;
			str += "]";

			return str;
		}
		
	}

	public class TextureComponent : Component
	{
		public int Id { get; set; }
		public float StartX { get; set; }
		public float StartY { get; set; }
		public float EndX { get; set; }
		public float EndY { get; set; }

		public TextureComponent()
			:base(ComponentType.Texture)
		{

		}

		public new string Serialize()
		{
			var str = "[ComponentId:" + ComponentId + ", ComponentType:" + ComponentType;
			str += ", Id:" + Id;
			str += ", StartX:" + StartX;
			str += ", StartY:" + StartY;
			str += ", EndX:" + EndX;
			str += ", EndY:" + EndY;
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
		Speed = 8,
		Texture = 9,
	}
}