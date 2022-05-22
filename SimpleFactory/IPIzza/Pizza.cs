using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleFactory.Pizza
{
     public abstract class  Pizza
    {
        public  string Nome { get; set; }
        public abstract void  Preparar();
        public abstract void Assar(int Tempo);
        public abstract void Embalar ();
    }
}