using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace SnakesAndLadders
{
    public class Board
    {
        private int numberOfSquares;
        private List<Square> mySquares = new List<Square>();
        private Queue<Player> myPlayers = new Queue<Player>();
        private Player currentPlayer;
        
        public Board(int squareCount, int playerCount)
        {
            numberOfSquares = squareCount;
            int i;
            for (i = 0; i < numberOfSquares-1; i++)
            {
                mySquares.Add(new Square(this, i)); // to add normal square
                //mySquares.Add(new ActionSquare(this, i, ~move this many squares (snakes are negative)~)); // to add action square i.e snake or ladder
            }
            mySquares.Add(new LastSquare(this, numberOfSquares));

            for (int j = 1; j <= playerCount; j++)
            {
                myPlayers.Enqueue(new Player($"Player {j}", mySquares[0]));
            }
        }

        public void Play()
        {
            currentPlayer = myPlayers.Dequeue();
            Console.WriteLine($"Player: {currentPlayer.Name}");
            currentPlayer.Move();
            Console.WriteLine($"Position: {currentPlayer.currentSquare.Position}");
            myPlayers.Enqueue(currentPlayer);
            currentPlayer = null; // clear current player, not strictly nessecary but protects against misuse
        }

        public Square FindSquare(Square current, int roll)
        {
            int destination = (current.Position + roll) >= numberOfSquares ? numberOfSquares-1 : (current.Position + roll);
            return mySquares[destination].LandHere();
        }

        public void GameOver()
        {
            currentPlayer.PlayerWins();
        }
    }
}
