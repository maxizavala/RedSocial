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

        public void registrarUsuario(string usuario, string pass) 
        {
            idUsuarios++;
            usuarios.Add(new Usuario(idUsuarios, usuario, pass));
        }

        public void reaccionar(Post post, Reaccion reaccion) {

            reaccion.usuario = usuarioActual;
            reaccion
            post.reacciones.Add(reaccion);
            usuarioActual.misReacciones.Add(reaccion);



        }
    }
}
