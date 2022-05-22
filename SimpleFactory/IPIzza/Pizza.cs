using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleFactory.Pizza
{
     public interface  Pizza
    {

        public  void Preparar();
        public void Assar(int Tempo);
        public void Embalar ();
    }
}