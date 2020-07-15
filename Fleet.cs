using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinos
{
    class Fleet
    {
        //mem variables

        Robot robotOne;
        Robot robotTwo;
        Robot robotThree;
        public List<Robot> robotFleet;
        Random rand;
        List<Weapon> weaponList = new List<Weapon>();
    

        //constructor 
        public Fleet()
        {
            Weapon sword = new Weapon("sword", 25, 10);
            Weapon toothbrush = new Weapon("toothbrush", 10, 10);
            Weapon bazooka = new Weapon("bazooka", 50, 10);
            robotOne = new Robot("Wall-E", 100, 25, sword);
            robotTwo = new Robot("Ultron", 250, 100, toothbrush);
            robotThree = new Robot("Iron Giant", 200, 75, bazooka);
            //rand = new Random();
            robotFleet = GetRobotFleet();
        }

        //mem methods
        public List<Robot> GetRobotFleet()
        {
            List<Robot> tempRobotFleet = new List<Robot>();
            tempRobotFleet.Add(robotOne);
            tempRobotFleet.Add(robotTwo);
            tempRobotFleet.Add(robotThree);
            return tempRobotFleet;
        }

        public Robot ChooseRandomRobot()
        {
              rand = new Random();
              int randomNumber = rand.Next(robotFleet.Count);
              return robotFleet[randomNumber];
        }
    }
}
