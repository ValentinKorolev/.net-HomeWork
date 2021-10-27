using System;
using System.Linq;

namespace CodeWars_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Usually when you buy something, you're asked whether your credit card number, 
              phone number or answer to your most secret question is still correct. 
              However, since someone could look over your shoulder, you don't want that shown on your screen.Instead, we mask it.
              Your task is to write a function maskify, which changes all but the last four characters into '#'.

              Examples
                Kata.Maskify("4556364607935616"); // should return "############5616"
                Kata.Maskify("64607935616");      // should return "#######5616"
                Kata.Maskify("1");                // should return "1"
                Kata.Maskify("");                 // should return ""   
            
            */

            string text = "4556364607935616";
                        
            Console.WriteLine(Mastify(text));            
        }
        public static string Mastify(string text)
        {
            string modifyText = null;
            if (text.Length > 4)
            {
                for (int i = 0; i < text.Length-4; i++)
                {
                    modifyText += "#";
                }
                modifyText += text.Substring(text.Length - 4, 4);
            }
            else if ((text.Length <= 4) || (text == "")) 
            {
                modifyText = text;
            }

            return modifyText;

            /* CodeWars decision 
              public static class Kata
            {
                // return masked string
                public static string Maskify(string cc)
                {
                     int len = cc.Length;
                     if (len <=4)
                        return cc;
        
                return cc.Substring(len-4).PadLeft(len, '#'); 
                //PadLeft() Возвращает новую строку указанной длины, 
                //в которой начало текущей строки заполняется пробелами или указанным знаком
                }
            }*/             
        }
    }
}
