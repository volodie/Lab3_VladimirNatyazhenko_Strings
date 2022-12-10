using System;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите строку вида xxxx-yyy-xxxx-yyy-xyxy : ");
        string stringParse = Console.ReadLine();
        //PrintTwoBloksNumber(stringParse);
        //ReplaceChars(stringParse);
        //PrintChars(stringParse);
        //FindSubstring(stringParse);
        //FindStartChars(stringParse);
        //FindEndChars(stringParse);
        //PrintUpperChars(stringParse);
    }

    static void PrintTwoBloksNumber(string stringParse)
    {
        string[] words = stringParse.Split(new char[] { '-' });
        Console.WriteLine(words[0] + " "+ words[2]);
       
    }
   
    static void ReplaceChars(string stringParse)
    {
        string[] words = stringParse.Split(new char[] { '-' });
        foreach (string s in words)
        {
            if (s.Length == 3)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (s.Any(char.IsLetter))
                    {
                        Console.Write("*");
                    }
                }
            }
            else
            {
                Console.WriteLine(s);
            }
            // второй вариант решения
            //if (s.Length == 3)
            //{
            //    Console.Write("***");
            //}
            //else
            //{
            //    Console.Write(s);
            //}

        }
    }
    static void PrintChars(string stringParse)
    {
        StringBuilder sb = new StringBuilder();
        
        string[] words = stringParse.Split(new char[] { '-' });
        sb.Append(words[1].Substring(0, words[1].Length).ToLower()).Append("/");
        sb.Append(words[3].Substring(0, words[3].Length).ToLower()).Append("/");

        foreach (Char s in words[4])
        {
            if (char.IsLetter(s))
                {
                sb.Append(Char.ToLower(s)).Append("/");
                }
        }
        sb.Remove(sb.Length-1,1);
        Console.WriteLine(sb);
    }

    static void PrintUpperChars(string stringParse)
    {
        StringBuilder sb = new StringBuilder();

        string[] words = stringParse.Split(new char[] { '-' });
        sb.Append(words[1].Substring(0, words[1].Length).ToUpper()).Append("/");
        sb.Append(words[3].Substring(0, words[3].Length).ToUpper()).Append("/");

        foreach (Char s in words[4])
        {
            if (char.IsLetter(s))
            {
                sb.Append(Char.ToUpper(s)).Append("/");
            }
        }
        sb.Remove(sb.Length - 1, 1);
        Console.WriteLine("Letters: "+ sb);
    }

    static void FindSubstring(string stringParse)
    {
        string subStr = "abc";
        
        if ((stringParse.IndexOf(subStr) > -1) | (stringParse.IndexOf(subStr.ToUpper()) > -1))
        {
            Console.WriteLine("Вхождения подстроки abc найдены ");
        }
        else
        {
            Console.WriteLine("Вхождения подстроки abc не найдены ");
        }
    }
    static void FindStartChars(string stringParse)
    {
        if (stringParse.StartsWith("555"))
        {
            Console.WriteLine("Номер документа начинается на 555");
        }
        else
        {
            Console.WriteLine("Номер документа  не начинается на 555");
        } 
    }
    static void FindEndChars(string stringParse)
    {
        if (stringParse.EndsWith("1a2b"))
        {
            Console.WriteLine("Номер документа заканчивается на 1a2b");
        }
        else
        {
            Console.WriteLine("Номер документа не заканчивается на 1a2b");
        }
    }
}
