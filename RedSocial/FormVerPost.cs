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
    }
}
