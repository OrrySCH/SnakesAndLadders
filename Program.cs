using System;

namespace SnakesAndLadders
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Board myBoard = new Board(30,5);
            Console.WriteLine("Game start!");
            while (true)
            {
                Console.ReadLine();
                myBoard.Play();
            }
        }
    }
}
