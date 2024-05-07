using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAbstraccion
{
    public class ConsoleApp : Operaciones

    {

        public override double Suma(double a, double b)

        {

            return a + b;

        }


        public override double Resta(double a, double b)

        {

            return a - b;

        }


        public override double Multiplicacion(double a, double b)

        {

            return a * b;

        }


        public override double Division(double a, double b)

        {

            if (b == 0)

            {

                throw new DivideByZeroException("Cannot divide by zero");

            }

            return a / b;


        }
    }
}
