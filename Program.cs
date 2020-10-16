using System;
using System.Text;
using System.Linq;

namespace CoreTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("Hello it Step");
            Console.WriteLine("Вітаємо в Акадмії ШАГ");

            // Console.Write("a=");
            //double a = double.Parse(Console.ReadLine());
            // bool f = double.TryParse(Console.ReadLine(), out double a);


            //string str0 = new string("Hello It Step");
            string str1 = "Hello It Step";
            string str2 = "";
            string str3 = null;
            string str4 = String.Empty;

            //char[] word = {'H','e','l','l','o' };
            char[] word = "Hello".ToCharArray();
            //char[] word =  "Hello".ToArray() ;
            string str5 = new string(word);
            string str6 = new string(word, 0, 2);
            string str7 = new string('-', 50);

            //  Console.WriteLine($"|{str0}|");
            Console.WriteLine($"1|{str1}|");
            Console.WriteLine($"4|{str4}|");
            Console.WriteLine($"5|{str5}|");
            Console.WriteLine($"6|{str6}|");
            Console.WriteLine($"7|{str7}|");

            Console.WriteLine($"-|{str5[1]}|");
            //  str5[1] = 'a';
            // str5 = "Hello";
            Console.WriteLine($"L=|{str5.Length}|");

            str6 = "Вітаємо в Акадмії ШАГ";
            char[] arr = new char[10];
            str6.CopyTo(10, arr, 0, 7);
            //Console.WriteLine($"arr=|{arr}|"); error
            //Console.Write($"arr=|");
            //foreach (var item in arr)
            //    Console.Write(item);
            //Console.WriteLine("|");
            Console.WriteLine($"arr=|{new string(arr)}|");
            Console.WriteLine($"arr=|{String.Join("", arr)}|");
            int[] mas = { 1, 2, 35, 652, 65, 659 };
            Console.WriteLine($"mas=|{String.Join(", ", mas)}|");
            //-------------Equals-------------------------------
            str5 = "Вітаємо в Акадмії ШАГ";
            str6 = "вітаємо в Акадмії ШАГ";

            //if (str5 == str6) {
            //if (str5.Equals(str6))
            //if (str5.Equals(str6, StringComparison.CurrentCulture))
            //if (str5.Equals(str6, StringComparison.CurrentCultureIgnoreCase))
            //if (str5.Equals(str6, StringComparison.InvariantCulture))
            //if (str5.Equals(str6, StringComparison.InvariantCultureIgnoreCase))
            //if (str5.Equals(str6, StringComparison.Ordinal))
            //if (str5.Equals(str6, StringComparison .OrdinalIgnoreCase))
            if (str5.Equals(str6, (StringComparison)0))
                Console.WriteLine($"Yes");
            else
                Console.WriteLine($"No");

            //----------------CompareTo----------------------------
            // str5 = "AAAA";
            str5 = "WWWW";
            str5 = "AAAA";
            //str6 = "WWWW";
            str6 = null;
            // -1
            //  0
            //  1 
            if (str5.CompareTo(str6) < 0)
                Console.WriteLine($"< {str5}<{str6}");
            else
            {
                if (str5.CompareTo(str6) > 0)
                    Console.WriteLine($"> {str5}>{str6}");
                else
                    Console.WriteLine($"== {str5}=={str6}");
            }
            //----------------Compare----------------------------

            str5 = "wwww";
            str6 = "WWWW";
            //str6 = null;
            if (String.Compare(str5, str6, true) < 0)
                Console.WriteLine($"< {str5}<{str6}");
            else
            {
                if (String.Compare(str5, str6, true) > 0)
                    Console.WriteLine($"> {str5}>{str6}");
                else
                    Console.WriteLine($"== {str5}=={str6}");
            }
            //--------------------------------------------
            str6 = "Вітаємо в Акадмії ШАГ";
            if (str6.StartsWith("Вітає"))
                Console.WriteLine($"StartsWith true");
            else
                Console.WriteLine($"StartsWith false");

            if (str6.EndsWith("ШАГ"))
                Console.WriteLine($"EndsWith true");
            else
                Console.WriteLine($"EndsWith false");

            if (str6.Contains("Акадміz"))
                Console.WriteLine($"Contains true");
            else
                Console.WriteLine($"Contains false");

            str6 = "Вітаємо в Акадмії ШАГ в місті Житомир таємо";

            string findText = "і";
            int pos = str6.IndexOf(findText);
            while (pos != -1)
            {
                Console.WriteLine($"pos->{pos}");
                pos = str6.IndexOf(findText, pos + 1);
            }
            pos = str6.LastIndexOf("таємо");
            Console.WriteLine($"pos={pos}");

            str6 = "Вітаємо в Акадмії ШАГ в місті Житомир таємо";
            str6 = str6.Substring(10, 7);
            Console.WriteLine($"str6={str6}");

            str6 = "     Іваненко         Іван      Петрович       ";
            str5 = "Іваненко І.П.";

            str6 = str6.Trim();
            while (str6.Contains("  "))
                str6 = str6.Replace("  ", " ");
            str2 = str6.Substring(0, str6.IndexOf(" "));
            str3 = str6.Substring(str6.IndexOf(" ") + 1, 1) + ".";
            str4 = str6.Substring(str6.LastIndexOf(" ") + 1, 1) + ".";
            Console.WriteLine($"str6=|{str6}|");
            Console.WriteLine($"str2=|{str2}|");
            Console.WriteLine($"str3=|{str3}|");
            Console.WriteLine($"str4=|{str4}|");

            str6 = "     Іваненко         Іван      Петрович       ";

            var words = str6.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"pib=|{words[0]} {words[1][0]}. {words[2][0]}.|");

            str6 = " Академія, Петрович. Ура!    Іваненко         Іван      Петрович       ";


            char[] separator = " .!,?".ToCharArray();
            words = str6.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"Length=|{words.Length}|");

            foreach (var item in words)
                Console.WriteLine($"=|{item}|");




        }
    }
}
