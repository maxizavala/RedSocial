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
        private int cantidadUsuarios;
        private List<Post> posts;
        private List<Tag> tags;

        public RedSocial() 
        {
            usuarios = new List<Usuario>();
            posts = new List<Post>();
            tags = new List<Tag>();
            cantidadUsuarios = 0;
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

        public void registrarUsuario(string dni, string nombre, string apellido, string mail,
                string pass, int intentosFallidos, bool bloqueado)
        {
            cantidadUsuarios++;
            usuarios.Add(new Usuario(cantidadUsuarios, dni, nombre, apellido, mail, pass, intentosFallidos, bloqueado));
        }

        public void modificarUsuario(Usuario u)
        {
            //Busco en la lista el indice del usuario
            int aux = usuarios.FindIndex(usuario => usuario.id == u.id);
            usuarios[aux] = u;
        }

        public void eliminarUsuario(Usuario u)
        {
            //Se remueve usuario de la lista
            usuarios.Remove(u); 
        }

    }
}
