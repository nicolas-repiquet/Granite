using GameEngine.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var loc = new HealthComponent();
            Console.WriteLine(loc.Serialize());
            Console.ReadKey();
        }
    }
}
