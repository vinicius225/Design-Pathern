using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleFactory.Pizza
{
    public class PizzaCalabreza : Pizza
    {

        public PizzaCalabreza()
        {
            Nome = "Calabreza";
        }


        public override void Assar(int Tempo)
        {
            Console.WriteLine($"Assando a pizza de {Nome}");

        }

        public override void Embalar()
        {
            Console.WriteLine($"Embalando a pizza de {Nome}");
        }
        public override void Preparar()
        {
            Console.WriteLine($"Preparando a pizza de {Nome}");

        }
    }
}