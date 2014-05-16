using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class AcademyPopcornMain
    {
        const int WorldRows = 23;
        const int WorldCols = 40;
        const int RacketLength = 6;

        static void Initialize(PatchedEngine engine)
        {
            int startRow = 3;
            int startCol = 2;
            int endCol = WorldCols - 2;

            for (int i = startCol; i < endCol; i++)
            {
                Block currBlock = new Block(new MatrixCoords(startRow, i++));
                ExplodingBlock currBlock1 = new ExplodingBlock(new MatrixCoords(startRow, i));

                engine.AddObject(currBlock);
                engine.AddObject(currBlock1);
            }

            #region Exercise 01 Making the walls
            for (int i = startRow - 2; i < WorldRows; i++)
            {
                engine.AddObject(new IndestructibleBlock(new MatrixCoords(i, startCol - 2)));
                engine.AddObject(new IndestructibleBlock(new MatrixCoords(i, WorldCols - 1)));
            }

            for (int i = startCol - 1; i <= endCol; i++)
            {
                engine.AddObject(new IndestructibleBlock(new MatrixCoords(startRow - 2, i)));
            }
            #endregion

            // Exercise 07 : Test Changed old ball with a meteorite one 
            MeteoriteBall theBall = new MeteoriteBall(new MatrixCoords(WorldRows / 2, 0),
                new MatrixCoords(-1, 1));

            // Exercise 09 : Adding some unpassable blocks for a test
            for (int i = startCol + 6; i <= endCol - 6; i += 4)
            {
                engine.AddObject(new UnpassableBlock(new MatrixCoords(startRow + 2, i++)));
                engine.AddObject(new UnpassableBlock(new MatrixCoords(startRow + 2, i++)));
                engine.AddObject(new UnpassableBlock(new MatrixCoords(startRow + 2, i++)));
                engine.AddObject(new UnpassableBlock(new MatrixCoords(startRow + 2, i++)));
            }

            //// Exercise 09 : Test Changed old ball with a unstoppable one
            //UnstoppableBall theBall = new UnstoppableBall(new MatrixCoords(WorldRows / 2, 0),
            //    new MatrixCoords(-1, 1));

            engine.AddObject(theBall);

            Racket theRacket = new Racket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);

            engine.AddObject(theRacket);
        }

        static void Main(string[] args)
        {
            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();

            PatchedEngine gameEngine = new PatchedEngine(renderer, keyboard, 200);

            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketLeft();
            };

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketRight();
            };

            Initialize(gameEngine);

            //

            gameEngine.Run();
        }
    }
}
