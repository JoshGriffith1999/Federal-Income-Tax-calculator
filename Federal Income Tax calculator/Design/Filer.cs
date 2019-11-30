using System;
using System.Collections.Generic;
using System.Text;

namespace Federal_Income_Tax_calculator
{
	public class Filer
	{
		private float Final_Tax;
		private float Income;
		private float Standard_Deduction = 12000;
		private string Name;

		private void Set_Name()
		{
            Console.WriteLine("Please Enter Your Name: ");
            this.Name = Console.ReadLine();
		}

		public void Set_Income()
		{
            float income = 0;
            float alimony = 0;
            float interest = 0;
            float lottery = 0;

            Console.WriteLine("Please Enter your income or wages");
            income = float.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter any alimony earnings");
            alimony = float.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter any interest gained");
            interest = float.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter any lottery winnings");
            lottery = float.Parse(Console.ReadLine());

            this.Income = income + alimony + interest + lottery;
        }

		public void Calc_Deductions()
		{
            float IRA = 0;
            float student_loan_interest = 0;
            float alimony_Payments = 0;
            float moving_expense = 0;
            int option = 0;

            Console.WriteLine("Enter 1 for standard deduction or 2 for itemized deduction");
            option = Convert.ToInt32(Console.ReadLine());

            if (option == 1)
            {

                this.Income = this.Income - this.Standard_Deduction;
            }

            else {
                Console.WriteLine("Please Enter any IRA contributions you have made");
                IRA = float.Parse(Console.ReadLine());

                Console.WriteLine("Please Enter any student loan interest");
                student_loan_interest = float.Parse(Console.ReadLine());

                Console.WriteLine("Please Enter any alimony payments");
                alimony_Payments = float.Parse(Console.ReadLine());

                Console.WriteLine("Please Enter any moving expenses");
                moving_expense = float.Parse(Console.ReadLine());

                this.Income = this.Income - (IRA + student_loan_interest + alimony_Payments + moving_expense);

            }


        }

		public void set_Calc_Exemption()
		{
            float child_dependents = 0;
            float non_child_dependents = 0;

            Console.WriteLine("How many child dependents do you have? ");
            child_dependents = float.Parse(Console.ReadLine());

            Console.WriteLine("How any non-child dependents do you have?");
            non_child_dependents = float.Parse(Console.ReadLine());

            this.Income = this.Income - ((child_dependents * 2000) + (non_child_dependents * 500));
        }

        public float getIcome() {
            return this.Income;
        }

        public void setFinalTax(float tax) {
            this.Final_Tax = tax;
        }
        public float getFinalTax() {

            return this.Final_Tax;
        }
	}
}
