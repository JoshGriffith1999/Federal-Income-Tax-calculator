using System;
using System.Collections.Generic;
using System.Text;

namespace Federal_Income_Tax_calculator
{
	public class Filer
	{
		private double Final_Tax;
		private double Income;
		private double Standard_Deduction = 12000;
		private string Name;

		public void Set_Name()
		{
            Console.WriteLine("Please Enter Your Name: ");
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

		public void Calc_Deductions()
		{
            double IRA = 0;
            double student_loan_interest = 0;
            double k_Payments = 0;
            double moving_expense = 0;
            int option = 0;

            if (this.Income < this.Standard_Deduction) {

                Console.WriteLine("Please Enter any IRA contributions you have made");
                IRA = double.Parse(Console.ReadLine());

                Console.WriteLine("Please Enter any student loan interest");
                student_loan_interest = double.Parse(Console.ReadLine());

                Console.WriteLine("Please Enter any 401(k) payments");
                k_Payments = double.Parse(Console.ReadLine());

                Console.WriteLine("Please Enter any moving expenses");
                moving_expense = double.Parse(Console.ReadLine());

                this.Income = this.Income - (IRA + student_loan_interest + k_Payments + moving_expense);
            }

            else {
                Console.WriteLine("Enter 1 for standard deduction or 2 for itemized deduction");
                option = Convert.ToInt32(Console.ReadLine());

                if (option == 1)
                {

                    this.Income = this.Income - this.Standard_Deduction;
                }

                else {
                    Console.WriteLine("Please Enter any IRA contributions you have made");
                    IRA = double.Parse(Console.ReadLine());

                    Console.WriteLine("Please Enter any student loan interest");
                    student_loan_interest = double.Parse(Console.ReadLine());

                    Console.WriteLine("Please Enter any 401(k) payments");
                    k_Payments = double.Parse(Console.ReadLine());

                    Console.WriteLine("Please Enter any moving expenses");
                    moving_expense = double.Parse(Console.ReadLine());

                    this.Income = this.Income - (IRA + student_loan_interest + k_Payments + moving_expense);

                }

            }
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
        public void getFinalTax() {

            Console.WriteLine(this.Final_Tax);
        }
	}
}
