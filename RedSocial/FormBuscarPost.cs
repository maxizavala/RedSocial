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
    public partial class FormBuscarPost : Form
    {
        RedSocial miRed;

        public delegate void TransfDelegado();
        public TransfDelegado eventoMain;
        public FormBuscarPost(RedSocial red)
        {
            miRed = red;
            InitializeComponent();
        }

        private void button_agrgarTag_Click(object sender, EventArgs e)
        {
            if (textBox_Tags.Text != "")
            {
                dataGridView_Tags.Rows.Add(textBox_Tags.Text, "Eliminar");
                textBox_Tags.Text = "";
            }
        }
    }
}
