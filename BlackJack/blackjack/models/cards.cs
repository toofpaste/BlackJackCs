using System;
namespace BlackJack
{
    public class Cards
    {
        private int Card;
        private int Deal; 

        public Cards(int card1, int card2)
        {
            Card = card1;
            Deal = card2;
        }
        public int hitCard(int card1)
        {
            return Card += card1;
        }
        public int stayCard(int deal1)
        {
            return Deal += deal1;
        }

        public int getCard()
        {
            return Card;
        }

        public int getDeal()
        {
            return Deal;
        }

        public int checkWin(int deal, int card)
        {
            if (card > 21)
            {
                return 1;
            }
            else if (card < deal)
            {
                return 1;
            }
            else if (card > deal)
            {
                return 2;
            }
            else if (card == deal)
            {
                return 0;
            }
            else if (deal > 21)
            {
                return 2;
            }
            else return 0;
        }
    }
}
