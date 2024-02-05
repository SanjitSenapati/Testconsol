using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Testconsol;

namespace Testconsol
{
    public class Methodoverding
    {
        public virtual string method1()
        {
            string s = "hello SIR";
            return s;
        }
        
    }
    public class manager: Methodoverding
    {
        override public  string method1() 
        {
            string s1 = "how are you..???";
return s1;
        }

    }
   
}
class Calling
{
    public static void Main(string[] args)
    {
        // Methodoverding mns = new Methodoverding();
        manager mns = new manager();
        mns.method1();

    }
}
