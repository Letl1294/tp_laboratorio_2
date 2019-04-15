using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    /// Calculadora
    /// Validamos el operador.
    /// return operador

    class Calculadora
    {
        private static string validarOperador(string operador)
        {
            if (operador == "+" || operador == "-" || operador == "*" || operador == "/")
            {
                return operador;
            }
            else
            {
                operador = "+";
                return operador;
            }
        }

        /// Operar
        /// 
        /// le pasamos a la funcion 2 numero y un operador.
        /// validamos el operador.
        /// con un switch recorremos para entrar en a la operacion correcta. 
        /// return resul.

        public static double Operar(Numero num1, Numero num2, string operador)
        {
            string aux;
            double resul = 0;
            aux = Calculadora.validarOperador(operador);
            switch(aux)
            {
                case "+":
                    resul = num1 + num2;
                    break;
                case "-":
                    resul = num1 - num2;
                    break;
                case "/":
                    resul = num1 / num2;
                    break;
                case "*":
                    resul = num1 * num2;
                    break;
            }
            return resul; 
        }
    }
}