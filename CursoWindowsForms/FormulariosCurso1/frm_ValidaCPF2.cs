using CursoWindowsFormsBiblioteca;
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
    public partial class frm_ValidaCPF2 : Form
    {
        public frm_ValidaCPF2()
        {
            InitializeComponent();
        }     


        //Criando método para limpar o text box do CPF.
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            msk_CPF.Text = "";
        }


        //Instanciando a classe Cls_Uteis que possui o validador de CPF.
        Cls_Uteis cls = new Cls_Uteis();


        //Criando método que da o retorno da validação do CPF.
        private void btn_Valida_Click(object sender, EventArgs e)
        {
            //Atribuindo o valor digitado (ou não digitado) do campo CPF
            string conteudo = msk_CPF.Text;

            //retirando os pontos, traços e espaços (Trim) do campo CPF
            conteudo = conteudo.Replace(".", "").Replace("-", "");
            conteudo = conteudo.Trim();

            //Criando if de verificação para entender se o campo está vazio ou não.
            if( conteudo == "")
            {
                MessageBox.Show("Você deve digitar um CPF.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //else if para entender se a quantidade digitada é menor que 11 caracteres.
            else if( conteudo.Length != 11)
            {
                MessageBox.Show("CPF deve ter 11 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                else
                {            
                //Criando messageBox que pergunta se deseja validar o CPF
                //Passa o messageBox na condição, e compara o a opção clicada com DialogResult
                if (MessageBox.Show("Tem certeza que deseja validar o CPF?", "Validação de CPF", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                //Criando uma variável bool, pois o método de validador do CPF retorna um valor bool.
                bool ValidaCPF = false;

                //Atribuindo a variável o método para validar o CPF passando como parâmetro, o texto digitado no text box.
                ValidaCPF = cls.Valida(msk_CPF.Text);

                if (ValidaCPF == true)
                {
                    //Personalização do MessageBox
                    // Mensagem do messageBox / Título / botão / ícone
                    MessageBox.Show("CPF válido!", "Validação de CPF", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("CPF inválido!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                }
                }
        }
    }
}
