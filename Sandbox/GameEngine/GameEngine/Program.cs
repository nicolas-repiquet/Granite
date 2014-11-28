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
    class Program
    {
        static void Main(string[] args)
        {
            //Initialisations de tous les systems
            SystemManager.Instance.Initialize();

            //Creation du joueur
            var player = new GameObject();
            //A chaque ajout de composant on ajoute les systems en observer
            player.AddComponent(ComponentType.Location, new LocationComponent());
            player.AddComponent(ComponentType.Orientation, new OrientationComponent());

            //Modification d'une donnée
            var orientation = player.GetComponent(ComponentType.Orientation) as OrientationComponent;
            orientation.X = 1;

            Console.WriteLine("==================================");

            //Boucle qui simule une boucle de jeu
            int cpt = 0;
            var continuer = true;
            while (continuer)
            {
                //Update des systems IUpdateSystem
                SystemManager.Instance.Update(new TimeSpan(0, 0, 1));
                //Render des systems IRenderSystem
                SystemManager.Instance.Render(Matrix4.Identity);

                //On affiche l'état actuel du composant pour voir les changements
                var location = player.GetComponent(ComponentType.Location) as LocationComponent;
                Console.WriteLine(cpt + " : Location : " + location.Serialize());

                Console.WriteLine("==================================");

                cpt++;

                var input = Console.ReadLine();

                if (input == "quit")
                {
                    continuer = false;
                }
            }
        }
    }
}
