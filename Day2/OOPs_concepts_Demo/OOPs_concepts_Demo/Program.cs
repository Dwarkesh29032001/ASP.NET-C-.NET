using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_concepts_Demo
{

    public class Basicmath {
       public virtual int addition(int i, int j)
        {
            return i + j;   
        }
        /*int addition(int i , int j , int k)
        {
            return i + j + k;
        }
        int addition(double i , int j) {
        return (int)i+j;

        }*/

    }


    public class AdvMath : Basicmath {

        public override int addition(int i, int j)
        {
            return i + j + 1000;
        }

    }

    public class Math {
            public  virtual int addition(int i, int j) {  return i + j; }
            
    }

    public class AdvanceMath : Math
    {
        public new int addition(int i, int j) { return i + j - 2000; }

    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Basicmath obj = new Basicmath();
            Console.WriteLine(obj.addition(1000, 2000));  //3000

            AdvMath advMath = new AdvMath();
            Console.WriteLine(advMath.addition(3000, 1000)); //5000

            Basicmath obj2 = new AdvMath();
            Console.WriteLine(obj2.addition(3000, 4000)); // 8000  runtime pe matches with with base class method but compile time pe executes method from child class 

            Math M1 = new Math();
            Console.WriteLine(M1.addition(5000, 2000)) ; //7000

            Math M2 = new AdvanceMath();
            Console.WriteLine(M2.addition(5000,3000)); // 6000

            AdvanceMath M3 = new AdvanceMath();
            Console.WriteLine(M3.addition(4000,5000)); //7000

            Console.ReadKey();


           
        }
    }
}
