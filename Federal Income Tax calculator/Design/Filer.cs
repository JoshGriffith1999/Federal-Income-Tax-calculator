using System;
using System.Collections.Generic;
using System.Text;

namespace Federal_Income_Tax_calculator
{
	public class Filer
	{
		private double Final_Tax = 0;
        private double calc_capital_gain_tax = 0;
        private double Income = 0;
		private string Name = null;

		public void Set_Name()
		{
            Console.WriteLine("Please Enter Your Name: \t");
            this.Name = Console.ReadLine();
		}

        public void getName() {

            Console.WriteLine(this.Name);
        }

		public void Set_Income()
		{
            double income = 0;
            double interest = 0;
            double lottery = 0;

            Console.WriteLine("Please Enter your income or wages");
            income = double.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter any interest gained");
            interest = double.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter any lottery winnings");
            lottery = double.Parse(Console.ReadLine());

            this.Income = income + interest + lottery;
        }

        public void Calc_Deductions() {

            double TaxesWithHeld = 0;
            double student_loan_interest = 0;
            double k_Payments = 0;
            double morgage_interest = 0;

            Console.WriteLine("Please Enter any taxes already with held");
            TaxesWithHeld = double.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter any student loan interest");
            student_loan_interest = double.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter any 401(k) payments");
            k_Payments = double.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter any morgage interest");
            morgage_interest = double.Parse(Console.ReadLine());

            calc_capital_gain();

            if (morgage_interest > 750000)
                morgage_interest = 750000;

            this.Income = this.Income - (TaxesWithHeld + student_loan_interest + k_Payments + morgage_interest);

        }

        public void Calc_Deductions(double Standard_Deduction)
		{
            double TaxesWithHeld = 0;
            double student_loan_interest = 0;
            double k_Payments = 0;
            double morgage_interest = 0;           

            
                    Console.WriteLine("Please Enter any taxes already with held");
                    TaxesWithHeld = double.Parse(Console.ReadLine());

                    Console.WriteLine("Please Enter any student loan interest");
                    student_loan_interest = double.Parse(Console.ReadLine());

                    Console.WriteLine("Please Enter any 401(k) payments");
                    k_Payments = double.Parse(Console.ReadLine());

                    Console.WriteLine("Please Enter any morgage interest");
                    morgage_interest = double.Parse(Console.ReadLine());

                    calc_capital_gain();

                    if (morgage_interest > 750000)
                        morgage_interest = 750000;

                    this.Income = this.Income - (TaxesWithHeld +  Standard_Deduction + student_loan_interest + k_Payments + morgage_interest);


            }

		public void set_Calc_Exemption()
		{
            double child_dependents = 0;
            double non_child_dependents = 0;

            Console.WriteLine("How many child dependents do you have? ");
            child_dependents = double.Parse(Console.ReadLine());

            Console.WriteLine("How any non-child dependents do you have?");
            non_child_dependents = double.Parse(Console.ReadLine());

            this.Income = this.Income - ((child_dependents * 2000) + (non_child_dependents * 500));
        }

        public double getIcome() {
            return this.Income;
        }

        public void setFinalTax(double tax) {
            this.Final_Tax = tax;
        }
        public void getFinalTax(double x) {

            Console.WriteLine((this.Final_Tax * x) + this.calc_capital_gain_tax);
        }

        //Use this function only to compare the final tax to a value of zero
        //Did it this way since I can't convert a double to a string because of size differences
        public double LookFinalTax() {
            return this.Final_Tax + this.calc_capital_gain_tax;
        }

        public double calc_capital_gain() {

            double bracket1 = 39375;
            double bracket2 = 434550;
            double hold = this.calc_capital_gain_tax;
            double tax = 0;

            Console.WriteLine("Enter amount for money gained by selling anything ");
            this.calc_capital_gain_tax = double.Parse(Console.ReadLine());


            /*
             Bracket 1 for capital gains is interesting because the tax rate it 0% meaning
             our capital gains tax is zero if it doesn't go any higher than that
             */
            if (hold > bracket1)
                hold -= bracket1;
            else
                return 0;
            if (hold > bracket2)
            {
                hold -= bracket2;
                tax = tax + (bracket2 * 0.15);
            }

            else
            {
                tax = tax + (hold * 0.12);
                return 0;
            }

            tax = tax + (hold * 0.28);
            return 0;
        }
	}
}
