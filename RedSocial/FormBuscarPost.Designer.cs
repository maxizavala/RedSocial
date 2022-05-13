namespace RedSocial
{
    partial class FormBuscarPost
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
            this.button_agrgarTag = new System.Windows.Forms.Button();
            this.textBox_Comentario = new System.Windows.Forms.TextBox();
            this.label_Comentario = new System.Windows.Forms.Label();
            this.dateTimePicker_Desde = new System.Windows.Forms.DateTimePicker();
            this.label_Desde = new System.Windows.Forms.Label();
            this.label_Hasta = new System.Windows.Forms.Label();
            this.dateTimePicker_Hasta = new System.Windows.Forms.DateTimePicker();
            this.label_Tags = new System.Windows.Forms.Label();
            this.textBox_Tags = new System.Windows.Forms.TextBox();
            this.dataGridView_Tags = new System.Windows.Forms.DataGridView();
            this.Tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button_Buscar = new System.Windows.Forms.Button();
            this.dataGridView_PosteosRed = new System.Windows.Forms.DataGridView();
            this.idPosteos = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PosteosRed)).BeginInit();
            this.SuspendLayout();
            // 
            // button_agrgarTag
            // 
            this.button_agrgarTag.Location = new System.Drawing.Point(233, 286);
            this.button_agrgarTag.Name = "button_agrgarTag";
            this.button_agrgarTag.Size = new System.Drawing.Size(110, 33);
            this.button_agrgarTag.TabIndex = 0;
            this.button_agrgarTag.Text = "Agregar Tag";
            this.button_agrgarTag.UseVisualStyleBackColor = true;
            this.button_agrgarTag.Click += new System.EventHandler(this.button_agrgarTag_Click);
            // 
            // textBox_Comentario
            // 
            this.textBox_Comentario.Location = new System.Drawing.Point(44, 69);
            this.textBox_Comentario.Name = "textBox_Comentario";
            this.textBox_Comentario.Size = new System.Drawing.Size(296, 27);
            this.textBox_Comentario.TabIndex = 1;
            // 
            // label_Comentario
            // 
            this.label_Comentario.AutoSize = true;
            this.label_Comentario.Location = new System.Drawing.Point(44, 46);
            this.label_Comentario.Name = "label_Comentario";
            this.label_Comentario.Size = new System.Drawing.Size(87, 20);
            this.label_Comentario.TabIndex = 2;
            this.label_Comentario.Text = "Comentario";
            // 
            // dateTimePicker_Desde
            // 
            this.dateTimePicker_Desde.Location = new System.Drawing.Point(44, 135);
            this.dateTimePicker_Desde.Name = "dateTimePicker_Desde";
            this.dateTimePicker_Desde.Size = new System.Drawing.Size(296, 27);
            this.dateTimePicker_Desde.TabIndex = 3;
            // 
            // label_Desde
            // 
            this.label_Desde.AutoSize = true;
            this.label_Desde.Location = new System.Drawing.Point(44, 112);
            this.label_Desde.Name = "label_Desde";
            this.label_Desde.Size = new System.Drawing.Size(51, 20);
            this.label_Desde.TabIndex = 4;
            this.label_Desde.Text = "Desde";
            // 
            // label_Hasta
            // 
            this.label_Hasta.AutoSize = true;
            this.label_Hasta.Location = new System.Drawing.Point(44, 182);
            this.label_Hasta.Name = "label_Hasta";
            this.label_Hasta.Size = new System.Drawing.Size(47, 20);
            this.label_Hasta.TabIndex = 6;
            this.label_Hasta.Text = "Hasta";
            // 
            // dateTimePicker_Hasta
            // 
            this.dateTimePicker_Hasta.Location = new System.Drawing.Point(44, 205);
            this.dateTimePicker_Hasta.Name = "dateTimePicker_Hasta";
            this.dateTimePicker_Hasta.Size = new System.Drawing.Size(296, 27);
            this.dateTimePicker_Hasta.TabIndex = 5;
            // 
            // label_Tags
            // 
            this.label_Tags.AutoSize = true;
            this.label_Tags.Location = new System.Drawing.Point(44, 266);
            this.label_Tags.Name = "label_Tags";
            this.label_Tags.Size = new System.Drawing.Size(38, 20);
            this.label_Tags.TabIndex = 8;
            this.label_Tags.Text = "Tags";
            // 
            // textBox_Tags
            // 
            this.textBox_Tags.Location = new System.Drawing.Point(44, 289);
            this.textBox_Tags.Name = "textBox_Tags";
            this.textBox_Tags.Size = new System.Drawing.Size(183, 27);
            this.textBox_Tags.TabIndex = 7;
            // 
            // dataGridView_Tags
            // 
            this.dataGridView_Tags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Tags.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tag,
            this.Eliminar});
            this.dataGridView_Tags.Location = new System.Drawing.Point(44, 340);
            this.dataGridView_Tags.Name = "dataGridView_Tags";
            this.dataGridView_Tags.RowHeadersVisible = false;
            this.dataGridView_Tags.RowHeadersWidth = 51;
            this.dataGridView_Tags.RowTemplate.Height = 29;
            this.dataGridView_Tags.Size = new System.Drawing.Size(296, 210);
            this.dataGridView_Tags.TabIndex = 9;
            // 
            // Tag
            // 
            this.Tag.HeaderText = "Tag";
            this.Tag.MinimumWidth = 6;
            this.Tag.Name = "Tag";
            this.Tag.Width = 220;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Width = 70;
            // 
            // button_Buscar
            // 
            this.button_Buscar.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Buscar.Location = new System.Drawing.Point(44, 567);
            this.button_Buscar.Name = "button_Buscar";
            this.button_Buscar.Size = new System.Drawing.Size(296, 43);
            this.button_Buscar.TabIndex = 10;
            this.button_Buscar.Text = "Buscar";
            this.button_Buscar.UseVisualStyleBackColor = true;
            // 
            // dataGridView_PosteosRed
            // 
            this.dataGridView_PosteosRed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_PosteosRed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPosteos,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView_PosteosRed.Location = new System.Drawing.Point(386, 46);
            this.dataGridView_PosteosRed.Name = "dataGridView_PosteosRed";
            this.dataGridView_PosteosRed.RowHeadersVisible = false;
            this.dataGridView_PosteosRed.RowHeadersWidth = 51;
            this.dataGridView_PosteosRed.RowTemplate.Height = 29;
            this.dataGridView_PosteosRed.Size = new System.Drawing.Size(535, 564);
            this.dataGridView_PosteosRed.TabIndex = 11;
            // 
            // idPosteos
            // 
            this.idPosteos.HeaderText = "idPosteos";
            this.idPosteos.MinimumWidth = 6;
            this.idPosteos.Name = "idPosteos";
            this.idPosteos.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idPosteos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idPosteos.Visible = false;
            this.idPosteos.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Posteo";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 440;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Ver Post";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn5.Width = 90;
            // 
            // FormBuscarPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.dataGridView_PosteosRed);
            this.Controls.Add(this.button_Buscar);
            this.Controls.Add(this.dataGridView_Tags);
            this.Controls.Add(this.label_Tags);
            this.Controls.Add(this.textBox_Tags);
            this.Controls.Add(this.label_Hasta);
            this.Controls.Add(this.dateTimePicker_Hasta);
            this.Controls.Add(this.label_Desde);
            this.Controls.Add(this.dateTimePicker_Desde);
            this.Controls.Add(this.label_Comentario);
            this.Controls.Add(this.textBox_Comentario);
            this.Controls.Add(this.button_agrgarTag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBuscarPost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBuscarPost";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tags)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PosteosRed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_agrgarTag;
        private TextBox textBox_Comentario;
        private Label label_Comentario;
        private DateTimePicker dateTimePicker_Desde;
        private Label label_Desde;
        private Label label_Hasta;
        private DateTimePicker dateTimePicker_Hasta;
        private Label label_Tags;
        private TextBox textBox_Tags;
        private DataGridView dataGridView_Tags;
        private DataGridViewTextBoxColumn Tag;
        private DataGridViewButtonColumn Eliminar;
        private Button button_Buscar;
        private DataGridView dataGridView_PosteosRed;
        private DataGridViewButtonColumn idPosteos;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewButtonColumn dataGridViewTextBoxColumn5;
    }
}