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
            int intentos = 0;

            foreach (Usuario usuario in usuarios) 
            {
                if(usuario.nombre.Equals(user)) 
                {
                    if(!usuario.bloqueado) { 
                        if(usuario.pass.Equals(pass){
                            usuarioEncontrado = true;
                            this.usuarioActual = usuario;
                        } else {
                            intentos++;
                            if(intentos == usuario.intentosFallidos)
                            {
                                usuario.bloqueado = true;
                                intentos=0;
                            }
                        }
                    }
                    //Se podria mostrar un mensaje si usuario.bloqueado = true;
                }
            }
            return usuarioEncontrado;
        }

        public void cerrarSesion()
        {
            this.usuarioActual = null;
        }

        public void agregarUsuario(string usuario, string pass) 
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

        //ABM Clase Tag


    }
}
