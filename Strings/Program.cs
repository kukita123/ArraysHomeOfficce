using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {

        static int CountPatern(string text, string pattern)
        {
            int counter = 0;
            int index = text.IndexOf(pattern);

            while (index != -1)
            {
                counter++;
                index = text.IndexOf(pattern, index + 1);
            }
            return counter;
        }

        static bool CheckMath(string equation)
        {
            if (equation.StartsWith(")") || equation.EndsWith("(")) return false;
            else
            {
                int count = 0;
                int index = 0;
                while (index < equation.Length)//for(int index = 0; index < equation.Length; index ++){if( ...) ...}
                {
                    if (equation[index] == '(') count++;
                    else if (equation[index] == ')') count--;
                    index++;
                }

                if (count != 0) return false;
                else return true;
            }
        }

        static string BanWords(string banwords, string text)
        {
            string[] banWordsArray = banwords.Split(' ', ',');
            foreach(string item in banWordsArray)
            {
                if (text.Contains(item) && item != "")
                {
                    text = text.Replace(item, new string('*',item.Length));
                }
            }
            return text;
        }

        static void Main(string[] args)
        {
            //string input = Console.ReadLine();
            //input = input.ToLower();
            //string pattern = Console.ReadLine().ToLower();

            //Console.WriteLine(CountPatern(input, pattern));
            //Console.WriteLine(CountPatern("dyra byra", "yra"));


            //string listOfBeers = "Amstel, Zagorka, Tuborg/Becks.";
            //string[] beers = listOfBeers.Split(' ', ',', '.', '/');
            //Console.WriteLine("Available beers are:");

            //foreach (string beer in beers)
            //    Console.WriteLine(beer);


            //              По важни методи и свойства на класа System.String:
            //              Length – връща дължината на низа
            //              Equals(string) – сравнява низа с друг низ
            //              Compare(string, string) – сравнява два низа лексикографски един с друг(прави се разлика между малки и главни букви)
            //              оператори == и != – също сравняват низове
            //              оператори + и += – слепват низове
            //              this[int] – индексатор, който връща символа на зададената позиция(броенето започва от 0)
            //              StartsWith(string) – проверява дали низът започва с посочения низ
            //              EndsWith(string) – проверява дали низът завършва с посочения низ
            //              Substring(int startIndex, int Length) – извлича подниз по дадено начало и дължина
            //              IndexOf(string) – връща позицията на първото срещане на посочения низ или - 1.
            //              LastIndexOf(string str) – връща позицията на последното срещане на посочения низ
            //              Split(params char[]) – разделя низа на множество от низове спрямо зададена група разделящи символи
            //              Join(string, string[]) – слепва поредица от низове посредством зададен разделител
            //              Format(string, params object[]) – връща низ, получен чрез замяна на форматиращите идентификатори с посочените за тях стойности(като Console.WriteLine(…))
            //              PadLeft(int, char) – подравнява отляво до посочената дължина със зададения символ
            //              PadRight(int, char) – подравнява отдясно до посочената дължина със зададения символ
            //              Trim(params char[]) – изтрива всички зададени символи от началото и края на низа
            //              ToLower()  – заменя всички главни букви със съответните им малки, обратно на ToUpper()
            //              Insert(int index, string) – връща нов низ, получен чрез вмъкване на посочения низ преди зададената позиция
            //              Remove(int index, int count) – връща нов низ, получен чрез премахване на зададена поредица от символи
            //              Replace(string oldVal, string newVal) – връща низ, получен чрез замяна на всички срещания на даден низ с даден друг низ


            //Напишете програма, която проверява дали в даден аритметичен
            //израз скобите са поставени коректно. Пример за израз с коректно
            //поставени скоби: ((a + b) / 5 - d).Пример за некоректен израз: )(a + b)).

            string izraz1 = "((a + b) / 5 - d)";

            if(CheckMath(izraz1))
                Console.WriteLine("good");
            else
                Console.WriteLine("bad");

            string banWords = "Windows, Linux";
            string text = "It is not Linux, it is GNU/Linux. Linux is merely the kernel, while GNU adds the functionality...";

            Console.WriteLine(BanWords(banWords,text));

            Console.ReadKey();
        }
    }
}
