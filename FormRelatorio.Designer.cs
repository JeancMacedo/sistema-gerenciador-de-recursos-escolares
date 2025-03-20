namespace Main
{
    partial class FormRelatorio
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
            this.cmbCadastro = new System.Windows.Forms.ComboBox();
            this.btnVoltarCadastro = new System.Windows.Forms.Button();
            this.btnConfirmarCadastro = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbCadastro
            // 
            this.cmbCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCadastro.FormattingEnabled = true;
            this.cmbCadastro.Items.AddRange(new object[] {
            "PDF",
            "PNG"});
            this.cmbCadastro.Location = new System.Drawing.Point(254, 111);
            this.cmbCadastro.Name = "cmbCadastro";
            this.cmbCadastro.Size = new System.Drawing.Size(360, 32);
            this.cmbCadastro.TabIndex = 22;
            // 
            // btnVoltarCadastro
            // 
            this.btnVoltarCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarCadastro.Location = new System.Drawing.Point(254, 185);
            this.btnVoltarCadastro.Name = "btnVoltarCadastro";
            this.btnVoltarCadastro.Size = new System.Drawing.Size(126, 60);
            this.btnVoltarCadastro.TabIndex = 21;
            this.btnVoltarCadastro.Text = "Voltar";
            this.btnVoltarCadastro.UseVisualStyleBackColor = true;
            this.btnVoltarCadastro.Click += new System.EventHandler(this.btnVoltarCadastro_Click);
            // 
            // btnConfirmarCadastro
            // 
            this.btnConfirmarCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarCadastro.Location = new System.Drawing.Point(409, 185);
            this.btnConfirmarCadastro.Name = "btnConfirmarCadastro";
            this.btnConfirmarCadastro.Size = new System.Drawing.Size(126, 60);
            this.btnConfirmarCadastro.TabIndex = 20;
            this.btnConfirmarCadastro.Text = "Exportar";
            this.btnConfirmarCadastro.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(648, 39);
            this.label4.TabIndex = 19;
            this.label4.Text = "Bem vindo (a) ao Relatório de Alimentos!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tipo de arquivo:";
            // 
            // FormRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 285);
            this.Controls.Add(this.cmbCadastro);
            this.Controls.Add(this.btnVoltarCadastro);
            this.Controls.Add(this.btnConfirmarCadastro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "FormRelatorio";
            this.Text = "Relatório de Alimentos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCadastro;
        private System.Windows.Forms.Button btnVoltarCadastro;
        private System.Windows.Forms.Button btnConfirmarCadastro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}