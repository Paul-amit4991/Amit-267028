using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment001
{
    class Information
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Your Age: ");
            string age = Console.ReadLine();

            Console.Write("Enter Your Adress: ");
            string adress = Console.ReadLine();

            Console.Write("Enter Your Contact: ");
            var contact = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("Here Is Your Basic Information");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Adress: " + adress);
            Console.WriteLine("Contact: " + contact);

            Console.ReadLine();
        }
    }
}
