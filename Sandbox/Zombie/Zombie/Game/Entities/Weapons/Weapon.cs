using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zombie.Game.Entities.Components;
using Zombie.Game.Entities.Tools;

namespace Zombie.Game.Entities.Weapons
{
    public class Weapon : IUpdatable
    {
        #region Properties
        private string m_name;
        private double m_damage;
        private int m_charger;
        private int m_bulletsInCharger;
        private double m_timeLoadBullet;
        private double m_timeLoadCharger;
        private int m_ammoSize;
        private double m_startReloadBullet;
        private double m_startReloadCharger;
        private bool m_loaded;
        private Shoot m_shoot;
        #endregion

        #region Accessors
        public string Name { get { return m_name; } }
        public double Damage { get { return m_damage; } }
        #endregion

        #region Constructor
        public Weapon(string name, double damage, int charger, 
            double timeLoadBullet, double timeLoadCharger, int ammoSize, Shoot shoot)
        {
            m_name = name;
            m_damage = damage;
            m_charger = charger;
            m_bulletsInCharger = charger;
            m_timeLoadBullet = timeLoadBullet;
            m_timeLoadCharger = timeLoadCharger;
            m_ammoSize = ammoSize;
            m_shoot = shoot;
            m_startReloadBullet = 0;
            m_startReloadCharger = 0;
            m_loaded = true;
            shoot.SetWeapon(this);
        }
        #endregion

        #region Methods
        public bool ReloadCharger()
        {
            //Si != 0, déja en train de recharger
            if (m_startReloadCharger == 0 && m_ammoSize != 0)
            {
                m_startReloadCharger = m_timeLoadCharger;

                return true;
            }

            return false;
        }

        public bool ReloadBullet()
        {
            //Si != 0, déja en train de recharger
            if (m_startReloadBullet == 0 && m_bulletsInCharger != 0)
            {
                m_startReloadBullet = m_timeLoadBullet;

                return true;
            }

            return false;
        }

        public bool Fire(Vector2 position, Vector2 direction)
        {
            if (m_startReloadCharger != 0)
            {
                Console.WriteLine("Weapon reload charger !");
            }
            else if (m_startReloadBullet != 0)
            {
                Console.WriteLine("Weapon reload bullet !");
            }
            else if (m_loaded)
            {
                Console.WriteLine("Fire !");
                var shoot = (Shoot)m_shoot.Clone();
                shoot.SetPosition(position);
                shoot.SetDirection(direction);
                    
                ShootManager.Instance.AddShoot(shoot);

                m_loaded = false;

                ReloadBullet();
            }
            else
            {
                Console.WriteLine("Weapon not loaded !");
            }

            return false;
        }

        public void Update(TimeSpan elapsed)
        {
            if (m_startReloadCharger != 0)
            {
                m_startReloadCharger -= elapsed.TotalSeconds;

                if (m_startReloadCharger <= 0)
                {
                    m_ammoSize -= m_charger;
                    if (m_ammoSize < 0)
                    {
                        Console.WriteLine("Ammo empty !");
                        m_ammoSize = 0;
                    }
                    m_startReloadCharger = 0;
                    m_bulletsInCharger = m_charger;
                    ReloadBullet(); //Le chargeur est plein, on charge une balle
                }
            }

            if (m_startReloadBullet != 0)
            {
                m_startReloadBullet -= elapsed.TotalSeconds;

                if (m_startReloadBullet <= 0)
                {
                    if (m_bulletsInCharger == 0)
                    {
                        Console.WriteLine("Charger empty !");
                    }
                    else
                    {
                        m_bulletsInCharger -= 1;
                        m_loaded = true;
                    }
                    m_startReloadBullet = 0;
                }
            }
        }
        #endregion
    }
}
