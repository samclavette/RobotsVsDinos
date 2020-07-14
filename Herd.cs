using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinos
{
    class Herd
    {
        //mem variables (has a) 

        Dinosaur dinoOne;
        Dinosaur dinoTwo;
        Dinosaur dinoThree;
        List<Dinosaur> dinoHerd = new List<Dinosaur>();

        //constructor 

        public Herd()
        {
            dinoOne = new Dinosaur("T-Rex", 250, 100, 75);
            dinoTwo = new Dinosaur("Raptor", 100, 25, 20);
            dinoThree = new Dinosaur("Mosasaurus", 200, 75, 50);
            dinoHerd.Add(dinoOne);
            dinoHerd.Add(dinoTwo);
            dinoHerd.Add(dinoThree);
        }

        //meme methods (can do)


        public Dinosaur GetDinoOne()
        {
            return dinoOne;
        }
        public List<Dinosaur> GetHerd()
        {
            return dinoHerd;
        }
    }

}
