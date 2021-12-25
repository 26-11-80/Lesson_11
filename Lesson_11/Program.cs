using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Решить линейное уравнение 0=kx+b");
            Console.Write("Введите значение коэффициента k ");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение коэффициента b ");
            double b = Convert.ToDouble(Console.ReadLine());
            Equation Equation = new Equation (k, b);
            Equation.Root();
            Console.ReadKey();

        }
        public struct Equation
        {
            public Equation(double k, double b)
            {
                this.k = k;
                this.b = b;
            }
            public double k;
            public double b;

            public void Root()
            {
                Console.WriteLine("Значение  X = {0}", -b / k);
            }
        }
    }
}
