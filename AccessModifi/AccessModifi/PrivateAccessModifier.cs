using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifi
{
    internal class PrivateAccessModifier
    {
        // private accessModifier:-It restrictes other program part from asssessing its types and members.
        private void show()
        {
            Console.WriteLine("show method is private");
        }
        public void write()
        { 
           show();
        }
    }
}
