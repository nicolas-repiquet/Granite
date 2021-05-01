using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Temple3D.Programs;

namespace Temple3D
{
    class Game : ApplicationLogicBase
    {
        static void Main(string[] args)
        {
            Engine.Run(new Game(), new ApplicationSettings
            {
                DisplayStyle = DisplayStyle.ResizeableWithTitle,
                VerticalSynchronization = false,
            });
        }

        private Camera _mainCamera;
        private Camera _debugCamera;
        private Grid[] _grids;
        private Mesh _mesh;
        private LinePainter _linePainter;

        public override void Start()
        {
            _linePainter = new LinePainter();

            _mainCamera = new Camera()
            {
                FieldOfView = 50f,
                NearPlaneDistance = 1f,
                FarPlaneDistance = 100f,
                UpDirection = Vector3.UnitZ,
                Target = new Vector3(0, 0, 5)
            };

            _debugCamera = new Camera()
            {
                FieldOfView = 90f,
                NearPlaneDistance = 1f,
                FarPlaneDistance = 1000f,
                UpDirection = Vector3.UnitZ,
                Target = new Vector3(0, 0, 5),
                Position = new Vector3(30, 30, 30)
            };

            _mesh = new Mesh(
                new Vertex[]
                {
                    new Vertex { Position = new Vector3(+0.5f, +0.5f, +0.5f) },
                    new Vertex { Position = new Vector3(-0.5f, +0.5f, +0.5f) },
                    new Vertex { Position = new Vector3(-0.5f, -0.5f, +0.5f) },
                    new Vertex { Position = new Vector3(+0.5f, -0.5f, +0.5f) },

                    new Vertex { Position = new Vector3(+0.5f, +0.5f, -0.5f) },
                    new Vertex { Position = new Vector3(-0.5f, +0.5f, -0.5f) },
                    new Vertex { Position = new Vector3(-0.5f, -0.5f, -0.5f) },
                    new Vertex { Position = new Vector3(+0.5f, -0.5f, -0.5f) },
                },
                new uint[] {
                    0, 1, 2,
                    0, 2, 3,

                    4, 5, 6,
                    4, 6, 7,

                    0, 3, 7,
                    0, 7, 4,

                    3, 2, 6,
                    3, 6, 7,

                    2, 1, 5,
                    2, 5, 6,

                    1, 0, 4,
                    1, 4, 5,
                }
            );

            _grids = new Grid[] {
                new Grid(new Vector3(0, 0, 0), 20f, 40),
                new Grid(new Vector3(0, 0, 5), 20f, 40),
                new Grid(new Vector3(0, 0, 10), 20f, 40)
            };
        }

        private Vector2? _mousePosition;

        public override void InputEvent(InputEventArgs e)
        {
            if (e is MouseButtonDownEventArgs mbde && mbde.Button == MouseButton.Left)
            {
                _mousePosition = mbde.Position;
            }
            else if (e is MouseButtonUpEventArgs mbue && mbue.Button == MouseButton.Left)
            {
                _mousePosition = null;
            }
            else if (e is MouseMoveEventArgs mme && _mousePosition != null)
            {
                var offsetX = mme.Position.X - _mousePosition.Value.X;
                var offsetY = mme.Position.Y - _mousePosition.Value.Y;

                _mousePosition = mme.Position;

                _rotationX -= offsetX * 1f;
                _rotationZ = Math.Max(-1.2f, Math.Min(1.2f, _rotationZ - offsetY * 1f));
            }
            else if (e is MouseWheelEventArgs mwe)
            {
                _distance = Math.Max(5f, Math.Min(40f, _distance - mwe.Ticks));
            }
        }

        private float _distance = 20f;
        private float _rotationX;
        private float _rotationZ;

