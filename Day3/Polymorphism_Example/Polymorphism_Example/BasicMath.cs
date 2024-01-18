using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Example
{
    internal class BasicMath
    {

        public void Notice()
        {
            Console.WriteLine(" Today is Holiday !");
        }
        public virtual int Addition(int num1 , int num2) {
        return num1+num2 + 1000;
        }
    }
}
