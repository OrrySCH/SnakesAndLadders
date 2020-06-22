using System;
namespace SnakesAndLadders
{
    public class Die
    {
        private Random rnd = new Random(Guid.NewGuid().GetHashCode());

        public int Face { get; private set; }

        private byte sides = 6;

        public Die()
        {
            Roll();
        }

        public Die(byte _sides)
        {
            if (_sides > 1)
            {
                this.sides = _sides;
                Roll();
            }
            else
            {
                throw new ArgumentOutOfRangeException("Invalid number of sides for die");
            }

        }

        public void Roll()
        {
            this.Face = rnd.Next(1, sides + 1);
        }
    }
}
