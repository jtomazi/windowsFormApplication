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
    public partial class frm_DemonstracaoKey : Form
    {
        public frm_DemonstracaoKey()
        {
            InitializeComponent();
        }

        private void frm_DemonstracaoKey_Load(object sender, EventArgs e)
        {

        }

        //Método para limpar toda a tela 
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            //Atribuindo o valor vazio para os campos do formulário.
            txt_Msg.Text = "";
            txt_Input.Text = "";
            lbl_Lower.Text = "";
            lbl_Upper.Text = "";

            
        }

        //Capturando o valor digitado no txt_Input e passando para o txt_Msg
        private void txt_Input_KeyDown(object sender, KeyEventArgs e)
        {
            // txt_Msg.AppendText recebe o valor passado no método pelo e.KeyCode, que é o valor digitado no campo.
            txt_Msg.AppendText("\r\n"+ "Pressionei a tecla " + e.KeyCode +"\r\n");
            txt_Msg.AppendText("\t" + "Código da tecla " + ((int)e.KeyCode) + "\r\n");
            txt_Msg.AppendText("\t" + "Nome da tecla " + e.KeyData + "\r\n");

            //O texto/conteúdo da label lbl_Upper recebe o valor do campo maiúsculo 
            lbl_Upper.Text = e.KeyCode.ToString().ToUpper();
            //O texto/conteúdo da label lbl_Lower recebe o valor do campo minúsculo
            lbl_Lower.Text = e.KeyCode.ToString().ToLower();
        }

        //Criando método para sair/fechar a aplicação
        private void btn_fechar_Click(object sender, EventArgs e)
        {
            //Chamando o método Close para fechar apenas o formulário demonstração.
            this.Close();
        }
    }
}
