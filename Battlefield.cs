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
        public void RunBattlefield()
        {
            while (fleet.robotFleet.Count > 0 && herd.dinoHerd.Count > 0) 
            {
                DinoAttackRobot();
                bool robotStatus = CheckForLivingRobot();
                if (robotStatus == true)
                {
                    RobotAttackDino();
                }
            }
            
        }
        public void DinoAttackRobot()
        {
            Dinosaur attackingDino = herd.ChooseRandomDino();
            Robot defendingRobot = fleet.ChooseRandomRobot();
            attackingDino.AttackRobot(defendingRobot);
            //defendingRobot.RobotLoseHealth(attackingDino);
            if (defendingRobot.robotHealth <= 0)
            {
                fleet.robotFleet.Remove(defendingRobot);
                Console.WriteLine(defendingRobot.name + "has died.");
            }
        }

        public void RobotAttackDino()
        {
            Robot attackingRobot = fleet.ChooseRandomRobot();
            Dinosaur defendingDino = herd.ChooseRandomDino();
            attackingRobot.AttackDino(defendingDino);
            //defendingDino.DinoLoseHealth(attackingRobot);
            if (defendingDino.dinoHealth <= 0)
            {
                herd.dinoHerd.Remove(defendingDino);
                Console.WriteLine(defendingDino.type + "has died.");
            }

        }

        public bool CheckForLivingRobot()
        {
            if (fleet.robotFleet.Count == 0)
            {
                Console.WriteLine("Dinos win!");
                return false;
            }
            return true;
        }
    }
}
