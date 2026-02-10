using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gnomo_nuria
{
    public class Gnomo
    {
        protected string nombre;
        protected string color;

        public Gnomo(string nombre, string color)
        {
            this.nombre = nombre;
            this.color = color;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
    }
}
