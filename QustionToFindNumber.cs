//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "QustionToFindNumber.cs" company ="Bridgelabz">
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
    class QustionToFindNumber
    {
        public static void FindNumber()
        {
            Console.WriteLine("please enter the value");
            int n = Utility.ReadInteger();
            int N =(int)Math.Pow(2, n);
            Console.WriteLine("think the number between 0 to " + (N-1));
            int[] arr = new int[N];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }
            int lower = 0;
            int higher = arr.Length - 1;
            int middle = (lower + higher) / 2;
            int count = 0;
            Console.WriteLine("is your number " + arr[middle]);
            Console.WriteLine("please enter 'yes' if it is your number, write 'low' if your number is less then or write 'high' if your number is high");
            while (lower <= higher)
            { 
                string input = Utility.ReadString();
                if (input.Equals("low"))
                {
                    higher = middle - 1;
                    count++;
                }
                else if(input.Equals("yes"))
                {
                    Console.WriteLine(arr[middle] + " is the number you thought");
                    Console.WriteLine("it takes " + (count + 1) + " time to find the number");
                    break;
                }
                else if(input.Equals("high"))
                {
                    lower = middle + 1;
                    count++;
                }
                if (count <= n)
                {
                    middle = (lower + higher) / 2;
                    Console.WriteLine("is your number " + arr[middle]);
                }
            }
            if(lower > higher)
            {
                Console.WriteLine("number not found");
            }
        }
    }
}
