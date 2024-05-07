using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAbstraccion
{
    public abstract class Operacion

    {
        public abstract double Suma(double a, double b);

        public abstract double Resta(double a, double b);

        public abstract double Multiplicacion(double a, double b);

        public abstract double Division(double a, double b);

        public virtual void Imprimir()

        {

            Console.WriteLine("The results are:");

            Console.WriteLine($"Sum: {Suma(this.Num1, this.Num2)}");

            Console.WriteLine($"Difference: {Resta(this.Num1, this.Num2)}");

            Console.WriteLine($"Product: {Multiplicacion(this.Num1, this.Num2)}");

            Console.WriteLine($"Quotient: {Division(this.Num1, this.Num2)}");

        }

        public double Num1 { get; set; }

        public double Num2 { get; set; }


    }
}
  