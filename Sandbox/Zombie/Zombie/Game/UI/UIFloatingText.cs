using Granite.Core;
using Granite.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zombie.Game.Entities.World;

namespace Zombie.Game.UI
{
    public enum FloatingTextType{
        Damage,
        Heal,
        Action,
        Other
    }

    public class UIFloatingText
    {
        private static UIFloatingText s_instance;
        public static UIFloatingText Instance
        {
            get
            {
                if (s_instance == null)
                {
                    s_instance = new UIFloatingText();
                }
                return s_instance;
            }
        }

        private UIManager m_uiManager;

        private Queue<FloatingText> m_floatingTexts;
        private List<FloatingText> m_floatingTextsLoaded;

        private Dictionary<FloatingTextType, Color4ub> m_floatingTextType;

        public UIFloatingText()
        {
            var size = Engine.Display.GetSize();

            m_uiManager = new UIManager();

            m_floatingTexts = new Queue<FloatingText>();
            m_floatingTextsLoaded = new List<FloatingText>();

            m_floatingTextType = new Dictionary<FloatingTextType, Color4ub>();

            m_floatingTextType.Add(FloatingTextType.Damage, new Color4ub(255, 0, 0, 255));
            m_floatingTextType.Add(FloatingTextType.Heal, new Color4ub(0, 255, 0, 255));
            m_floatingTextType.Add(FloatingTextType.Action, new Color4ub(255, 255, 0, 255));
            m_floatingTextType.Add(FloatingTextType.Other, new Color4ub(0, 0, 255, 255));

            //m_uiManager.Root = m_lblWeaponInfos;
        }

        public void AddText(FloatingText text)
        {
            m_floatingTexts.Enqueue(text);
        }

        public void Render(TimeSpan elapsed)
        {
            //On met à jour les labels déjà chargés
            Parallel.ForEach(m_floatingTextsLoaded, t =>
                {
                    t.Position += t.Direction * (float)elapsed.TotalSeconds;
                    t.TTL -= elapsed.TotalSeconds;
                });

            //On supprime les labels en fin de vie
            m_floatingTextsLoaded.RemoveAll(x => x.TTL < 0);

            //On ajoute les nouveaux labels en attente
            while (m_floatingTexts.Any())
            {
                var text = m_floatingTexts.Dequeue();

                text.Label = new UILabel()
                {
                    Color = m_floatingTextType[text.Color],
                    Font = InternalFonts.BoldSmallVariableWidthFont,
                    Bounds = new Box2(text.Position.X, text.Position.Y, 50, 25),
                    Text = text.Text
                };

                m_floatingTextsLoaded.Add(text);
            }

            m_uiManager.Render(elapsed);
        }
    }
}
