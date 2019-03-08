using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Persona
{
    class PersonaItaliana: Persona
    {

        public PersonaItaliana()
        {
            nombre = "";
        }

        public new void Saludar()
        {
            Console.WriteLine("Ciao: "+nombre);

        }

    }
}
