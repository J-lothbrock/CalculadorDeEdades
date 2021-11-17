using System;
using System.Threading;

namespace CalculadorDeEdades
{
    class Program
    {
        static void Main(string[] args)
        {
            int yearB;
            int yearF;
            const int yearA = 2021;
            const string MessageError= "Debe ingresar solo el año, intente nuevamente";

            tryagain:

            try
            {
                Console.WriteLine("En que año naciste?");
                yearB = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(MessageError);
                Console.ResetColor();

                goto tryagain;
            }
            Console.Clear();

            Console.WriteLine("Estamos calculando, por favor espere...");
            Thread.Sleep(2000);
            Console.Clear();

            calculator(yearB, yearA);

            Console.WriteLine("Si desea saber que edad tendra en cierto año, por favor ingrese" +
                " el año en el que quiere saber su futura edad");

            string answer = Console.ReadLine();

            int answerC = string.Compare(answer, "si", true);

            if(answerC == 0)
            {
                tryagain2:

                try
                {
                    Console.WriteLine("En que año quieres saber que edad tendras?");
                    yearF = int.Parse(Console.ReadLine());
                }
                catch(Exception)
                {
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(MessageError);
                    Console.ResetColor();

                    goto tryagain2;
                }
                Console.Clear();

                calculator2(yearB, yearF);

            }

        }

        static void calculator(int yearB, int yearA)
        {
            int calculatorYears = yearA - yearB;

            Console.WriteLine("Actualmente tienes " + calculatorYears + " años \n");


        }

        static void calculator2(int yearB, int yearF)
        {

            int calculatorYearsF = yearF - yearB;

            Console.WriteLine("En el año " + yearF + " tendras " + calculatorYearsF);

        }
    }
}
