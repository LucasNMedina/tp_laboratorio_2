using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        double _numero;

        #region "Constructores"
        public Numero() { 
        
        }

        public Numero(double numero) : this() {
            this._numero = numero;
        }

        public Numero(string numero) : this() {
            this.SetNumero = numero;
        }
        #endregion

        #region "Propiedades"
        /// <summary>
        /// Asignará un valor al atributo numero, previa validación
        /// </summary>
        public string SetNumero {
            set 
            {
                this._numero = this.ValidarNumero(value);
            }
        }
        #endregion

        #region "Métodos"
        /// <summary>
        /// Comprobará que el valor recibido sea numérico, y lo retornará en formato double. Caso contrario, retornará 0.
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns>double</returns>
        private double ValidarNumero(string strNumero) {
                double numero;
                double.TryParse(strNumero, out numero);
                return numero;
        }


        /// <summary>
        /// Convertirá un número binario a decimal, en caso de ser posible. Caso contrario retornará "Valor inválido".
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>string</returns>
        public string BinarioDecimal(string binario) {
            foreach (char c in binario) {
                if (c != '1' && c != '0')
                    return "Valor Invalido";
            }

            int b=0;
            for (int i = 1; i <= binario.Length; i++)
            {
                b += int.Parse(binario[i - 1].ToString()) * (int)Math.Pow(2, binario.Length - i);
            }

            return b.ToString();
        }

        /// <summary>
        /// Convertirán un número decimal a binario, en caso de ser posible. Caso contrario retornará "Valor inválido".
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>string</returns>
        public string DecimalBinario(string numero) {
            if (this.ValidarNumero(numero) != 0)
            {
                int n = int.Parse(numero);
                numero = "";
                while (n > 0)
                {
                    numero = (n % 2).ToString() + numero;
                    n = n / 2;
                }
                return numero;
            }
            else {
                return ("Valor Invalido");
            }
            /*foreach (char c in numero) {
                if (((int)c) < 48 && ((int)c) > 57)
                    return "Numero Invalido";
            }*/

            
        }

        /// <summary>
        /// Convertirán un número decimal a binario, en caso de ser posible. Caso contrario retornará "Valor inválido".
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>string</returns>
        public string DecimalBinario(double numero)
        {
            return this.DecimalBinario(numero.ToString());
        }
        #endregion

        #region "Sobrecarga de operadores"
        /// <summary>
        /// Sumará dos número.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>double</returns>
        public static double operator +(Numero n1, Numero n2) 
        {
            return (n1._numero + n2._numero);
        }

        /// <summary>
        /// Restará dos números.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator -(Numero n1, Numero n2)
        {
            return (n1._numero - n2._numero);
        }

        /// <summary>
        /// Multiplicará dos números.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator *(Numero n1, Numero n2)
        {
            return (n1._numero * n2._numero);
        }

        /// <summary>
        /// Dividirá dos números.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator /(Numero n1, Numero n2)
        {
            if (n2._numero < 0)
                return 0;
            else
                return (n1._numero / n2._numero); 
        }
        #endregion


    }
}
