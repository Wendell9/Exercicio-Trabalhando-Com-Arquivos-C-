using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_de_Fixação
{
    internal class Produto
    {
        public string Name { get; set; }
        public int Quantidade { get; set; }
        public double Preco_Produto { get; set; }
        public double PrecoFinal { get; set; }

        public Produto(string name, int quantidade, double preco_Produto)
        {
            Name = name;
            Quantidade = quantidade;
            Preco_Produto = preco_Produto;
            PrecoFinal = quantidade * preco_Produto;
        }

        public override string ToString()
        {
            return $"{Name}, {PrecoFinal.ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
