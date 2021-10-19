using System;

namespace CodeWars_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsIsogramm("Babe"));
        }
        static bool IsIsogramm(string str)
        {
            bool isIsogramm = true;
            string lower = str.ToLower();
            char[] stringCharacters = lower.ToCharArray();

            for(int i = 0; i<=stringCharacters.Length-1; i++)
            {
                for(int j = i+1; j <= stringCharacters.Length - 1; j++)
                {
                    if (stringCharacters[i] == stringCharacters[j])
                    {
                      isIsogramm = false;
                    }
                }

            }
            return isIsogramm;
        }
    }
}
