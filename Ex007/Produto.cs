using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex007
{
    internal class Produto
    {

        public string Nome;
        public double Preco;

        public Produto(string nome, double preco)
        {

            Nome = nome;
            Preco = preco;

        }

        public void ExibirProduto()
        {

            Console.WriteLine($"Produto: {Nome} \nPreço: {Preco}");

        }

    }
}
