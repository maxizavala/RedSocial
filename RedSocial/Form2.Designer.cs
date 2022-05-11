namespace RedSocial
{
    partial class Form2
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
            this.listBox_ListaDeAmigos = new System.Windows.Forms.ListBox();
            this.panelPost = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label_listaDeAmigos = new System.Windows.Forms.Label();
            this.button_agregarAmigo = new System.Windows.Forms.Button();
            this.button_postear = new System.Windows.Forms.Button();
            this.panelPost.SuspendLayout();
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
            // listBox_ListaDeAmigos
            // 
            this.listBox_ListaDeAmigos.FormattingEnabled = true;
            this.listBox_ListaDeAmigos.ItemHeight = 20;
            this.listBox_ListaDeAmigos.Location = new System.Drawing.Point(542, 61);
            this.listBox_ListaDeAmigos.Name = "listBox_ListaDeAmigos";
            this.listBox_ListaDeAmigos.Size = new System.Drawing.Size(229, 324);
            this.listBox_ListaDeAmigos.TabIndex = 2;
            this.listBox_ListaDeAmigos.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panelPost
            // 
            this.panelPost.Controls.Add(this.tabPage1);
            this.panelPost.Controls.Add(this.tabPage2);
            this.panelPost.Location = new System.Drawing.Point(12, 101);
            this.panelPost.Name = "panelPost";
            this.panelPost.SelectedIndex = 0;
            this.panelPost.Size = new System.Drawing.Size(500, 287);
            this.panelPost.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(492, 254);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(473, 262);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(379, 409);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "Buscar Post";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label_listaDeAmigos
            // 
            this.label_listaDeAmigos.AutoSize = true;
            this.label_listaDeAmigos.Location = new System.Drawing.Point(542, 35);
            this.label_listaDeAmigos.Name = "label_listaDeAmigos";
            this.label_listaDeAmigos.Size = new System.Drawing.Size(113, 20);
            this.label_listaDeAmigos.TabIndex = 6;
            this.label_listaDeAmigos.Text = "Lista de amigos";
            // 
            // button_agregarAmigo
            // 
            this.button_agregarAmigo.Location = new System.Drawing.Point(652, 409);
            this.button_agregarAmigo.Name = "button_agregarAmigo";
            this.button_agregarAmigo.Size = new System.Drawing.Size(119, 29);
            this.button_agregarAmigo.TabIndex = 7;
            this.button_agregarAmigo.Text = "Agregar amigo";
            this.button_agregarAmigo.UseVisualStyleBackColor = true;
            // 
            // button_postear
            // 
            this.button_postear.Location = new System.Drawing.Point(279, 409);
            this.button_postear.Name = "button_postear";
            this.button_postear.Size = new System.Drawing.Size(94, 29);
            this.button_postear.TabIndex = 8;
            this.button_postear.Text = "Postear";
            this.button_postear.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_postear);
            this.Controls.Add(this.button_agregarAmigo);
            this.Controls.Add(this.label_listaDeAmigos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelPost);
            this.Controls.Add(this.listBox_ListaDeAmigos);
            this.Controls.Add(this.nombreCompleto);
            this.Controls.Add(this.nombreUsuarioActual);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panelPost.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label nombreUsuarioActual;
        private Label nombreCompleto;
        private ListBox listBox_ListaDeAmigos;
        private TabControl panelPost;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button1;
        private Button button2;
        private Label label_listaDeAmigos;
        private Button button_agregarAmigo;
        private Button button_postear;
    }
}