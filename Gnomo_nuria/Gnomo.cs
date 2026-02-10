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
        protected int vida;

        public Gnomo(string nombre, string color, int vida)
        {
            this.nombre = nombre;
            this.color = color;
            this.vida = vida;
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

        public int Vida
        {
            get { return vida; }
            set { vida = 100; }
        }

    }

}