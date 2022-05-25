using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class SpPizzaMussarela : Pizza
    {
        public SpPizzaMussarela()
        {
        Nome = "Pizza de mussarela paulista";
        Massa = "Massa fina, crocante Paulista";
        Molho = "Molho de tomate Italiano";
        Ingreditentes.Add("Queijo Parmesao");
        }
        
    }
}