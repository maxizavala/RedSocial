using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSocial
{
    public class Usuario
    {
        public string nombre { get; set; }
        public string pass { get; set; }
        public int id { get; }

        public Usuario() { }

        public Usuario(int id, string Nombre, string Pass) 
        {
            this.id = id;
            nombre = Nombre;
            pass = Pass;
        }
    }
}
