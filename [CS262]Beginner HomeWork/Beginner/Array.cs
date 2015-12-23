using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner
{
    internal class Array
    {
        public double[] variables;

        public double total = 0;

        //建構式(constructor)用來初始化
        public Array(int length)
        {
            variables = new double[length];

            for (int count = 0; count < length; count++)
            {
                variables[count] = 0; //初始化為0
            }
        }

        public Array Add(double value)
        {
            double[] addArray = new double[this.variables.Length];

            for (int count = 0; count < variables.Length; count++)
            {
                addArray[count] = this.variables[count] + value;
            }

            this.variables = addArray;

            return this;
        }

        public Array Sub(double value)
        {
            double[] subArray = new double[this.variables.Length];

            for (int count = 0; count < variables.Length; count++)
            {
                subArray[count] = this.variables[count] - value;
            }

            this.variables = subArray;

            return this;
        }

        public Array Multiply(double value)
        {
            double[] multiplyArray = new double[this.variables.Length];

            for (int count = 0; count < variables.Length; count++)
            {
                multiplyArray[count] = this.variables[count] * value;
            }

            this.variables = multiplyArray;

            return this;
        }

        public Array Div(double value)
        {
            double[] divAarray = new double[this.variables.Length];

            for (int count = 0; count < variables.Length; count++)
            {
                divAarray[count] = this.variables[count] / value;
            }

            this.variables = divAarray;

            return this;
        }

        public Array Sum()
        {
            double sum = 0;

            for (int count = 0; count < variables.Length; count++)
            {
                sum += this.variables[count];
            }

            this.total = sum;

            return this;
        }

        public Array Cusum()
        {
            double[] cusumAarray = new double[this.variables.Length];

            cusumAarray = this.variables;

            for (int i = variables.Length - 1; i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    cusumAarray[i] += cusumAarray[i - j];
                }
            }

            this.variables = cusumAarray;

            return this;
        }

        public void Print()
        {
            for (int count = 0; count < this.variables.Length; count++)
            {
                Console.WriteLine("Array[{0}] = {1}", count, variables[count]);
            }

            Console.Write("\n");
            Console.WriteLine("Sun:{0}\n", this.total);
        }
    }
}