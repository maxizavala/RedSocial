﻿namespace RedSocial
{
    partial class FormVerPost
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_PostComentario = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label_listaTag = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comentarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button_volverMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label_PostComentario
            // 
            this.label_PostComentario.AutoSize = true;
            this.label_PostComentario.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_PostComentario.Location = new System.Drawing.Point(22, 22);
            this.label_PostComentario.Name = "label_PostComentario";
            this.label_PostComentario.Size = new System.Drawing.Size(347, 45);
            this.label_PostComentario.TabIndex = 0;
            this.label_PostComentario.Text = "COmentario de posteo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 150);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(344, 27);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(420, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Comentar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Comentarios,
            this.Eliminar});
            this.dataGridView1.Location = new System.Drawing.Point(37, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(477, 369);
            this.dataGridView1.TabIndex = 3;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(598, 80);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(300, 398);
            this.dataGridView2.TabIndex = 4;
            // 
            // label_listaTag
            // 
            this.label_listaTag.AutoSize = true;
            this.label_listaTag.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_listaTag.Location = new System.Drawing.Point(848, 49);
            this.label_listaTag.Name = "label_listaTag";
            this.label_listaTag.Size = new System.Drawing.Size(50, 28);
            this.label_listaTag.TabIndex = 5;
            this.label_listaTag.Text = "Tags";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(608, 537);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            this.ID.Width = 125;
            // 
            // Comentarios
            // 
            this.Comentarios.HeaderText = "Comentarios";
            this.Comentarios.MinimumWidth = 6;
            this.Comentarios.Name = "Comentarios";
            this.Comentarios.Width = 400;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Width = 70;
            // 
            // button_volverMain
            // 
            this.button_volverMain.Location = new System.Drawing.Point(12, 609);
            this.button_volverMain.Name = "button_volverMain";
            this.button_volverMain.Size = new System.Drawing.Size(115, 29);
            this.button_volverMain.TabIndex = 7;
            this.button_volverMain.Text = "Volver Inicio";
            this.button_volverMain.UseVisualStyleBackColor = true;
            this.button_volverMain.Click += new System.EventHandler(this.button_volverMain_Click);
            // 
            // FormVerPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.button_volverMain);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label_listaTag);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_PostComentario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVerPost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVerPost";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_PostComentario;
        private TextBox textBox1;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label_listaTag;
        private Button button2;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Comentarios;
        private DataGridViewButtonColumn Eliminar;
        private Button button_volverMain;
    }
}