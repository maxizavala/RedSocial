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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "prueba",
            "jeje",
            "jaja"}, -1);
            this.nombreUsuarioActual = new System.Windows.Forms.Label();
            this.nombreCompleto = new System.Windows.Forms.Label();
            this.panelPost = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label_listaDeAmigos = new System.Windows.Forms.Label();
            this.button_agregarAmigo = new System.Windows.Forms.Button();
            this.button_postear = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView_Nombres = new System.Windows.Forms.ColumnHeader();
            this.listView_apellido = new System.Windows.Forms.ColumnHeader();
            this.Posteo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reacciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelPost.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.panelPost.Size = new System.Drawing.Size(640, 490);
            this.panelPost.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(60, 3, 3, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(632, 457);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mis post";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Posteo,
            this.Reacciones});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(632, 457);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(632, 457);
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
            // 
            // label_listaDeAmigos
            // 
            this.label_listaDeAmigos.AutoSize = true;
            this.label_listaDeAmigos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_listaDeAmigos.Location = new System.Drawing.Point(674, 39);
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
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listView_Nombres,
            this.listView_apellido});
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(674, 77);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(250, 499);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // listView_Nombres
            // 
            this.listView_Nombres.Text = "Nombre";
            this.listView_Nombres.Width = 120;
            // 
            // listView_apellido
            // 
            this.listView_apellido.Text = "Apellido";
            this.listView_apellido.Width = 120;
            // 
            // Posteo
            // 
            this.Posteo.HeaderText = "Posteo";
            this.Posteo.MinimumWidth = 6;
            this.Posteo.Name = "Posteo";
            this.Posteo.Width = 125;
            // 
            // Reacciones
            // 
            this.Reacciones.HeaderText = "Column1";
            this.Reacciones.MinimumWidth = 6;
            this.Reacciones.Name = "Reacciones";
            this.Reacciones.Width = 125;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.listView1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private ListView listView1;
        private ColumnHeader listView_Nombres;
        private ColumnHeader listView_apellido;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Posteo;
        private DataGridViewTextBoxColumn Reacciones;
    }
}