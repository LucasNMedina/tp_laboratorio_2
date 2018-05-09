using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades_2017
{
    public class Leche : Producto
    {
        #region "Enumerados"
        public enum ETipo { Entera, Descremada }
        #endregion

        ETipo _tipo;

        #region "Constructores"
        /// <summary>
        /// Por defecto, TIPO será ENTERA
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="patente"></param>
        /// <param name="color"></param>
        public Leche(EMarca marca, string codigoDeBarra, ConsoleColor color)
            : this(marca, codigoDeBarra, color, ETipo.Entera)
        {
        }

        public Leche(EMarca marca, string codigoDeBarra, ConsoleColor color, ETipo tipo)
            : base(codigoDeBarra, marca, color)
        {
            this._tipo = tipo;
        }
        #endregion

        #region "Propiedades"
        /// <summary>
        /// Las leches tienen 20 calorías
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return 20;
            }
        }
        #endregion

        #region "Métodos"
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("LECHE");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("CALORIAS : " + this.CantidadCalorias);
            sb.AppendLine("TIPO : " + this._tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
