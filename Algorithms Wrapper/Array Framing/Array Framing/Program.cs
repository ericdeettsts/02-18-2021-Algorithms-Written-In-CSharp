using System;

namespace Array_Framing
{
    class Program
    {
        private string l = "L";

        public void Solution(int N)
        {
            string lineOutString = null;

            for (int i = 0; i < N; i++)
            {
                if (i == N - 1)
                {
                    for (int lineOut = 0; lineOut < N; lineOut++)
                    {
                        lineOutString += this.l;
                    }
                    Console.Write(lineOutString);
                    break;
                }
                Console.WriteLine(this.l);
            }
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Solution(27);
        }
    }
}
