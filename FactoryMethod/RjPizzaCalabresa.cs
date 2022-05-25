using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class RjPizzacalabeza : Pizza
    {
        public RjPizzacalabeza()
        {
        Nome = "Pizza de calabeza carioca";
        Massa = "Massa fina, crocante carioca";
        Molho = "Molho de tomate Italiano";
        Ingreditentes.Add("Queijo Parmesao");
        }
        
    }
}