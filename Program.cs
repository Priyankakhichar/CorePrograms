//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "Program.cs" company ="Bridgelabz">
//Copyright © 2019 company ="Bridgelabz"
//</copyright>
//<creator name ="Priyanka khichar"/>
//
//-------------------------------------------------------------------------------------------------------------------------------
namespace AlgorithmPrograms
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] arr = { 2, 4, 5, 7, 9, 11};
                string[] str = { "am", "bridge", "banglore", "in", "i", "labz" };
                int element;
                string word;
                List<TimeSpan> list = new List<TimeSpan>();
                Console.WriteLine("1.Anagram");
                Console.WriteLine("2.PrimeNumber");
                Console.WriteLine("3.PrimePalindrom");
                Console.WriteLine("4.BinarySearch");
                Console.WriteLine("5.BinarySearchString");
                Console.WriteLine("6.InsertionSort");
                Console.WriteLine("7.InsertionSortString");
                Console.WriteLine("8.BubbleSort");
                Console.WriteLine("9.BubbleSortString");
                Console.WriteLine("10.QuestionToFindNumber");
                Console.WriteLine("11.BinarySearchOfWord");
                Console.WriteLine("12.InsertionSortWord");
                Console.WriteLine("13.BubbleSort");
                Console.WriteLine("14.VendingMachine");
                Console.WriteLine("15.DayOfWeek");
                Console.WriteLine("16.TemperaturConversion");
                Console.WriteLine("17.​MonthlyPayment");
                Console.WriteLine("18.SqueRoot");
                Console.WriteLine("19.ToBinary");
                Console.WriteLine("20.Binary");
                Console.WriteLine("21.ElapsedTime");
                Console.WriteLine("21.MergeSort");
                int choice;
                   Console.WriteLine("please enter the choice");
                   choice = Utility.ReadInteger();
                    switch (choice)
                    {
                        case 1: Anagram.IsAnagram();
                                break;
                        case 2: PrimeNumber.IsPrimeNumber();
                                break;
                        case 3: PrimePalindrom.IsPrimeNumber();
                                break;
                        case 4: Console.WriteLine("please enter the element you want to serach");
                                Utility.BinarySearchInteger(arr, 0, arr.Length-1, element = Utility.ReadInteger());
                                break;
                        case 5: Console.WriteLine("please enter the word you want to search");
                                Utility.BinarySearchString(str, word = Utility.ReadString());
                                break;
                        case 6: Utility.InsertionSort();
                                break;
                        case 7: Utility.InsertionSortString();
                                break;
                        case 8: Utility.BubbleSort();
                                break;
                        case 9: Utility.BubbleSortString();
                                break;
                        case 10: QustionToFindNumber.FindNumber();
                                 break;
                        case 11: BinarySearchOfWords.BinarySearchWord();
                                 break;
                        case 12: InsertionSortWord.InsertionSort();
                                 break;
                        case 13: BubbleSort.BubbleSortInteger();
                                 break;
                        case 14: Console.WriteLine("please enter the money");
                                 int i = VendingMachine.Calculate();
                                 Console.WriteLine("total no of notes " + i);
                                 break;
                        case 15: Console.WriteLine("please enter the year");
                                 int year = Utility.ReadInteger();
                                 Console.WriteLine("plaese enter the month");
                                 int month = Utility.ReadInteger();
                                 Console.WriteLine("please enter the date");
                                 int date = Utility.ReadInteger();
                                 int dayOfWeek = Utility.DayOfWeek(date, month, year);
                                 Console.WriteLine("day of week is: " + dayOfWeek);
                                 break;
                        case 16: Console.WriteLine("please enter the temprature");
                                 int temp = Utility.ReadInteger();
                                 Utility.TemperaturConversion(temp);
                                 break;
                        case 17: Utility.MonthlyPayment();
                                 break;
                        case 18: Utility.SqureRoot();
                                 break;
                        case 19: Console.WriteLine("please enter the number");
                                 int[] arrOfBinary =  Utility.ToBinary(Utility.ReadInteger());
                                 foreach(int num in arrOfBinary)
                                  {
                                      Console.Write(num + " ");
                                  }
                                 break;
                        case 20: Console.WriteLine("please enter the number");
                                 int[] binaryArray = Utility.Binary(Utility.ReadInteger());
                                 break;
                        case 21: Util.ElapsedTime();
                                 break;
                        case 22: int[] mergeArray = { 5, 7, 11, 3, 2, 9 };
                                 Console.WriteLine("before sorting "+string.Join(",", mergeArray));
                                 int[] array1 = Utility.MergeSort(mergeArray, 0, mergeArray.Length - 1);
                                 Console.WriteLine("after sorting " + string.Join(",", array1));
                                 break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
