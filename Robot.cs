﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinos
{
    class Robot
    {
        // mem variables (has a)
        string name;
        int robotHealth;
        int robotPowerLevel;
        bool isAlive;
        public Weapon weapon;

        // constructor (spawner)

        public Robot(string name, int robotHealth, int robotPowerLevel)
        {
            this.name = name;
            this.robotHealth = robotHealth;
            this.robotPowerLevel = robotPowerLevel;
            this.isAlive = true;
        }

        //mem methods (can do)

    }
}