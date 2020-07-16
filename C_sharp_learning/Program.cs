using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_learning
{
    class Program
    {
        static void Main(string[] args)
        {
            var human = new Human();

            human.Name = "Naveed";

            human.Introduce("Farhan");

            var newHuman = Human.Parse("Rahman");
            Console.WriteLine("The name of the new human is {0}.", newHuman.Name);
        }
    }
}
