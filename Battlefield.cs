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
            //List<Robot> robotList = fleet.GetRobotFleet();
            //List<Dinosaur> dinoList = herd.GetHerd();

        }

        //mem methods

        public void DinoAttackRobot()
        {
            Dinosaur attackingDino = herd.ChooseRandomDino();
            Robot defendingRobot = fleet.ChooseRandomRobot();
            attackingDino.AttackRobot(defendingRobot);
            //RobotLoseHealth(defendingRobot);
            //List<Robot> robotList = fleet.GetRobotFleet();
            //List<Dinosaur> dinoList = herd.GetHerd(); 
            // randomly choose 1 robot. if alive continue to next step. if not choose another robot
            // randomly choose 1 dino. if alive continue to next step. if not choose another dino
            // get chosen dino attack number and energy used number
            // get robot health number
            // subtract dino attack number from robot health number. if <or= 0 print robot has died
            // subtract dino energy from energy level. if <or= 0 print dino has died

        }

        public void RobotAttackDino()
        {
            Robot attackingRobot = fleet.ChooseRandomRobot();
            Dinosaur defendingDino = herd.ChooseRandomDino();
            attackingRobot.AttackDino(defendingDino);
            //List<Robot> robotList = fleet.GetRobotFleet();
            //List<Dinosaur> dinoList = herd.GetHerd();


            //Dinosaur dinoOne = herd.GetDinoOne();
            //Robot robotOne = robotList.ElementAt(0);
            //Weapon robotOneSword = robotOne.GetWeapon();
            //int robotOneSwordAttackPower = robotOneSword.GetAttackPower();
            //int dinoOneHealth = dinoOne.GetDinoHealth();
            //Console.WriteLine(dinoOneHealth);
            //dinoOne.DinoLoseHealth(robotOneSwordAttackPower);
            //Console.WriteLine(dinoOne.GetDinoHealth());
            //Console.ReadLine();

        }
    }
}
