namespace Main
{
    partial class FormInventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.rdbCasdratro = new System.Windows.Forms.RadioButton();
            this.rdbEdicao = new System.Windows.Forms.RadioButton();
            this.rdbConsulta = new System.Windows.Forms.RadioButton();
            this.rdbRelatorio = new System.Windows.Forms.RadioButton();
            this.rdbHistorico = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(603, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bem vindo (a) ao Controle de Estoque";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(433, 121);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(119, 54);
            this.btnConfirmar.TabIndex = 4;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(433, 230);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(119, 54);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // rdbCasdratro
            // 
            this.rdbCasdratro.AutoSize = true;
            this.rdbCasdratro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCasdratro.Location = new System.Drawing.Point(27, 17);
            this.rdbCasdratro.Name = "rdbCasdratro";
            this.rdbCasdratro.Size = new System.Drawing.Size(186, 28);
            this.rdbCasdratro.TabIndex = 0;
            this.rdbCasdratro.TabStop = true;
            this.rdbCasdratro.Text = "Cadastrar Alimento";
            this.rdbCasdratro.UseVisualStyleBackColor = true;
            // 
            // rdbEdicao
            // 
            this.rdbEdicao.AutoSize = true;
            this.rdbEdicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEdicao.Location = new System.Drawing.Point(27, 50);
            this.rdbEdicao.Name = "rdbEdicao";
            this.rdbEdicao.Size = new System.Drawing.Size(155, 28);
            this.rdbEdicao.TabIndex = 1;
            this.rdbEdicao.TabStop = true;
            this.rdbEdicao.Text = "Editar Alimento";
            this.rdbEdicao.UseVisualStyleBackColor = true;
            // 
            // rdbConsulta
            // 
            this.rdbConsulta.AutoSize = true;
            this.rdbConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbConsulta.Location = new System.Drawing.Point(27, 84);
            this.rdbConsulta.Name = "rdbConsulta";
            this.rdbConsulta.Size = new System.Drawing.Size(186, 28);
            this.rdbConsulta.TabIndex = 3;
            this.rdbConsulta.TabStop = true;
            this.rdbConsulta.Text = "Consultar Alimento";
            this.rdbConsulta.UseVisualStyleBackColor = true;
            // 
            // rdbRelatorio
            // 
            this.rdbRelatorio.AutoSize = true;
            this.rdbRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRelatorio.Location = new System.Drawing.Point(27, 118);
            this.rdbRelatorio.Name = "rdbRelatorio";
            this.rdbRelatorio.Size = new System.Drawing.Size(280, 28);
            this.rdbRelatorio.TabIndex = 4;
            this.rdbRelatorio.TabStop = true;
            this.rdbRelatorio.Text = "Exportar Relatório de Estoque";
            this.rdbRelatorio.UseVisualStyleBackColor = true;
            // 
            // rdbHistorico
            // 
            this.rdbHistorico.AutoSize = true;
            this.rdbHistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbHistorico.Location = new System.Drawing.Point(27, 152);
            this.rdbHistorico.Name = "rdbHistorico";
            this.rdbHistorico.Size = new System.Drawing.Size(256, 28);
            this.rdbHistorico.TabIndex = 5;
            this.rdbHistorico.TabStop = true;
            this.rdbHistorico.Text = "Histórico de Movimentação";
            this.rdbHistorico.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbEdicao);
            this.panel1.Controls.Add(this.rdbCasdratro);
            this.panel1.Controls.Add(this.rdbHistorico);
            this.panel1.Controls.Add(this.rdbConsulta);
            this.panel1.Controls.Add(this.rdbRelatorio);
            this.panel1.Location = new System.Drawing.Point(23, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 195);
            this.panel1.TabIndex = 6;
            // 
            // FormInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 354);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FormInventario";
            this.Text = "Controle Diário de Estoque de Alimentos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.RadioButton rdbCasdratro;
        private System.Windows.Forms.RadioButton rdbEdicao;
        private System.Windows.Forms.RadioButton rdbConsulta;
        private System.Windows.Forms.RadioButton rdbRelatorio;
        private System.Windows.Forms.RadioButton rdbHistorico;
        private System.Windows.Forms.Panel panel1;
    }
}