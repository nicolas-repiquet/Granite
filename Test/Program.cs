using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Granite.Core;
using System.Threading;


namespace Test
{

    class Program
    {
        static void Main(string[] args)
        {
            Engine.Run(new Game(), new ApplicationSettings()
            {
                DisplayStyle = DisplayStyle.FixedWithTitle
            });
        }
    }
}
