namespace Main
{
    partial class FormConfirmacao
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
            this.btnVoltarConfirmacao = new System.Windows.Forms.Button();
            this.btnConfirmarConfirmacao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Você deseja confirmar essa ação?";
            // 
            // btnVoltarConfirmacao
            // 
            this.btnVoltarConfirmacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarConfirmacao.Location = new System.Drawing.Point(54, 80);
            this.btnVoltarConfirmacao.Name = "btnVoltarConfirmacao";
            this.btnVoltarConfirmacao.Size = new System.Drawing.Size(104, 48);
            this.btnVoltarConfirmacao.TabIndex = 1;
            this.btnVoltarConfirmacao.Text = "Voltar";
            this.btnVoltarConfirmacao.UseVisualStyleBackColor = true;
            this.btnVoltarConfirmacao.Click += new System.EventHandler(this.btnVoltarConfirmacao_Click);
            // 
            // btnConfirmarConfirmacao
            // 
            this.btnConfirmarConfirmacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarConfirmacao.Location = new System.Drawing.Point(177, 80);
            this.btnConfirmarConfirmacao.Name = "btnConfirmarConfirmacao";
            this.btnConfirmarConfirmacao.Size = new System.Drawing.Size(104, 48);
            this.btnConfirmarConfirmacao.TabIndex = 2;
            this.btnConfirmarConfirmacao.Text = "Confirmar";
            this.btnConfirmarConfirmacao.UseVisualStyleBackColor = true;
            this.btnConfirmarConfirmacao.Click += new System.EventHandler(this.btnConfirmarConfirmacao_Click);
            // 
            // FormConfirmacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 157);
            this.Controls.Add(this.btnConfirmarConfirmacao);
            this.Controls.Add(this.btnVoltarConfirmacao);
            this.Controls.Add(this.label1);
            this.Name = "FormConfirmacao";
            this.Text = "Confirmação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltarConfirmacao;
        private System.Windows.Forms.Button btnConfirmarConfirmacao;
    }
}