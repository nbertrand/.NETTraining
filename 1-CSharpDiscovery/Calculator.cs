using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDiscovery
{
    using System.Collections;
    using System.Runtime.Remoting.Messaging;

    class Calculator
    {
        public string Name { get; set; }

        public Calculator()
        {
        }

        public Calculator(string name)
        {
            this.Name = name;
        }

        public double SumOfTheArray(double[] valuesToSum)
        {
            double result = 0;
            foreach (double value in valuesToSum)
            {
                result += value;
            }
            return result;
        }

        //public double Sum(double[] arrayToSum)
        //{
        //    arrayToSum.Sum();
        //}
    }
}
