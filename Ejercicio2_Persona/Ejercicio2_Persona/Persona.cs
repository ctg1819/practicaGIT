using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Persona
{
    class Persona
    {
        protected string nombre;

        public Persona()
        {
            nombre = "";

        }
        

        public void SetNombre(string nuevoValor)
        {
            nombre = nuevoValor;
        }
        public void Saludar()
        {
            Console.WriteLine("Hola, soy "+ nombre);
            
        }

        public new void Saludar(string nuevoSaludo)
        {
            Console.WriteLine(nuevoSaludo);

        }

    }
}
