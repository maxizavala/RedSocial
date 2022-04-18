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
        private Form1 hijoLogin;
        //Form2 hijoMain;
        public Form0()
        {
            InitializeComponent();

            RedSocial miRed = new RedSocial();

            Form1 hijoLogin = new Form1(miRed);
            hijoLogin.logued = false;
            hijoLogin.MdiParent = this;
            hijoLogin.Show();
        }
    }
}
