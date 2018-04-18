using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        /// <summary>
        /// Validará que el operador recibido sea +, -, / o *. Caso contrario retornará +
        /// </summary>
        /// <param name="operador"></param>
        /// <returns>string</returns>
        private static string ValidarOperador(string operador) {
            if (operador == "+" || operador == "-" || operador == "*" || operador == "/")
                return operador;
            else
                return "+";
        }

        /// <summary>
        /// Validará y realizará la operación pedida entre ambos números
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <param name="operador"></param>
        /// <returns>double</returns>
        public double Operar(Numero n1, Numero n2, string operador) {
            operador = Calculadora.ValidarOperador(operador);
            double resultado=0;

            if (n1 != null && n2 != null) 
            {
                switch (operador)
                {
                    case "+":
                        resultado = n1 + n2;
                        break;
                    case "-":
                        resultado = n1 - n2;
                        break;
                    case "*":
                        resultado = n1 * n2;
                        break;
                    case "/":
                        resultado = n1 / n2;
                        break;
                }
            } 

            return resultado;
        }
    }
}
