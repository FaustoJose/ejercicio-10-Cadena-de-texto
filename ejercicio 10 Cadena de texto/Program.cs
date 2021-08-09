using System;

namespace ejercicio_10_Cadena_de_texto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("La primera letra de esta palabra es :"+Cadena("Hola"));
        }
        public static char Cadena(string palabra)
        {
            char[] a = palabra.ToCharArray();
            return a[0];
        }
    }
}
