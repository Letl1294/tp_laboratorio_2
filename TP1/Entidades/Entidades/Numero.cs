﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Numero
    {
        private double numero;

        public Numero()
        {
            this.numero = 0;
        }

        public Numero(double numero)
        {
            this.numero = numero;
        }

        public Numero(string numero)
        {
            this.numero = Double.Parse(numero);
        }

        private static double ValidarNumero(string numero)
        {
            string aux = "";
            double num;
            for (int i = 0; i < numero.Length; i++)
            {
                if (numero[i] >= '0' && numero[i] <= '9')
                {
                    aux += numero[i];
                }
                else
                {
                    aux = "0";
                    break;
                }

            }
            num = Convert.ToDouble(aux);
            return num;
        }

        public string SetNumero
        {
            set
            {
                numero = ValidarNumero(value);
            }
        }

        public static string DecimalBinario(double num)
        {
            string bin = "";
            if (num <= 0)
            {
                bin = "Valor Invalido";
            }
            while (num > 0)
            {
                if (num % 2 == 0)
                {
                    bin = "0" + bin;
                }
                else
                {
                    bin = "1" + bin;
                }
                num = (int)(num / 2);
            }
            Console.WriteLine("Listo");
            return bin;
        }

        public static string DecimalBinario(string num)
        {
            string bin = "";
            int aux = int.Parse(num);
            if (aux <= 0)
            {
                bin = "Valor Invalido";
            }
            while (aux > 0)
            {
                if (aux % 2 == 0)
                {
                    bin = "0" + bin;
                }
                else
                {
                    bin = "1" + bin;
                }
                aux = aux / 2;
            }
            Console.WriteLine("Listo");
            return bin;
        }

        public static string BinaroDecimal(string num)
        {
            char[] array = num.ToCharArray();
            // Invertido pues los valores van incrementandose de derecha a izquierda: 16-8-4-2-1
            Array.Reverse(array);
            string sum = "";

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '1')
                {
                    // Usamos la potencia de 2, según la posición
                    sum += Math.Pow(2, i);
                }
                else
                {
                    sum = "Valor Invalido";
                }
            }
            return sum;
        } 

        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }

        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }

        public static double operator /(Numero n1, Numero n2)
        {
            if (n2.numero == 0)
            {
                return double.MinValue;
            }
            return n1.numero * n2.numero;
        }

        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero / n2.numero;
        }
    }
}
