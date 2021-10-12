using System;

namespace TestGit
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;

            switch (num)
            {
                case 256:
                    Console.WriteLine( 2 );
                    break;
                case 1:
                    Console.WriteLine(1);
                    goto case 5;
                    
                case 5:
                    Console.WriteLine(5);
                    break;


            }
        }
    }
}
