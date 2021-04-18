using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("-------------Welcome to Address Book Program------------ ");
            Person  person  = new Person("Ankita","patil","dehu","pune","maharashtra","412109","9146852365","ankitakhairnar00@gmail.com");
            Console.WriteLine( person .getName());
            Console.WriteLine(person.getlastName());
            Console.WriteLine(person.getaddress());
            Console.WriteLine(person.getcity());
            Console.WriteLine(person.getstate());
            Console.WriteLine(person.getzip());
            Console.WriteLine(person.getphone());
            Console.WriteLine(person.getemail());
            //contacts.FirstName = anki
            Console.Read();
        }
        
        

    }
}