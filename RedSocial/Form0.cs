﻿using System;
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
        FormMain hijoMain;
        FormAgregarAmigo hijoAgregarAmigo;

        bool logued;
        public Form0()
        {
            InitializeComponent();

            miRed = new RedSocial();
            hijoLogin = new Form1(miRed,false);
            logued = false;

            miRed.registrarUsuario("1", "1", "1", "1", "1");
            miRed.registrarUsuario("2", "2", "2", "2", "2");
            TransfDelegadoLogIn();
        }

        private void TransfDelegadoLogIn()
        {
            hijoLogin.MdiParent = this;
            hijoLogin.eventoEvento += TransfDelegado;
            hijoLogin.Show();
        }

        private void TransfDelegado()
        {
            hijoMain = new FormMain(miRed);
            hijoMain.MdiParent = this;
            hijoMain.eventoAgregarAmigo += TransfDelegadoAgregarAmigo;
            
            hijoMain.Show();
        }
        private void TransfDelegadoAgregarAmigo()
        {
            hijoAgregarAmigo = new FormAgregarAmigo(miRed);
            hijoAgregarAmigo.MdiParent = this;
            hijoAgregarAmigo.eventoMain += TransfDelegado;
            hijoAgregarAmigo.Show();
        }

    }
}
