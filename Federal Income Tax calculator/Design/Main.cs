﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Federal_Income_Tax_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = 0;
            Console.WriteLine("2019 - 2020 Federal Income TAX Calculator");
            Console.WriteLine("Enter filing status 1: Single 2: Married file Jointly 3: 3 Married filing speratly 4: Head of Household");
            Console.WriteLine("Filing status:");
            answer = Convert.ToInt32(Console.ReadLine());

            switch (answer)
            {

                case 1:
                    Single_Filer person = new Single_Filer();

                    break;
                case 2:
                    Married_File_Jointly person2 = new Married_File_Jointly();

                    break;
                case 3:
                    Married_File_Seperatly person3 = new Married_File_Seperatly();

                    break;

                case 4:
                    Head_of_Houseold_Filer person4 = new Head_of_Houseold_Filer();

                    break;

            }

            Thread.Sleep(30000);
        }//main end
    }//class end
}//namespace end
