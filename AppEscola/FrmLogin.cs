﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscola
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(textNome.Text.Trim() == "")
            {

                MessageBox.Show("Digite um nome!");
                return;

            }

            if(textSenha.Text != "123")
            {

                MessageBox.Show("Digite uma senha");
                return;

            }

            Program.usuario = textNome.Text;

             FrmPrincipal frm = new FrmPrincipal();
             frm.ShowDialog();

            this.Close();
        }
    }
}
