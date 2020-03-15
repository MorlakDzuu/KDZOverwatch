using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Hero
    {
        private Random random = new Random();
        public string Name { get; set; }
        public double DamagePerSecond { get; set; }  
        public double HeadshotDPS { get; set; }

        public double SingleShot { get; set; }
        public double Life { get; set; }
        public string Reload { get; set; }

        public override string ToString()
        {
            return Name + ":" + Environment.NewLine + "Damage per second = " + DamagePerSecond + Environment.NewLine +
                   "HeadshotDPS = " + HeadshotDPS + Environment.NewLine +
                   "Single shot = " + SingleShot + Environment.NewLine + 
                   "Life = " + Life + Environment.NewLine + 
                   "Reload = " + Reload + Environment.NewLine;
        }

        /// <summary>
        /// Герой получает урон от обычного выстрела.
        /// Возвращет TRUE в случае если Life < 0, FALSE в противном случае.
        /// </summary>
        /// <param name="damage"></param>
        public bool GetSimpleShot(double damage)
        {
            for (int i = 0; i < 5; i++)
            {
                if (random.Next(1, 101) <= 70)
                {
                    Life -= 0.1 * damage;
                }
            }
            return Life < 0 ? true : false;
        }

        /// <summary>
        /// Герой получает урон от выстрела с прицелеванием.
        /// Возвращет TRUE в случае если Life < 0, FALSE в противном случае.
        /// </summary>
        /// <param name="damageSimple"></param>
        /// <param name="damageHeadshot"></param>
        /// <returns></returns>
        public bool GetTargetShot(double damageSimple, double damageHeadshot) 
        {
            for (int i = 0; i < 3; i++)
            {
                if (random.Next(1, 101) <= 30)
                {
                    if (random.Next(1, 101) <= 20)
                    {
                        Life -= damageHeadshot;
                    }
                    else
                    {
                        Life -= 0.4 * damageSimple;
                    }
                }
            }
            return Life < 0 ? true : false;
        }
    }
}
