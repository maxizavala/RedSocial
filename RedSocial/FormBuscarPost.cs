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
    public partial class FormBuscarPost : Form
    {
        RedSocial miRed;
        int tagSeleccionado;

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

        private void button_FormMain_Click(object sender, EventArgs e)
        {
            this.eventoMain();
            this.Close();
        }

        private void eliminarTag(object sender, DataGridViewCellEventArgs e)
        {
            if (tagSeleccionado != null && tagSeleccionado != -1)
            {
                if (MessageBox.Show("Quiere quitar este tag?",
                    "Mensaje",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dataGridView_Tags.Rows.Remove(dataGridView_Tags.Rows[tagSeleccionado]);
                }
            }
        }
        private void seleccionarTag(object sender, DataGridViewCellEventArgs e)
        {
            tagSeleccionado = e.RowIndex;
        }

        private void button_Buscar_Click(object sender, EventArgs e)
        {
            string comentario = textBox_Comentario.Text;
            string desde = dateTimePicker_Desde.Text;
            label_Comentario.Text = comentario;
        }
    }
}