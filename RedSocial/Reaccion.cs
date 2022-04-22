using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSocial
{
    public class Reaccion
    {
        public int id { get; set; }
        public int tipo { get; set; }
        public Post post { get; set; }
        public Usuario usuario{ get; set; }

        public Reaccion(int id, int tipo, Post post, Usuario usuario)
        {
            this.id = id;
            this.tipo = tipo;
            this.post = post;
            this.usuario = usuario;
        }

    }
}
