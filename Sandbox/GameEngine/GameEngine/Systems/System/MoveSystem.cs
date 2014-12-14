using GameEngine.Components;
using GameEngine.Entities;
using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Systems
{
    public class MoveSystem : ISystem
    {
        
        public MoveSystem()
        {

        }

        public void Start()
        {
            Console.WriteLine("[MoveSystem] Started");
        }

        public void Update(TimeSpan elapsed, Matrix4 transform)
        {
            
            Console.WriteLine("[MoveSystem] Update ended");
        }

        //private void Execute(TimeSpan elapsed, GameObject data)
        //{
        //    var speed = data.GetComponent(ComponentType.Speed) as SpeedComponent;
        //    speed.Current += speed.Acceleration;
        //    speed.Acceleration = 0;

        //    var orientation = data.GetComponent(ComponentType.Orientation) as OrientationComponent;

        //    var location = data.GetComponent(ComponentType.Location) as LocationComponent;
        //    location.X += (float)(speed.Current * orientation.X * elapsed.TotalSeconds);
        //    location.Y += (float)(speed.Current * orientation.Y * elapsed.TotalSeconds);

        //    //data.Notify();
        //    //Notify();
        //}

        public void End()
        {
            Console.WriteLine("[MoveSystem] Ended");
        }
    }
}
