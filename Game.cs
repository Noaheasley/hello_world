using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        public void Run()
        { 
            //health
            float health = 100.0f;
            //level
            int level = 1;
            float healthRegen = 20;
            //mmmmmmm
            int magik = 1;
            //default ass
            string role = "Nobody";
            //gain health
            health = health + healthRegen;
            //damn age
            int damage = 20;
            //stuff
            Console.WriteLine("Who are you?");
            string name = Console.ReadLine(); //name
            //roles
            Console.WriteLine("What are you?" + name);
            Console.WriteLine("Press 1. Wizard");
            Console.WriteLine("Press 2. Warrior");
            char input = Console.ReadKey().KeyChar;
            if (input == '1')
            {
                health = 20;
                damage = 40;
                role = "wizard";
                magik = 200;
            }
            else if (input == '2')
            {
                health = 80;
                damage = 20;
                role = "warrior";
            }
            else
            {
                Console.WriteLine("I see... so you're a nobody");
            }

            Console.WriteLine("\nPlayer name:" + name);
            Console.WriteLine("Player health:" + health);
            Console.WriteLine("Player level:" + level);
            Console.WriteLine("Player Dam:" + damage);
            Console.WriteLine("Player banana:" + magik);
            Console.WriteLine("Player role:" + role);
            Console.WriteLine("Press any button to start");
            Console.ReadKey();

            Console.WriteLine("I'll leave you then, you better wake up now.");

            Console.WriteLine("\nYou wake up in the middle of a forest confused on where you are.");
            Console.WriteLine("An old man notices you and approaches you");
            Console.WriteLine("\nOld fellow: Hello there stranger, why is there a " + role + "in the middle of the forest laying down?");
            Console.WriteLine("\nPress 1. I'm unsure");
            Console.WriteLine("Press 2. Beat it old man");
            Console.WriteLine("Press 3. kill him");

            input = Console.ReadKey().KeyChar;
            if (input == '1')
            {
                Console.WriteLine("\nOld Fellow: Interesting well I'll be on my way to my cottage");
            }
            else if (input == '2')
            {
                Console.WriteLine("\nOld Fellow: hmph ungrateful bastard");
            }
            else if (input == '3')
            {
                Console.WriteLine("\nOld fellow: BLARG");
                Console.WriteLine("The old man dies as you smack him in the face with a rock that was next to you");
                Console.WriteLine("you've gained 1 exp!");
                level += 1;
                Console.WriteLine("level: " + level);
            }
            else
            {
                Console.WriteLine("Old fellow: I see, not much of a talker are ya?");
            }

            Console.WriteLine("After the encounter with the old man you take a look at the surroundings");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You look around and notice two paths.");
            Console.WriteLine("Press 1: enter the path shaded by overgrown trees and vines.");
            Console.WriteLine("Press 2: walk into an open medow.");
            input = Console.ReadKey().KeyChar;
            if (input == '1')
            {
                Console.WriteLine("\nYou walk down the dark path and you feel a sense of fear surronding you as you walk deeper in");
                Console.WriteLine("you hear a woman weeping, what will you do?");
                Console.WriteLine("Press 1: ignore it");
                Console.WriteLine("Press 2: check out the noise");
                input = Console.ReadKey().KeyChar;
                if (input == '1')
                {
                    Console.WriteLine("\nyou're walking");
                }
                else if(input == '2')
                {
                    Console.WriteLine("\nYou walk to the source of the weeping and find a girl dressed in a maids outfit with large claws covered in a rock like material");
                    Console.WriteLine("she notices you and turns her head to face you. you notice a slight green glow emmiting from the palms of her claws");
                }
            }
            else if (input == '2')
            {
                Console.WriteLine("\nYou walk down a sweet and pleasent medow just to get hit in the shoulder by an arrow causing you to stumble around until you fell unconcious");
            }
            else
            {
                Console.WriteLine("\nwhy");
            }
            Console.ReadKey();
        }
    }
}
