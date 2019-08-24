//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "PrimeNumber.cs" company ="Bridgelabz">
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
    class PrimeNumber
    {
        public static void IsPrimeNumber()
        {
            try
            {
                Console.WriteLine("please enter the from you want to start prime number");
                int start = Utility.ReadInteger();
                Console.WriteLine("please enter the number till that you want to print prime number");
                int end = Utility.ReadInteger();
                Boolean isPrime = true;
                for (int i = start; i <= end; i++)
                {
                    for (int j = 2; j <= i / 2; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                        if( i == 0 || i == 1)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        Console.Write(i + ", ");
                    }
                    isPrime = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
