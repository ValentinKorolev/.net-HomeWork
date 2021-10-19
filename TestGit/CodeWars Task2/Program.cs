using System;

namespace CodeWars_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsIsogramm("aba"));
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
            //CodeWars decision 
            /*public static bool IsIsogram(string str)
            {
                return str.ToLower().Distinct().Count() == str.Length;
                приведем строку к нижнему регистру, Distinct удалит повторный символ, Count поолучит число элементов,
                и затем стравним с длинной строки. Если было совпаление символов длинна не сойдется, вернеться фолс.
            
            }*/
        }
    }
}
