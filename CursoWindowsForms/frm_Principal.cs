using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
        }

        private void btn_DemonstracaoKey_Click(object sender, EventArgs e)
        {
            //Instanciando a classe referente ao formulário.
            frm_DemonstracaoKey frm_demo = new frm_DemonstracaoKey();

            //Esse método roda/imprime o formulário em tela.
            frm_demo.ShowDialog();
        }

        private void btn_HelloWorld_Click(object sender, EventArgs e)
        {
            frm_HelloWorld frm_Hello = new frm_HelloWorld();
            frm_Hello.ShowDialog();
        }

        private void btn_Mascara_Click(object sender, EventArgs e)
        {
            frm_Mascara frm_Masc = new frm_Mascara();
            frm_Masc.ShowDialog();
        }

        private void btn_ValidaCPF_Click(object sender, EventArgs e)
        {
            frm_ValidaCPF frm_cpf1 = new frm_ValidaCPF();
            frm_cpf1.ShowDialog();
        }

        private void btn_ValidaCPF2_Click(object sender, EventArgs e)
        {
            frm_ValidaCPF2 frm_cpf2 = new frm_ValidaCPF2();
            frm_cpf2.ShowDialog();
        }

        private void btn_ValidaSenha_Click(object sender, EventArgs e)
        {
            frm_ValidaSenha frm_senha = new frm_ValidaSenha();
            frm_senha.ShowDialog();
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            //Criando if, para se o usuário clicar em Sim, fechar todos os formulários.
            if (MessageBox.Show("Você deseja fechar a aplicação?", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else { }
        }


        private void frm_Principal_Load(object sender, EventArgs e)
        {
            
        }
    }
}
