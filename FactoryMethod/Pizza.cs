using System.Collections;
using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Pizza
    {
        protected string  Nome { get; set; }
        protected string Massa;
        protected string Molho = string.Empty;
        protected List<string> Ingreditentes = new List<string>();
        public string Preparar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Preparando {Nome} \n");
            sb.Append($"{Massa} \n");
            sb.Append($"{Molho} \n");
            sb.Append("Ingredientes: \n");
            foreach(string ingrediente in  Ingreditentes)
            {
                sb.Append($"\t{ingrediente}");
            }
            return sb.ToString();

        }
        public virtual string Cozinhar()
        {
            return "Cozinhar por 25 minutos";
        }
        public virtual string Fatiar()
        {
            return "Fatiar a pizza em 8 pedaços";
        }
        public virtual string Embalar()
        {
            return "Embalar a pizza com a embalagem oficial";
        }
    }
}