using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    interface Veiculo
    {
        public void Acelerar(int speed);
    }
    internal class Plane : Veiculo
    {

        public int Speed {  get; set; }

        public void Acelerar(int speed) { 
            if(speed > 0 && speed <= 500)
            {
                Speed = speed;
            }
        }
    }
}
