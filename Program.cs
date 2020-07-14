using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinos
{
    class Program
    {
        static void Main(string[] args)
        {
            Battlefield battlefield = new Battlefield();
            Robot bitch = new Robot("Bitch", 50, 50);
            Console.WriteLine(bitch.getName());
            bitch.SetName("Cocksmith");
            Console.WriteLine(bitch.getName());
            Console.ReadLine();
        }
    }
}
