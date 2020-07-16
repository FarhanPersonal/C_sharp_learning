using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_learning
{
    public class Human
    {
        public string Name;

        //FR: Constructor
        public Human()
        {
            this.Name = "What's_In_a_name";
        }

        public void Introduce(string introduceTo)
        {
            Console.WriteLine("Hi {0}, I am {1}.", introduceTo,Name);
        }


        public static Human Parse(string nameOfPersonToBeCreated)
        {
            var human = new Human();
            human.Name = nameOfPersonToBeCreated;

            return human;
        }

    }
}
