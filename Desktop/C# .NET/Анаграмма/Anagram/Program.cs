using System;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string: ");
            string str = Console.ReadLine();
            string[] arrayStrings = str.Split(' ');

            for (int i = 0; i < arrayStrings.Length; i++)
            {
                arrayStrings[i] = anagram(arrayStrings[i]);
            }
            
            string newstr = String.Join(" ",arrayStrings);
            Console.WriteLine(str + " => " + newstr);

            Console.ReadKey();
        }
        public static string anagram(string x)
        {
            if (x.Length > 1)
            {
                int j = x.Length - 1;
                char t;
                char[] arrayChar = x.ToCharArray();
                int i = 0;
                do
                {
                    if (!Char.IsLetter(arrayChar[i]))
                    {
                        i++;
                    }
                    else if (!Char.IsLetter(arrayChar[j]))
                    {
                        j--;
                    }
                    else
                    {

                        t = arrayChar[i];
                        arrayChar[i] = arrayChar[j];
                        arrayChar[j] = t;
                        j--;
                        i++;
                    }
                } while (i < j);

                return (new string(arrayChar));
            }
            else
            {
                return x;
            }

        }
    }
}
