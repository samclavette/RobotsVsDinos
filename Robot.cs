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
        public int robotHealth;
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
        //attack method--what would happen to the robot when it attacks a dino.  What would happen to the dino?  Would that
        //happen in this class?  Think about the parameters and what would have to be passed in.  What do you need access to?
        public void AttackDino(Dinosaur dinosaur)
        {
            dinosaur.dinoHealth -= ;
            //robotHealth
        }

        public void RobotAttackPower()
        {
            weapon.attackPower;
        }

        public int RobotGetHealth()
        {
            return robotHealth;
        }

        public void RobotLoseHealth(Dinosaur dino)
        {
            robotHealth -= dino.dinoAttackPower;
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
