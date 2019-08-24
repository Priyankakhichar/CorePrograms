//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "BubbleSort.cs" company ="Bridgelabz">
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
    class BubbleSort
    {
        public static void BubbleSortInteger()
        {
            Console.WriteLine("please enter how many elements you want to insert");
            int n = Utility.ReadInteger();
            int[] arr = new int[n];
            for(int i=0; i < n; i++)
            {
                Console.WriteLine("please enter value");
                arr[i] = Utility.ReadInteger();
            }
            for(int i=0; i < arr.Length; i++)
            {
                for(int j=0; j < arr.Length - 1 - i; j++)
                {
                    if(arr[j] > arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("after sorting");
            foreach(int i in arr)
            {
                Console.WriteLine(i + " ");
            }
        }
    }
}
