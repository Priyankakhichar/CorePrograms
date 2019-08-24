//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "Anagram.cs" company ="Bridgelabz">
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
    class Anagram
    {
        public static void IsAnagram()
        {
            try
            {
                Console.WriteLine("please Enter the String");
                string s1 = Utility.ReadString();
                Console.WriteLine("please enter another String");
                string s2 = Utility.ReadString();
                if (s1.Length != s2.Length)
                {
                    Console.WriteLine("Strings are not anagrams");
                }
                else
                {
                    s1 = Sort(s1);
                    s2 = Sort(s2);
                    if (s1.Equals(s2))
                    {
                        Console.WriteLine("Strings are anagrams to each other");
                    }
                    else
                    {
                        Console.WriteLine("Strings are not anagrams");
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
             }
        }
        public static String Sort(string s1)
        {
            try
            {
                char[] c1 = s1.ToCharArray();
                for (int i = 0; i < c1.Length; i++)
                {
                    for (int j = i + 1; j < c1.Length; j++)
                    {
                        if (c1[i] > c1[j])
                        {
                            char temp = c1[i];
                            c1[i] = c1[j];
                            c1[j] = temp;
                        }
                    }
                }
                return new string(c1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }
    }
}
