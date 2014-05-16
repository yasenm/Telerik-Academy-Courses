using System;
using System.Threading;
using System.Linq;
using System.Collections.Generic;
 
class Exercise11FallingRocks
{
    public struct Object // with this struct make objects
    {
        public int x;
        public int y;
        public int rockSize;
        public string symbols;
        public ConsoleColor color;
    }
    static void Draw(int x, int y, ConsoleColor color, string str) // with this method draw in console
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(str);
    }
    static void Main()
    {
        //----Variables----- variables with * can changing, variables with ! can changing but game may be throw exeption or infinity loop.
        int sleepTime = 300;          //* base slowing game variable - in miliseconds
        int lives = 10;               //* base number of lives
        double accelerate = 0.1;      //* base acceleration of game speed per game cycle
        int chanceOfEmptyLyne = 70;   //* chance in percent to draw empty line (no rocks on the line)
        char[] rockSymbols =          //* base massive of symbols for representing rocks
            {
                '^', '@', '*', '&',
                '+', '%', '$', '#',
                '!', '.', ';',
            };
        ConsoleColor[] color =        //* base massive of colors for representing colors of rocks
            {
                ConsoleColor.Blue, ConsoleColor.Cyan,
                ConsoleColor.Gray, ConsoleColor.Green,
                ConsoleColor.Magenta, ConsoleColor.Red,
            };
        string dwarfString = "(O)";   //*! string representing dwarf (must be 3 symbols long to avoid exeptions)  
        int biggestRockSize = 4;      // ! max allowed characters to create rock
        int maxNumberOfRocks = 4;     // ! max allowed rocks in one line
       
        int score = 0;                //This is system variables
        int numberOfRocks = 0;
        int testLives = 0;
        int tempX = 0;
        int tempDwarfX = 0;
        double speed = 0;
        bool collision = false;       // Variable to check collisions
        bool isRock = false;
        
        Random randomNumber = new Random(); // Generate random numbers
        List<Object> rocks = new List<Object>();  // List with objects to draw
        Object temp;                  // make temporary object
        Object dwarf;                 // make dwarf object
        Object rock;                  // make rock object
 
        //-----Prepare console-----
        Console.BufferWidth = Console.WindowWidth = 60;    // make windows bufer equal of windows size
        Console.BufferHeight = Console.WindowHeight = 30;  // *! these two parameters can be modified (try increase them , not decrease, to avoid exeption)
 
        //-----Make and positioning dwarf-----    
        dwarf.x = ((Console.WindowWidth - 20) / 2) - 1;
        dwarf.y = Console.WindowHeight - 1;
        dwarf.symbols = dwarfString;
        dwarf.color = ConsoleColor.Yellow;
        while (true)
        {
            isRock = false;
            collision = false;
        //-----Calculate rock positions (make objects falling)-----
            for (int i = 0; i < rocks.Count; i++)   // calculate new y coordinates
            {
                temp = rocks[i];
                temp.y = temp.y + 1;
                if (temp.y >= Console.WindowHeight) // if rock is outside of game field...
                {
                    score = score + temp.rockSize;  // calculate score by rock size
                    rocks.RemoveAt(i);              // remove rock from list
                    i--;                            // return count with one to avoid miss next element in list after removing of current
                }
                else                                // if new y coordinate is in game field...
                {
                    rocks[i] = temp;                // update list of objects
                }
            }
        //-----Generate rocks-----
            if (randomNumber.Next (0, 100) > chanceOfEmptyLyne) // Generate number of rocks on line or make empty line
            {
                numberOfRocks = randomNumber.Next(1, maxNumberOfRocks + 1);
            }
            else
            {
                numberOfRocks = 0;
            }
            for (int i = 1; i <= numberOfRocks; i++)     // Generate object rock and add in list of objects
            {
                rock.y = 0;
                rock.x = randomNumber.Next(0, Console.WindowWidth - 20);
                rock.rockSize = randomNumber.Next(1, biggestRockSize + 1);
                int test = 1;
                while (test != 0)                // make check to avoid generating object over another object - and make distance 3 between two objects
                {
                    test = 0;
                    rock.x = randomNumber.Next(0, Console.WindowWidth - 20);
                    foreach (Object check in rocks)
                    {
                        if ((check.y == 0 && !(check.x > rock.x + rock.rockSize + 3 || check.x + check.rockSize + 3 < rock.x)))
                        {
                            test++;
                        }
                    }
                }
                if (rock.x + rock.rockSize >= Console.WindowWidth - 20)   // make size of rock smaller to avoid draw outside of the game field
                {
                    rock.rockSize += ((Console.WindowWidth - 21) - (rock.x + rock.rockSize));
                }
                rock.color = color[randomNumber.Next(0, color.Length)];  // random color...
                rock.symbols = new string(rockSymbols[randomNumber.Next(0, rockSymbols.Length)], rock.rockSize); // random size and symbol...
                rocks.Add(rock);
            }  
        //-----Controls of the game and calculate dwarf position-----
            while (Console.KeyAvailable)   // check for pressed key
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true); // take pressed key
                if (pressedKey.Key == ConsoleKey.LeftArrow)        // calculate new position by type of pressed key
                {
                    if (dwarf.x > 0)
                    {
                        dwarf.x--;
                    }
                }

                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (dwarf.x < Console.WindowWidth - 24)
                    {
                        dwarf.x++;
                    }
                }
            }
         //-----Redraw game field-----
            Console.Clear(); // clear temporary variables and console
            testLives = 0;
            foreach (Object rockElement in rocks) // draw list of objects (rocks)
            {
                Draw(rockElement.x, rockElement.y, rockElement.color, rockElement.symbols);
                for (int i = 1; i <= rockElement.rockSize; i++) // Check for collision (check must be perform for all 3 coord of dwarf and for all coord of rock)
                {
                    for (int a = 1; a <= 3; a++)               // Here start check dwarf coord
                    {
                        tempX = rockElement.x + i;
                        tempDwarfX = dwarf.x + a;
                        if (rockElement.y == dwarf.y && tempX == tempDwarfX) // Check for collision
                        {
                            collision = true;
                            isRock = true;
                            while (testLives == 0 && isRock) // Calculate lives - if collision is with rock
                            {
                                lives -= rockElement.rockSize;
                                testLives++;
                            }
                        }
                    }
                }
            }
            if (collision && isRock) // draw dwarf - if we have collision with rock draw BAM ;)
            {
                Draw(dwarf.x, dwarf.y, ConsoleColor.Red, "BAM");
            }
            else
            {
                Draw(dwarf.x, dwarf.y, dwarf.color, dwarf.symbols);
            }
            //------Redraw information window-----
            Draw(41, 2, ConsoleColor.DarkMagenta, "Falling Rocks");
            Draw(41, 3, ConsoleColor.DarkMagenta, "by Stoyanov Games");
            Draw(41, 6, ConsoleColor.White, "Lives: " + lives);   // draw lives
            Draw(41, 8, ConsoleColor.White, "Speed: " + (int)speed); // draw speed
            Draw(41, 10, ConsoleColor.White, "Score: " + score); // draw score
            for (int i = 0; i < Console.WindowHeight; i++)  // Make line to separate information window from game field
            {
                Draw(39, i, ConsoleColor.White, "\u2502");
            }
            //-----Slowing program-----
            Thread.Sleep(sleepTime - (int)speed);
            //-----Calculate speed, check lives  and etc-----
            if (lives <= 0)            // Check for game end and update information window if game end
            {
                Draw(41, 13, ConsoleColor.Red, "!!! GAME OVER !!!");
                Draw(41, 15, ConsoleColor.Red, "press enter");
                Draw(41, 16, ConsoleColor.Red, "for new game");
                Draw(41, 17, ConsoleColor.Red, "or any other");
                Draw(41, 18, ConsoleColor.Red, "key to exit:");
                ConsoleKeyInfo choice = Console.ReadKey(true);
                if (choice.Key == ConsoleKey.Enter)
                {
                    Main();
                }
                return;
            }
            if (speed < 250)          // Accelerate speed ;)
            {
                speed += accelerate;
            }
            if (isRock && collision) // If we have collision - clear list with rocks
            {
                rocks.Clear();
            }
        }
    }
}