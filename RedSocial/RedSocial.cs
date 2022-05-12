﻿using System;
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
        private List<Comentario> comentarios;


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
                    this.usuarioActual = usuario;
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

        private void modificarUsuario(Usuario u)
        {
            //Busco en la lista el indice del usuario
            int aux = usuarios.FindIndex(usuario => usuario.id == u.id);
            usuarios[aux] = u;
        }

        private void eliminarUsuario(Usuario u)
        {
            //Se remueve usuario de la lista
            usuarios.Remove(u);
        }

        public void eliminarUsuario(int id)
        {
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.id == id)
                {
                    eliminarUsuario(usuario);
                }
            }
        }

        //Seccion Amigos

        private bool agregarAmigo(Usuario amigo)
        {
            if(usuarioActual.id == amigo.id || usuarioActual.amigos.Contains(amigo))
            {
                return false;
            }
            else {
                //Se agrega a amigos al usuario
                int aux = usuarios.FindIndex(usuario => usuario.id == usuarioActual.id);
                usuarios[aux].amigos.Add(amigo);

                //El usuario que fue agregado, tambien agrega al usuario que lo agrego a amigos
                int aux2 = usuarios.FindIndex(usuario => usuario.id == amigo.id);
                usuarios[aux2].amigos.Add(usuarioActual);

                return true;
            }
            
        }

        private void quitarAmigo(Usuario exAmigo)
        {
            //Se elimina el amigo
            int aux = usuarios.FindIndex(usuario => usuario.id == usuarioActual.id);
            usuarios[aux].amigos.Remove(exAmigo);

            //El usuario que fue eliminado, tambien elimina al usuario que lo elimino
            int aux2 = usuarios.FindIndex(usuario => usuario.id == exAmigo.id);
            usuarios[aux2].amigos.Remove(usuarioActual);
        }

        public void quitarAmigo(int id)
        {
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.id == id)
                {
                    quitarAmigo(usuario);
                }
            }
        }

        // Seccion de logica de Reacciones.
        private void reaccionar(Post post, Reaccion reaccion)
        {

            reaccion.usuario = usuarioActual;

            // Busco el indice del usuario en la lista para agregarle sus reacciones
            int aux = usuarios.FindIndex(usuario => usuario.id == usuarioActual.id);
            usuarios[aux].misReacciones.Add(reaccion);

            int aux2 = posts.FindIndex(p => p.id == post.id);
            posts[aux2].reacciones.Add(reaccion);

        }

        public void reaccionar(int id, Reaccion reaccion)
        {
            foreach(Post p in posts)
            {
                if(p.id == id)
                {
                    reaccionar(p, reaccion);
                }
            }
        }

        private void modificarReaccion(Post post, Reaccion r)
        {
            int aux2 = posts.FindIndex(p => p.id == post.id);
            
            //busco el indice de la reaccion en la lista de posts
            int aux = posts[aux2].reacciones.FindIndex((reaccion) => reaccion.id == r.id);

            //reemplazo por nueva reaccion
            posts[aux2].reacciones[aux] = r;
        }

        public void modificarReaccion(int id, Reaccion reaccion)
        {
            foreach (Post p in posts)
            {
                if (p.id == id)
                {
                    modificarReaccion(p, reaccion);
                }
            }
        }


        private void quitarReaccion(Post post, Reaccion r)
        {
            //Borro reaccion de la lista
            int aux2 = posts.FindIndex(p => p.id == post.id);
            posts[aux2].reacciones.Remove(r);
        }

        public void quitarReaccion(int id, int idReaccion)
        {
            foreach (Post p in posts)
            {
                if (p.id == id)
                {
                    foreach(Reaccion r2 in p.reacciones)
                    {
                        if (r2.id == idReaccion)
                        {
                            quitarReaccion(p, r2);
                        }
                    }
                 
                }
            }
        }


        //---------------------------METODOS DEL POSTEO-------------------
        public void postear(Post post, List<Tag> tag)
        {

            foreach (Tag t in tag)
            {
                //agrego los tag que no existan a la lista de tags 
                if (!tags.Contains(t))
                {
                    tags.Add(t);
                }

                //agrego post a la lista post con esos tags 
                int taux = tags.FindIndex(ta => ta.id == t.id);
                tags[taux].posts.Add(post);
            }

            post.tags = tag; //agrego la lista de tags al post
            int aux = usuarios.FindIndex(usuario => usuario.id == usuarioActual.id);
            usuarios[aux].misPost.Add(post); // agrega post al usuario actual en la lista de usuarios

            posts.Add(post); //agrego post a la lista de posts
        }

        public void modificarPost(Post post)
        {
            int aux = posts.FindIndex(p => p.id == post.id);
            posts[aux] = post;
        }

        public void eliminarPost(Post post)
        {
            //busco al usuario en la lista de usuarios
            int aux = usuarios.FindIndex(usuario => usuario.id == usuarioActual.id);

            //busco la reaccion correspondiente al post 
            Reaccion reaccionEliminar;
            if (post.reacciones != null)
            {
                //elimino la reaccion correspondiente al post
                reaccionEliminar = usuarios[aux].misReacciones.Find(x => x.post.Equals(post));
                usuarios[aux].misReacciones.Remove(reaccionEliminar);
            }
            //Busco el comentario correspondiente al post
            Comentario comentarioEliminar;
            if (post.comentarios != null)
            {
                //Se elimina el comentario del post
                comentarioEliminar = usuarios[aux].misComentarios.Find(x => x.post.Equals(post));
                usuarios[aux].misComentarios.Remove(comentarioEliminar);
            }

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

        //Buscar posts
        public List<Post> buscarPosts(string contenido, DateTime fechaDesde, DateTime fechaHasta, List<Tag> t)
        {
            List<Post> bPost = new List<Post>();
            foreach (Post post in posts)
            {
                if (post.contenido.Equals(contenido))
                {
                    bPost.Add(post);
                } else if (post.fecha >= fechaDesde && post.fecha <= fechaHasta)
                {
                    bPost.Add(post);
                } else
                {
                    foreach (Tag p in post.tags)
                    {
                        if (t.Contains(p))
                        {
                            bPost.Add(post);
                        }
                    }
                }
            }
            return bPost;
        }


        //Metodos Comentarios


        //Comentar
        public void Comentar(Post p, Comentario c) {

            c.usuario = usuarioActual;
            c.post = p;

            comentarios.Add(c);
            p.comentarios.Add(c);

            int aux = usuarios.FindIndex(usuario => usuario.id == usuarioActual.id);
            usuarios[aux].misComentarios.Add(c);
        }

        //Modificar comentario
        public void ModificarComentario(Comentario c)
        {
            int auxC = comentarios.FindIndex(comentario => comentario.id == c.id);
            comentarios[auxC] = c;
        }

        //Borrar comentario
        public void QuitarComentario(Post p, Comentario c) {
            posts[p.id].comentarios.Remove(c);

            int aux = usuarios.FindIndex(usuario => usuario.id == usuarioActual.id);
            usuarios[aux].misComentarios.Remove(c);

            comentarios.Remove(c);
        }


        public List<Usuario> getUsuarios()
        {
            return this.usuarios;
        }

        //-------------------------------Metodos de busqueda-------------------------------

        public bool agregarAmigo(int id) {
            
            foreach (Usuario u in usuarios)
            {
                if (u.id == id)
                {
                    return agregarAmigo(u);
                }
               
            }

            return false;
        }





    }

}        
