﻿using Microsoft.VisualBasic;
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
        int comentarioSeleccionado;

        public delegate void TransfDelegado();
        public TransfDelegado eventoMain;
        public FormVerPost(RedSocial red, int idPost)
        {
            miRed = red;
            post = miRed.buscarPost(idPost);
            InitializeComponent();
            label_PostComentario.Text = post.contenido;
            foreach(Tag tag in post.tags)
            {
                dataGridView_Tags.Rows.Add(tag.palabra);
            }
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
                Comentario comentario = new Comentario(post, miRed.usuarioActual, textBox_Comentar.Text, DateTime.Now);
                miRed.comentar(post, comentario);
                dataGridView_Comentarios.Rows.Add(comentario.id, comentario.contenido, "Modificar");
                textBox_Comentar.Text = "";
            }
        }

        private void selectorComentario(object sender, DataGridViewCellEventArgs e)
        {
            comentarioSeleccionado = e.RowIndex;
        }
            private void dataGridView_Comentarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(MessageBox.Show("Quiere borrar su comentario?",
                "Mensaje",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes){
                miRed.quitarComentario(post.id, int.Parse(dataGridView_Comentarios.Rows[comentarioSeleccionado].Cells[0].Value.ToString()));
                dataGridView_Comentarios.Rows.Remove(dataGridView_Comentarios.Rows[comentarioSeleccionado]);
            }
            else
            {
                string nuevoComentario = Interaction.InputBox("Ingrese el replazo de comentario:");
                miRed.modificarComentario(int.Parse(dataGridView_Comentarios.Rows[comentarioSeleccionado].Cells[0].Value.ToString()),nuevoComentario);
                dataGridView_Comentarios.Rows[comentarioSeleccionado].Cells[1].Value = nuevoComentario;
            }
        }
    }
}