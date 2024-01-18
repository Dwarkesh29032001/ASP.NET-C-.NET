using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Example
{
    internal class AdvanceMath : BasicMath
    {
        public override int Addition(int num1, int num2)
        {
            return num1 + num2 - 1000;
        }

        public new void Notice()
        {
            Console.WriteLine("Tomorrow is not a Holiday !!");
        }
    }
}
