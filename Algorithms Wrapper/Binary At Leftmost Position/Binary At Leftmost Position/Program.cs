using System;

namespace Binary_At_Leftmost_Position
{
    class Program
    {
        public int Solution(int _a, int _b)
        {
            string a = _a.ToString();
            string b = _b.ToString();
            int[] aArray = new int[a.Length];
            int[] bArray = new int[b.Length];
            int indexa = 0;
            int indexb = 0;

            foreach (char c in a)
            {
                aArray[indexa] = (int)Char.GetNumericValue(c);
                indexa++;
            }

            foreach (char c in b)
            {
                bArray[indexb] = (int)Char.GetNumericValue(c);
                indexb++;
            }

            int storeIndex = 0;

            for (int bi = 0; bi < indexb; bi++)
            {
                if (aArray[0] == bArray[bi])
                {
                    for (int ai = 0; ai < indexa; ai++)
                    {
                        if (aArray[ai] != bArray[bi])
                        {
                            break;
                        }

                        bi++;

                        if (ai == indexa - 1 && aArray[ai] == bArray[bi - 1])
                        {
                            storeIndex = bi - indexa;
                            return storeIndex;
                        }
                    }
                }
            }

            Console.WriteLine("Test" + storeIndex);
            return -1;
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            int a = program.Solution(178, 1953341786);
            Console.WriteLine($"The value you found is at an index of no less than {a} + 1");
        }
    }
}
