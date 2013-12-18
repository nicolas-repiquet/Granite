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
            Engine.Initialize(new EngineSettings());

            Engine.Run(new GameLogic());
        }
    }
}
