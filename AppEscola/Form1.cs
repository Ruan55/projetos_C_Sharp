using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscola
{
    public partial class FrmPrincipal : Form
    {

        // Váriaveis Globais
        float primeiroNumero, segundoNumero, terceiroNumero, quartoNumero, Media;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

            dtData.Text = DateTime.Today.ToString();
            lblNome.Text = Program.usuario;

        }

        public void Resultado()
        {

            primeiroNumero = float.Parse(textNota1.Text);
            segundoNumero = float.Parse(textNota2.Text);
            terceiroNumero = float.Parse(textNota3.Text);
            quartoNumero = float.Parse(textNota4.Text);

            Media = (primeiroNumero + segundoNumero + terceiroNumero + quartoNumero) / 4;

            lblMedia.Text = Media.ToString();

        }

        public void SituacaoAluno()
        {


            if(Media >= 7)
            {

                lblStatus.Text = "Parabéns!!! Você foi aprovado!";

            }

            else if(Media >= 4 && Media <= 6.9)
            {

                lblStatus.Text = "Você está na recuperação!";

            }

            else
            {

                lblStatus.Text = "Você foi reprovado!";

            }


        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {

            Resultado();
            SituacaoAluno();

        }

    }
}
