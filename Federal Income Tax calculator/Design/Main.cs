using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Federal_Income_Tax_calculator
{
    class Main
    {
        static void main()
        {
            int answer = 0;

            Console.WriteLine("Enter filing status 1: Single 2: Married file Jointly 3: 3 Married filing speratly 4: Head of Household");
            answer = Convert.ToInt32(Console.ReadLine());

            switch (answer) {

                case 1: Head_of_Houseold_Filer person = new Head_of_Houseold_Filer();
                        person.setInfo();
                        person.displayFinal();
                    break;
                case 2:
                    Married_File_Jointly person2 = new Married_File_Jointly();
                    person2.setInfo();
                    person2.displayFinal();
                    break;
                case 3:
                    Married_File_Seperatly person3 = new Married_File_Seperatly();
                    person3.setInfo();
                    person3.displayFinal();
                    break;

                case 4:
                    Head_of_Houseold_Filer person4 = new Head_of_Houseold_Filer();
                    person4.setInfo();
                    person4.displayFinal();
                    break;

        }
        }//main end
    }//class end
}//namespace end
