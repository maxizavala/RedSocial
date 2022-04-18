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
        private int idUsuarios;
        public RedSocial() 
        {
            usuarios = new List<Usuario>();
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
    }
}
