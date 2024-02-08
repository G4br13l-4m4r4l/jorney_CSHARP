using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enc_new
{
    interface veiculo
    {
        public void acelerar(int speed);
    }
    internal class Plane : veiculo
    {
           public int Speed {  get; set; }
        public void acelerar(int speed) { 
            Speed += speed;
            Console.WriteLine($"\n=>The plane is now going at {Speed} KM/H");
        }
    }
}
