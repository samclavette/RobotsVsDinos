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
        bool isAlive;

        // constructor (spawner)

        public Dinosaur(string type, int dinoHealth, int dinoEnergy, int dinoAttackPower)
        {
            this.type = type;
            this.dinoHealth = dinoHealth;
            this.dinoEnergy = dinoEnergy;
            this.dinoAttackPower = dinoAttackPower;
            isAlive = true;
        }

        // mem methods (can do)

        public int GetDinoHealth()
        {
            return dinoHealth;
        }

        public void DinoLoseHealth(int healthLost)
        {
            dinoHealth = dinoHealth - healthLost;
        }

        public int GetDinoEnergy()
        {
            return dinoEnergy;
        }

        public void DinoLoseEnergy(int energyLost)
        {
            dinoEnergy = dinoEnergy - energyLost;
        }

        public void DinoDie()
        {
            if (dinoHealth == 0 && isAlive == true)
            {
                isAlive = false;
                Console.WriteLine("Dinosaur has died.");
            }
        }
    }
}
