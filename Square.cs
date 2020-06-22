using System;
namespace SnakesAndLadders
{
    public class Square
    {
        public int Position;
        protected Board board;

        public Square(Board tempBoard, int tempPosition)
        {
            board = tempBoard;
            Position = tempPosition;
        }

        virtual public Square Move(int moveBy)
        {
            return board.FindSquare(this, moveBy);
        }

        virtual public Square LandHere() // overridden by action square
        {
            return this;
        }
    }
}
