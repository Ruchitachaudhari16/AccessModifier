using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifi
{
    //Access Modifier are the keywords which specify the accessibilty of a variable or a function
    //It will control visibility of the class. 
    public class Modifier
    {
        //public modifier allow a part of a program in a same assembly (project) or different assembly to access the type and member
        public void display()
        {
            Console.WriteLine("Display Method is public");
        }

        


    }
}
