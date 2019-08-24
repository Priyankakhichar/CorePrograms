//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "Utility.cs" company ="Bridgelabz">
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
    class Utility
    {
        public static int ReadInteger()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        public static double ReadDouble()
        {
            return Convert.ToDouble(Console.ReadLine());
        }
        public static String ReadString()
        {
            return Console.ReadLine();
        }
        public static void BinarySearchInteger(int[] arr, int lowerIndex, int higherIndex, int element)
        {
            int middle = (lowerIndex + higherIndex) / 2;
            while (lowerIndex <= higherIndex)
            {
                if (element < arr[middle])
                {
                    higherIndex = middle - 1;
                }
                else if (element == arr[middle])
                {
                    Console.WriteLine(element + " is at index " + middle);
                    break;
                }
                else
                {
                    lowerIndex = middle + 1;
                }
                middle = (lowerIndex + higherIndex) / 2;
            }
            if (lowerIndex > higherIndex)
            {
                Console.WriteLine("element not found");
            }
        }
        public static void BinarySearchString(string[] arr, string word)
        {
            int lowerIndex = 0;
            int higherIndex = arr.Length - 1;
            int middle = (lowerIndex + higherIndex) / 2;
            while (lowerIndex <= higherIndex)
            {

                int result = word.CompareTo(arr[middle]);
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
                middle = (lowerIndex + higherIndex) / 2;
            }
            if (lowerIndex > higherIndex)
            {
                Console.WriteLine("word not found");
            }
        }
        public static void InsertionSort()
        {
            int[] arr = { 2, 4, 5, 7, 9, 11, 1, 6 };
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
            Console.WriteLine("Insertion Sort");
            foreach (int e in arr)
            {
                Console.Write(e + " ");
            }
        }
        public static void InsertionSortString()
        {
            string[] arr = { "am", "i", "in", "bridge", "labz", "banglore" };
            for (int i = 1; i < arr.Length; i++)
            {
                string element = arr[i];
                int j = 0;
                for (j = i; j > 0; j--)
                {
                    if (element.CompareTo(arr[j - 1]) < 0)
                    {
                        arr[j] = arr[j - 1];
                    }
                    else
                    {
                        break;
                    }
                }
                arr[j] = element;
            }
            Console.WriteLine("Insertion Sort");
            foreach (string e in arr)
            {
                Console.Write(e + " ");
            }
        }
        public static void BubbleSort()
        {
            int[] arr = { 2, 15, 5, 37, 19, 11, 1, 6 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Bubble sorting");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }
        public static void BubbleSortString()
        {
            string[] arr = { "am", "i", "in", "bridge", "labz", "banglore" };
            for (int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if(arr[j].CompareTo(arr[j+1]) > 0)
                    {
                        string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Bubble sorting");
            foreach (string str in arr)
            {
                Console.Write(str + " ");
            }
        }
        public static int DayOfWeek(int d, int m, int y)
        {
            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + (31 * m0) / 12) % 7;
            return d0;
        }
        public static void TemperaturConversion(int temp)
        {
            // Celsius to Fahrenheit: (°C × 9 / 5) +32 = °F 
            //Fahrenheit to Celsius:   (°F − 32) x 5 / 9 = °C
            Console.WriteLine("please enter 1 if temperature you entered in Celsius and enter 2 if it is in Fahrenheit");
            int num = Utility.ReadInteger();
            if(num == 1)
            {
                temp = (temp * 9 / 5) + 32;
                Console.WriteLine("temp is in Fahrenheit is: " + temp);
            }
            else if(num == 2)
            {
                temp = (temp - 32) * 5 / 9;
                Console.WriteLine("temp is in Celsius is: " + temp);
            }
            else
            {
                Console.WriteLine("please enter a valid number");
            }
        }
        public static void MonthlyPayment()
        {
            Console.WriteLine("please enter the principle loan amount");
            double P = Utility.ReadDouble();
            Console.WriteLine("please enter the the no of years for loan");
            double Y = Utility.ReadDouble();
            Console.WriteLine("please enter the interest rate");
            double R = Utility.ReadDouble();
            double n = 12 * Y;
            double r = R / (12 * 100);
            double payment = (P * r) / (1 - Math.Pow((1 + r), -n));
            Console.WriteLine("monthlyPayment is: " + payment);
        }
        public static void SqureRoot()
        {
            Console.WriteLine("please enter the number");
            double c = Utility.ReadDouble();
            double t = c;
            double epsilon = 1 * Math.Pow(10, - 15);
            while (Math.Abs(t - c / t) > epsilon * t)
            {
                t = (c / t + t) / 2;
                                                                                                                                                                                      }
            Console.WriteLine("square root is: " + t);
        }
        public static int[] ToBinary(int number)
        {
            string bin = "";
            while(number != 0)
            {
                bin = number % 2 + bin;
                number = number / 2;
            }
            while(bin.Length % 4 != 0)
            {
                    bin = 0 + bin;
            }
            return StringToIntArray(bin);
        }
        static int[] StringToIntArray(string bin)
        {
            char[] chars = bin.ToCharArray();
            int[] binary = new int[bin.Length];
            for(int i = 0; i < bin.Length; i++)
            {                                                                                                                                                                                               
                binary[i] = chars[i] - 48;
            } 
            return binary;
        }
        public static int[] Binary(int number)
        {
            string bin = "";
            while (number != 0)
            {
                bin = number % 2 + bin;
                number = number / 2;
            }
            while (bin.Length % 4 != 0)
            {
                bin = 0 + bin;
            }
            Console.WriteLine("before swaping : " + bin);
            int[] beforeSwap = StringToIntArray(bin);
            Console.WriteLine("before swaping decimal number is "+ ToDecimal(beforeSwap));
            string str1 = bin.Substring(0, bin.Length / 2);
            string str2 = bin.Substring(bin.Length / 2 );
            bin = str2 + str1;
            int[] afterSwap = StringToIntArray(bin);
            Console.WriteLine("after swaping: " + bin);
            Console.WriteLine("after swaping decimal number is " + ToDecimal(afterSwap));
            return StringToIntArray(bin);
        }
        static int ToDecimal(int[] binary)
        {
            int dec = 0, j = 0;
            for (int i = binary.Length - 1; i >= 0; i--)
            {
                if (binary[i] == 1)
                {
                    dec = dec + (int)Math.Pow(2, j);
                }
                j++;
            }
            return dec;
        }
       public static int[] MergeSort(int[] array, int start, int end)
        {
            if (start < end)
            {
                int middle = (end + start) / 2;
                int[] leftArr = MergeSort(array, start, middle);
                int[] rightArr = MergeSort(array, middle + 1, end);
                int[] mergedArr = MergeArray(leftArr, rightArr);
                return mergedArr;
            }
            return new int[] { array[start] };
        }

        public static int[] MergeArray(int[] leftArr, int[] rightArr)
        {
            int[] mergedArr = new int[leftArr.Length + rightArr.Length];
            int leftIndex = 0;
            int rightIndex = 0;
            int mergedIndex = 0;
            while (leftIndex < leftArr.Length && rightIndex < rightArr.Length)
            {
                if (leftArr[leftIndex] < rightArr[rightIndex])
                {
                    mergedArr[mergedIndex++] = leftArr[leftIndex++];
                }
                else
                {
                    mergedArr[mergedIndex++] = rightArr[rightIndex++];
                }
            }
            while (leftIndex < leftArr.Length)
            {
                mergedArr[mergedIndex++] = leftArr[leftIndex++];
            }
            while (rightIndex < rightArr.Length)
            {
                mergedArr[mergedIndex++] = rightArr[rightIndex++];
            }
            return mergedArr;
        }
    }
}
