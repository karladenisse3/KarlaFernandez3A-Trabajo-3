using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarlaFernandez3A.Clases
{
    public class Cliente
    {
        private string apellidos;

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        private string nombres;

        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        private int numeroDeCedulaDeIdentidad;

        public int NumeroDeCedulaDeIdentidad
        {
            get { return numeroDeCedulaDeIdentidad; }
            set { numeroDeCedulaDeIdentidad = value; }
        }

        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

    }
}
