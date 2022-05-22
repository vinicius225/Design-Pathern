using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleFactory.Pizza
{
    public class PizzaCalabreza : Pizza
    {
        public string Nome { get; set; }
        public PizzaCalabreza()
        {
            Nome = "Calabreza";
        }


        public void Assar(int Tempo)
        {
            Console.WriteLine($"Assando a pizza de {Nome}");

        }

        public void Embalar()
        {
            Console.WriteLine($"Embalando a pizza de {Nome}");
        }
        public void Preparar()
        {
            Console.WriteLine($"Preparando a pizza de {Nome}");

        }
    }
}