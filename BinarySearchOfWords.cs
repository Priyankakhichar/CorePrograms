//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "BinarySearchOfWords.cs" company ="Bridgelabz">
//Copyright © 2019 company ="Bridgelabz"
//</copyright>
//<creator name ="Priyanka khichar"/>
//
//-------------------------------------------------------------------------------------------------------------------------------
namespace AlgorithmPrograms
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    class BinarySearchOfWords
    {
        private static string textFile = @"C:\Users\admin\source\repos\AlgorithmPrograms\test.txt";
        static string list1 = File.ReadAllText(textFile);
        static string[] list = list1.Split(" ");
        public static void BinarySearchWord()
        {
            Array.Sort(list);
            foreach (string l in list)
            {
                Console.Write(l + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("please enter the word that you want to search");
            string word = Utility.ReadString(); 
            int lowerIndex = 0;
            int higherIndex = list.Length - 1;
            int middle = (lowerIndex + higherIndex) / 2;
            while (lowerIndex <= higherIndex)
            {

                int result = word.CompareTo(list[middle]);
                if (result > 0)
                {
                    lowerIndex = middle + 1;
                }
                else if (result == 0)
                {
                    Console.WriteLine(word + " present at index " + middle);
                    break;
                }
                else
                {
                    higherIndex = middle - 1;
                }
                middle = (lowerIndex + higherIndex ) / 2;
            }
            if (lowerIndex > higherIndex)
            {
                Console.WriteLine("word not found");
            }
        }
    }
}
 