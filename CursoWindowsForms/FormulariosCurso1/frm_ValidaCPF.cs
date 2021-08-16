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
    public partial class frm_ValidaCPF : Form
    {
        public frm_ValidaCPF()
        {
            InitializeComponent();
        }


        //Instanciando a classe Cls_Uteis, que contém o método de validação de CPF.
        Cls_Uteis cls = new Cls_Uteis();



        //Criando método para limpar os campos do formulário.
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            msk_CPF.Text = "";
            lbl_Resultado.Text = "";
        }

        
        //lógica para retorno da validação de CPF.
        private void btn_Valida_Click(object sender, EventArgs e)
        {
            //Criando uma variável bool, pois o método de validador do CPF retorna um valor bool.
            bool ValidaCPF = false;

            //Atribuindo a variável o método para validar o CPF passando como parâmetro, o texto digitado no text box.
            ValidaCPF = cls.Valida(msk_CPF.Text);

            if(ValidaCPF == true)
            {
                lbl_Resultado.Text = "CPF válido!";
                lbl_Resultado.ForeColor = Color.Green;
            }
            else
            {
                lbl_Resultado.Text = "CPF inválido!";
                lbl_Resultado.ForeColor = Color.Red;                
            }
            
        }
        

        private void msk_CPF_KeyDown(object sender, KeyEventArgs e)
        {
           

        }
    }



}
