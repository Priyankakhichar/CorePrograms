//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "VendingMachine.cs" company ="Bridgelabz">
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
    class VendingMachine
    {
        static int i = 0;
        static int total = 0;
        static int[] notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };
        static int money = Utility.ReadInteger();
        public static int Calculate()
        {
            int rem;
            if (money == 0)
            {
                return total;
            }
            else
            {
                if (money >= notes[i])
                {
                    int calNotes = money / notes[i];
                    rem = money % notes[i];
                    money = rem;
                    total += calNotes;
                    Console.WriteLine(notes[i] + " Notes ---> " + calNotes);
                }
                i++;
                return Calculate();
            }
        }
    }
}
