using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Granite3D;
using System.Threading;


namespace Test
{

    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Color4ub(0xFF, 0x10, 0xA0, 0x50);
            var c2 = new Color4ub(0x10, 0xA0, 0xFF, 0x50);

            var c = Color4ub.Mix(c1, c2, 0f);

            var m = Matrix3d.Identity;
            
            var v = new Vector3d(1f, 4f, 2f);
            v = m * v;

            var rec = new Box3(-1f, -1f, -1f, 2f, 2f, 2f);

            var v0 = new Vector3(1f, 4f, 2f);
            var v1 = new Vector3(2f, 1f, 5f);

            if (rec.Contains(new Vector3(0f, 0f, 0f)))
            {
                if (rec.Contains(new Vector3(1f, 1f, 1f)))
                {

                }
            }
            

            var r = (v0 - v1).Normalize();

            if (r == Vector3.Zero)
            {

            }
            

            Engine engine = new Engine(new EngineSettings(), new GameLogic());

            engine.Run();
        }
    }
}
