using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifi
{
    public class ProtectedAccessModifier
    {
        //allow code within the same class and inherited class and its member.
        protected void read()
        {
            Console.WriteLine("read method is protected");
        }
    }
}
