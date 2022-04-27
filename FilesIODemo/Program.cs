using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesIODemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath =@"c:\FilesDemo\test.txt";
            
            //class File:
            
            //var lines = File.ReadAllLines(filePath);

            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList();

            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }

            lines.Add("John, Doe, nobody@nobody.com");

            File.WriteAllLines(@"c:\FilesDemo\test1.txt", lines);            

            File.Copy(filePath, @"c:\FilesDemo\test2.txt", true);

            #region exercises
            //exersice 1:
            string exercise1 = File.ReadAllText(filePath);
            string[] words = exercise1.Split(',');
            Console.WriteLine("There are {0} words in the file", words.Length);

            //exersice 2:
            int longestIndex = 0;
            int longestLength = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > longestLength)
                {
                    longestLength = words[i].Length;
                    longestIndex = i;
                }
            }

            Console.WriteLine("The longest word is {0}", words[longestIndex]);
            #endregion

            //class FileInfo:
            FileInfo fileInfo = new FileInfo(filePath); //fileInfo <- test.txt
            fileInfo.CopyTo(@"c:\FilesDemo\test3.txt",true);
            
            //....
            Console.ReadKey();
        }
    }
}
