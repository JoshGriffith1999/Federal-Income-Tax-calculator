using System;
using System.Collections.Generic;
using System.Text;

namespace Federal_Income_Tax_calculator
{
	public class Married_File_Seperatly : Filer
	{
        //You may notice that the bracket for married-Speratly and Single Filer are the same
        //this is very true however,except bracket 6 where its 311025 instead of 518400
        //I need them to stay seperate that way the four filing status can be available
        public Married_File_Seperatly()
        {
            base.Set_Name();
            base.Set_Income();
            base.Calc_Deductions();
            base.set_Calc_Exemption();
            this.calc_final_tax();




            base.getName();
            Console.WriteLine("You owe ");
            base.getFinalTax();
            Console.WriteLine("In taxes");
        }
        private double calc_final_tax()
        {

            double temp = base.getIcome();
            double final = 0;

            //Bracket 1
            if (temp > 9875)
            {

                final = 9875 * 0.10;
                temp -= 9875;
            }

            else
            {

                base.setFinalTax(final = temp * 0.10);
                return 0;


            }

            //Bracket 2
            if (temp > 40125)
            {

                final = final + (40125 * 0.12);
                temp -= 40125;

            }

            else
            {
                base.setFinalTax(final + (temp * 0.12));
                return 0;
            }

            //Bracket 3
            if (temp > 85545)
            {
                final = final + (85545 * 0.22);
                temp -= 85545;
            }

            else
            {
                base.setFinalTax(final + (temp * 0.22));
                return 0;

            }

            //Bracket 4
            if (temp > 163300)
            {
                final = final + (163300 * 0.24);
                temp -= 163300;
            }
            else
            {
                base.setFinalTax(final + (temp * 0.24));
                return 0;
            }

            //Bracket 5
            if (temp > 207350)
            {
                final = final + (207350 * 0.32);
                temp -= 207350;
            }
            else
            {
                base.setFinalTax(final + (temp * 0.32));
                return 0;
            }

            //Bracket 6
            if (temp > 311025)
            {
                final = final + (311025 * 0.35);
                temp -= 311025;
            }
            else
            {
                base.setFinalTax(final + (temp * 0.35));
                return 0;
            }

            //Bracket 7 - this one is special in the sense that so matter how much you make after bracket 6 your still going to be taxed at 37%
            base.setFinalTax(final + (temp * 0.37));
            

            return 0;
        }
        
    }
}
