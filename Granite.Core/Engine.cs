using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace Granite.Core
{
    public static class Engine
    {
        private static bool m_initialized;


        #region Initialization

        public static void Initialize(EngineSettings settings)
        {
            if (!m_initialized)
            {
                m_initialized = true;
                InternalInitialize(settings);
            }
            else
            {
                throw new InvalidOperationException("Engine is already initialized");
            }
        }

        public static bool IsInitialized { get { return m_initialized; } }

        #endregion



        private static IntPtr m_eventHandle;
        private static Thread m_thread;
        private static Queue<Action> m_actions;
        private static GL m_gl;


        private static  bool m_running;
        private static  IntPtr m_openglContext;

        // ********************************************************************
        // * Constructor / Destructor

        private static void InternalInitialize(EngineSettings settings)
        {
            if (settings == null) throw new ArgumentNullException("settings");

            m_actions = new Queue<Action>();
            m_eventHandle = WinApi.CreateEvent(IntPtr.Zero, true, false, null);
            m_thread = Thread.CurrentThread;

            using (Display display = new Display(new InternalDisplayLogic()))
            {
                m_openglContext = WinApi.wglCreateContext(display.DeviceContextHandle);
                var result = WinApi.wglMakeCurrent(display.DeviceContextHandle, m_openglContext);
                m_gl = new GL();
            }
        }

        //~Engine()
        //{
        //    WinApi.CloseHandle(m_eventHandle);
        //}

        // ********************************************************************
        // * Private methods


        private static void WakeUp()
        {
            WinApi.SetEvent(m_eventHandle);
        }

        private class InternalDisplayLogic : DisplayLogicBase
        {
        
        }

        // ********************************************************************
        // * internal

        internal static IntPtr OpenglContext { get { return m_openglContext; } }

        public static GL Gl { get { return m_gl; } }

        internal static void CheckThread()
        {
            if (Thread.CurrentThread != m_thread)
            {
                throw new InvalidOperationException("Invalid thread");
            }
        }

        internal static void CheckThreadAndRunning()
        {
            if (Thread.CurrentThread != m_thread)
            {
                throw new InvalidOperationException("Invalid thread");
            }
            else if (!m_running)
            {
                throw new InvalidOperationException("Engine is not running");
            }
        }

        internal static void ExecuteAction(Action action)
        {
            if (action != null)
            {
                if (Thread.CurrentThread == m_thread)
                {
                    action();
                }
                else
                {
                    lock (m_actions)
                    {
                        m_actions.Enqueue(action);
                    }
                    WakeUp();
                }
            }
        }


        // ********************************************************************
        // * Public methods

        public static bool IsRunning { get { return m_running; } }

        public static void Run(IRunnableLogic logic)
        {
            CheckThread();

            if (!m_running)
            {
                try
                {
                    m_running = true;

                    logic.OnStart();

                    bool stop = false;
                    IntPtr[] handles = new IntPtr[] { m_eventHandle };
                    WinApi.Message message = new WinApi.Message();

                    while (!stop)
                    {
                        uint index = WinApi.MsgWaitForMultipleObjects(
                            (uint)handles.Length,
                            handles,
                            false,
                            WinApi.INFINITE,
                            WinApi.QS_ALLINPUT
                        );

                        WinApi.ResetEvent(m_eventHandle);

                        // Do things
                        if (index == 0)
                        {
                            lock (m_actions)
                            {
                                while (m_actions.Count > 0)
                                {
                                    m_actions.Dequeue()();
                                }
                            }
                        }

                        // Process messages
                        while (WinApi.PeekMessage(ref message, IntPtr.Zero, 0, 0, WinApi.PM_REMOVE))
                        {
                            if (message.id == WinApi.WM_QUIT)
                            {
                                stop = true;
                                break;
                            }
                            else
                            {
                                WinApi.TranslateMessage(ref message);
                                WinApi.DispatchMessage(ref message);
                            }
                        }
                    }

                    logic.OnStop();

                }
                finally
                {
                    m_running = false;
                }
            }
        }

        public static void Stop()
        {
            CheckThread();

            if (m_running)
            {
                WinApi.PostQuitMessage(0);
            }
        }

        public static Display CreateDisplay(DisplaySettings settings, IDisplayLogic logic)
        {
            CheckThread();
            return new Display(logic);
        }

        public static Buffer<T> CreateBuffer<T>() where T : struct
        {
            CheckThread();
            return new Buffer<T>();
        }

        public static Buffer<T> CreateBuffer<T>(T[] data) where T : struct
        {
            CheckThread();
            var buffer = new Buffer<T>();
            buffer.SetData(data);
            return buffer;
        }

        public static VertexShader CreateVertexShader(string source)
        {
            CheckThread();
            return new VertexShader(source);
        }

        public static FragmentShader CreateFragmentShader(string source)
        {
            CheckThread();
            return new FragmentShader(source);
        }

        public static Program CreateProgram(VertexShader vertexShader, FragmentShader fragmentShader)
        {
            CheckThread();
            return new Program(vertexShader, fragmentShader);
        }

        public static Texture2D CreateTexture2D()
        {
            CheckThread();
            return new Texture2D();
        }
    }
}
