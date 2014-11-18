using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithread
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Simulation();
            s.Init();
            s.ExecutionSerial();
            ////s.Results();

            s.Init();
            s.ExecutionMultiThread();
            //s.Results();

            //s.ExecutionMultiThread2();

            s.Init2();
            s.ExecutionMultiThreadTask();

            s.Init2();
            s.ExecutionParallel();

            Console.ReadKey();
        }
    }
}
