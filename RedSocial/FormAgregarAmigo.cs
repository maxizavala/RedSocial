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
    public partial class FormAgregarAmigo : Form
    {
        RedSocial miRed;
        private int seleccionado; 

        public delegate void TransfDelegado();
        public TransfDelegado eventoMain;

        public FormAgregarAmigo(RedSocial miRed)
        {
            InitializeComponent();
            this.miRed = miRed;
            foreach(Usuario dato in miRed.getUsuarios())
            {
                this.dataGridView_Usuarios.Rows.Add(
                    dato.nombre,dato.apellido,dato.mail,dato.dni,dato.id);
            }
        }

        private void button_volverMenu_Click(object sender, EventArgs e)
        {
            this.eventoMain();
            this.Close();
        }



        private void button_agregarAmigo_Click(object sender, EventArgs e)
        {
            label_ayuda.Text = "";
        }

        private void seleccionarCelda(object sender, DataGridViewCellEventArgs e)
        {
            seleccionado = e.RowIndex;

            if(seleccionado != null && seleccionado != -1)
            {
                //Usuario usuario = dataGridView_Usuarios.Rows[seleccionado].Cells[4].Value;
            }
        }

        private void button_ayuda_Click(object sender, EventArgs e)
        {
            label_ayuda.Text = "Para agregar a un amigo\n haga clic en uno de los\n datos de el." +
                "\n Despues haga clic en\n el boton agregar amigo";

        }
    }
}
