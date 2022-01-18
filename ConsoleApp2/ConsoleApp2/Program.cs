using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Tartaleta Tartaleta = new Tartaleta("Almidon", "Parmesano", "Ahumado", "Frito", "Molido", "Cerrano");
            Tartaleta.Ingredientes();
        }
    }
}
