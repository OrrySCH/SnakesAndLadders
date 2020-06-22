using System;
namespace SnakesAndLadders
{
    class Player
    {
        public string Name;

        protected int winTally;

        public Square currentSquare;

        public Player(string nameEntered, Square startingSquare)
        {
            Name = nameEntered;
            currentSquare = startingSquare;
        }
        public void Move()
        {
            Shaker myShaker = new Shaker();
            myShaker.RollDice();
            currentSquare = currentSquare.Move(myShaker.Total);
        }

        public void PlayerWins()
        {
            winTally++;
        }
    }
}