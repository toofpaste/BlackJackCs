using System;

namespace BlackJack
{
    class MainClass
    {
        public static void Main()
        {
            Random rnd = new Random();

            int card1 = rnd.Next(2, 11);
            int card2 = rnd.Next(2, 11);

            int deal = rnd.Next(2, 11);


            Cards gameCard = new Cards((card1 + card2), deal);
            Console.WriteLine("Dealer: " + gameCard.getDeal());
            Console.WriteLine("User: " + gameCard.getCard());
            int i = 0;


            while (i == 0)
            {
                Console.WriteLine("HIT/STAY/QUIT");
                bool ans = Console.ReadLine().ToLower() == "hit";

                if (ans)
                {
                    int card3 = rnd.Next(2, 11);
                    gameCard.hitCard(card3);
                    Console.WriteLine("User: " + gameCard.getCard());
                }
                else
                {
                    while (gameCard.getDeal() < 17)
                    {
                        int deal1 = rnd.Next(2, 11);
                        gameCard.stayCard(deal1);
                    };
                    i = 1;
                    break;

                
                }
            }
            int win = gameCard.checkWin(gameCard.getDeal(), gameCard.getCard());
            Console.WriteLine("Dealer: " + gameCard.getDeal());
            Console.WriteLine("User: " + gameCard.getCard());
            if (win == 2)
            {
                Console.WriteLine("User Wins");
            }
            else if (win == 1)
            {
                Console.WriteLine("Dealer Wins");
            }
            else if (win == 0)
            {
                Console.WriteLine("TIE TIE");
            }
        }
    }
}

