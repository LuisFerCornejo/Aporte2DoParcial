using System;
using System.Collections.Generic;
using System.Text;
// El patron builder trata de medio de contruccion de metodos llegar a un resultado por medio del desarrollo paso a paso del mismo o mejor
// dicho por partes para asi llegar finalmente a un resultado final.
//En este ejemplo aplico el patron builder por medio de un ejemplo de tartaleta donde este por medio de la aplicacion de cada ingrediente
// obtiene su finalidad o como resultado una tartaleta y eso es lo que que especificamente nos dice el patron builder.
namespace ConsoleApp2
{
    class Tartaleta
    {
        String Masa;
        String Tocino;
        String Queso;
        String Jamon;
        String Oregano;
        String Cilantro;
        public Tartaleta(String Masa, String Queso, String Jamon, String Tocino, String Oregano, String Cilantro)
        {
            this.Masa = Masa;
            this.Queso = Queso;
            this.Jamon = Jamon;
            this.Tocino = Tocino;
            this.Oregano = Oregano;
            this.Cilantro = Cilantro;
        }


        public virtual void Ingredientes()
        {

            Console.WriteLine("Ingredientes de la tartaleta");
            Console.WriteLine("Masa: " + Masa);
            Console.WriteLine("Queso: " + Queso);
            Console.WriteLine("Jamon: " + Jamon);
            Console.WriteLine("Tocino: " + Tocino);
            Console.WriteLine("Oregano: " + Oregano);
            Console.WriteLine("Cilantro: " + Cilantro);

        }

    }
}

