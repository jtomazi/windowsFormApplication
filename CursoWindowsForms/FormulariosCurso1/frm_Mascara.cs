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
    public partial class frm_Mascara : Form
    {
        public frm_Mascara()
        {
            InitializeComponent();
        }

        private void frm_Mascara_Load(object sender, EventArgs e)
        {
           
        }

        //Criando método click no botão hora, formatação de hora.
        private void btn_Hora_Click(object sender, EventArgs e)
        {
            //Desativando a formatação de senha
            msk_TextBox.UseSystemPasswordChar = false;

            //Limpando a label de conteúdo
            lbl_Conteudo.Text = "";

            //Formatando a máscara do text box.
            msk_TextBox.Mask = "00:00";

            //lbl da mascara ativa recebe o formato da text box
            lbl_MascaraAtiva.Text = msk_TextBox.Mask;

            //Limpa o conteúdo do text box e atribui o foco ao clicar.
            msk_TextBox.Text = "";
            msk_TextBox.Focus();
            
        }


        //Método de formatação de CEP
        private void btn_CEP_Click(object sender, EventArgs e)
        {
            //Explicação das linhas no primeiro click.
            msk_TextBox.UseSystemPasswordChar = false;
            lbl_Conteudo.Text = "";
            msk_TextBox.Mask = "00000-000";            
            lbl_MascaraAtiva.Text = msk_TextBox.Mask;            
            msk_TextBox.Text = "";
            msk_TextBox.Focus();
            
        }

        //Método de formatação de Moeda
        private void btn_Moeda_Click(object sender, EventArgs e)
        {
            //Explicação das linhas no primeiro click.
            msk_TextBox.UseSystemPasswordChar = false;
            lbl_Conteudo.Text = "";
            msk_TextBox.Mask = "$ 000,000,000.00";
            lbl_MascaraAtiva.Text = msk_TextBox.Mask;
            msk_TextBox.Text = "";
            msk_TextBox.Focus();
        }


        //Método de formatação de data
        private void btn_Data_Click(object sender, EventArgs e)
        {
            //Explicação das linhas no primeiro click.
            msk_TextBox.UseSystemPasswordChar = false;
            lbl_Conteudo.Text = "";
            msk_TextBox.Mask = "00/00/0000";
            lbl_MascaraAtiva.Text = msk_TextBox.Mask;
            msk_TextBox.Text = "";
            msk_TextBox.Focus();
        }


        private void btn_Senha_Click(object sender, EventArgs e)
        {
            //Explicação das linhas no primeiro click.
            lbl_Conteudo.Text = "";
            msk_TextBox.UseSystemPasswordChar = true;
            msk_TextBox.Mask = "000000";
            lbl_MascaraAtiva.Text = "******";
            msk_TextBox.Text = "";
            msk_TextBox.Focus();
            
        }

        private void btn_Telefone_Click(object sender, EventArgs e)
        {
            //Explicação das linhas no primeiro click.
            msk_TextBox.UseSystemPasswordChar = false;
            lbl_Conteudo.Text = "";
            msk_TextBox.Mask = "(00) 0 0000-0000";
            lbl_MascaraAtiva.Text = msk_TextBox.Mask;
            msk_TextBox.Text = "";
            msk_TextBox.Focus();
        }

        private void btn_VerConteudo_Click(object sender, EventArgs e)
        {
            lbl_Conteudo.Text = msk_TextBox.Text;
        }

        
    }
}
