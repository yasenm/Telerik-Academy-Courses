using System;
using System.Threading;
using System.Linq;
using System.Collections.Generic;
using System.Timers;
using System.Diagnostics;

//

namespace MyGame
{
    class MyGame
    {
        //----------- Initialise a structure of .value for objects to be used or implemented.
        struct Object
        {
            public int x;                       // we add .x , .y , .sizeOfRock , .symbol , .color
            public int y;                       // to the objects we gonna use in the code for our
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
            int score = 0;
            string overalTime = "";
            string dwarfBody = "(0)";       // seting dwarfs body
            int chanceToSkipLine = 30;      // will make sure we dont have symbols on every line
            bool endGameTrigger = false;
            //----------- Initialise the symbols that will represent the falling rocks.
            char[] rocksTypes = 
                {
                    '~', '!', '@', '#', '$',
                    '%', '^', '&', '*', '?',
                    '/', '<', '>', '|'
                };
            //----------- Variables that will be used in main loop for rocks
            int countOfRocks = 0;
            //int maxCountOfRocks = 3;
            int maxSizeOfRocks = 3;

            //----------- Set console field, game field and score screen width and height.
            Console.WindowHeight = 25;
            Console.BufferHeight = 25;      // buffers should be equal to the value you want to set
            Console.WindowWidth = 80;       // for more convinience
            Console.BufferWidth = 80;

            //----------- Generate random number to use for random position, color, chance of rocks and size of rocks
            Random randomNumber = new Random();

            //----------- Initialise objects we wanna use
            List<Object> rocks = new List<Object>();    // making list of objects all falling rocks on screen will be pushed in
            // it and used in the loop
            //Object temp;              // will contain temp values if needed
            Object dwarf;               // will represent dwarf

            //Positioning the dwarf in the window
            dwarf.x = 20;
            dwarf.y = Console.WindowHeight - 1;
            dwarf.sizeOfRock = 2;
            dwarf.symbol = dwarfBody;
            dwarf.color = ConsoleColor.Gray;

            //----------- We make array with different colors so we can change it on every input rock
            ConsoleColor[] color = 
                { 
                    ConsoleColor.Blue, ConsoleColor.White,
                    ConsoleColor.Green, ConsoleColor.Red,
                    ConsoleColor.Cyan, ConsoleColor.Yellow,
                    ConsoleColor.DarkBlue, ConsoleColor.Magenta,
                    ConsoleColor.Gray, ConsoleColor.DarkYellow
                };

            //----------- Game timer
            Stopwatch gameTimer = new Stopwatch();
            gameTimer.Start();
            //----------- We start an infinite loop to start drawing symbols all the time in the console
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
                for (int i = 0; i < countOfRocks; i++)
                {
                    // creates Object rock with current position row and column
                    Object rock = new Object()
                    {
                        x = randomNumber.Next(2, Console.WindowWidth - 40),         // set random position for column
                        y = 0,                                                      // set start position for first row
                        sizeOfRock = randomNumber.Next(1, maxSizeOfRocks + 1),                                         // set size of falling rock
                        symbol = new string(rocksTypes[randomNumber.Next(0, rocksTypes.Length)], 2),     // enter symbol for current generated
                        color = color[randomNumber.Next(0, color.Length)],                                              // set random color
                    };
                    rocks.Add(rock);
                }
                //------------ Dwarf movement module
                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyUsed = Console.ReadKey(true);     // indicates if there is a used key
                    if (keyUsed.Key == ConsoleKey.LeftArrow)            // if LeftArrow key is pressed move left
                    {
                        if (dwarf.x > 2)
                        {
                            dwarf.x--;
                        }
                    }
                    if (keyUsed.Key == ConsoleKey.RightArrow)           // if RightArrow key is pressed move right
                    {
                        if (dwarf.x <= 40)
                        {
                            dwarf.x++;
                        }
                    }
                }
                //----------- Making new List<> with new positions ( 1 row down ) and after that 
                //----------- rocks gets the new positions after clearing we see the movement
                List<Object> updatedRocks = new List<Object>();
                foreach (var item in rocks)
                {
                    Object oldRock = item;
                    oldRock.y++;
                    //------------ Check if there is hit from rock to the dwarf, if so break game and print score
                    if (dwarf.x == oldRock.x && dwarf.y == oldRock.y)
                    {
                        endGameTrigger = true;
                        dwarf.symbol = "HIT!!!";
                        dwarf.color = ConsoleColor.DarkRed;
                    }
                    if (oldRock.y >= Console.WindowHeight)
                    {
                        continue;
                    }
                    updatedRocks.Add(oldRock);
                    //Todo: console end
                }
                rocks = updatedRocks;

                string time = string.Format("Time : {0}:{1} ", gameTimer.Elapsed.Minutes, gameTimer.Elapsed.Seconds);
                overalTime = time;

                score++;            // update score
                Console.Clear();    // clear console and then drow updated content of game

                //----------- Draw falling rocks
                foreach (Object fallingRock in rocks)
                {
                    Draw(fallingRock.x, fallingRock.y, fallingRock.color, fallingRock.symbol);
                    Draw(dwarf.x, dwarf.y, dwarf.color, dwarf.symbol);
                }
                //----------- Draw a line that will separate the score screen from the play screen
                for (int i = 0; i < Console.WindowHeight; i++)
                {
                    Draw(40, i, ConsoleColor.DarkGray, "||");
                    Draw(0, i, ConsoleColor.DarkGray, "||");
                }
                Draw(57, 5, ConsoleColor.Yellow, "Score : " + score);
                Draw(57, 7, ConsoleColor.Yellow, time);

                //------------ If we triggerd the game to end break loop
                if (endGameTrigger == true)
                {
                    break;
                }
                //------------ Controling the pace of the game
                Thread.Sleep(400);
            }
            Console.Clear();

            Draw(22, 7, ConsoleColor.Red, "Your score is : " + score);
            Draw(22, 9, ConsoleColor.Red, "Thank you for Playing!");
            Draw(22, 11, ConsoleColor.Red, "If you liked it start a new game!");
            Draw(22, 13, ConsoleColor.Red, "Your time was : " + overalTime);
            Draw(22, 15, ConsoleColor.Red, "GL & HF");
            Console.ReadLine();
        }
    }
}
