using System;

namespace edad_ingresada_es_de_una_persona_menor_o_mayor_de_edad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad = 18;
            Console.WriteLine("Vamos a evaluar si eres mayor de edad");

            if(edad >= 18)
            {
                Console.WriteLine("Adelante, pudes pasar porque eres mayor de edad");
            }
        }
    }
}
