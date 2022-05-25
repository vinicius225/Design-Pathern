using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class SpPizzacalabeza : Pizza
    {
        public SpPizzacalabeza()
        {
        Nome = "Pizza de calabeza paulista";
        Massa = "Massa fina, crocante Paulista";
        Molho = "Molho de tomate Italiano";
        Ingreditentes.Add("Queijo Parmesao");
        }
        
    }
}