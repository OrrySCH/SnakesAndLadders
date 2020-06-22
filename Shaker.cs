using System;
namespace SnakesAndLadders
{
    public class Shaker
    {
        public int Total
        {
            get
            {
                int tempTotal = die1.Face + die2.Face;
                if (IsADouble()) tempTotal += die3.Face;
                return tempTotal;
            }
        }

        public readonly Die die1 = new Die();
        public readonly Die die2 = new Die();
        public readonly Die die3 = new Die();

        public Shaker()
        {
        }

        public void RollDice()
        {
            die1.Roll();
            die2.Roll();
            die3.Roll();
        }

        public bool IsADouble()
        {
            return die1.Face == die2.Face;
        }
    }
}

