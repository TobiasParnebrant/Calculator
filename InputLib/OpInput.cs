using Calculations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace InputOpperator
{
    ///<summary>
    /// Denhär klassen kallas på för att ta emot en opperatorn 
    /// och skapar en egen exception. 
    ///</summary>
    public class OPInputs 
    {
        ///<summary>
        /// MathOp metoden tar emot ett värde från användaren.
        ///</summary>
        ///<remarks> 
        /// Beroende på vad värdet är för något så kommer 1 av 3 alternativ att ske, men man kommer kunna 
        /// fortsätta att skriva in ett värde tills ett giltigt värde har valts.
        ///</remarks>
        public static string MathOp()
        {
            string counter = "";
            bool isrunning2 = true;
            while (isrunning2)
            {
                Console.WriteLine("Type an operator");
                try
                {
                    string userInput = Console.ReadLine();                    
                    counter = Operator(userInput);
                    isrunning2 = false;
                }
                catch (EasterEggException e)
                {
                    //Fångar easter egg
                    Console.WriteLine(e.Message);
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid operator\n");
                    Thread.Sleep(1000);
                }
            }
            return counter;
        }
        ///<summary>
        /// Opperator metoden tar värdet och kollar om det är ett av de giltiga värdena.
        ///</summary>
        ///<exception> 
        /// Om värdet inte är giltigt så kommer en exception att throwas, om värdet är ett easter egg värde så 
        /// kommer EasterEggExceptionen att köras.
        ///</exception>
        public static string Operator(string Op)
        {
            //La till en ToLower så man kan skriva i både små och stora bokstäver
            Op = Op.ToLower();
            if (Op != "-" && Op != "+" && Op != "/" && Op != "*" && Op != "C" && Op != "F")
            {
                if (Op == "xyzzy") //Easter Egg
                {
                    throw new EasterEggException("Nothing happends");
                }
                else if (Op == "quit")  //Avslutarprogrammet med "quit"
                {
                    Environment.Exit(0);
                }
                throw new Exception();
            }
            return Op;
        }
        ///<exception>
        /// EasterEggException skapas för att checka om input har ett speciellt värde.
        ///</exception>
        public class EasterEggException : ArgumentException
        {
            public EasterEggException() { }
            public EasterEggException(string message) : base(message) { }
            public EasterEggException(string message, ArgumentException inner) : base(message, inner) { }
        }
    }
}