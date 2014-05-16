using System;
using System.Threading;
using System.Linq;
using System.Collections.Generic;


namespace MyGame
{
    class MyGame
    {
        //----------- Initialise a structure of .value for objects to be used or implemented.
        struct Rock
        {
            public int x;                       // we add .x , .y , .sizeOfRock , .symbol , .color
            public int y;                     // to the objects we gonna use in the code for our
            public int sizeOfRock;              // convinience.
            public string symbol;
            public ConsoleColor color;
        }
        //----------- Function that with the input said will draw on the console our rocks.
        static void Draw(int posX, int posY, ConsoleColor color, string str)
        {
            Console.SetCursorPosition(posX, posY);
            Console.ForegroundColor = color;
            Console.Write(str);
        }
        static void Main()
        {
            int chanceToSkipLine = 0;      // will make sure we dont have symbols on every line
            //----------- Initialise the symbols that will represent the falling rocks.
            char[] rocksTypes = 
                {
                    '~', '!', '@', '#', '$',
                    '%', '^', '&', '*', '?',
                    '/', '<', '>', '|'
                };
            //----------- Variables that will be used in main loop for rocks
            int countOfRocks = 0;
            int maxCountOfRocks = 3;
            int maxSizeOfRocks = 3;

            //----------- Set console field, game field and score screen width and height.
            Console.WindowHeight = 40;
            Console.BufferHeight = 40;      // buffers should be equal to the value you want to set
            Console.WindowWidth = 60;       // for more convinience
            Console.BufferWidth = 60;

            //----------- Generate random number to use for random position, color, chance of rocks and size of rocks
            Random randomNumber = new Random();

            //----------- Initialise objects we wanna use
            List<Rock> rocks = new List<Rock>();    // making list of objects all falling rocks on screen will be pushed in
            // it and used in the loop
            Rock temp;        // will contain temp values if needed
            Rock dwarf;       // will represent dwarf
            // will represent current examined rock

            //----------- We make array with different colors so we can change it on every input rock
            ConsoleColor[] color = 
                { 
                    ConsoleColor.Blue, ConsoleColor.White,
                    ConsoleColor.Green, ConsoleColor.Red,
                    ConsoleColor.Cyan, ConsoleColor.Yellow,
                    ConsoleColor.DarkBlue, ConsoleColor.Magenta,
                    ConsoleColor.Gray, ConsoleColor.DarkYellow
                };
            //----------- We start an infinite loop to stard drawing symbols all the time in the console
            while (true)
            {


                //----------- Generate rocks if chance bigger than the one for empty line
                if (randomNumber.Next(0, 100) > chanceToSkipLine)
                {
                    countOfRocks = 1;
                }
                else
                {
                    countOfRocks = 0;
                }

                for (int i = 0; i < 2; i++)
                {
                    Rock rock = new Rock()
                    {
                        color = ConsoleColor.Yellow,
                        x = randomNumber.Next(0, Console.WindowWidth - 20),     // set random position for column
                        y = 5,                                                     // set start position for first row
                        sizeOfRock = randomNumber.Next(1, maxSizeOfRocks + 1),                                         // set size of falling rock
                        symbol = new string(rocksTypes[randomNumber.Next(0, rocksTypes.Length)], 2)     // enter symbol for current generated
                    };

                    rocks.Add(rock);

                }

                List<Rock> updatedRocks = new List<Rock>();
                foreach (var item in rocks)
                {
                    Rock oldRock = item;
                    oldRock.y++;
                    updatedRocks.Add(oldRock);
                    //Todo: console end
                }
                rocks = updatedRocks;

                Console.Clear();

                //----------- Draw falling rocks
                foreach (Rock fallingRock in rocks)
                {
                    Draw(fallingRock.x, fallingRock.y, fallingRock.color, fallingRock.symbol);
                }

                Thread.Sleep(400);
            }

        }
    }
}
