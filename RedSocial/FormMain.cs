﻿using System;
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
        private int seleccionarAmigo;

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
            foreach(Usuario amigos in miRed.mostrarDatos().amigos)
            {
                dataGridView_listaAmigos.Rows.Add(amigos.id,amigos.nombre,amigos.apellido,"X");
            }
        }


        private void button_agregarAmigo_Click(object sender, EventArgs e)
        {
            this.eventoAgregarAmigo();
            this.Close();
        }


        private void seleccionadorAmigo(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarAmigo = e.RowIndex;
        }

        private void eliminadorAmigo(object sender, DataGridViewCellEventArgs e)
        {
            if (seleccionarAmigo != null && seleccionarAmigo != -1)
            {
                miRed.quitarAmigo(int.Parse(dataGridView_listaAmigos.Rows[seleccionarAmigo].Cells[0].Value.ToString()));
                
            }
        }
    }
}
