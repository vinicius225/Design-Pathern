using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class SpFactoryMethod : PIzzaFactoryMethod
    {
        protected override Pizza CriarPizza(string tipo)
        {
            if(tipo.Equals("C"))
            {
                return new SpPizzaMussarela();
            }else
            {
                return new SpPizzacalabeza();
            }
        }
        
    }
}