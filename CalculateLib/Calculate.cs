using System;
using System.Threading;


namespace Calculations
{
    ///<summary>
    /// Calculate klassen gör alla uträkningar.
    ///</summary>
    public class Calculate
    {
        ///<summary>
        /// När Show_Solution metoden kallats på så tar den emot värdena och gör uträkningen av dem.
        ///</summary>
        ///<remarks> 
        /// Beroende vilken opperator man har valt så kommer switch-satsen aktivera den metoden som är kopplad 
        /// till den opperatorn.
        ///</remarks>
        public static decimal Show_Solution(decimal Input_Num1, string counter, decimal Input_Num2)
        {
            switch (counter)
            {
                case "+":
                    return Adding(Input_Num1, Input_Num2);

                case "-":
                    return Subtract(Input_Num1, Input_Num2);

                case "/":
                    return Dividing(Input_Num1, Input_Num2);

                case "*":
                    return Multiplication(Input_Num1, Input_Num2);

                case "C": //Lättare att förstå om man vill ha celcius så skriver man ett stort C,
                          //samma för Fahrenheit
                    return TOCelsius(Input_Num1);

                case "F":
                    return TOFahrenheit(Input_Num1);
                default:
                    Console.WriteLine("Error");
                    return 000;
            }
        }

        ///<summary>
        /// Vilken metod som körs är upp till vad användaren har valt för opperator.
        ///</summary>
        //Här görs uträkningen beroende på vilken opperator som hav valts från ovan;
        public static decimal Adding(decimal Input_Num1, decimal Input_Num2)
        {
            decimal sum = Input_Num1 + Input_Num2;
            return sum;
        }
        public static decimal Subtract(decimal Input_Num1, decimal Input_Num2)
        {
            decimal sum = Input_Num1 - Input_Num2;
            return sum;
        }

        public static decimal Dividing(decimal Input_Num1, decimal Input_Num2)
        {
            //checkar om värde 2 är en 0 och skriver ut varningsmedelandet nedan
            if (Input_Num2 == 0)
            {
                Console.WriteLine("Error! you can't Divide with 0");
                Thread.Sleep(2000);
                return 00;
            }
            decimal sum = Input_Num1 / Input_Num2;

            return sum;
        }

        public static decimal Multiplication(decimal Input_Num1, decimal Input_Num2)
        {
            decimal sum = Input_Num1 * Input_Num2;
            return sum;
        }

        public static decimal TOCelsius(decimal Input_Num1)
        {
            decimal sum = (Input_Num1 - 32) * 5 / 9;
            return sum;
        }

        public static decimal TOFahrenheit(decimal Input_Num1)
        {
            decimal sum = (Input_Num1 * 9) / 5 + 32;
            return sum;
        }
    }
}