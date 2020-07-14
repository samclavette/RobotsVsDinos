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
        List<Robot> robotFleet = new List<Robot>();
        List<Weapon> weaponList = new List<Weapon>();

        //constructor 
        public Fleet()
        {
            Weapon sword = new Weapon("sword", 25, 10);
            Weapon toothbrush = new Weapon("toothbrush", 10, 15);
            Weapon bazooka = new Weapon("bazooka", 50, 40);
            robotOne = new Robot("Wall-E", 100, 25, sword);
            robotTwo = new Robot("Ultron", 250, 100, toothbrush);
            robotThree = new Robot("Iron Giant", 200, 75, bazooka);
            robotFleet.Add(robotOne);
            robotFleet.Add(robotTwo);
            robotFleet.Add(robotThree);
        }

        //mem methods
        public List<Robot> GetRobotFleet()
        {
            return robotFleet;
        }
    }
}
