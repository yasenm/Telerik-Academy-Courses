using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Media;
using System.Diagnostics;

namespace GameSnakeFromLecture
{
    //structure that will hold two parameters columns and rows
    struct Position
    {
        public int Row;
        public int Col;
        public Position(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }
    }

    class SnakeGame
    {
        //method that will print the snakeElements
        static void PrintSnake(IEnumerable snakeElements)
        {
            int counter = 0;
            foreach (Position position in snakeElements)
            {
                if (counter == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                counter++;
                Console.SetCursorPosition(position.Col, position.Row);
                Console.Write("*");
            }
        }

        //method that will print the apples food
        static void PrintApples(Position apple) 
        {
            Console.SetCursorPosition(apple.Col, apple.Row);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("@");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        //Function that with the input said will draw on the console our rocks.
        static void Draw(int posX, int posY, ConsoleColor color, string str)
        {
            Console.SetCursorPosition(posX, posY);
            Console.ForegroundColor = color;
            Console.Write(str);
        }

        //printing images and logos on console depending on the gamestate we are at
        static void PrintingLogoSnake(string gameState) 
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();

            //----------- ImagePrinting algo dont know how it works actualy
            Image picture = Image.FromFile(gameState);
            Console.SetBufferSize((picture.Width * 0x2), (picture.Height * 0x2));
            FrameDimension dimension = new FrameDimension(picture.FrameDimensionsList[0x0]);
            int FrameCount = picture.GetFrameCount(dimension);
            int left = Console.WindowLeft, top = Console.WindowTop;
            char[] chars = { '#', '#', '@', '%', '=', '+', '*', ':', '-', '.', ' ' };
            picture.SelectActiveFrame(dimension, 0x0);
            for (int i = 0x0; i < picture.Height; i++)
            {
                for (int x = 0x0; x < picture.Width; x++)
                {
                    Color color = ((Bitmap)picture).GetPixel(x, i);
                    int black = (color.R + color.G + color.B) / 0x3;
                    int index = (black * (chars.Length - 0x1)) / 0xFF;
                    Console.Write(chars[index]);
                }
                Console.Write('\n');
            }
            Console.SetCursorPosition(left, top);
            Console.Read();

        }

        //saving score and sorting the best ones from which onely the top 5 or 10 will be printed
        static void SaveScoreInResultFile(int score, string timer, string userInfo)
        {
            List<string> resultsList = new List<string>();
            //get all the other users top scores till the 15th so if its lower than the oters wont be in the high scores
            using (StreamReader sr = new StreamReader("scores.txt"))
            {
                int lineNumber = 1;
                string line = sr.ReadLine();
                while (line != null && lineNumber < 15)
                {
                    resultsList.Add(line);
                    line = sr.ReadLine();
                    lineNumber++;
                }
            }
            resultsList.Add(score.ToString().PadLeft(8,'0') + " - score; " + timer + " - record time; " + userInfo + " - user info.");
            //sort all the scores from lowest to highest
            resultsList.Sort();
            //then reverse it so the top scores are at the first lines
            resultsList.Reverse();
            using (StreamWriter sw = new StreamWriter("scores.txt"))
            {
                for (int i = 0; i < resultsList.Count; i++)
                {
                    sw.WriteLine(resultsList[i]);
                }
            }
        }

        static void Main()
        {
            //enter user nick for the high scores
            Draw(20, 15, ConsoleColor.DarkRed, "Enter your user name the SNAKE GAME!!!");
            Console.SetCursorPosition(20, 18);
            Console.Write("Write your user down : ");
            string userInfo = Console.ReadLine();

            Console.Clear();
            //----------- Set console field, game field and score screen width and height.
            Console.WindowHeight = 46;
            Console.BufferHeight = 46;          // buffers should be equal to the value you want to set
            Console.WindowWidth = 100;          // for more convinience
            Console.BufferWidth = 100;

            //score int that will hold our score
            int score = 0;
            //int that will hold player lives and life upper coeficient
            int playerLives = 5;
            int upALifeBorder = 3000;
            //string that will be printed as a current time
            string overalTime = string.Empty;
            //variable that will up the speed og game as game progresses
            int speedEnchancer = 0;
            int gameSpeed = 100;

            // Create new SoundPlayer in the using statement.
            using (SoundPlayer player = new SoundPlayer(@"music/09-A place for my head.wav"))
            {
                // Use PlaySync to load and then play the sound.
                // ... The program will pause until the sound is complete.
                player.Play();
            }

            string startGame = @"picture/SnakeHelloScreen.jpg";

            Console.ForegroundColor = ConsoleColor.Black;
            PrintingLogoSnake(startGame);
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            //Draw a line that will separate the score screen from the play screen basicaly a Frame
            for (int i = 0; i < 45; i++)
            {
                Draw(60, i, ConsoleColor.DarkGreen, "||");
                Draw(0, i, ConsoleColor.DarkGreen, "||");
            }
            for (int i = 1; i < 60; i += 2)
            {
                Draw(i, 0, ConsoleColor.DarkGreen, "<>");
                Draw(i, 45, ConsoleColor.DarkGreen, "<>");
            }
            Console.ForegroundColor = ConsoleColor.Gray;

            Position[] directions = new Position[]
                {
                    new Position(0,1),      //right
                    new Position(0,-1),     //left
                    new Position(1,0),      //down
                    new Position(-1,0),     //up
                };

            int direction = 0;      //will hold which way our snake is going to move

            Random randomNumbersGenerator = new Random();
            Position apple = new Position(randomNumbersGenerator.Next(3, 43),randomNumbersGenerator.Next(2, 58));

            //new snake made
            Queue<Position> snakeElements = new Queue<Position>();
            for (int i = 2; i <= 7; i++)
            {
                snakeElements.Enqueue(new Position(1, i));
            }
            
            //----------- Game timer
            Stopwatch gameTimer = new Stopwatch();
            gameTimer.Start();

            PrintSnake(snakeElements);

            while (true)
            {
                //actualizing the speed enchancer
                speedEnchancer++;
                //actualizing the speed of game if the enchancer reaches sertain level
                if (speedEnchancer == 1500)
                {
                    gameSpeed--;
                    speedEnchancer = 0;
                }
                //updating lives if the player has reached 3000 points
                if (score >= upALifeBorder)
                {
                    playerLives += 1;
                    upALifeBorder += 3000;
                }

                //controls for the movement of the snake
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo userInput = Console.ReadKey();
                    if (userInput.Key == ConsoleKey.LeftArrow)
                    {
                        direction = 1;
                    }
                    if (userInput.Key == ConsoleKey.RightArrow)
                    {
                        direction = 0;
                    }
                    if (userInput.Key == ConsoleKey.UpArrow)
                    {
                        direction = 3;
                    }
                    if (userInput.Key == ConsoleKey.DownArrow)
                    {
                        direction = 2;
                    }
                }

                Position snakeHead = snakeElements.Last();
                Position nextDirection = directions[direction];
                Position snakeNewHeadPos = new Position(snakeHead.Row + nextDirection.Row, snakeHead.Col + nextDirection.Col);

                //if we end up in a wall the game ends or takes 1 of our lifes
                //collusion with wall only still.... i'm thinking of figuring out with snake body , taking life and restarting from begining
                if (snakeNewHeadPos.Col < 2 || snakeNewHeadPos.Row < 1 || snakeNewHeadPos.Col > 59 || snakeNewHeadPos.Row > 44)
                {
                    Console.Clear();
                    Draw(40,20,ConsoleColor.DarkRed,"Your score is : " + score);
                    SaveScoreInResultFile(score, overalTime,userInfo);

                    string endGame = @"picture/GameOver.jpg";
                    ConsoleKeyInfo endKey = Console.ReadKey();
                    if (endKey.Key == ConsoleKey.Enter)
                    {
                        // TODO: draw the score of player Draw();
                    }
                    Console.Clear();
                    PrintingLogoSnake(endGame);
                    return;
                }
                snakeElements.Enqueue(snakeNewHeadPos);
                PrintSnake(snakeElements);
                //deleting old score from console
                Draw(80, 20, ConsoleColor.Black, String.Format("|{0,8}|", score.ToString().PadLeft(8, '0')));
                //deleting old number of lifes from console
                Draw(78, 20, ConsoleColor.Black, String.Format("|{0,3}|", playerLives.ToString().PadLeft(3, '0')));
                //deleting old timer from console
                Draw(78, 20, ConsoleColor.Black, overalTime);
                //deleting old speed from console
                Draw(79, 29, ConsoleColor.Black, String.Format("|{0,3}|", gameSpeed.ToString().PadLeft(3, '0')));

                //time variable that will be printed
                string time = string.Format("|{0,2}:{1,2}:{2,3}|", gameTimer.Elapsed.Minutes.ToString().PadLeft(2, '0'), gameTimer.Elapsed.Seconds.ToString().PadLeft(2, '0'),gameTimer.Elapsed.Milliseconds.ToString().PadLeft(3,'0'));
                overalTime = time;

                //if snake eats apple
                if (snakeNewHeadPos.Col == apple.Col && snakeNewHeadPos.Row == apple.Row)
                {
                    apple = new Position(randomNumbersGenerator.Next(3, 44), randomNumbersGenerator.Next(2, 59));
                    score += 100;
                    // TODO:
                }
                else
                {
                    snakeElements.Dequeue();
                }
                //updating score for the more time the game goes on
                score += 1;
                //printing new score on console
                Draw(71, 15, ConsoleColor.DarkGreen, "Your current score : ");
                Draw(76, 17, ConsoleColor.DarkGreen, String.Format("|{0,8}|", score.ToString().PadLeft(8,'0')));
                //printing player lifes
                Draw(72, 19, ConsoleColor.DarkGreen, "Player lives left : ");
                Draw(78, 21, ConsoleColor.DarkGreen, String.Format("|{0,3}|", playerLives.ToString().PadLeft(3, '0')));
                //printing new timer to console
                Draw(70, 23, ConsoleColor.DarkGreen, "Your current time is : ");
                Draw(76, 25, ConsoleColor.DarkGreen, overalTime);
                //print current speed of game
                Draw(78, 27, ConsoleColor.DarkGreen, "Speed : ");
                Draw(79, 29, ConsoleColor.DarkGreen, String.Format("|{0,3}|", gameSpeed.ToString().PadLeft(3, '0')));

                PrintApples(apple);
                Thread.Sleep(gameSpeed);
            }
        }
    }
}
