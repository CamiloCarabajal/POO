using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    public class Bottle
    {
        private int capacity;
        private string color;
        private string material;
        //Propiedad de C#

        public int Capacity
        { 
           get{ return capacity; }
           set{ capacity = value; }
        }
    }
}
