using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remebering
{
    internal class Hamster : Animal
    {
        String name;
        public Hamster(String name) {
            this.name = name;
        }

        public override void Speak()
        {
            Console.WriteLine($"The {name} goes *nhack*");
        }

        public override string ToString()
        {
            Speak();
            return $"This is {name} the hamster!\n";
        }
    }
}
