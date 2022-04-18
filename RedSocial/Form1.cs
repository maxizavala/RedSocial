namespace RedSocial
{
    public partial class Form1 : Form
    {

        public RedSocial miRed;
        public bool logued;
        public string usuario;
        public Form1(RedSocial redSocial)
        {
            InitializeComponent();
            miRed = redSocial;
            logued = false;
        }

        public Form1() {
            InitializeComponent();
            miRed = new RedSocial();
            logued = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            miRed.agregarUsuario(textBox1.Text, textBox2.Text);
            label3.Text = "USUARIO AGREGADO";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (miRed.iniciarSesion(textBox1.Text, textBox2.Text))
            {
                label3.Text = "ACCESO PERMITIDO";
            }
            else
            {
                label3.Text = "ACCESO DENEGADO";
            }
        }
    }
}