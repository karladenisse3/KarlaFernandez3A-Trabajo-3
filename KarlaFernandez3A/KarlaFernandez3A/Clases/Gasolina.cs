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

        private double precioDeVenta;

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

        private double subtotal;

        public double Subtotal
        {
            get { return CantidadDeGalones*PrecioDeVenta; }
        }

        private double iva;

        public double Iva
        {
            get { return Subtotal*0.12; }
        }

        private double total;

        public double Total
        {
            get { return Subtotal+Iva; }
        }


    }
}
