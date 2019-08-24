//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "InsertionSortWord.cs" company ="Bridgelabz">
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
    using System.Linq;
    class InsertionSortWord
    {
       public static void InsertionSort()
        {
            Console.WriteLine("how many elements you want to add to string array");
            int numberOfElements = Utility.ReadInteger();
            string[] str = new string[numberOfElements];
            for (int i = 0; i < numberOfElements; i++)
            {
                Console.WriteLine("please enter the element");
                str[i] = Console.ReadLine();
            }
            for(int i = 1; i < numberOfElements; i++)
            {
                string key = str[i];
                int j = i - 1;
                while( j >= 0  && str[j].CompareTo(key) > 0)
                {
                    str[j+1] = str[j];
                    j--;
                }
                str[j + 1] = key;
            }
            Console.WriteLine("after sorting");
            foreach(string e in str)
            {
                Console.Write(e + " ");
            }
        }
    }
}
