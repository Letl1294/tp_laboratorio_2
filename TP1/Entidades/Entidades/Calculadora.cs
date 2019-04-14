using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Calculadora
    {
        private static string validarOperador(string operador)
        {
            string aux = operador;
            if (aux == "+" || aux == "-" || aux == "*" || aux == "/")
            {
                return aux;
            }
            else
            {
                aux = "+";
                return aux;
            }
        }

        public static double Operar(Numero num1, Numero num2, string operador)
        {
            string aux = operador;
            aux = Calculadora.validarOperador(operador);
            num1.numero + num2.numero;
        }
    }
}
