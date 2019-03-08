using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Persona
{
    class PersonaInglesa:Persona
    {

        public PersonaInglesa()
        {
            nombre = "John";
        }

        public PersonaInglesa(string NuevoValor)
        {
            nombre = NuevoValor;
        }


        public void TomarTe()
        {
            Console.WriteLine("Estoy tomando té");
        }

        public new void Saludar()
        {
            Console.WriteLine("Hi, I am: " + nombre);

        }


    }
}
