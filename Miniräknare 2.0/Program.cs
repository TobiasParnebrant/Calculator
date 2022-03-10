using InputNumber;
using Calculations;
using System;
using InputOpperator;

namespace Miniräknare_2._0
{
    ///<summary>
    /// Vi börjar med start klassen vars ända mening ska vara att kalla metoderna och skriva 
    /// ut svaret till consolen.
    ///</summary>
    class Program 
    {
        static void Main(string[] args)
        {
            bool Keep_Going = true;
            while (Keep_Going)
            {
                ///<summary>
                ///Programmet kallar på de metoderna.
                ///</summary>
                ///<remarks> 
                /// ///Metoderna InpNum och MathOp körs igenom och samlar in ett värde från användaren.
                ///</remarks>
                decimal Input_Num1 = NumInput.InpNum();
                string Counter = OPInputs.MathOp();
                decimal Input_Num2 = NumInput.InpNum();
                decimal Solution = Calculate.Show_Solution(Input_Num1, Counter, Input_Num2);
                //Jag valde att ha en clear för att förmiska all kod som synns i slutet av uträkningen
                Console.Clear();
                // Eftersom att all tidigare kod kommer försvinna med clearn så kommer inte det användaren slagit
                // in visas så la till Console.WriteLine för att visa både svaret men också de inputs användaren
                // har slagit in
                if (Counter == "C" || Counter == "F")
                {
                    //Gjorde en if-sats så att man inte skriver ut ett extra input nummer
                    //och förvirrar det för användaren.
                    Console.WriteLine(Input_Num1 + Counter  + " = " + Solution + "\n");
                }
                else
                {
                    Console.WriteLine(Input_Num1 + Counter + Input_Num2 + " = " + Solution + "\n");
                }               
            }

        }
    }  
}