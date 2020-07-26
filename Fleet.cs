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
        List<Weapon> weaponList;
    

        //constructor 
        public Fleet()
        {
            Weapon sword = new Weapon("sword", 50, 10);
            Weapon toothbrush = new Weapon("toothbrush", 20, 10);
            Weapon bazooka = new Weapon("bazooka", 75, 10);
            weaponList = new List<Weapon>() { sword, toothbrush, bazooka };
            Weapon randomWeapon = ChooseRandomWeapon();
            robotOne = new Robot("Wall-E", 120, 25, randomWeapon);
            robotTwo = new Robot("Ultron", 225, 100, randomWeapon);
            robotThree = new Robot("Iron Giant", 220, 75, randomWeapon);
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

        public Weapon ChooseRandomWeapon()
        {
            rand = new Random();
            int randomNumber = rand.Next(weaponList.Count);
            return weaponList[randomNumber];
        }
    }
}
