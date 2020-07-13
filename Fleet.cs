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

        //constructor (spawner)
        public Fleet()
        {
            robotOne = new Robot("Wall-E", 100, 25);
            robotTwo = new Robot("Ultron", 250, 100);
            robotThree = new Robot("Iron Giant", 200, 75);
        }

        //mem methods (can do)
    }
}
