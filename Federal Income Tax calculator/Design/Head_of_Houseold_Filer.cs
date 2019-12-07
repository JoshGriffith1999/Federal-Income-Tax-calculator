using System;
using System.Collections.Generic;
using System.Text;

namespace Federal_Income_Tax_calculator
{
     public class Head_of_Houseold_Filer : Filer
	{
        public Head_of_Houseold_Filer() {

            base.Set_Name();
            base.Set_Income();
            base.Calc_Deductions(12000);
            base.set_Calc_Exemption();
            this.calc_final_tax();

            if (base.LookFinalTax() > 0)
            {
                base.getName();
                Console.WriteLine("You owe ");
                base.getFinalTax();
                Console.WriteLine("In taxes");
            }

            else
            {
                base.getName();
                Console.WriteLine("You will get ");
                base.getFinalTax();
                Console.WriteLine(" back in as return");

            }
        }

        private double calc_final_tax()
        {

            double temp = base.getIcome();
            double final = 0;

            double bracket1 = 14100;
            double bracket2 = 53700;
            double bracket3 = 85500;
            double bracket4 = 163300;
            double bracket5 = 207350;
            double bracekt6 = 518400;

            //Bracket 1
            if (temp > bracket1)
            {
                temp -= bracket1;
                final = 9875 * 0.10;
            }

            else
            {

                base.setFinalTax(final = temp * 0.10);
                return 0;


            }

            //Bracket 2
            if (temp > bracket2)
            {
                temp -= bracket2;
                final = final + (bracket2 * 0.12);

            }

            else
            {
                base.setFinalTax(final + (temp * 0.12));
                return 0;
            }

            //Bracket 3
            if (temp > bracket3)
            {
                temp -= bracket3;
                final = final + (bracket3 * 0.22);
            }

            else
            {
                base.setFinalTax(final + (temp * 0.22));
                return 0;

            }

            //Bracket 4
            if (temp > bracket4)
            {
                temp -= bracket4;
                final = final + (bracket4 * 0.24);
            }
            else
            {
                base.setFinalTax(final + (temp * 0.24));
                return 0;
            }

            //Bracket 5
            if (temp > bracket5)
            {
                temp -= bracket5;
                final = final + (bracket5 * 0.32);
            }
            else
            {
                base.setFinalTax(final + (temp * 0.32));
                return 0;
            }

            //Bracket 6
            if (temp > bracekt6)
            {
                final = final + (bracekt6 * 0.35);
                temp -= bracekt6;
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


    }//class ending
}//name space ending
