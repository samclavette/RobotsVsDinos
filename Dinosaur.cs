using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinos
{
    class Dinosaur
    {
        // mem variables (has a)

        string type;
        int dinoHealth;
        int dinoEnergy;
        int dinoAttackPower;
        bool isDinoAlive;

        // constructor (spawner)

        public Dinosaur(string type, int dinoHealth, int dinoEnergy, int dinoAttackPower)
        {
            this.type = type;
            this.dinoHealth = dinoHealth;
            this.dinoEnergy = dinoEnergy;
            this.dinoAttackPower = dinoAttackPower;
            isDinoAlive = true;
        }

        // mem methods (can do)
        public int GetDinoAttackPower()
        {
            return dinoAttackPower;
        }

        public int GetDinoHealth()
        {
            return dinoHealth;
        }

        public void DinoLoseHealth(int dinoHealthLost)
        {
            dinoHealth = dinoHealth - dinoHealthLost;
        }

        public int GetDinoEnergy()
        {
            return dinoEnergy;
        }

        public void DinoLoseEnergy(int dinoEnergyLost)
        {
            dinoEnergy = dinoEnergy - dinoEnergyLost;
        }

        public void DinoDie()
        {
            if (dinoHealth == 0 && isDinoAlive == true)
            {
                isDinoAlive = false;
                Console.WriteLine("Dinosaur is dead.");
            }
        }
    }
}
