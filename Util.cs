//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "Util.cs" company ="Bridgelabz">
//Copyright © 2019 company ="Bridgelabz"
//</copyright>
//<creator name ="Priyanka khichar"/>
//
//-------------------------------------------------------------------------------------------------------------------------------
namespace AlgorithmPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Util
    {
        public static void ElapsedTime()
        {
            int[] arr = { 2, 4, 5, 7, 9, 11 };
            string[] str = { "am", "bridge", "banglore", "in", "i", "labz" };
            int element;
            string word;
            List<TimeSpan> list = new List<TimeSpan>();
                DateTime start = DateTime.Now;
                Console.WriteLine("please enter the element you want to serach");
                Utility.BinarySearchInteger(arr, 0, arr.Length - 1, element = Utility.ReadInteger());
                DateTime end = DateTime.Now;
                TimeSpan time = end - start;
                list.Add(time);
                start = DateTime.Now;
                Console.WriteLine("please enter the word you want to search");
                Utility.BinarySearchString(str, word = Utility.ReadString());
                end = DateTime.Now;
                time = end - start;
                list.Add(time);
                start = DateTime.Now;
                Utility.InsertionSort();
                end = DateTime.Now;
                time = end - start;
                list.Add(time);
                start = DateTime.Now;
                Utility.InsertionSortString();
                end = DateTime.Now;
                time = end - start;
                list.Add(time);
                start = DateTime.Now;
                Utility.BubbleSort();
                end = DateTime.Now;
                time = end - start;
                list.Add(time);
                start = DateTime.Now;
                Utility.BubbleSortString();
                end = DateTime.Now;
                time = end - start;
                list.Add(time);
            //sorting of time
                list.Sort((a, b) => b.CompareTo(a));
                Console.WriteLine();
            //printing array contents
                foreach(var times in list)
                {
                    Console.Write(times + ", ");
                } 

        }
    }
}
