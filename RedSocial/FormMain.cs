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
    public partial class FormMain : Form
    {
        private RedSocial miRed;

        public delegate void TransfDelegadoAgregarAmigo();
        public TransfDelegadoAgregarAmigo eventoAgregarAmigo;
        public FormMain(RedSocial miRed)
        {
            this.miRed = miRed;
            InitializeComponent();
            nombreUsuarioActual.Text = miRed.usuarioActual.nombre;
            nombreCompleto.Text = miRed.usuarioActual.nombre + miRed.usuarioActual.apellido;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button_agregarAmigo_Click(object sender, EventArgs e)
        {

        }
    }
}
