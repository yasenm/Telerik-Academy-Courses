using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03CardWarsBatka
{
    class CardWarsBatka
    {
        static void Main()
        {
            //---- Main variables
            int playerOneCurrentGameScore = 0;
            int playerTwoCurrentGameScore = 0;
            int playerOneScore = 0;
            int playerTwoScore = 0;
            int playerOneGamesWon = 0;
            int playerTwoGamesWon = 0;
            int num;
            bool playerOneXindex = false;
            bool playerTwoXindex = false;
            bool gameEnded = false;

            //---- input data sequence
            int N = int.Parse(Console.ReadLine());

            //---- loop for all the games
            for (int i = 0; i < N; i++)
            {
                for (int playerOneCardIndex = 0; playerOneCardIndex < 3; playerOneCardIndex++)
                {
                    int cardRepresentationValue = 2;
                    int cardNumberValue = 10;
                    string playerOneCard = Console.ReadLine();
                    //----- Check if it's entered a card with number value
                    if (int.TryParse(playerOneCard, out num) == true)
                    {
                        while (int.Parse(playerOneCard) > cardRepresentationValue)
                        {
                            cardNumberValue--;
                            cardRepresentationValue++;
                        }
                    }
                    //----- If we have a 'A' , 'J' , 'Q' or 'K' card
                    else
                    {
                        if (playerOneCard == "A")
                        {
                            cardNumberValue = 1;
                        }
                        else if (playerOneCard == "J")
                        {
                            cardNumberValue = 11;
                        }
                        else if (playerOneCard == "Q")
                        {
                            cardNumberValue = 12;
                        }
                        else if (playerOneCard == "K")
                        {
                            cardNumberValue = 13;
                        }
                        //----- Additional cards in game check
                        else if (playerOneCard == "Y")
                        {
                            playerOneScore = playerOneScore - 200;
                            cardNumberValue = 0;
                        }
                        else if (playerOneCard == "Z")
                        {
                            playerOneCurrentGameScore = playerOneCurrentGameScore * 2;
                            cardNumberValue = 0;
                        }
                        else if (playerOneCard == "X")
                        {
                            playerOneXindex = true;
                            cardNumberValue = 0;
                        }
                    }
                    playerOneCurrentGameScore = playerOneCurrentGameScore + cardNumberValue;
                }
                for (int playerTwoCardIndex = 0; playerTwoCardIndex < 3; playerTwoCardIndex++)
                {
                    int cardRepresentationValue = 2;
                    int cardNumberValue = 10;
                    string playerTwoCard = Console.ReadLine();
                    //----- Check if it's entered a card with number value
                    if (int.TryParse(playerTwoCard, out num) == true)
                    {
                        while (int.Parse(playerTwoCard) > cardRepresentationValue)
                        {
                            cardNumberValue--;
                            cardRepresentationValue++;
                        }
                    }
                    //----- If we have a 'A' , 'J' , 'Q' or 'K' card
                    else
                    {
                        if (playerTwoCard == "A")
                        {
                            cardNumberValue = 1;
                        }
                        else if (playerTwoCard == "J")
                        {
                            cardNumberValue = 11;
                        }
                        else if (playerTwoCard == "Q")
                        {
                            cardNumberValue = 12;
                        }
                        else if (playerTwoCard == "K")
                        {
                            cardNumberValue = 13;
                        }
                        //----- Additional cards in game check
                        else if (playerTwoCard == "Y")
                        {
                            playerTwoScore = playerTwoScore - 200;
                            cardNumberValue = 0;
                        }
                        else if (playerTwoCard == "Z")
                        {
                            playerTwoCurrentGameScore = playerTwoCurrentGameScore * 2;
                            cardNumberValue = 0;
                        }
                        else if (playerTwoCard == "X")
                        {
                            playerTwoXindex = true;
                            cardNumberValue = 0;
                        }
                    }
                    playerTwoCurrentGameScore = playerTwoCurrentGameScore + cardNumberValue;
                }
                //----- Check if one or both drew 'X'
                if ((playerOneXindex == true) && (playerTwoXindex == true))
                {
                    playerOneScore = playerOneScore + 50;
                    playerTwoScore = playerTwoScore + 50;
                }
                else if ( (playerOneXindex == true) && (playerTwoXindex == false) )
                {
                    Console.WriteLine("X card drawn! Player one wins the match!");
                    gameEnded = true;
                    break;
                }
                else if ((playerOneXindex == false) && (playerTwoXindex == true))
                {
                    Console.WriteLine("X card drawn! Player two wins the match!");
                    gameEnded = true;
                    break;
                }
                //----- Compare current game scores and refresh new ones
                if (playerOneCurrentGameScore > playerTwoCurrentGameScore)
                {
                    playerOneScore = playerOneScore + playerOneCurrentGameScore;
                    playerOneGamesWon++;
                }
                else if (playerOneCurrentGameScore < playerTwoCurrentGameScore)
                {
                    playerTwoScore = playerTwoScore + playerTwoCurrentGameScore;
                    playerTwoGamesWon++;
                }
                playerOneCurrentGameScore = 0;
                playerTwoCurrentGameScore = 0;
            }
            //----- Check end results for the two players
            if (gameEnded == false)
            {
                if (playerOneScore > playerTwoScore)
                {
                    Console.WriteLine("First player wins!");
                    Console.WriteLine("Score: {0}", playerOneScore);
                    Console.WriteLine("Games won: {0}", playerOneGamesWon);
                }
                else if (playerOneScore < playerTwoScore)
                {
                    Console.WriteLine("Second player wins!");
                    Console.WriteLine("Score: {0}", playerTwoScore);
                    Console.WriteLine("Games won: {0}", playerTwoGamesWon);
                }
                else
                {
                    Console.WriteLine("It's a tie!");
                    Console.WriteLine("Score: {0}", playerOneScore);
                }
            }
        }
    }
}
