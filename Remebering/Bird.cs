using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remebering
{
    internal class Bird :Animal
    {
        String name;

        public Bird(String name) { 
            this.name = name;
        }

        public override string ToString()
        {
            Speak();
            return $"This is {name} the bird!\n";
        }
    }
}
