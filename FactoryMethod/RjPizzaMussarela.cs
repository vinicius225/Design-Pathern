using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class RjPizzaMussarela : Pizza
    {
        public RjPizzaMussarela()
        {
        Nome = "Pizza de mussarela carioca";
        Massa = "Massa fina, crocante carioca";
        Molho = "Molho de tomate Italiano";
        Ingreditentes.Add("Queijo Parmesao");
        }
        
    }
}