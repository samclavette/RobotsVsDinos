using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinos
{
    class Weapon
    {
        //mem variables
        string weaponType;
        public int attackPower;
        int energyUsed;
         
        public Weapon(string weaponType, int attackPower, int energyUsed)
        {
            this.weaponType = weaponType;
            this.attackPower = attackPower;
            this.energyUsed = energyUsed;
        }
        //mem methods 
        public int GetAttackPower()
        {
            return attackPower;
        }

        public int LoseEnergyUsed()
        {
            return energyUsed;
        }
    }
}
