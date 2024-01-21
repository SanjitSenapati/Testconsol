using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testconsol
{
    public class Methodoverding
    {
        public string method1()
        {
            string s = "hello SIR";
        }
        
    }
    public class manager: Methodoverding
    {
        public override string method1() 
        {

        }
    }
}
