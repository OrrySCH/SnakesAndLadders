using System;
namespace SnakesAndLadders
{
    public class LastSquare : Square
    {
        public LastSquare(Board tempBoard, int tempPosition) : base(tempBoard, tempPosition) { }

        override public Square Move(int moveBy)
        {
            board.GameOver();
            return this;
        }
    }
}
