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
            
            usuarios.Add(new Usuario(cantidadUsuarios, dni, nombre, apellido, mail, pass, intentosFallidos, bloqueado));
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
            usuarioActual.misPost.Add(post); // agrega post al usuario actual
            post.tags.AddRange(tags);   // agrega tags al post
            foreach (Tag tag in tags)
            {
                if(tags.Contains(tag)){
                    this.tags.Add(tag); // agrega tag que no esta en la lista
                }
            }

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
            if(posts.Contains(post) && usuarioActual.misPost.Contains(post))
            {
                usuarioActual.misPost.Remove(post);
                this.posts.Remove(post);
            }
        }


    }

}        
