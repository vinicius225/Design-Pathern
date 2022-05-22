using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleFactory.Pizza
{
    public class PizzaMussarela : Pizza
    {
        public  PizzaMussarela()
        {
            Nome = "Mussarela";
        }


        public override void Assar(int Tempo)
        {
            throw new NotImplementedException();
        }

        public override void Embalar()
        {
            Console.WriteLine($"Embalando a pizza de {Nome}");
        }
        public override void Preparar()
        {
            throw new NotImplementedException();
        }
    }
}