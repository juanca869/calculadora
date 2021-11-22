using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite su primer numero");
            int primerDigito = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite su segundo numero");
            int segundoDigito = int.Parse(Console.ReadLine());
            int resultado;
            Console.WriteLine("digite el signo operativo que quiere usar: + =suma, - = resta, * = multiplicacion, / = division");
            string signo;
            signo = Console.ReadLine();
            switch (signo)
            {

                case "+":
                    {
                        resultado = (primerDigito + segundoDigito);
                        Console.WriteLine("su resultado de la operacion es: " + resultado);
                        break;
                    }
                case "-":
                    {
                        resultado = (primerDigito - segundoDigito);
                        Console.WriteLine("su resultado de la operacion es: " + resultado);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }
    }
}