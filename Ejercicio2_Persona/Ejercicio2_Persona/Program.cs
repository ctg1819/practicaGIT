using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Persona
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Persona per1 = new Persona();
            Persona per2 = new Persona();

            per1.SetNombre("María");
            per2.SetNombre("Elena");
           

            per1.Saludar();
            Console.WriteLine("\n");
            per2.Saludar();
            Console.WriteLine("\n");
            */


            /* Añadimos PersonaInglesa
            Persona per = new Persona();
            PersonaInglesa peringlesa = new PersonaInglesa();

            per.SetNombre("Carmen");
            peringlesa.SetNombre("Elisabeth");


            per.Saludar();
            Console.WriteLine("\n");
            peringlesa.Saludar();
            Console.WriteLine("\n");

            peringlesa.TomarTe();
            */

            Persona per = new Persona();
            PersonaInglesa peringlesa = new PersonaInglesa();
            PersonaItaliana peritaliana = new PersonaItaliana();

            per.Saludar();
            peringlesa.Saludar();
            peritaliana.Saludar();

            PersonaInglesa peringlesa2 = new PersonaInglesa("Catherine");
            peringlesa2.Saludar();
            
            per.SetNombre("Carmen");
            peritaliana.SetNombre("Donatella");
            per.Saludar();
            peritaliana.Saludar();
            
            per.Saludar("Soy una persona...");
            peringlesa.Saludar("Soy un/a inglés/a...");
            Console.WriteLine();
            peritaliana.Saludar("Soy un/a italiano/a...");
            Console.WriteLine();

            /*
            per.SetNombre("Carmen");
            peringlesa.SetNombre("Elisabeth");
            peritaliana.SetNombre("Donatella");

            per.Saludar();
            Console.WriteLine();
            peringlesa.Saludar();
            Console.WriteLine();
            peritaliana.Saludar();
            Console.WriteLine();

            peringlesa.TomarTe();
            */



        }
    }

    



}
