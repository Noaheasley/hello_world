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
            char input = ' ';
            void Choice(string choice1, string choice2)
            {
                char input = ' ';
                while (input != '1' && input != '2')
                {
                    input = Console.ReadKey().KeyChar;
                    if (input == '1')
                    {
                        choice1 = "nothing";
                    }
                    if (input == '2')
                    {
                        choice2 = "still nothing";
                    }
                    else
                    {
                        Console.Clear();
                    }
                }
            }
            
            void PStats(string name, float PHealth, int level, int damage, int magik, string role, int PDefence)
            {
                Console.WriteLine("\nPlayer name:" + name);
                Console.WriteLine("Player health:" + PHealth);
                Console.WriteLine("Player level:" + level);
                Console.WriteLine("Player Dam:" + damage);
                Console.WriteLine("Player mana:" + magik);
                Console.WriteLine("Player role:" + role);
                Console.WriteLine("Player defence:" + PDefence);
                Console.WriteLine("Press any button to continue");
                Console.ReadKey();
            }
            bool gameOver = false;
            while (gameOver != true)
            {
                string choice1 = "nothing";
                string choice2 = "still nothing";
                int PearlFriendship = 50;
                int ScarletFriendship = 0;
                float PHealth = 100.0f;
                //level
                int level = 1;
                float healthRegen = 20;
                //mmmmmmm
                int magik = 1;
                //default ass
                string role = "Nobody";
                //gain health
                PHealth = PHealth + healthRegen;
                //damn age
                int damage = 20;
                //defence
                int PDefence = 20;
                //current enemy
                //intro dialog
                Console.WriteLine("Who are you?");
                string name = Console.ReadLine(); //name

                while (input != '1' && input != '2')
                {
                    Console.WriteLine("What are you? " + name);
                    Console.WriteLine("Press 1. Wizard");
                    Console.WriteLine("Press 2. Warrior");
                    input = Console.ReadKey().KeyChar;
                    if (input == '1')
                    {
                        PDefence = 20;
                        PHealth = 100;
                        damage = 80;
                        role = "wizard";
                        magik = 200;
                    }
                    else if (input == '2')
                    {
                        PDefence = 30;
                        PHealth = 140;
                        damage = 20;
                        role = "warrior";
                    }
                    else
                    {
                        Console.Clear();
                    }
                } 
                //player stats
                PStats(name, PHealth, level, damage, magik, role, PDefence);

                //game starts
                Console.WriteLine("I'll leave you then, you better wake up now.");
                //test//
               
                Console.WriteLine("\nYou wake up in the middle of a forest confused on where you are.");
                Console.WriteLine("An old man notices you and approaches you");
                Console.WriteLine("\nOld fellow: Hello there stranger, why is there a " + role + "in the middle of the forest laying down?");

                //test//
                Console.WriteLine("\nYou wake up in the middle of a forest confused on where you are.");
                Console.WriteLine("An old man notices you and approaches you");
                Console.WriteLine("\nOld fellow: Hello there stranger, why is there a " + role + "in the middle of the forest laying down?");
                input = Console.ReadKey().KeyChar;
                //old man encounter
                while (input != '1' && input != '2' && input != '3')
                {
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
                    //old man fight starts
                    else if (input == '3')
                    {
                        Console.Clear();
                        Console.WriteLine("\nOld fellow: you fool");
                        Console.WriteLine("The old man transforms into a deformed demon");
                        int OMHealth = 100;
                        int OMDamage = 40;
                        while (PHealth >  0 && OMHealth > 0)
                        {
                            Console.WriteLine("Player health:" + PHealth);
                            Console.WriteLine("Player level:" + level);
                            Console.WriteLine("Player Dam:" + damage);
                            Console.WriteLine("Player mana:" + magik);
                            Console.WriteLine("Player defence:" + PDefence);

                            Console.WriteLine("\npress 1: to attack");
                            Console.WriteLine("press 2: to block");
                            input = Console.ReadKey().KeyChar;
                            if (input == '1')
                            {
                                input = Console.ReadKey().KeyChar;
                                OMHealth -= damage;
                                Console.WriteLine("The old man has recieved: " + damage);
                                Console.WriteLine("The old man's health: " + OMHealth);
                                Console.WriteLine("Press any key to continue");
                                Console.ReadKey();

                                Console.WriteLine("the old man slashes at you with his large talons");
                                OMDamage -= PDefence; 
                                PHealth -= OMDamage;

                                Console.WriteLine("you've taken: " + OMDamage );
                                Console.WriteLine("your health: " + PHealth);
                                OMDamage += PDefence;

                                Console.WriteLine("Press any key to continue");
                                Console.ReadKey();
                                continue;

                            }
                            else if(input == '2')
                            {
                                input = Console.ReadKey().KeyChar;
                                Console.WriteLine("you start blocking for 20 Defence points");
                                PDefence += 20;
                                Console.WriteLine("the old man slashes at you with his large talons");
                                OMDamage -= PDefence;
                                PHealth -= OMDamage;

                                Console.WriteLine("you've taken: " + OMDamage);
                                Console.WriteLine("your health: " + PHealth);
                                PDefence -= 20;
                                OMDamage += PDefence;

                                Console.WriteLine("Press any key to continue");
                                Console.ReadKey();
                            }

                        }
                    }
                    else
                    {
                        Console.Clear();
                    }
                }
                if (PHealth == 0)
                {
                    Console.WriteLine("\nYou Lose");
                    Console.WriteLine("Press any key to restart");

                    Console.ReadKey();
                    gameOver = false;
                    continue;
                }
                //after the old man encounter
                input = Console.ReadKey().KeyChar;
                while (input != '1' && input != '2')
                {
                    Console.WriteLine("After the encounter with the old man you take a look at the surroundings");
                    Console.WriteLine("You look around and notice two paths.");
                    Console.WriteLine("Press 1: enter the path shaded by overgrown trees and vines.");
                    Console.WriteLine("Press 2: walk into an open medow.");
                    input = Console.ReadKey().KeyChar;
                    //pearl sidestory starts
                    if (input == '1')
                    {
                        Console.WriteLine("\nYou walk down the dark path and you feel a sense of fear surronding you as you walk deeper in");
                        Console.WriteLine("you hear a woman weeping, and find a girl dressed in a maids outfit with large claws covered in a rock like material");
                        Console.WriteLine("she notices you and turns her head to face you. you notice a slight green glow emmiting from the palms of her claws");
                        Console.WriteLine("Press enter to continue");
                        input = Console.ReadKey().KeyChar;
                        while (input != '1' && input != '2')
                        {
                            Console.WriteLine("woman: who are you?");
                            Console.WriteLine("Press 1: my name is " + name + " what's wrong?");
                            Console.WriteLine("Press 2: none of your business freak");
                            input = Console.ReadKey().KeyChar;
                            if (input == '1')
                            {
                                Console.WriteLine("Woman: oh... that's a wonderful name, my name is Pearl. I was hoping to find something but I got lost in these woods and I got scared.");
                                Console.WriteLine(name + ": and what would that be?");

                            }
                            //alt Scarlet story start
                            else if(input == '2')
                            {
                                Console.WriteLine("\nthe woman starts weeping again");
                                Console.WriteLine("Woman: you humans are so rude!");
                                Console.WriteLine("the woman get's up and runs off deeper in the woods, as you stand there you get hit with an arrow and ge4t knocked out");

                                PearlFriendship -= 50;
                            }
                            else
                            {
                                Console.Clear();
                            }
                        }
                        
                    }
                    //Scarlet's side story starts
                    else if (input == '2')
                    {
                        Console.WriteLine("\nYou walk down a sweet and pleasent medow just to get hit in the shoulder by an arrow causing you to stumble around until you fell unconcious");
                        Console.ReadKey();

                        Console.WriteLine("you wake up in a bed inside a dimly lit room. You look around and you see a woman in the corner sharpening her knife. She looks at you and flinches when she notices you're looking at her");
                        while (input != '1' && input != '2')
                        {
                            Console.WriteLine("Woman: so you finally decided to wake up from your little nap");
                            Console.WriteLine("Press 1: where am I?");
                            Console.WriteLine("Press 2: release me at once!");
                            if(input == '1')
                            {
                                Console.WriteLine("that's none of your concern right now");
                                Console.WriteLine("Press an button to continue");
                                Console.ReadKey();
                            }
                            else if (input == '2')
                            {
                                Console.WriteLine("that's none of your concern right now");
                                Console.WriteLine("Press an button to continue");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Clear();
                            }
                        }

                        Console.WriteLine("Woman: anyways thats not important for now, what is important is the fact that you were in the forbidden forrest");

                         while (input != '1' && input != '2')
                         {

                         }
                    }
                    else
                    {
                        Console.Clear();
                    }
                }

                Console.Clear();
                Console.WriteLine("you and Pearl walk up to a strange temple with walls covered in moss and vines.");
                Console.WriteLine("Pearl: we must be carefull in here, I've heard there were traps within these walls but this is the place in which i could possibly gain the power to make my dolls");
                Console.WriteLine("You two approach a locked door that has 6 glowing orbs surrounding it");
                Console.WriteLine("Pearl: try to choose an orb on the door but be carful it might have traps");
                for (int i = 0; i < 5; i++)
                {
                    Console.Clear();
                    if (i == 4)
                    {
                        Console.WriteLine("Pearl gets nervous");
                        Console.WriteLine(name + " please be careful I think the door might break, try the bottom left");
                    }
                    Console.WriteLine("you have " + (5 - i) + " tries");
                    Console.WriteLine("Press 1: for the bottom left");
                    Console.WriteLine("Press 2: for to the middle left");
                    Console.WriteLine("Press 3: for the top left");
                    Console.WriteLine("Press 4: for the bottom right");
                    Console.WriteLine("Press 5: for the middle right");
                    Console.WriteLine("Press 6: for the top right");
                    input = Console.ReadKey().KeyChar;
                    if (input == '1')
                    {
                        Console.WriteLine("the door creaks open");
                    }
                    else
                    {
                        Console.WriteLine("the inner mechanizms of the door start moving around");
                    }
                }
                Console.ReadKey();
            }
        }
    }
}