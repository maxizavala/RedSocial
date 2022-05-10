using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSocial
{
    public class RedSocial
    {
        private List<Usuario> usuarios;
        public Usuario usuarioActual { get; set; }
        private int idUsuarios;
        private List<Post> posts;
        private List<Tag> tags;

        public RedSocial() 
        {
            usuarios = new List<Usuario>();
            posts = new List<Post>();
            tags = new List<Tag>();
            idUsuarios = 0;
        }

        public bool iniciarSesion(string user, string pass)
        {
            bool usuarioEncontrado = false;

            foreach (Usuario usuario in usuarios) 
            {
                if (usuario.nombre.Equals(user) && usuario.pass.Equals(pass)) 
                {
                    usuarioEncontrado = true;
                }
            }
            return usuarioEncontrado;
        }

        public void agregarUsuario(string usuario, string pass) 
        {
            idUsuarios++;
            usuarios.Add(new Usuario(idUsuarios, usuario, pass));
        }


        // Seccion de logica de Reacciones.
        public void reaccionar(Post post, Reaccion reaccion) {

            reaccion.usuario = usuarioActual;
            usuarioActual.misReacciones.Add(reaccion);
        }

        public void modificarReaccion(Post p, Reaccion r) {

            //busco el indice de la reaccion en la lista de posts
            int aux = posts[p.id].reacciones.FindIndex((reaccion) => reaccion.id == r.id);

            //reemplazo por nueva reaccion
            posts[p.id].reacciones[aux] = r;
        }

        public void quitarReaccion(Post p, Reaccion r) {
            //borro reaccion de la lista
            posts[p.id].reacciones.Remove(r);
        }
    }
}
