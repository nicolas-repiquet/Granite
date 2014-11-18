using Granite.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithread
{
    public class Simulation
    {
        private readonly double UPDATE_INTERVAL = 1.0;
        private readonly int SPHERE_COUNT = 10000000;
        private readonly int THREAD_COUNT = 2;

        private SphereState[] m_states;
        private ThreadMove[] m_threadMoves;
        private int testInt = 0;

        public Simulation()
        {

        }

        public void Init()
        {
            m_states = new SphereState[SPHERE_COUNT];
            m_threadMoves = new ThreadMove[THREAD_COUNT];

            for (var i = 0; i < SPHERE_COUNT; i++)
            {
                m_states[i] = new SphereState();
                m_states[i].Sphere = new Sphere();
                m_states[i].Sphere.Location.Position = new Vector3(0, i * 10, 0);
                m_states[i].Sphere.Radius = 5; 
            }

            for (var i = 0; i < THREAD_COUNT; i++)
            {
                m_threadMoves[i] = new ThreadMove();
                m_threadMoves[i].States = m_states;
                m_threadMoves[i].IndexStart = (SPHERE_COUNT / THREAD_COUNT) * i;
                m_threadMoves[i].IndexEnd = (SPHERE_COUNT / THREAD_COUNT) * (i + 1);
            }
        }

        public void Init2()
        {
            m_states = new SphereState[SPHERE_COUNT];
            m_threadMoves = new ThreadMove[SPHERE_COUNT];

            for (var i = 0; i < SPHERE_COUNT; i++)
            {
                m_states[i] = new SphereState();
                m_states[i].Sphere = new Sphere();
                m_states[i].Sphere.Location.Position = new Vector3(0, i * 10, 0);
                m_states[i].Sphere.Radius = 5;
            }

            for (var i = 0; i < SPHERE_COUNT; i++)
            {
                m_threadMoves[i] = new ThreadMove();
                m_threadMoves[i].States = m_states;
                m_threadMoves[i].IndexStart = i;
                m_threadMoves[i].IndexEnd = i;
            }
        }

        public void ExecutionSerial()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (var i = 0; i < THREAD_COUNT; i++)
            {
                m_threadMoves[i].Move();
            }
            sw.Stop();

            Console.WriteLine(string.Format("Serial : {0}", sw.Elapsed));
        }

        public void ExecutionMultiThread()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (var i = 0; i < THREAD_COUNT; i++)
            {
                m_threadMoves[i].Start();
            }

            var allHasMoved = false;
            while (!allHasMoved)
            {
                for (var i = 0; i < SPHERE_COUNT; i++)
                {
                    if (!m_states[i].HasMoved)
                    {
                        allHasMoved = false;
                        break;
                    }

                    allHasMoved = true;
                }

                Thread.Sleep(1);
            }
            sw.Stop();

            Console.WriteLine(string.Format("Multi : {0}", sw.Elapsed));
        }

        public void ExecutionMultiThreadTask()
        {
            var tasks = new Task[SPHERE_COUNT];

            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (var i = 0; i < SPHERE_COUNT; i++)
            {
                var t = Task.Factory.StartNew(m_threadMoves[i].Move);
                tasks[i] = t;
                //m_threadMoves[i].Start();
            }

            Task.WaitAll(tasks);
            sw.Stop();

            Console.WriteLine(string.Format("Tasks : {0}", sw.Elapsed));
        }

        public void ExecutionParallel()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            var p = Parallel.ForEach(m_threadMoves, x => x.Move());
            sw.Stop();

            Console.WriteLine(string.Format("Parallel : {0}", sw.Elapsed));
        }


        public void ExecutionMultiThread2()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            var t1 = new Thread(() => Run(1));
            var t2 = new Thread(() => Run(2));
            var t3 = new Thread(() => Run(3));
            var t4 = new Thread(() => Run(4));

            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();

            sw.Stop();

            Console.WriteLine(string.Format("Multi : {0}", sw.Elapsed));
        }

        public void Run(int id)
        {
            while (true)
            {
                testInt = id;
                Console.WriteLine(id + " : " + testInt);

                Thread.Sleep(1);
            }
        }

        public void Results()
        {
            Console.WriteLine("=======================");
            Console.WriteLine("= Results             =");
            Console.WriteLine("=======================");

            for (var i = 0; i < SPHERE_COUNT; i++)
            {
                Console.WriteLine(String.Format("{0} : {1}", i, m_states[i].Sphere.Location.Position));
            }

            Console.WriteLine("=======================");
            Console.ReadKey();
        }

    }
}
