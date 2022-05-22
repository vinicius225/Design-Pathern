using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleFactory.Pizza
{
    public class PizzaMussarela : Pizza
    {
        public string Nome { get; set; }
        public PizzaMussarela()
        {
            Nome = "Mussarela";
        }


        public void Assar(int Tempo)
        {
            throw new NotImplementedException();
        }

        public void Embalar()
        {
            Console.WriteLine($"Embalando a pizza de {Nome}");
        }
        public void Preparar()
        {
            throw new NotImplementedException();
        }
    }
}