using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        public void Run()
        {
            int maxLevel = 100;
            int level = maxLevel;
            maxLevel = 120;
            string name = Console.ReadLine();
            float health = 100.0f;
            float healthRegen = 20;
            bool ready = false;
            health = health + healthRegen;
            Console.WriteLine(name + " you live :D " + healthRegen);
        }
    }
}
