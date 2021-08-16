
namespace CursoWindowsForms
{
    partial class frm_HelloWorld
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_HelloWorld));
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_ModificaLabel = new System.Windows.Forms.Button();
            this.txt_ConteudoLabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(200, 118);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(190, 19);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Visual Studio .NET Version";
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(415, 375);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(186, 23);
            this.btn_sair.TabIndex = 1;
            this.btn_sair.Text = "Fechar";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_ModificaLabel
            // 
            this.btn_ModificaLabel.Location = new System.Drawing.Point(204, 160);
            this.btn_ModificaLabel.Name = "btn_ModificaLabel";
            this.btn_ModificaLabel.Size = new System.Drawing.Size(186, 23);
            this.btn_ModificaLabel.TabIndex = 2;
            this.btn_ModificaLabel.Text = "Modifica Texto";
            this.btn_ModificaLabel.UseVisualStyleBackColor = true;
            this.btn_ModificaLabel.Click += new System.EventHandler(this.btn_ModificaLabel_Click);
            // 
            // txt_ConteudoLabel
            // 
            this.txt_ConteudoLabel.Location = new System.Drawing.Point(204, 209);
            this.txt_ConteudoLabel.Name = "txt_ConteudoLabel";
            this.txt_ConteudoLabel.Size = new System.Drawing.Size(186, 20);
            this.txt_ConteudoLabel.TabIndex = 3;
            // 
            // frm_HelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 410);
            this.Controls.Add(this.txt_ConteudoLabel);
            this.Controls.Add(this.btn_ModificaLabel);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.lbl_Titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_HelloWorld";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_ModificaLabel;
        private System.Windows.Forms.TextBox txt_ConteudoLabel;
    }
}

