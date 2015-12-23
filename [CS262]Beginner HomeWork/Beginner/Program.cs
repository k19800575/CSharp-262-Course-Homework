using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double AddNumber = 0;
            double SubNumber = 0;
            double MultiplyNumber = 0;
            double DivNumber = 0;

            Array array = new Array(10);
            array.variables[0] = 70;
            array.variables[1] = 65;
            array.variables[2] = 85;
            array.variables[3] = 95;
            array.variables[4] = 83;
            array.variables[5] = 95;
            array.variables[6] = 93;
            array.variables[7] = 84;
            array.variables[8] = 95;
            array.variables[9] = 93;

            Console.WriteLine("---Array Numbers---");
            array.Print();

            Console.WriteLine("---Cusum()---");
            array.Cusum().Print();

            Console.WriteLine("---Input---");
            Console.Write("Add = ");
            AddNumber = double.Parse(Console.ReadLine());
            Console.Write("Sub = ");
            SubNumber = double.Parse(Console.ReadLine());
            Console.Write("Multiply = ");
            MultiplyNumber = double.Parse(Console.ReadLine());
            Console.Write("Div = ");
            DivNumber = double.Parse(Console.ReadLine());

            Console.Write("\n---Output---\n");
            array.Add(AddNumber).Sub(SubNumber).Multiply(MultiplyNumber).Div(DivNumber).Sum().Print();
        }
    }
}