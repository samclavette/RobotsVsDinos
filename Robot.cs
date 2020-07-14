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
        bool isRobotAlive;
        Weapon weapon;

        // constructor (spawner)

        public Robot(string name, int robotHealth, int robotPowerLevel, Weapon weapon)
        {
            this.name = name;
            this.robotHealth = robotHealth;
            this.robotPowerLevel = robotPowerLevel;
            isRobotAlive = true;
            this.weapon = weapon; 
        }

        //mem methods (can do)

        public Weapon GetWeapon()
        {
            return weapon;
        }

        public int RobotGetHealth()
        {
            return robotHealth;
        }

        public void RobotLoseHealth(int robotHealthLost)
        {
            robotHealth = robotHealth - robotHealthLost;
        }

        public int GetRobotHealth()
        {
            return robotHealth;
        }

        public void RobotLosePowerLevel(int robotPowerLost)
        {
            robotPowerLevel = robotPowerLevel - robotPowerLost;
        }

        public void RobotDie()
        {
            if (robotHealth == 0 && isRobotAlive == true)
            {
                isRobotAlive = false;
                Console.WriteLine("Robot is dead.");
            }
        }
    }
}
