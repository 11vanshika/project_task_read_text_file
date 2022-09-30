using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"..\..\..\File.txt";
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);

            // Print file name and Extension
            FileInfo name = new FileInfo(path);
            string fileName = name.Name;
            string fileExtension = name.Extension;
            Console.WriteLine("File name : " + fileName);
            Console.WriteLine("File Extension : " + fileExtension);

            // All Word Count 
            int wordCount = 0;
            for (int i = 0; i <= readText.Length - 1; i++)
            {
                if (readText[i] == ' ')
                {
                    wordCount++;
                }
            }

            Console.WriteLine("Total words is : " + wordCount);
            // ------------------ copy text file one folder  to another folder -------------------//
            string sourceFile = @"..\..\..\File.txt";
            string destinationFile = @"..\..\..\File1.txt";
            File.Copy(sourceFile, destinationFile, true);

            //----------------------------- Delete Command---------------------------//
            File.Delete(@"..\..\..\File1.txt");

           //-------------------------- Again Copy --------------------------------//
            File.Copy(sourceFile, destinationFile, true);
        }
    }
}
