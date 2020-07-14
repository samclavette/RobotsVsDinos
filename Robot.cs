using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RobotsVDinos
{
    class Robot
    {
        // mem variables (has a)
        string name;
        int robotHealth;
        int robotPowerLevel;
        bool isAlive;
        Weapon weapon;

        // constructor (spawner)

        public Robot(string name, int robotHealth, int robotPowerLevel)
        {
            this.name = name;
            this.robotHealth = robotHealth;
            this.robotPowerLevel = robotPowerLevel;
            isAlive = true;
        }

        public string getName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
        //mem methods (can do)

        public void ChooseWeapon()
        {

        }
        public void AttackDino()
        {
            //

        }

        public void LoseHealth()
        {

        }

        public void LosePowerLevel()
        {

        }

        public void GainPowerLevel()
        {

        }

        public void RobotDie()
        {
            if (robotHealth == 0
                )
            {
                Console.WriteLine("Robot has died.");
            }
        }
    }
}
