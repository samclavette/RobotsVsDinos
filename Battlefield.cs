using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinos
{
    class Battlefield
    {
        //mem variables

        Fleet fleet;
        Herd herd;

        // constructor

        public Battlefield()
        {
            fleet = new Fleet();
            herd = new Herd();
        }

        //mem methods

        public void DinoAttackRobot()
        {
            //List<Dinosaur> dinoList = herd.GetHerd();
        }

        public void RobotAttackDino()
        {
            List<Robot> robotList = fleet.GetRobotFleet();
            Dinosaur dinoOne = herd.GetDinoOne();
            Robot robotOne = robotList.ElementAt(0);
            Weapon robotOneSword = robotOne.GetWeapon();
            int robotOneSwordAttackPower = robotOneSword.GetAttackPower();
            int dinoOneHealth = dinoOne.GetDinoHealth();
            Console.WriteLine(dinoOneHealth);
            dinoOne.DinoLoseHealth(robotOneSwordAttackPower);
            Console.WriteLine(dinoOne.GetDinoHealth());
            Console.ReadLine();

        }
    }
}
