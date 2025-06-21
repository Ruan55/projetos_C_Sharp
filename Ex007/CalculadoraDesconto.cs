using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex007
{
    internal class CalculadoraDesconto
    {

        public double CalcularDesconto(double preco, double porcentagem)
        {

            return preco - (preco * (porcentagem / 100));

        }

        public double CalcularDesconto(double preco, double porcentagem, double adicional)
        {

            return preco - (preco * (porcentagem / 100)) - adicional;

        }

    }
}
