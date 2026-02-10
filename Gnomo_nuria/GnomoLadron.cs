using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gnomo_nuria
{
    public class GnomoLadron : Gnomo
    {
        private string especialidad;

        public GnomoLadron(string nombre, string color, string especialidad, int vida)
            : base(nombre, color, vida)
        {
            this.especialidad = especialidad;
        }

        public string Especialidad
        {
            get { return especialidad; }
            set { especialidad = value; }
        }

        public bool RobarObjeto(Objeto objeto)
        {
            // Lógica de ejemplo
            return objeto != null && objeto.Valor > 0;
        }
    }
}
