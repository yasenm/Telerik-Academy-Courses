namespace SnakeTheGame
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.IO;
    using System.Linq;
    using System.Media;
    using System.Threading;

    #region Position
    public class Position
    {
        public int Row;
        public int Col;

        public Position(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }
    }
    #endregion

    public class TheCodeOfGame
    {
        /// <summary>
        /// method that will print the snakeElements
        /// </summary>
        /// <param name="snakeElements"></param>
        private static void PrintSnake(IEnumerable snakeElements, ConsoleColor color)
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
                    Console.ForegroundColor = color;
                }

                counter++;
                Console.SetCursorPosition(position.Col, position.Row);
                Console.Write("*");
            }
        }

        #region Snake's Food
        private static void PrintApples(Position apple)
        {
            Console.SetCursorPosition(apple.Col, apple.Row);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("@");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        #endregion

        /// <summary>
        /// Function that with the input said will draw on the console our rocks.
        /// </summary>
        /// <param name="posX"></param>
        /// <param name="posY"></param>
        /// <param name="color"></param>
        /// <param name="str"></param>
        private static void Draw(int posX, int posY, ConsoleColor color, string str)
        {
            Console.SetCursorPosition(posX, posY);
            Console.ForegroundColor = color;
            Console.Write(str);
        }

        /// <summary>
        /// Tova e method koito shte nachertae logo na zmiqta pri natiskane posle na Key shte se pusne igrata
        /// </summary>
        /// <param name="image"></param>
        private static void PrintingLogoSnake(string image)
        {
            // making console background color to darkgreen so it is more suitable for the game logo
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();

            //----------- ImagePrinting algo dont know how it works actualy
            Image picture = Image.FromFile(string.Empty + image);
            Console.SetBufferSize(picture.Width * 0x2, picture.Height * 0x2);
            FrameDimension dimension = new FrameDimension(picture.FrameDimensionsList[0x0]);
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

            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
        }

        /// <summary>
        /// saving score and sorting the best ones from which onely the top 5 or 10 will be printed
        /// </summary>
        /// <param name="score"></param>
        /// <param name="timer"></param>
        /// <param name="userInfo"></param>
        private static void SaveScoreInResultFile(int score, string timer, string userInfo, string scoresFile)
        {
            List<string> resultsList = new List<string>();

            // get all the other users top scores till the 15th so if its lower than the oters wont be in the high scores
            using (StreamReader sr = new StreamReader(scoresFile))
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

            resultsList.Add(score.ToString().PadLeft(8, '0') + " - score; " + timer + " - record time; " + userInfo + " - user info.");

            // sort all the scores from lowest to highest
            resultsList.Sort();

            // then reverse it so the top scores are at the first lines
            resultsList.Reverse();
            using (StreamWriter sw = new StreamWriter(scoresFile))
            {
                for (int i = 0; i < resultsList.Count; i++)
                {
                    sw.WriteLine(resultsList[i]);
                }
            }
        }

        /// <summary>
        /// Method that checks if the snake has bitten her body that return a bool variable
        /// </summary>
        /// <param name="newSnakeHeadPos"></param>
        /// <param name="snakeElements"></param>
        /// <returns></returns>
        private static bool HasSnakeBittenHerSelf(Position newSnakeHeadPos, Queue<Position> snakeElements)
        {
            bool snakeHasBittenHerSelf = false;
            foreach (var snakeElement in snakeElements)
            {
                if (snakeElement.Col == newSnakeHeadPos.Col && snakeElement.Row == newSnakeHeadPos.Row)
                {
                    snakeHasBittenHerSelf = true;
                }
            }

            return snakeHasBittenHerSelf;
        }

        public static void Menu()
        {
            // enter user nick for the high scores in the begining of game
            Draw(20, 11, ConsoleColor.DarkRed, "TEAM UNCLE FESTER!");
            Draw(20, 13, ConsoleColor.DarkRed, "SNAKE GAME!!!");
            Draw(20, 15, ConsoleColor.DarkRed, "Enter а user name!");
            Console.SetCursorPosition(20, 18);
            Console.Write("Write in latin letters : ");
        }
        
        public static void SoundInTheGame()
        {
            // Create new SoundPlayer in the using statement.
            using (SoundPlayer player = new SoundPlayer(@"music/Wav Daft Punk - Get Lucky 8 Bit.wav"))
            {
                // Use PlaySync to load and then play the sound without stopping
                player.PlayLooping();
            }
        }
        
        public static void DrawPlayScreenFrame()
        {
            // Draw a line that will separate the score screen from the play screen basicaly a Frame
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
        }
        
        public static void DeletingOldScoreNumberTimerSpeedFromConsole(int score, int playerLives, string overalTime, int gameSpeed)
        {
            // deleting old score from console
            Draw(80, 20, ConsoleColor.Black, "|" + score.ToString().PadLeft(8, '0') + "|");

            // deleting old number of lifes from console
            Draw(78, 20, ConsoleColor.Black, "|" + playerLives.ToString().PadLeft(3, '0') + "|");

            // deleting old timer from console
            Draw(78, 20, ConsoleColor.Black, overalTime);

            // deleting old speed from console
            Draw(79, 29, ConsoleColor.Black, "|" + gameSpeed.ToString().PadLeft(3, '0') + "|");
        }
        
        public static void PrintNewScoreNumberTimerSpeedFromConsole(int score, int playerLives, string overalTime, int gameSpeed)
        {
            // printing new score on console
            Draw(71, 15, ConsoleColor.DarkGreen, "Your current score : ");
            Draw(76, 17, ConsoleColor.DarkGreen, "|" + score.ToString().PadLeft(8, '0') + "|");

            // printing player lifes
            Draw(72, 19, ConsoleColor.DarkGreen, "Player lives left : ");
            Draw(78, 21, ConsoleColor.DarkGreen, "|" + playerLives.ToString().PadLeft(3, '0') + "|");

            // printing new timer to console
            Draw(70, 23, ConsoleColor.DarkGreen, "Your current time is : ");
            Draw(76, 25, ConsoleColor.DarkGreen, overalTime);

            // print current speed of game
            Draw(78, 27, ConsoleColor.DarkGreen, "Speed : ");
            Draw(79, 29, ConsoleColor.DarkGreen, "|" + gameSpeed.ToString().PadLeft(3, '0') + "|");
        }

        private static void Main(string[] args)
        {
            /*********************** THE MAIN GAME FUNCTION ***********************/

            Menu();
            string userInfo = Console.ReadLine();

            Console.Clear();

            // Set console field, game field and score screen width and height.
            Console.WindowHeight = 50;
            Console.BufferHeight = 50;          // buffers should be equal to the value you want to set
            Console.WindowWidth = 100;          // for more convinience
            Console.BufferWidth = 100;

            Console.Clear();
            
            Console.CursorVisible = false;
            // score int that will hold our score
            int score = 0;
            string scoresFile = @"..\..\scores.txt";
            
            // int that will hold player lives and life upper coeficient
            int playerLives = 5;
            int getingNewLineMark = 3000;

            // string that will be printed as a current time
            string overalTime = string.Empty;

            // variable that will up the speed og game as game progresses
            int speedEnchancer = 0;
            int gameSpeed = 100;
            
            SoundInTheGame();

            string startGame = @"picture/SnakeHelloScreen.jpg";

            Console.ForegroundColor = ConsoleColor.Black;

            try
            {
                PrintingLogoSnake(startGame);
            }
            catch (Exception e)
            {
                Draw(10, 5, ConsoleColor.DarkRed, e.Message);
                Draw(10, 7, ConsoleColor.DarkRed, "We were not able to load a logo screen of SNAKE GAME.");
                Draw(10, 9, ConsoleColor.DarkRed, "Press any key to continue to the game.");
                string me = Console.ReadLine();
            }

            Console.ForegroundColor = ConsoleColor.Gray;

            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            DrawPlayScreenFrame();
                       
            Console.ForegroundColor = ConsoleColor.Gray;

            Position[] directions = new Position[]
                {
                    new Position(0, 1),      // right
                    new Position(0, -1),     // left
                    new Position(1, 0),      // down
                    new Position(-1, 0),     // up
                };

            int direction = 0;      // will hold which way our snake is going to move

            Random randomNumbersGenerator = new Random();
            Position apple = new Position(randomNumbersGenerator.Next(3, 43), randomNumbersGenerator.Next(2, 58));

            // new snake made
            Queue<Position> snakeElements = new Queue<Position>();
            for (int i = 2; i <= 7; i++)
            {
                snakeElements.Enqueue(new Position(1, i));
            }

            // Game timer
            Stopwatch gameTimer = new Stopwatch();
            gameTimer.Start();

            // variable that will hold tha last direction and we will check in the conditions so it cant go oposite side
            int lastDirectionLeftOrRight = 0;
            int lastDirectionUpOrDown = 3;

            while (true)
            {
                // actualizing the speed enchancer
                speedEnchancer++;

                // actualizing the speed of game if the enchancer reaches sertain level
                if (speedEnchancer == 1500)
                {
                    gameSpeed--;
                    speedEnchancer = 0;
                }

                // updating lives if the player has reached 3000 points
                if (score >= getingNewLineMark)
                {
                    playerLives += 1;
                    getingNewLineMark += 3000;
                }

                // controls for the movement of the snake
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo userInput = Console.ReadKey();
                    if (userInput.Key == ConsoleKey.LeftArrow && direction != lastDirectionLeftOrRight)
                    {
                        direction = 1;
                        lastDirectionLeftOrRight = 1;
                    }

                    if (userInput.Key == ConsoleKey.RightArrow && direction != lastDirectionLeftOrRight)
                    {
                        direction = 0;
                        lastDirectionLeftOrRight = 0;
                    }

                    if (userInput.Key == ConsoleKey.UpArrow && direction != lastDirectionUpOrDown)
                    {
                        direction = 3;
                        lastDirectionUpOrDown = 3;
                    }

                    if (userInput.Key == ConsoleKey.DownArrow && direction != lastDirectionUpOrDown)
                    {
                        direction = 2;
                        lastDirectionUpOrDown = 2;
                    }
                }

                Position snakeHead = snakeElements.Last();
                Position nextDirection = directions[direction];
                Position snakeNewHeadPos = new Position(snakeHead.Row + nextDirection.Row, snakeHead.Col + nextDirection.Col);

                // if we end up in a wall the game ends or takes 1 of our lifes
                // collusion with wall and snake body , taking life and restarting from begining
                if (snakeNewHeadPos.Col < 2 || snakeNewHeadPos.Row < 1 || snakeNewHeadPos.Col > 59 || snakeNewHeadPos.Row > 44 || HasSnakeBittenHerSelf(snakeNewHeadPos, snakeElements))
                {
                    if (playerLives > 0)
                    {
                        playerLives--;
                        if (playerLives == 0)
                        {
                            Console.Clear();
                            Draw(20, 10, ConsoleColor.DarkRed, "Your score is : " + score);
                            SaveScoreInResultFile(score, overalTime, userInfo, scoresFile);
                            Draw(20, 14, ConsoleColor.DarkRed, "The see the best 15 scores, press SPACE.");
                            Draw(20, 18, ConsoleColor.DarkRed, "To end the game press any other key.");

                            ConsoleKeyInfo endKey = Console.ReadKey();
                            if (endKey.Key == ConsoleKey.Spacebar)
                            {
                                try
                                {
                                    using (StreamReader sr = new StreamReader(scoresFile))
                                    {
                                        int lineNumber = 0;
                                        string line = " ";
                                        Draw(20, 24, ConsoleColor.DarkRed, "LIST OF BEST 15 RESULTS!");
                                        while ((line = sr.ReadLine()) != null && lineNumber < 15)
                                        {
                                            Console.SetCursorPosition(20, lineNumber + 26);
                                            Console.WriteLine(line);
                                            lineNumber++;
                                        }
                                    }
                                }
                                catch (Exception e)
                                {
                                    Draw(10, 5, ConsoleColor.DarkRed, e.Message);
                                    Draw(10, 7, ConsoleColor.DarkRed, "We were not able to load the Scores for the SNAKE GAME.");
                                    Draw(10, 9, ConsoleColor.DarkRed, "Press any key to continue to the game.");
                                    endKey = Console.ReadKey();
                                }
                            }

                            endKey = Console.ReadKey();
                            string endGame = @"picture/GameOver.jpg";

                            Console.Clear();
                            PrintingLogoSnake(endGame);
                            endKey = Console.ReadKey();
                            return;
                        }
                        else
                        {
                            // delete old snake elements from the console by painting them black
                            PrintSnake(snakeElements, ConsoleColor.Black);

                            // clear the whole queue of elements and start again from begining with 1 less life
                            snakeElements.Clear();
                            for (int i = 2; i <= 7; i++)
                            {
                                snakeElements.Enqueue(new Position(1, i));
                            }

                            direction = 0;
                        }
                    }
                }
                else
                {
                    snakeElements.Enqueue(snakeNewHeadPos);
                }

                PrintSnake(snakeElements, ConsoleColor.Gray);

                DeletingOldScoreNumberTimerSpeedFromConsole(score, playerLives, overalTime, gameSpeed);
                
                // time variable that will be printed
                string time = string.Format("|{0,2}:{1,2}:{2,3}|", gameTimer.Elapsed.Minutes.ToString().PadLeft(2, '0'), gameTimer.Elapsed.Seconds.ToString().PadLeft(2, '0'), gameTimer.Elapsed.Milliseconds.ToString().PadLeft(3, '0'));
                overalTime = time;
                               
                // if snake eats apple
                if (snakeNewHeadPos.Col == apple.Col && snakeNewHeadPos.Row == apple.Row)
                {
                    apple = new Position(randomNumbersGenerator.Next(3, 44), randomNumbersGenerator.Next(2, 59));
                    score += 100;
                }
                else
                {
                    snakeElements.Dequeue();
                }

                // updating score for the more time the game goes on
                score += 1;

                PrintNewScoreNumberTimerSpeedFromConsole(score, playerLives, overalTime, gameSpeed);
                
                PrintApples(apple);
                Thread.Sleep(gameSpeed);
            }
        }
    }
}