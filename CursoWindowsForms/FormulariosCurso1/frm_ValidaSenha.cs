using CursoWindowsFormsBiblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CursoWindowsFormsBiblioteca.Cls_Uteis;

namespace CursoWindowsForms
{
    public partial class frm_ValidaSenha : Form
    {
        public frm_ValidaSenha()
        {
            InitializeComponent();
        }

        //Método para limpar os campos do formulário ao clicar no botão Limpar
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_Senha.Text = "";
            lbl_Resultado.Text = "";
        }

        //Método para capturar cada tecla digitada no teclado   
        private void txt_Senha_KeyDown(object sender, KeyEventArgs e)
        {
            //Instanciando a classe ChecaForcaSenha
            ChecaForcaSenha verifica = new ChecaForcaSenha();

            //Declarando a variavel forca do tipo ChecaForcaSenha.ForcaDaSenha,
            //que recebe a função GetForcaDaSenha passando como parâmetro o texto da text box senha..
            ChecaForcaSenha.ForcaDaSenha forca = verifica.GetForcaDaSenha(txt_Senha.Text);
            lbl_Resultado.Text = forca.ToString();

            //Criando sequências de if's para personalizar a cor da senha dependendo do status.
           if(lbl_Resultado.Text == "Inaceitavel" | lbl_Resultado.Text == "Fraca")
            {
                lbl_Resultado.ForeColor = Color.Red;
            }else if(lbl_Resultado.Text == "Aceitavel")
            {
                lbl_Resultado.ForeColor = Color.Blue;
            }
            else if(lbl_Resultado.Text == "Segura"| lbl_Resultado.Text == "Forte")
            {
                lbl_Resultado.ForeColor = Color.Green;
            }


        }

        //Método para visualizar senha e esconder senha ao clicar no botão.
        private void btn_VisualizarSenha_Click(object sender, EventArgs e)
        {

            //Se o campo UseSystemPasswordChar do text box da senha for true (senha escondida), então mostra a senha.
            if (txt_Senha.UseSystemPasswordChar == true)
            {
                txt_Senha.UseSystemPasswordChar = false;
                btn_VisualizarSenha.Text = "Esconder senha";
                
            }
            //Se não for true, estiver com a senha a mostra, então esconde a senha novamente.
            else
            {
                txt_Senha.UseSystemPasswordChar = true;
                btn_VisualizarSenha.Text = "Ver senha";
            }
          
            
            
        }
    }


    
}
