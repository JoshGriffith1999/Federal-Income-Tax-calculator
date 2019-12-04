using System;
using System.Collections.Generic;
using System.Text;

namespace Federal_Income_Tax_calculator
{
    public class Married_File_Jointly : Filer
    {

        public Married_File_Jointly()
        {
            Console.WriteLine("Note before you add in anything add your income, deductions, independednts etc before enetering - THANKS!");
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
            if (temp > 19750)
            {

                final = 19750 * 0.10;
                temp -= 19750;
            }

            else
            {

                base.setFinalTax(final = temp * 0.10);
                return 0;


            }

            //Bracket 2
            if (temp > 80250)
            {

                final = final + (80250 * 0.12);
                temp -= 80250;

            }

            else
            {
                base.setFinalTax(final + (temp * 0.12));
                return 0;
            }

            //Bracket 3
            if (temp > 171050)
            {
                final = final + (171050 * 0.22);
                temp -= 171050;
            }

            else
            {
                base.setFinalTax(final + (temp * 0.22));
                return 0;

            }

            //Bracket 4
            if (temp > 326600)
            {
                final = final + (326600 * 0.24);
                temp -= 326600;
            }
            else
            {
                base.setFinalTax(final + (temp * 0.24));
                return 0;
            }

            //Bracket 5
            if (temp > 414700)
            {
                final = final + (414700 * 0.32);
                temp -= 414700;
            }
            else
            {
                base.setFinalTax(final + (temp * 0.32));
                return 0;
            }

            //Bracket 6
            if (temp > 622050)
            {
                final = final + (622050 * 0.35);
                temp -= 622050;
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
