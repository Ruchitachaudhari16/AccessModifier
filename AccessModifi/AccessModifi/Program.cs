using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifi
{
    public class Program: ProtectedAccessModifier
{
        static void Main(string[] args)
        {
            //create object for public class
            Modifier modifier = new Modifier();
            modifier.display();

            //create object for private class
            PrivateAccessModifier priv=new PrivateAccessModifier();
            priv.write();
           
           

            //Create the object  of protected class
            ProtectedAccessModifier obj = new ProtectedAccessModifier();
            Program p1 = new Program();
              p1.read();

            //create the object for internal class
            Internal obje=new Internal();
            obje.displays();

            //Calling to enum
            Day obj1 = Day.monday;
            Console.WriteLine(obj1);
            //print index position of enum
            int obj2 = (int)Day.monday;
            Console.WriteLine(obj2);
            Console.ReadLine();


        }
    }
}
