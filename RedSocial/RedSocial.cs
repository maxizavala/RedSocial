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
                if (usuario.intentosFallidos == 3) {
                    usuarios[usuario.id].bloqueado = true;
                }

                if (usuario.nombre.Equals(user) && usuario.pass.Equals(pass) && usuario.bloqueado != true)
                {
                    usuarioEncontrado = true;
                } else if (usuario.nombre.Equals(user) && !usuario.pass.Equals(pass)) {
                    usuarios[usuario.id].intentosFallidos++;
                }

            }
            return usuarioEncontrado;
        }

        //Seccion de logica Usuarios

        public void registrarUsuario(string dni, string nombre, string apellido, string mail,
                string pass)
        {
            
            usuarios.Add(new Usuario(cantidadUsuarios, dni, nombre, apellido, mail, pass));
            cantidadUsuarios++;
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

        //Seccion Amigos

        public void agregarAmigo(Usuario amigo)
        {
            //Se agrega a amigos al usuario
            int aux = usuarios.FindIndex(usuario => usuario.id == usuarioActual.id);
            usuarios[aux].amigos.Add(amigo);

            //El usuario que fue agregado, tambien agrega al usuario que lo agrego a amigos
            int aux2 = usuarios.FindIndex(usuario => usuario.id == amigo.id);
            usuarios[aux2].amigos.Add(usuarioActual);
        }

        public void quitarAmigo(Usuario exAmigo)
        {
            //Se elimina el amigo
            int aux = usuarios.FindIndex(usuario => usuario.id == usuarioActual.id);
            usuarios[aux].amigos.Remove(exAmigo);

            //El usuario que fue eliminado, tambien elimina al usuario que lo elimino
            int aux2 = usuarios.FindIndex(usuario => usuario.id == exAmigo.id);
            usuarios[aux2].amigos.Remove(usuarioActual);
        }

        // Seccion de logica de Reacciones.
        public void reaccionar(Post post, Reaccion reaccion)
        {

            reaccion.usuario = usuarioActual;

            // Busco el indice del usuario en la lista para agregarle sus reacciones
            int aux = usuarios.FindIndex(usuario => usuario.id == usuarioActual.id);
            usuarios[aux].misReacciones.Add(reaccion);

        }

        public void modificarReaccion(Post p, Reaccion r)
        {

            //busco el indice de la reaccion en la lista de posts
            int aux = posts[p.id].reacciones.FindIndex((reaccion) => reaccion.id == r.id);

            //reemplazo por nueva reaccion
            posts[p.id].reacciones[aux] = r;
        }

        public void quitarReaccion(Post p, Reaccion r)
        {
            //Borro reaccion de la lista
            posts[p.id].reacciones.Remove(r);
        }

        //---------------------------METODOS DEL POSTEO-------------------
        public void postear(Post post, List<Tag> tags)
        {

            post.tags = tags; //agrego la lista de tags al post

            int aux = usuarios.FindIndex(usuario => usuario.id == usuarioActual.id);
            usuarios[aux].misPost.Add(post); // agrega post al usuario actual en la lista de usuarios
           
            posts.Add(post); //agrego post a la lista de posts


        }

        public void modificarPost(Post postExistente, Post modificado)
        {
            if (postExistente != null || posts.Contains(postExistente))
            {
                int index = posts.FindIndex(tag => tag.id == postExistente.id);
                posts[index] = modificado;

            }
        }

        public void eliminarPost(Post post)
        {

            int aux = usuarios.FindIndex(usuario => usuario.id == usuarioActual.id);
            usuarios[aux].misPost.Remove(post); // borro el post de la lista de posts del usuario

            posts.Remove(post); //borro el post de la lista de posts
            
        }

        //---------------------------MOSTRAR DATOS-------------------

        //Mostrar datos usuario
        public Usuario mostrarDatos()
        {
            return usuarioActual;
        }

        //Mostar posts
        public List<Post> mostrarPost()
        {
            return posts;
        }

        //Mostrar posts amigo
        public List<Post> mostrarPostAmigo()
        {
            List<Post> postAmigo = new List<Post>();
            foreach (Usuario amigo in usuarioActual.amigos)
            {
                foreach (Post post in amigo.misPost)
                {
                    postAmigo.Add(post);
                }
            }
            return postAmigo;
        }

    }

}        
