using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarlaFernandez3A.Clases
{
    public class Gasolina
    {
        private string tipo;

        public string Tipo
        {
            get { return tipo;  }
            set { tipo = value; }
        }

        private int cantidadDeGalones;

        public int CantidadDeGalones
        {
            get { return cantidadDeGalones; }
            set { cantidadDeGalones = value; }
        }

        public double PrecioDeVenta
        {
            get 
            {

                if (this.tipo == "Extra")
                {
                    return 1.5;
                }
                else
                {
                    return 2;
                }
            }
        }

        public double Subtotal
        {
            get { return CantidadDeGalones*PrecioDeVenta; }
        }

        public double Iva
        {
            get { return Subtotal*0.12; }
        }

        public double Total
        {
            get { return Subtotal+Iva; }
        }


    }
}
