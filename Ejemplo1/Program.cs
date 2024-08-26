using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person1= new Person(); // De esta manera se genera un objeto
            person1.setAge(26);
            Console.WriteLine("La edad de la persona es: "+person1.getAge());
            Console.ReadKey();

            Bottle bottle1= new Bottle();
            //Para asignar valor
            bottle1.Capacity = 100;
            // Para leer el valor
            int valor= bottle1.Capacity;
        }
    }
}
