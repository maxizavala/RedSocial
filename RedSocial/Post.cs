using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSocial
{
    public class Post
    {
        public int id { get; set; }
        public Usuario user {get; set;}
        public string contenido {get; set;}
        public List<Comentario> comentarios {get; set;}
        public List<Reaccion> reacciones {get; set;}
        public List<Tag> tags {get; set;}
        public DateTime fecha {get; set;}

        public Post(int id, Usuario usuario, string contenido, List<Comentario> comentarios, List<Reaccion> reacciones, List<Tag> tags, DateTime fecha)
        {

            this.id = id;
            this.user = usuario;
            this.contenido = contenido;
            this.comentarios = comentarios;
            this.reacciones = reacciones;
            this.tags = tags;
            this.fecha = fecha;

        }
    }
    
}
