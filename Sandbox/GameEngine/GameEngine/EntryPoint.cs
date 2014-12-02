using GameEngine.Components;
using GameEngine.Entities;
using GameEngine.Systems;
using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    /// <summary>
    /// Pour cette archi je suis parti du principe qu'on utilise le réseau 
    /// et donc qu'on doit faire circuler le moins d'infos possible.
    /// D'où la simplicité des composants, 
    /// si on veut par exemple sauvegarder l'etat du monde, il suffit de sérialiser tous les composants
    /// </summary>
    class EntryPoint : ApplicationLogicBase
    {
        //static void Main(string[] args)
        //{
        //    //Initialisations de tous les systems
        //    SystemManager.Instance.Initialize();

        //    //Creation du joueur
        //    var player = new GameObject();
        //    //A chaque ajout de composant on ajoute les systems en observer
        //    player.AddComponent(ComponentType.Location, new LocationComponent());
        //    player.AddComponent(ComponentType.Orientation, new OrientationComponent());
        //    player.AddComponent(ComponentType.Speed, new SpeedComponent());

        //    //Modification d'une donnée
        //    var orientation = player.GetComponent(ComponentType.Orientation) as OrientationComponent;
        //    orientation.X = 1;

        //    var speed = player.GetComponent(ComponentType.Speed) as SpeedComponent;
        //    speed.Current = 10;
        //    speed.Acceleration = 0.1;

        //    Console.WriteLine("==================================");

        //    //Boucle qui simule une boucle de jeu
        //    int cpt = 0;
        //    var continuer = true;
        //    while (continuer)
        //    {
        //        //Update des systems IUpdateSystem
        //        SystemManager.Instance.Update(new TimeSpan(0, 0, 1));
        //        //Render des systems IRenderSystem
        //        SystemManager.Instance.Render(Matrix4.Identity);

        //        //On affiche l'état actuel du composant pour voir les changements
        //        var location = player.GetComponent(ComponentType.Location) as LocationComponent;
        //        Console.WriteLine(cpt + " : Location : " + location.Serialize());

        //        speed = player.GetComponent(ComponentType.Speed) as SpeedComponent;
        //        Console.WriteLine(cpt + " : Speed : " + speed.Serialize());

        //        Console.WriteLine("==================================");

        //        cpt++;

        //        var input = Console.ReadLine();

        //        if (input == "quit")
        //        {
        //            continuer = false;
        //        }
        //    }
        //}

        public static void Main(string[] args)
        {
            Engine.AddLogAppender(new ConsoleLogAppender());

            Engine.Run(new EntryPoint(), new ApplicationSettings()
            {
                DisplayStyle = DisplayStyle.ResizeableWithTitle,
            });
        }

        public EntryPoint()
        {
           
        }

        public override void InputEvent(InputEventArgs e)
        {
            
        }

        public override void Start()
        {
            //Creation du joueur
            var player = new Entity();
            //A chaque ajout de composant on ajoute les systems en observer
            player.AddComponent(ComponentType.Location, new LocationComponent());
            player.AddComponent(ComponentType.Orientation, new OrientationComponent());
            player.AddComponent(ComponentType.Speed, new SpeedComponent());
            player.AddComponent(ComponentType.Quad, new QuadComponent());
            player.AddComponent(ComponentType.Texture, new TextureComponent());

            //Modification d'une donnée
            var orientation = player.GetComponent(ComponentType.Orientation) as OrientationComponent;
            orientation.X = 1;

            var speed = player.GetComponent(ComponentType.Speed) as SpeedComponent;
            speed.Current = 0;
            speed.Acceleration = 0;

            var quad = player.GetComponent(ComponentType.Quad) as QuadComponent;
            quad.Width = 100;
            quad.Height = 100;

            var texture = player.GetComponent(ComponentType.Texture) as TextureComponent;
            texture.StartX = 0;
            texture.StartY = 0;
            texture.EndX = 1;
            texture.EndY = 1;
            texture.Id = 1;

            EntityManager.Instance.AddEntity(player);

            Console.WriteLine("==================================");

            GameManager.Instance.Start();
        }

        public override void Render(TimeSpan elapsed)
        {
            Engine.Display.Invalidate();

            Engine.Display.SetTitle(string.Format("{0:0} FPS", Engine.Display.FramesPerSecond));

            var size = Engine.Display.GetSize();

            GL.Viewport(size);
            GL.ClearColor(0.6f, 0.8f, 1.0f, 1.0f);
            GL.Clear(GL.COLOR_BUFFER_BIT | GL.DEPTH_BUFFER_BIT);
            GL.Enable_BLEND();
            GL.BlendFunc(GL.SRC_ALPHA, GL.ONE_MINUS_SRC_ALPHA);

            GameManager.Instance.Update(elapsed, Matrix4.Identity);

            GL.Finish();
        }
    }
}
