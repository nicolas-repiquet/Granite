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
    public class CollisionSystem : ISystem
    {
        public CollisionSystem()
        {

        }

        public void Start()
        {
            Console.WriteLine("[CollisionSystem] Started");
        }

        public void Update(TimeSpan elapsed, Matrix4 transform)
        {

            Console.WriteLine("[CollisionSystem] Update ended");
        }

        public void End()
        {
            Console.WriteLine("[CollisionSystem] Ended");
        }
    }
}
