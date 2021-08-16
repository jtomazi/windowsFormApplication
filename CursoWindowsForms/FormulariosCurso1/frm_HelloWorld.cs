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
    public partial class frm_HelloWorld : Form
    {
        public frm_HelloWorld()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            //Chamando o método Close para sair da aplicação quando clicar no botão btn_sair, apenas o formulário hello world.
            this.Close();
        }

        private void btn_ModificaLabel_Click(object sender, EventArgs e)
        {
            //Atribuindo o valor da text box txt_ConteudoLabel para a label lbl_Titulo
            lbl_Titulo.Text = txt_ConteudoLabel.Text;
        }
    }
}
