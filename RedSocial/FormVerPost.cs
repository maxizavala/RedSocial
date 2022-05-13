using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedSocial
{
    public partial class FormVerPost : Form
    {
        RedSocial miRed;
        Post post;

        public delegate void TransfDelegado();
        public TransfDelegado eventoMain;
        public FormVerPost(RedSocial red, int idPost)
        {
            miRed = red;
            post = miRed.buscarPost(idPost);
            InitializeComponent();
            label_PostComentario.Text = post.contenido;
        }

        private void button_volverMain_Click(object sender, EventArgs e)
        {
            this.eventoMain();
            this.Close();
        }

        private void button_Comentar_Click(object sender, EventArgs e)
        {
            if(textBox_Comentar.Text != "")
            {
                miRed.comentar(post, new Comentario(post, miRed.usuarioActual, textBox_Comentar.Text, DateTime.Now));
            }
            label_listaTag.Text = DateTime.Now.ToString();
        }
    }
}
