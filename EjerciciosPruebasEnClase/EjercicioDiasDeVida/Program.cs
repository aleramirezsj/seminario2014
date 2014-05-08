using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioDiasDeVida
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio Días de vida");
            Console.WriteLine("**********************");
            //Write imprime un texto sin incluir el enter
            //es decir, el cursor queda en el mismo
            //renglón
            Console.Write("Ingrese su nombre:");
            //declaramos la variable nombre
            string nombre;
            //ReadLine lee lo que escribe el usuario en la 
            //consola y lo asigna a una variable
            nombre = Console.ReadLine();
            Console.Write("Ingrese su edad:");
            byte edad;
            edad = Convert.ToByte(Console.ReadLine());
            int dias;
            dias = edad * 365;
            Console.WriteLine("Hola " + nombre);
            Console.WriteLine("sus días de vida aproximados son:" + dias.ToString());
            Console.ReadKey();
        }
    }
}
