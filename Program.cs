using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new instance of a Game
            Game game = new Game();
            //Run the Game
            game.Run();
            //Wait before closing
            Console.ReadKey();
        }

    }
}