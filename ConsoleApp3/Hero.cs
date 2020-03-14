using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Hero
    {
        public string Name { get; set; }
        public double DamagePerSecond { get; set; }  
        public double HeadshotDPS { get; set; }

        public double SingleShot { get; set; }
        public double Life { get; set; }
        public double Reload { get; set; }

        public override string ToString()
        {
            return Name + ":\nDamage per second = " + DamagePerSecond + "\nHeadshotDPS = " + HeadshotDPS +
                   "\nSingle shot = " + SingleShot + "\nLife = " + Life + "\nReload = " + Reload + "\n";
        }
    }
}
