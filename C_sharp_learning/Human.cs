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

        public void Introduce(string introduceTo)
        {
            Console.WriteLine("Hi {0}, I am {1}.", introduceTo,Name);
        }
    }
}
