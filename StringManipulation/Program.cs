using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    class Program
    {
        //1 - Дадени са текст и низ от забранени думи. Да се заменят всички забранени думи в текста със звездички(*), чийто брой е
        //равен на дължината на думата.
        //Input: Linux, Windows
        //Input: It is not Linux, it is GNU/Linux. Linux is merely тhe kernel, while GNU adds the functionality...
        //Output: It is not *****, it is GNU/*****. ***** is merely тhe kernel, while GNU adds the functionality...
        static string BanWords(string banwords, string text)
        {
            string[] banWordsArray = banwords.Split(' ', ',');
            foreach (string item in banWordsArray)
            {
                if (text.Contains(item) && item != "")
                {
                    text = text.Replace(item, new string('*', item.Length));
                }
            }
            return text;
        }
        //2 - Да се намери броят гласни букви в текста. В английския език гласните са A, E, O, U и I
        //Input: "hello"
        //Output: 2
        static int CountVowels(string str)
        {
            if (str == null)
                return 0;
            int count = 0;
            string vowels = "aoeui";
            str = str.ToLower();
            foreach (var ch in str) //for(int i=0;i<str.Length;i++){}
            {                
                //if (ch == 'a' || ch == 'o' || ch == 'e' || ch == 'u' || ch == 'i')
                //    count++;
               if(vowels.IndexOf(ch) != -1)
                    count++;
            }
            return count;
        }

        //3-	Да се преобърне(реверсира) стринг.
        //Input: "hello"
        //Output: "olleh"
        static string Reverse(string str)   //unefficient realisation, we'll try again later with String Builder
        {
            if (str == null)
                return "";

            string reversed = "";
            for (int i = str.Length - 1; i >= 0; i--)
                reversed += str.ElementAt(i);
            return reversed;
        }

        //4-	Да се преобърнат отзад напред думите в дадено изречение.
        //Input: "Trees are beautiful"
        //Output: "beautiful are Trees"
        static string ReverseWords(string str)    //unefficient realisation, we'll try again later with String Builder
        {
            string[] words = str.Split(' ');
            string reversedWords = "";
            for (int i = words.Length-1; i >= 0; i--)
            {
                reversedWords += words[i]+" ";                  
            }
            reversedWords.Remove(reversedWords.Length - 1, 1);
            return reversedWords;
        }
        
        //5-	Да се провери дали даден стринг е ротация на друг
        //Input: "ABCD", "DABC" (ротиран е последният символ надясно)
        //Output: true

        //Input: “ABCD”, “CDAB” (ротирани са последните два символа надясно)
        //Output: true

        //Input: “ABCD", “ADBC"                                                     
        //Output: false
        static bool AreRotation(string str1, string str2)
        {
            if (str1.Length != str2.Length)
                return false;

            string str = str1 + str1;
            if (! str.Contains(str2))
                return false;

            return true;
        }

        //6-Да се изтрият дублиращите се символи в стринг
        //Input: “Hellooo!!"
        //Output: “Helo!"
        static string RemoveDuplocates(string str)
        {
            string result = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (!result.Contains(str[i]))
                    result += str[i];
            }

            return result;
        }       

         //7-Да се капитализира(преобърне в главна буква) всяка първа буква на всяка дума в изречението.
        //Input: "trees are beautiful"
        //Output: “Trees Are Beautiful"
        static string CapitaliseWords(string str)
        {
            //remove extra spaces at the beggining and at the end of the sentece. 
            str = str.Trim();
            
            string[] words = str.Split(' ');             
            
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] != "")
                    words[i] = words[i].Substring(0, 1).ToUpper() + words[i].Substring(1).ToLower();
            }

            return string.Join(" ", words);
        }

        //8 - Да се създаде програма, с която се иска от потребителя да въведе няколко думи, разделени с интревал. Да се използват тези думи 
        // за създаване именa на променлива в PascalCase конвенция. Ако не се въведе нищо, да се изведе: Error 
        // Input: number of students
        // Output: NumberOfStudents

        //Input: NUMBER OF STUDENTS
        // Output: NumberOfStudents

        //Input: NUmbER OF studENTS
        // Output: NumberOfStudents

        static void VariableName()
        {
            Console.Write("Enter a few words: ");
            string input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error");
                return;
            }

            string variableName = "";
            foreach (var word in input.Split(' '))      //input.Split(' ') generates a string array
            {
                var wordWithPascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                variableName += wordWithPascalCase;
            }

            Console.WriteLine(variableName);
        }


        //9 -  Да се провери дали два стринга са анаграми един на друг (т.е.дали съдържат едни и същи букви в разбъркан ред).
        //Input: "abcd", "adbc"         Output: true
        //Input: "abcd", "cadb"         Output: true    
        //Input: "abcd", "abcd"         Output: true 
        //Input: "abcd", "abce"         Output: false

        static bool AreAnagrams(string str1, string str2)
        {
            str1=str1.ToLower();
            str2=str2.ToLower();

            char[] array1 = str1.ToCharArray();
            Array.Sort(array1);

            char[] array2 = str2.ToCharArray();
            Array.Sort(array2);

            if (array1.Length != array2.Length)
                return false;

            bool result = true;            
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

        //10 - Да се провери дали даден стринг е палиндром(стринг, който се чете по еднакъв начин отпред назад и отзад напред). 
        //Input: "abba"         Output: true
     
        //Input: "abcba"        Output: true

        //Input: "abca"         Output: false

            static bool IsPalindrom(string input)
        {
            string reversed = input;
            reversed=Reverse(input);
            
            return input == reversed;
        }

        //string exersice application:
        static void Main(string[] args)
        {
            string str="Hello world!";
            Console.WriteLine("The number of vowels in \"{0}\" is {1}", str, CountVowels(str));
            Console.WriteLine("The reverse string of the \"{0}\" is {1}", str, Reverse(str));
            Console.WriteLine("The reversed words string of the \"{0}\" is {1}", str, ReverseWords(str));            
            Console.WriteLine("Are the string \"{0}\" rotation of the string \"{1}\"? - The answer is: {2}", "abcd", "dabc", AreRotation("abcd", "dabc"));
            Console.WriteLine("After removeing duplicates the string \"{0}\" is: {1}", "Heello Wooorld", RemoveDuplocates("Heello Wooorld"));
            Console.WriteLine("The capitalisation of the sentense: \"{0}\" is \"{1}\"","  Trees are beautiful",CapitaliseWords("  Trees are beautiful"));
            //VariableName();
            Console.WriteLine("Are the string \"{0}\" and the string \"{1}\" anagrams? The answer is: {2}","ABCD", "BCDA", AreAnagrams("ABCD", "BCDa"));
            Console.WriteLine("Is this string {0} a palindrome? The answer is: {1}","abba",IsPalindrom("abba"));
            Console.ReadKey();
        }
    }
}
