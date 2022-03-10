using InputOpperator;
using System;
using System.Threading;

namespace InputNumber
{
    ///<summary>
    /// Denna <c>NumInput</c> klassens uppgift är att jobba med metoden för att läsa in ett 
    /// värde från användaren.
    ///</summary>
    public class NumInput 
    {
        ///<summary>
        /// Metoden blir kallad på och tar emot ett värde från användaren.
        ///</summary>
        ///<remarks> 
        /// Metoden går igenom och checkar så att inputs värdet är giltigt annars startas en exception
        ///</remarks>
        public static decimal InpNum()
        {
            // Den första inmatnings metoden som används 2 gånger för minskad kod
            decimal Number = 0;
            bool isrunning = true;
            while (isrunning)
            {
                Console.Write("Select a number/s \n");
                try
                {
                    string UserInputs = Console.ReadLine();
                    Number = Easteregg(UserInputs);
                    isrunning = false;
                }
                catch (OPInputs.EasterEggException e)
                {
                    Console.WriteLine(e.Message);
                }
                ///<exception>
                /// Exception throwas om alla andra inputs inte är giltiga.
                ///</exception>
                catch (Exception)
                {
                    Console.WriteLine("Invalid input"); 
                    Thread.Sleep(1000);
                }
            }
            return Number;
        }
        ///<summary>
        ///Easteregg metoden checkar om inputen är ett speciellt värde;
        ///</summary>
        ///<remarks>
        ///Eastereggs metoden ska chacka om inputen har ett speciellt värde och slänger antingen en exception
        ///eller så ska den alvsuta programmet.
        ///</remarks>
        ///<exception>
        /// EasterEggException throwas om värdet är lika med det satta värdet.
        ///</exception>
        public static decimal Easteregg(string input)
        {           
            decimal results;

            if (!decimal.TryParse(input, out results))
            {
                //Satte dit en ToLower för att se till så att användaren kan fylla i både stora och små bokstäver. 
                input = input.ToLower();
                if (input == "xyzzy")
                {
                    throw new OPInputs.EasterEggException("Nothing happend"); //Easter Egg 
                }
                else if (input == "quit") // Avslutar programmet.
                {
                    Environment.Exit(0);
                }
                throw new Exception();
            }
            return results;
        }        
    }
}