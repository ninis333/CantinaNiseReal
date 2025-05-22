using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CantinaNiseReal
    {
        class Produtos
        {
            public string Nome { get; set; }
            public double preco { get; set; }
            public int quantidade { get; set; }

            public double Total => preco * quantidade;

            public bool ExibirComoCatalogo { get; set; } = false;

            public override string ToString()
            {
                if (ExibirComoCatalogo)
                {
                    return $"{Nome} - R$ {preco:F2}";
                }
                else
                {
                    return $"{quantidade} x {Nome} - R$ {Total:F2}";
                }
            }
        }
    }



