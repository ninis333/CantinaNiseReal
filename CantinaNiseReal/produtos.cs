using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CantinaNiseReal
{

    class Produtos
    {
        private string comida;
        private double preco;

        public string Comida
        {
            get { return comida; }
        }

        public double Preco
        {
            get { return preco; }
        }

        public Produtos(string comida, double preco)
        {
            this.comida = comida;
            this.preco = preco;
        }
        public override string ToString()
        {
            return $"{comida} - R${preco:F2} ";
        }
    }
}
