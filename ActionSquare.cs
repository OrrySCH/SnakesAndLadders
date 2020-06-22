using System;
namespace SnakesAndLadders
{
    public class ActionSquare : Square
    {
        protected int translation;

        public ActionSquare(Board tempBoard, int tempPosition, int tempTranslation) : base(tempBoard, tempPosition)
        {
            translation = tempPosition;
        }

        override public Square LandHere()
        {
            return board.FindSquare(this, translation);
        }
    }
}
