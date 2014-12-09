using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zombie.Game.Entities.Zones;
using Zombie.Game.Sprites;

namespace Zombie.Game.Sprites
{
    public class TreesSprites : SpriteSheet
    {
        private static TreesSprites s_instance;
        public static TreesSprites Instance
        {
            get
            {
                if (s_instance == null)
                {
                    s_instance = new TreesSprites();
                }
                return s_instance;
            }
        }

        public Sprite Arbre1 { get; private set; }
        public Sprite Arbre2 { get; private set; }
        public Sprite Arbre3 { get; private set; }
        public Sprite Arbre4 { get; private set; }
        public Sprite Arbre5 { get; private set; }
        public Sprite Arbre6 { get; private set; }
        public Sprite Arbre7 { get; private set; }
        public Sprite Arbre8 { get; private set; }
        public Sprite Arbre10 { get; private set; }
        public Sprite Arbre11 { get; private set; }
        public Sprite Arbre12 { get; private set; }
        public Sprite Arbre13 { get; private set; }
        public Sprite Arbre20 { get; private set; }
        public Sprite Arbre21 { get; private set; }
        public Sprite Arbre22 { get; private set; }
        public Sprite Arbre23 { get; private set; }

        public TreesSprites()
        {
            Arbre1 = GetSprite("arbre_1");
            Arbre2 = GetSprite("arbre_2");
            Arbre3 = GetSprite("arbre_3");
            Arbre4 = GetSprite("arbre_4");
            Arbre5 = GetSprite("arbre_5");
            Arbre6 = GetSprite("arbre_6");
            Arbre7 = GetSprite("arbre_7");
            Arbre8 = GetSprite("arbre_8");
            Arbre10 = GetSprite("arbre_10");
            Arbre11 = GetSprite("arbre_11");
            Arbre12 = GetSprite("arbre_12");
            Arbre13 = GetSprite("arbre_13");
            Arbre20 = GetSprite("arbre_20");
            Arbre21 = GetSprite("arbre_21");
            Arbre22 = GetSprite("arbre_22");
            Arbre23 = GetSprite("arbre_23");
        }
    }
}
