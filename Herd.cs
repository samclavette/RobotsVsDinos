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
        public List<Dinosaur> dinoHerd = new List<Dinosaur>();
        Random rand;

        //constructor 

        public Herd()
        {
            dinoOne = new Dinosaur("T-Rex", 250, 100, 75);
            dinoTwo = new Dinosaur("Raptor", 100, 25, 20);
            dinoThree = new Dinosaur("Mosasaurus", 200, 75, 50);
            dinoHerd = GetHerd();
        }

        //meme methods (can do)


        public Dinosaur ChooseRandomDino()
        {
            rand = new Random();
            int randomNumber = rand.Next(dinoHerd.Count);
            return dinoHerd[randomNumber];
        }
        public List<Dinosaur> GetHerd()
        {
            List<Dinosaur> tempDinoList = new List<Dinosaur>();
            tempDinoList.Add(dinoOne);
            tempDinoList.Add(dinoTwo);
            tempDinoList.Add(dinoThree);
            return tempDinoList;
        }
    }

}