        public override void Render(TimeSpan elapsed)
        {
            Engine.Display.SetTitle(Engine.Display.FramesPerSecond.ToString("0") + " fps");

            var screenSize = Engine.Display.GetSize();

            GL.ClearColor(new Color4(0.2f, 0.2f, 0.2f, 1f));
            GL.Clear(GL.COLOR_BUFFER_BIT | GL.DEPTH_BUFFER_BIT);
            GL.Enable(GL.DEPTH_TEST);

            var d = new Vector2(
                (float)Math.Cos(_rotationX) * _distance,
                (float)Math.Sin(_rotationX) * _distance
            );

            // main view
            _mainCamera.Position = _mainCamera.Target + new Vector3(d * (float)Math.Cos(_rotationZ), (float)Math.Sin(_rotationZ) * _distance);
            _mainCamera.Viewport = new Box2i(0, 0, screenSize.X / 2, screenSize.Y);
            GL.Viewport(_mainCamera.Viewport);
            //GL.PolygonMode(GL.FRONT_AND_BACK, GL.FILL);
            Render(elapsed, _mainCamera, false);

            // debug view
            _debugCamera.Viewport = new Box2i(screenSize.X / 2, 0, screenSize.X - screenSize.X / 2, screenSize.Y);
            GL.Viewport(_debugCamera.Viewport);
            //GL.PolygonMode(GL.FRONT_AND_BACK, GL.POINT);
            //GL.PointSize(4f);

            Render(elapsed, _debugCamera, true);

            Engine.Display.Invalidate();
        }

        public void Render(TimeSpan elapsed, Camera camera, bool debug)
        {
            var projectionMatrix = camera.CreateWorldToViewportMatrix();

            var transform = Matrix4.Scale(0.5f, 0.5f, 0.5f);

            foreach (var grid in _grids)
            {
                grid.Draw(projectionMatrix);
            }

            _mesh.Draw(projectionMatrix, new Color3(1f, 1f, 1f));

            _mesh.Draw(projectionMatrix * Matrix4.Translate(10f, 0f, 0f), new Color3(1f, 0f, 0f));
            _mesh.Draw(projectionMatrix * Matrix4.Translate(0f, 10f, 0f), new Color3(0f, 1f, 0f));
            _mesh.Draw(projectionMatrix * Matrix4.Translate(0f, 0f, 10f), new Color3(0f, 0f, 1f));
            _mesh.Draw(projectionMatrix * Matrix4.Translate(10f, 10f, 0f), new Color3(1f, 1f, 0f));


            for (int z = 0; z < 3; z++)
            {
                for (int y = 0; y <= 10; y++)
                {
                    for (int x = 0; x <= 10; x++)
                    {
                        _mesh.Draw(projectionMatrix * Matrix4.Translate(10f - x * 2, 10f - y * 2, z * 5f) * transform, new Color3(x / 10f, y / 10f, 1f));
                    }
                }
            }

            //if (debug)
            {
                var frustum = _mainCamera.GetFrustum();

                _linePainter.AddLine(frustum.NearTopLeft, frustum.NearTopRight, new Color3(1f, 1f, 0f));
                _linePainter.AddLine(frustum.NearTopRight, frustum.NearBottomRight, new Color3(1f, 1f, 0f));
                _linePainter.AddLine(frustum.NearBottomRight, frustum.NearBottomLeft, new Color3(1f, 1f, 0f));
                _linePainter.AddLine(frustum.NearBottomLeft, frustum.NearTopLeft, new Color3(1f, 1f, 0f));

                _linePainter.AddLine(frustum.FarTopLeft, frustum.FarTopRight, new Color3(1f, 1f, 0f));
                _linePainter.AddLine(frustum.FarTopRight, frustum.FarBottomRight, new Color3(1f, 1f, 0f));
                _linePainter.AddLine(frustum.FarBottomRight, frustum.FarBottomLeft, new Color3(1f, 1f, 0f));
                _linePainter.AddLine(frustum.FarBottomLeft, frustum.FarTopLeft, new Color3(1f, 1f, 0f));

                _linePainter.AddLine(frustum.NearTopLeft, frustum.FarTopLeft, new Color3(1f, 1f, 0f));
                _linePainter.AddLine(frustum.NearTopRight, frustum.FarTopRight, new Color3(1f, 1f, 0f));
                _linePainter.AddLine(frustum.NearBottomLeft, frustum.FarBottomLeft, new Color3(1f, 1f, 0f));
                _linePainter.AddLine(frustum.NearBottomRight, frustum.FarBottomRight, new Color3(1f, 1f, 0f));

                _linePainter.Draw(projectionMatrix, new Color3(1f, 0.5f, 0f));
                _linePainter.Clear();
            }
            
        }
    }
}