namespace RedSocial
{
    public partial class Form1 : Form
    {

        private RedSocial miRed;
        public bool logeo;
        public string usuario;

        public delegate void TransfDelegado();
        public TransfDelegado eventoEvento;
        public Form1(RedSocial redSocial,bool logeo)
        {
            InitializeComponent();
            miRed = redSocial;
            this.logeo = logeo;
      
        }

        public Form1() {
            InitializeComponent();
            miRed = new RedSocial();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //miRed.agregarUsuario(textBox1.Text, textBox2.Text);
            if (textBox_NombreReg.Text == "" ||
                textBox_apellidoRegistro.Text == "" ||
                textBox_DNIReg.Text == "" ||
                textBox_MailReg.Text == "" ||
                textBox_PassReg.Text == "")
            {
                ResultadoRegistro.Text = "COMPLETE LOS CAMPOS NECESARIOS";
            }
            else
            {
                miRed.registrarUsuario(textBox_DNIReg.Text,
                    textBox_NombreReg.Text,
                    textBox_apellidoRegistro.Text,
                    textBox_MailReg.Text,
                    textBox_PassReg.Text); //se quitan mas adelante
                ResultadoRegistro.Text = "USUARIO AGREGADO";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (miRed.iniciarSesion(textBox1.Text, textBox2.Text))
            {
                this.eventoEvento();
                this.Close();
            }
            else
            {
                label3.Text = "ACCESO DENEGADO";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}