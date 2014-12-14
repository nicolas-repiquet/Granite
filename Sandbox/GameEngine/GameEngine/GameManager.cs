using GameEngine.Entities;
using GameEngine.Processes;
using GameEngine.Systems;
using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    public class GameManager
    {
        private static GameManager s_instance;
        public static GameManager Instance
        {
            get
            {
                if (s_instance == null)
                {
                    s_instance = new GameManager();
                }

                return s_instance;
            }
        }

        public void Start()
        {
            SystemManager.Instance.AddSystem(new MoveSystem(), 1);
            SystemManager.Instance.AddSystem(new CollisionSystem(), 2);
            SystemManager.Instance.AddSystem(new SpriteRenderSystem(), 3);


        }

        public void Update(TimeSpan elapsed, Matrix4 transform)
        {
            SystemManager.Instance.Update(elapsed, transform);
        }

        public void End()
        {
            SystemManager.Instance.RemoveAllSystems();
        }
    }
}
