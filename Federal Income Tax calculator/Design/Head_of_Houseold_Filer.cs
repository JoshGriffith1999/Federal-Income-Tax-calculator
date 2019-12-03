using System;
using System.Collections.Generic;
using System.Text;

namespace Federal_Income_Tax_calculator
{
     public class Head_of_Houseold_Filer : Filer
	{
        public Head_of_Houseold_Filer() {
            base.setFinalTax(0);
        }
       private float calc_final_tax() {

            float temp = base.getIcome();
            float final = 0;

            if (temp > 14100)
            {

                final = 14100.00 * 0.10;
                temp -= 14100;
            }

            else {

                base.setFinalTax(final = temp * 0.10);
                return 0;


            }

            if (temp > 53700)
            {

                final = final + (53700 * 0.12);
                temp -= 53700;

            }

            else {
                base.setFinalTax(final + (temp * 0.12));
                return 0;
            }

            if (temp > 85500)
            {
                final = final + (85500 * 0.22);
                temp -= 85500;
            }

            else {
                base.setFinalTax(final + (temp * 0.22));
                return 0;

            }

            if (temp > 163300)
            {
                final = final + (163300 * 0.24);
                temp -= 163300;
            }
            else {
                base.setFinalTax(final + (temp * 0.24));
                return 0;
            }

            if (temp > 207350)
            {
                final = final + (207350 * 0.32);
                temp -= 207350;
            }
            else {
                base.setFinalTax(final + (temp * 0.32));
                return 0;
            }

            if (temp > 518500)
            {
                final = final + (518500 * 0.35);
                temp -= 51500;
            }
            else {
                base.setFinalTax(final + (temp * 0.35));
                return 0;
            }
            if (temp > 518500) {
                base.setFinalTax(final + (temp * 0.37));
            }
        }
        public void setInfo()
        {

            base.Set_Name();
            base.Set_Income();
            base.Calc_Deductions();
            base.set_Calc_Exemption();
            this.calc_final_tax();
        }

        public void displayFinal() {

            base.getName();
            Console.WriteLine("You owe ");
            base.getFinalTax();
            Console.WriteLine("In taxes");
        }

    }//class ending
}//name space ending
