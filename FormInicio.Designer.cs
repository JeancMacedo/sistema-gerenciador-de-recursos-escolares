namespace Main
{
    partial class FormInicio
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
            this.gpbAmbientesInicio = new System.Windows.Forms.GroupBox();
            this.rdbControleInicio = new System.Windows.Forms.RadioButton();
            this.rdbInventarioInicio = new System.Windows.Forms.RadioButton();
            this.btnVoltarInicio = new System.Windows.Forms.Button();
            this.btnConfirmarInicio = new System.Windows.Forms.Button();
            this.gpbAmbientesInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bem vindo (a) ao SGRE!";
            // 
            // gpbAmbientesInicio
            // 
            this.gpbAmbientesInicio.Controls.Add(this.rdbControleInicio);
            this.gpbAmbientesInicio.Controls.Add(this.rdbInventarioInicio);
            this.gpbAmbientesInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbAmbientesInicio.Location = new System.Drawing.Point(47, 94);
            this.gpbAmbientesInicio.Name = "gpbAmbientesInicio";
            this.gpbAmbientesInicio.Size = new System.Drawing.Size(404, 122);
            this.gpbAmbientesInicio.TabIndex = 4;
            this.gpbAmbientesInicio.TabStop = false;
            this.gpbAmbientesInicio.Text = "Ambientes";
            // 
            // rdbControleInicio
            // 
            this.rdbControleInicio.AutoSize = true;
            this.rdbControleInicio.Location = new System.Drawing.Point(6, 72);
            this.rdbControleInicio.Name = "rdbControleInicio";
            this.rdbControleInicio.Size = new System.Drawing.Size(369, 28);
            this.rdbControleInicio.TabIndex = 1;
            this.rdbControleInicio.TabStop = true;
            this.rdbControleInicio.Text = "Controle Diário de Estoque de Alimentos";
            this.rdbControleInicio.UseVisualStyleBackColor = true;
            // 
            // rdbInventarioInicio
            // 
            this.rdbInventarioInicio.AutoSize = true;
            this.rdbInventarioInicio.Location = new System.Drawing.Point(6, 38);
            this.rdbInventarioInicio.Name = "rdbInventarioInicio";
            this.rdbInventarioInicio.Size = new System.Drawing.Size(326, 28);
            this.rdbInventarioInicio.TabIndex = 0;
            this.rdbInventarioInicio.TabStop = true;
            this.rdbInventarioInicio.Text = "Inventário de Estoque de Alimentos";
            this.rdbInventarioInicio.UseVisualStyleBackColor = true;
            // 
            // btnVoltarInicio
            // 
            this.btnVoltarInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarInicio.Location = new System.Drawing.Point(71, 235);
            this.btnVoltarInicio.Name = "btnVoltarInicio";
            this.btnVoltarInicio.Size = new System.Drawing.Size(119, 54);
            this.btnVoltarInicio.TabIndex = 7;
            this.btnVoltarInicio.Text = "Voltar";
            this.btnVoltarInicio.UseVisualStyleBackColor = true;
            this.btnVoltarInicio.Click += new System.EventHandler(this.btnVoltarInicio_Click);
            // 
            // btnConfirmarInicio
            // 
            this.btnConfirmarInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarInicio.Location = new System.Drawing.Point(303, 235);
            this.btnConfirmarInicio.Name = "btnConfirmarInicio";
            this.btnConfirmarInicio.Size = new System.Drawing.Size(119, 54);
            this.btnConfirmarInicio.TabIndex = 6;
            this.btnConfirmarInicio.Text = "Confirmar";
            this.btnConfirmarInicio.UseVisualStyleBackColor = true;
            this.btnConfirmarInicio.Click += new System.EventHandler(this.btnConfirmarInicio_Click);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 325);
            this.Controls.Add(this.btnVoltarInicio);
            this.Controls.Add(this.btnConfirmarInicio);
            this.Controls.Add(this.gpbAmbientesInicio);
            this.Controls.Add(this.label1);
            this.Name = "FormInicio";
            this.Text = "Início";
            this.gpbAmbientesInicio.ResumeLayout(false);
            this.gpbAmbientesInicio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbAmbientesInicio;
        private System.Windows.Forms.RadioButton rdbControleInicio;
        private System.Windows.Forms.RadioButton rdbInventarioInicio;
        private System.Windows.Forms.Button btnVoltarInicio;
        private System.Windows.Forms.Button btnConfirmarInicio;
    }
}