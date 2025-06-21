using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex006
{
    public class Carro
    {

        public string marca;
        public string modelo;
        public int ano;

        public void ExibirInformacoes()
        {

            Console.WriteLine($"Marca: {marca}\nModelo: {modelo}\nAno: {ano}");

        }

    }
}
