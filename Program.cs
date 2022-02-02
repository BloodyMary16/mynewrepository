using System;

namespace proyecto_consola
{
    class Program
    {
        static void Main(string[] args)
        {
            string mensaje;

            mensaje = "Hola" ;
            Console.WriteLine (mensaje);

            mensaje = "Estamos programando"; 
            Console.Write (mensaje);
            mensaje = Console.ReadLine(); 
            Console.WriteLine ("se debería añadir esto" + mensaje); 
            Console.ReadLine();
        }
    }
}
