using System;

namespace _01Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sobrecarga de métodos!");
            var usuario1 = new User();
            Console.WriteLine("usuario1");
            Console.WriteLine(usuario1);

            var usuario2 = new User("Bidkar", "Aragon");
            Console.WriteLine("usuario2");
            Console.WriteLine(usuario2);
        }
    }
}
