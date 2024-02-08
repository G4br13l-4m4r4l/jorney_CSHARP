using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remebering
{
    internal class Dog : Animal
    {
        String name;

        public Dog(String name)
        {
            this.name = name;
        }

        public override void Speak()
        {
            Console.WriteLine($"The {name} goes *woof*");
        }

        public override string ToString()
        {
            Speak();
            return $"This is {name} the dog!\n";
        }
    }
}
