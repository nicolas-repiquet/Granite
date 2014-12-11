using Granite.Core;
using Granite.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zombie.Game.Entities.World;

namespace Zombie.Game.UI
{
    public class UIGame
    {
        private UIManager m_uiManager;
        private UILabel m_lblWeaponInfos;
        private UILabel m_lblWeaponName;
        private UILabel m_lblWeaponCurrentAmmo;
        private UILabel m_lblWeaponTotalAmmo;

        public UIGame()
        {
            var size = Engine.Display.GetSize();

            m_uiManager = new UIManager();

            m_lblWeaponInfos = new UILabel()
            {
                Color = new Color4ub(0xFF, 0x80, 0x80, 0xFF),
                Font = InternalFonts.BoldSmallVariableWidthFont,
                Bounds = new Box2(size.X - 300, size.Y - 25, 300, 25)
            };

            m_lblWeaponName = new UILabel()
            {
                Color = new Color4ub(0xFF, 0x80, 0x80, 0xFF),
                Font = InternalFonts.BoldSmallVariableWidthFont,
                Bounds = new Box2(0, 0, 100, 25)
                
            };

            m_lblWeaponCurrentAmmo = new UILabel()
            {
                Color = new Color4ub(0xFF, 0x80, 0x80, 0xFF),
                Font = InternalFonts.BoldSmallVariableWidthFont,
                Bounds = new Box2(0, 25, 100, 25)
            };

            m_lblWeaponTotalAmmo = new UILabel()
            {
                Color = new Color4ub(0xFF, 0x80, 0x80, 0xFF),
                Font = InternalFonts.BoldSmallVariableWidthFont,
                Bounds = new Box2(0, 50, 100, 25)
            };


            m_uiManager.Root = m_lblWeaponInfos;
        }

        public void Render(TimeSpan elapsed)
        {
            var player = World.Instance.Player;

            if (player.Weapon != null)
            {
                //m_lblWeaponName.Text = string.Format("{0}", player.Weapon.Name);
                //m_lblWeaponCurrentAmmo.Text += string.Format("{0}/{1}", player.Weapon.AmmoInCharger, player.Weapon.Charger);
                //m_lblWeaponTotalAmmo.Text += string.Format("Total ammo : {0}", player.Weapon.AmmoSize);

                m_lblWeaponInfos.Text = string.Format("{0}, {1}/{2}, Total ammo : {3}", 
                    player.Weapon.Name,
                    player.Weapon.AmmoInCharger,
                    player.Weapon.Charger,
                    player.Weapon.AmmoSize);
            }

            m_uiManager.Render(elapsed);
        }
    }
}
