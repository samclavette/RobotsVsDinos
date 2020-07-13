using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinos
{
    class Weapon
    {
        //mem variables
        string weaponType;
        double damageMultiplier;
        int energyUsed;
        Weapon bazooka = new Weapon("Bazooka", 1.5, 80);
        Weapon sword = new Weapon("Sword", 1.0, 40);
        Weapon toothbrush = new Weapon("Toothbrush", 0.5, 20);
        public Weapon(string weaponType, double damageMultiplier, int energyUsed)
        {
            this.weaponType = weaponType;
            this.damageMultiplier = damageMultiplier;
            this.energyUsed = energyUsed;
        }
        //mem methods 

      
    }
}
