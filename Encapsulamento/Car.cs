using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    interface veiculo
    {
        public void acelerar(int speed);
    }
    internal class Car : veiculo
    {
        private int speed;

        public int Speed { 
            get { return speed; }
            set {
                if (value > 500) {
                    speed = 500;
                }
                else
                {
                    speed = value;
                }
            }
        }
        public void acelerar(int speed)
        {
            Speed = speed;
        }
    }
}
