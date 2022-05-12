namespace RedSocial
{
    partial class FormMain
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
            this.nombreUsuarioActual = new System.Windows.Forms.Label();
            this.nombreCompleto = new System.Windows.Forms.Label();
            this.panelPost = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView_Post = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label_listaDeAmigos = new System.Windows.Forms.Label();
            this.button_agregarAmigo = new System.Windows.Forms.Button();
            this.button_postear = new System.Windows.Forms.Button();
            this.dataGridView_listaAmigos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Posteo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VerPost = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelPost.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Post)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listaAmigos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreUsuarioActual
            // 
            this.nombreUsuarioActual.AutoSize = true;
            this.nombreUsuarioActual.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nombreUsuarioActual.Location = new System.Drawing.Point(12, 6);
            this.nombreUsuarioActual.Name = "nombreUsuarioActual";
            this.nombreUsuarioActual.Size = new System.Drawing.Size(133, 46);
            this.nombreUsuarioActual.TabIndex = 0;
            this.nombreUsuarioActual.Text = "Usuario";
            // 
            // nombreCompleto
            // 
            this.nombreCompleto.AutoSize = true;
            this.nombreCompleto.Location = new System.Drawing.Point(12, 52);
            this.nombreCompleto.Name = "nombreCompleto";
            this.nombreCompleto.Size = new System.Drawing.Size(0, 20);
            this.nombreCompleto.TabIndex = 1;
            // 
            // panelPost
            // 
            this.panelPost.Controls.Add(this.tabPage1);
            this.panelPost.Controls.Add(this.tabPage2);
            this.panelPost.Location = new System.Drawing.Point(12, 90);
            this.panelPost.Name = "panelPost";
            this.panelPost.Padding = new System.Drawing.Point(60, 3);
            this.panelPost.SelectedIndex = 0;
            this.panelPost.Size = new System.Drawing.Size(570, 490);
            this.panelPost.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView_Post);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(60, 3, 3, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(562, 457);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mis post";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Post
            // 
            this.dataGridView_Post.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Post.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Posteo,
            this.VerPost,
            this.dataGridViewButtonColumn1});
            this.dataGridView_Post.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Post.Name = "dataGridView_Post";
            this.dataGridView_Post.RowHeadersVisible = false;
            this.dataGridView_Post.RowHeadersWidth = 51;
            this.dataGridView_Post.RowTemplate.Height = 29;
            this.dataGridView_Post.Size = new System.Drawing.Size(559, 457);
            this.dataGridView_Post.TabIndex = 0;
            this.dataGridView_Post.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.seleccionadorPost);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(562, 457);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Posteos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 609);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(379, 609);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "Buscar Post";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_irFormPostear);
            // 
            // label_listaDeAmigos
            // 
            this.label_listaDeAmigos.AutoSize = true;
            this.label_listaDeAmigos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_listaDeAmigos.Location = new System.Drawing.Point(777, 24);
            this.label_listaDeAmigos.Name = "label_listaDeAmigos";
            this.label_listaDeAmigos.Size = new System.Drawing.Size(147, 28);
            this.label_listaDeAmigos.TabIndex = 6;
            this.label_listaDeAmigos.Text = "Lista de amigos";
            // 
            // button_agregarAmigo
            // 
            this.button_agregarAmigo.Location = new System.Drawing.Point(805, 609);
            this.button_agregarAmigo.Name = "button_agregarAmigo";
            this.button_agregarAmigo.Size = new System.Drawing.Size(119, 29);
            this.button_agregarAmigo.TabIndex = 7;
            this.button_agregarAmigo.Text = "Agregar amigo";
            this.button_agregarAmigo.UseVisualStyleBackColor = true;
            this.button_agregarAmigo.Click += new System.EventHandler(this.button_agregarAmigo_Click);
            // 
            // button_postear
            // 
            this.button_postear.Location = new System.Drawing.Point(279, 609);
            this.button_postear.Name = "button_postear";
            this.button_postear.Size = new System.Drawing.Size(94, 29);
            this.button_postear.TabIndex = 8;
            this.button_postear.Text = "Postear";
            this.button_postear.UseVisualStyleBackColor = true;
            // 
            // dataGridView_listaAmigos
            // 
            this.dataGridView_listaAmigos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_listaAmigos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Apellido,
            this.Eliminar});
            this.dataGridView_listaAmigos.Location = new System.Drawing.Point(602, 71);
            this.dataGridView_listaAmigos.Name = "dataGridView_listaAmigos";
            this.dataGridView_listaAmigos.RowHeadersVisible = false;
            this.dataGridView_listaAmigos.RowHeadersWidth = 51;
            this.dataGridView_listaAmigos.RowTemplate.Height = 29;
            this.dataGridView_listaAmigos.Size = new System.Drawing.Size(324, 509);
            this.dataGridView_listaAmigos.TabIndex = 9;
            this.dataGridView_listaAmigos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.seleccionadorAmigo);
            this.dataGridView_listaAmigos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eliminadorAmigo);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            this.ID.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 6;
            this.Apellido.Name = "Apellido";
            this.Apellido.Width = 125;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Eliminar.Width = 70;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(4, 1);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(555, 453);
            this.dataGridView2.TabIndex = 0;
            // 
            // Posteo
            // 
            this.Posteo.HeaderText = "Posteo";
            this.Posteo.MinimumWidth = 6;
            this.Posteo.Name = "Posteo";
            this.Posteo.Width = 360;
            // 
            // VerPost
            // 
            this.VerPost.HeaderText = "Ver Post";
            this.VerPost.MinimumWidth = 6;
            this.VerPost.Name = "VerPost";
            this.VerPost.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.VerPost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.VerPost.Width = 125;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Eliminar";
            this.dataGridViewButtonColumn1.MinimumWidth = 6;
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewButtonColumn1.Width = 70;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.dataGridView_listaAmigos);
            this.Controls.Add(this.button_postear);
            this.Controls.Add(this.button_agregarAmigo);
            this.Controls.Add(this.label_listaDeAmigos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelPost);
            this.Controls.Add(this.nombreCompleto);
            this.Controls.Add(this.nombreUsuarioActual);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panelPost.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Post)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listaAmigos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label nombreUsuarioActual;
        private Label nombreCompleto;
        private TabControl panelPost;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button1;
        private Button button2;
        private Label label_listaDeAmigos;
        private Button button_agregarAmigo;
        private Button button_postear;
        private DataGridView dataGridView_Post;
        private DataGridView dataGridView_listaAmigos;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewButtonColumn Eliminar;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Posteo;
        private DataGridViewButtonColumn VerPost;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
    }
}