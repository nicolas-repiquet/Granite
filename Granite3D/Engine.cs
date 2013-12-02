using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace Granite3D
{
    public sealed class Engine
    {
        private readonly IntPtr m_eventHandle;
        private readonly Thread m_thread;
        private readonly IEngineLogic m_logic;
        private readonly Queue<Action> m_actions;
        private GL m_gl;

        private bool m_running;
        private IntPtr m_openglContext;

        // ********************************************************************
        // * Constructor / Destructor

        public Engine(EngineSettings settings, IEngineLogic logic)
        {
            if (settings == null) throw new ArgumentNullException("settings");
            if (logic == null) throw new ArgumentNullException("logic");

            m_actions = new Queue<Action>();
            m_logic = logic;
            m_eventHandle = WinApi.CreateEvent(IntPtr.Zero, true, false, null);
            m_thread = Thread.CurrentThread;
        }

        ~Engine()
        {
            WinApi.CloseHandle(m_eventHandle);
        }

        // ********************************************************************
        // * Private methods


        private void WakeUp()
        {
            WinApi.SetEvent(m_eventHandle);
        }

        private class InternalDisplayLogic : DisplayLogicBase
        {
             
        }

        private void Prepare()
        {
            using (Display display = new Display(this, new InternalDisplayLogic()))
            {
                m_openglContext = WinApi.wglCreateContext(display.DeviceContextHandle);
                var result = WinApi.wglMakeCurrent(display.DeviceContextHandle, m_openglContext);
                m_gl = new GL();

                var vendor = Marshal.PtrToStringAnsi(m_gl.GetString(GL.VENDOR));
                var version = Marshal.PtrToStringAnsi(m_gl.GetString(GL.VERSION));
                var renderer = Marshal.PtrToStringAnsi(m_gl.GetString(GL.RENDERER));
                var shadingLanguageVersion = Marshal.PtrToStringAnsi(m_gl.GetString(GL.SHADING_LANGUAGE_VERSION));
                var extensions = new List<string>();

                while(true) {
                    var p = m_gl.GetStringi(GL.EXTENSIONS, (uint)extensions.Count);
                    if (p != IntPtr.Zero)
                    {
                        extensions.Add(Marshal.PtrToStringAnsi(p));
                    }
                    else
                    {
                        break;
                    }
                }
                extensions.Sort();
            }
        }

        // ********************************************************************
        // * internal

        internal IntPtr OpenglContext { get { return m_openglContext; } }

        internal GL Gl { get { return m_gl; } }

        internal void CheckThread()
        {
            if (Thread.CurrentThread != m_thread)
            {
                throw new InvalidOperationException("Invalid thread");
            }
        }

        internal void CheckThreadAndRunning()
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

        internal void ExecuteAction(Action action)
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

        public bool IsRunning { get { return m_running; } }

        public void Run()
        {
            CheckThread();

            if (!m_running)
            {
                try
                {
                    m_running = true;

                    Prepare();

                    m_logic.OnStart(this);

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

                    m_logic.OnStop(this);


                }
                finally
                {
                    m_running = false;
                }
            }
        }

        public void Stop()
        {
            CheckThread();

            if (m_running)
            {
                WinApi.PostQuitMessage(0);
            }
        }

        public Display CreateDisplay(DisplaySettings settings, IDisplayLogic logic)
        {
            CheckThread();

            if (m_running)
            {
                return new Display(this, logic);
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public Buffer<T> CreateBuffer<T>() where T : struct
        {
            CheckThreadAndRunning();
            return new Buffer<T>(this);
        }

        public Buffer<T> CreateBuffer<T>(T[] data) where T : struct
        {
            CheckThreadAndRunning();
            var buffer = new Buffer<T>(this);
            buffer.SetData(data);
            return buffer;
        }

        public VertexShader CreateVertexShader(string source)
        {
            CheckThreadAndRunning();
            return new VertexShader(this, source);
        }

        public FragmentShader CreateFragmentShader(string source)
        {
            CheckThreadAndRunning();
            return new FragmentShader(this, source);
        }

        public Program CreateProgram(VertexShader vertexShader, FragmentShader fragmentShader)
        {
            CheckThreadAndRunning();
            return new Program(this, vertexShader, fragmentShader);
        }

        public Texture2D CreateTexture2D()
        {
            CheckThreadAndRunning();
            return new Texture2D(this);
        }
    }
}
