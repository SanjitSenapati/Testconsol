using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using mthdovrding; 

namespace mthdovrding
{
    public class Methodoverding
    {
        public virtual string method1()
        {
            string s = "hello SIR";
            return s;
        }

    }
    public class manager : Methodoverding
    {
         public override string method1()
        {
            string s1 = "how are you..???";
            return s1;
        }

    }
    class Calling
    {
        public static void Main(string[] args)
        {
             Methodoverding mnss = new Methodoverding();
            string mns2=mnss.method1();
            manager mns = new manager();
            string mns1=mns.method1();
            Console.WriteLine(mns2+"   "+mns1);
            Console.WriteLine("thanks");

        }
    }
}

