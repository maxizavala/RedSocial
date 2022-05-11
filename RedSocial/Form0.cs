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
    public partial class Form0 : Form
    {
        private RedSocial miRed;
        Form1 hijoLogin;
        Form2 hijoMain;

        bool logued;
        public Form0()
        {
            InitializeComponent();

            miRed = new RedSocial();
            Form1 hijoLogin = new Form1(miRed,false);
            logued = false;

            hijoLogin.MdiParent = this;
            hijoLogin.eventoEvento += TransfDelegado;
            hijoLogin.Show();
        }

        private void TransfDelegado()
        {
            hijoMain = new Form2(miRed);
            hijoMain.MdiParent = this;
            hijoMain.Show();
        }
    }
}
