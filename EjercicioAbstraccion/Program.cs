using System;


namespace EjercicioAbstraccion

{

    class Program

    {

        static void Main(string[] args)

        {

            ConsoleApp operaciones = new ConsoleApp();

            operaciones.IngresarNumeros();

            operaciones.Imprimir();

        }

    }

        public void IngresarNumeros()

        {

            Console.Write("Enter the first number: ");

            this.Num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");

            this.Num2 = Convert.ToDouble(Console.ReadLine());

        }

    }

}