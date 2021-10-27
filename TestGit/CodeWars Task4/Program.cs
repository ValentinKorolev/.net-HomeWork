using System;

namespace CodeWars_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Welcome. In this kata, you are asked to square every digit of a number and concatenate them.

            For example, if we run 9119 through the function, 811181 will come out, because 92 is 81 and 12 is 1.

            Note: The function accepts an integer and returns an integer*/

            int num = 9119;
            Console.WriteLine(SquareDigits(num));

            int SquareDigits(int num)
            {
                char[] ch = num.ToString().ToCharArray();
                string modifyNum = null;
                for (int i = 0; i < ch.Length; i++)
                {
                    num = (int)Math.Pow(int.Parse(ch[i].ToString()),2);
                    modifyNum += num.ToString();
                }
                return int.Parse(modifyNum);


                /* CodeWars decision
                 
                   public static int SquareDigits(int n)
                   {
                         string output = "";
                         foreach (char c in n.ToString())
                             {
                              int square = int.Parse(c.ToString());
                                 output += (square * square);
                             }
                         return int.Parse(output);
                    }
                 */
            }
        }
    }
}
