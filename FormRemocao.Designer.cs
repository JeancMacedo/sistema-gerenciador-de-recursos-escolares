namespace Main
{
    partial class FormRemocao
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
            this.txbQuantidadeRemocao = new System.Windows.Forms.TextBox();
            this.txbValidadeRemocao = new System.Windows.Forms.TextBox();
            this.btnConfirmarRemocao = new System.Windows.Forms.Button();
            this.btnLimparRemocao = new System.Windows.Forms.Button();
            this.btnPesquisarRemocao = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlRemocao = new System.Windows.Forms.Panel();
            this.gpbCategoriasRemocao = new System.Windows.Forms.GroupBox();
            this.rdbPoteCategoriasRemocao = new System.Windows.Forms.RadioButton();
            this.rdbRrcCategoriasRemocao = new System.Windows.Forms.RadioButton();
            this.rdbUnidCategoriasRemocao = new System.Windows.Forms.RadioButton();
            this.rdbPctCategoriasRemocao = new System.Windows.Forms.RadioButton();
            this.gpbTiposRemocao = new System.Windows.Forms.GroupBox();
            this.rdbPanificadosTiposRemocao = new System.Windows.Forms.RadioButton();
            this.rdbRefrigeradosTiposRemocao = new System.Windows.Forms.RadioButton();
            this.rdbCongeladosTiposRemocao = new System.Windows.Forms.RadioButton();
            this.rdbEstocaveisTiposRemocao = new System.Windows.Forms.RadioButton();
            this.cmbRemocao = new System.Windows.Forms.ComboBox();
            this.pnlRemocao.SuspendLayout();
            this.gpbCategoriasRemocao.SuspendLayout();
            this.gpbTiposRemocao.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbQuantidadeRemocao
            // 
            this.txbQuantidadeRemocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQuantidadeRemocao.Location = new System.Drawing.Point(277, 339);
            this.txbQuantidadeRemocao.MaxLength = 3;
            this.txbQuantidadeRemocao.Name = "txbQuantidadeRemocao";
            this.txbQuantidadeRemocao.Size = new System.Drawing.Size(42, 29);
            this.txbQuantidadeRemocao.TabIndex = 25;
            // 
            // txbValidadeRemocao
            // 
            this.txbValidadeRemocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbValidadeRemocao.Location = new System.Drawing.Point(459, 370);
            this.txbValidadeRemocao.MaxLength = 10;
            this.txbValidadeRemocao.Name = "txbValidadeRemocao";
            this.txbValidadeRemocao.Size = new System.Drawing.Size(104, 29);
            this.txbValidadeRemocao.TabIndex = 26;
            // 
            // btnConfirmarRemocao
            // 
            this.btnConfirmarRemocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarRemocao.Location = new System.Drawing.Point(235, 433);
            this.btnConfirmarRemocao.Name = "btnConfirmarRemocao";
            this.btnConfirmarRemocao.Size = new System.Drawing.Size(126, 60);
            this.btnConfirmarRemocao.TabIndex = 30;
            this.btnConfirmarRemocao.Text = "Confirmar";
            this.btnConfirmarRemocao.UseVisualStyleBackColor = true;
            // 
            // btnLimparRemocao
            // 
            this.btnLimparRemocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparRemocao.Location = new System.Drawing.Point(400, 433);
            this.btnLimparRemocao.Name = "btnLimparRemocao";
            this.btnLimparRemocao.Size = new System.Drawing.Size(126, 60);
            this.btnLimparRemocao.TabIndex = 31;
            this.btnLimparRemocao.Text = "Limpar";
            this.btnLimparRemocao.UseVisualStyleBackColor = true;
            // 
            // btnPesquisarRemocao
            // 
            this.btnPesquisarRemocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarRemocao.Location = new System.Drawing.Point(627, 113);
            this.btnPesquisarRemocao.Name = "btnPesquisarRemocao";
            this.btnPesquisarRemocao.Size = new System.Drawing.Size(113, 29);
            this.btnPesquisarRemocao.TabIndex = 32;
            this.btnPesquisarRemocao.Text = "Pesquisar";
            this.btnPesquisarRemocao.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(158, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 24);
            this.label3.TabIndex = 29;
            this.label3.Text = "Data de Validade (DD/MM/AAAA):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "Quantidade:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(658, 39);
            this.label4.TabIndex = 23;
            this.label4.Text = "Bem vindo (a) ao Remoção de Alimentos!";
            // 
            // pnlRemocao
            // 
            this.pnlRemocao.Controls.Add(this.gpbCategoriasRemocao);
            this.pnlRemocao.Controls.Add(this.gpbTiposRemocao);
            this.pnlRemocao.Enabled = false;
            this.pnlRemocao.Location = new System.Drawing.Point(131, 148);
            this.pnlRemocao.Name = "pnlRemocao";
            this.pnlRemocao.Size = new System.Drawing.Size(507, 357);
            this.pnlRemocao.TabIndex = 33;
            // 
            // gpbCategoriasRemocao
            // 
            this.gpbCategoriasRemocao.Controls.Add(this.rdbPoteCategoriasRemocao);
            this.gpbCategoriasRemocao.Controls.Add(this.rdbRrcCategoriasRemocao);
            this.gpbCategoriasRemocao.Controls.Add(this.rdbUnidCategoriasRemocao);
            this.gpbCategoriasRemocao.Controls.Add(this.rdbPctCategoriasRemocao);
            this.gpbCategoriasRemocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCategoriasRemocao.Location = new System.Drawing.Point(30, 16);
            this.gpbCategoriasRemocao.Name = "gpbCategoriasRemocao";
            this.gpbCategoriasRemocao.Size = new System.Drawing.Size(200, 169);
            this.gpbCategoriasRemocao.TabIndex = 14;
            this.gpbCategoriasRemocao.TabStop = false;
            this.gpbCategoriasRemocao.Text = "Categorias";
            // 
            // rdbPoteCategoriasRemocao
            // 
            this.rdbPoteCategoriasRemocao.AutoSize = true;
            this.rdbPoteCategoriasRemocao.Location = new System.Drawing.Point(6, 130);
            this.rdbPoteCategoriasRemocao.Name = "rdbPoteCategoriasRemocao";
            this.rdbPoteCategoriasRemocao.Size = new System.Drawing.Size(80, 28);
            this.rdbPoteCategoriasRemocao.TabIndex = 3;
            this.rdbPoteCategoriasRemocao.TabStop = true;
            this.rdbPoteCategoriasRemocao.Text = "POTE";
            this.rdbPoteCategoriasRemocao.UseVisualStyleBackColor = true;
            // 
            // rdbRrcCategoriasRemocao
            // 
            this.rdbRrcCategoriasRemocao.AutoSize = true;
            this.rdbRrcCategoriasRemocao.Location = new System.Drawing.Point(6, 96);
            this.rdbRrcCategoriasRemocao.Name = "rdbRrcCategoriasRemocao";
            this.rdbRrcCategoriasRemocao.Size = new System.Drawing.Size(67, 28);
            this.rdbRrcCategoriasRemocao.TabIndex = 2;
            this.rdbRrcCategoriasRemocao.TabStop = true;
            this.rdbRrcCategoriasRemocao.Text = "RRC";
            this.rdbRrcCategoriasRemocao.UseVisualStyleBackColor = true;
            // 
            // rdbUnidCategoriasRemocao
            // 
            this.rdbUnidCategoriasRemocao.AutoSize = true;
            this.rdbUnidCategoriasRemocao.Location = new System.Drawing.Point(6, 62);
            this.rdbUnidCategoriasRemocao.Name = "rdbUnidCategoriasRemocao";
            this.rdbUnidCategoriasRemocao.Size = new System.Drawing.Size(72, 28);
            this.rdbUnidCategoriasRemocao.TabIndex = 1;
            this.rdbUnidCategoriasRemocao.TabStop = true;
            this.rdbUnidCategoriasRemocao.Text = "UNID";
            this.rdbUnidCategoriasRemocao.UseVisualStyleBackColor = true;
            // 
            // rdbPctCategoriasRemocao
            // 
            this.rdbPctCategoriasRemocao.AutoSize = true;
            this.rdbPctCategoriasRemocao.Location = new System.Drawing.Point(6, 28);
            this.rdbPctCategoriasRemocao.Name = "rdbPctCategoriasRemocao";
            this.rdbPctCategoriasRemocao.Size = new System.Drawing.Size(65, 28);
            this.rdbPctCategoriasRemocao.TabIndex = 0;
            this.rdbPctCategoriasRemocao.TabStop = true;
            this.rdbPctCategoriasRemocao.Text = "PCT";
            this.rdbPctCategoriasRemocao.UseVisualStyleBackColor = true;
            // 
            // gpbTiposRemocao
            // 
            this.gpbTiposRemocao.Controls.Add(this.rdbPanificadosTiposRemocao);
            this.gpbTiposRemocao.Controls.Add(this.rdbRefrigeradosTiposRemocao);
            this.gpbTiposRemocao.Controls.Add(this.rdbCongeladosTiposRemocao);
            this.gpbTiposRemocao.Controls.Add(this.rdbEstocaveisTiposRemocao);
            this.gpbTiposRemocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbTiposRemocao.Location = new System.Drawing.Point(260, 16);
            this.gpbTiposRemocao.Name = "gpbTiposRemocao";
            this.gpbTiposRemocao.Size = new System.Drawing.Size(200, 170);
            this.gpbTiposRemocao.TabIndex = 15;
            this.gpbTiposRemocao.TabStop = false;
            this.gpbTiposRemocao.Text = "Tipos";
            // 
            // rdbPanificadosTiposRemocao
            // 
            this.rdbPanificadosTiposRemocao.AutoSize = true;
            this.rdbPanificadosTiposRemocao.Location = new System.Drawing.Point(5, 133);
            this.rdbPanificadosTiposRemocao.Name = "rdbPanificadosTiposRemocao";
            this.rdbPanificadosTiposRemocao.Size = new System.Drawing.Size(124, 28);
            this.rdbPanificadosTiposRemocao.TabIndex = 3;
            this.rdbPanificadosTiposRemocao.TabStop = true;
            this.rdbPanificadosTiposRemocao.Text = "Panificados";
            this.rdbPanificadosTiposRemocao.UseVisualStyleBackColor = true;
            // 
            // rdbRefrigeradosTiposRemocao
            // 
            this.rdbRefrigeradosTiposRemocao.AutoSize = true;
            this.rdbRefrigeradosTiposRemocao.Location = new System.Drawing.Point(5, 99);
            this.rdbRefrigeradosTiposRemocao.Name = "rdbRefrigeradosTiposRemocao";
            this.rdbRefrigeradosTiposRemocao.Size = new System.Drawing.Size(135, 28);
            this.rdbRefrigeradosTiposRemocao.TabIndex = 2;
            this.rdbRefrigeradosTiposRemocao.TabStop = true;
            this.rdbRefrigeradosTiposRemocao.Text = "Refrigerados";
            this.rdbRefrigeradosTiposRemocao.UseVisualStyleBackColor = true;
            // 
            // rdbCongeladosTiposRemocao
            // 
            this.rdbCongeladosTiposRemocao.AutoSize = true;
            this.rdbCongeladosTiposRemocao.Location = new System.Drawing.Point(5, 65);
            this.rdbCongeladosTiposRemocao.Name = "rdbCongeladosTiposRemocao";
            this.rdbCongeladosTiposRemocao.Size = new System.Drawing.Size(130, 28);
            this.rdbCongeladosTiposRemocao.TabIndex = 1;
            this.rdbCongeladosTiposRemocao.TabStop = true;
            this.rdbCongeladosTiposRemocao.Text = "Congelados";
            this.rdbCongeladosTiposRemocao.UseVisualStyleBackColor = true;
            // 
            // rdbEstocaveisTiposRemocao
            // 
            this.rdbEstocaveisTiposRemocao.AutoSize = true;
            this.rdbEstocaveisTiposRemocao.Location = new System.Drawing.Point(5, 31);
            this.rdbEstocaveisTiposRemocao.Name = "rdbEstocaveisTiposRemocao";
            this.rdbEstocaveisTiposRemocao.Size = new System.Drawing.Size(118, 28);
            this.rdbEstocaveisTiposRemocao.TabIndex = 0;
            this.rdbEstocaveisTiposRemocao.TabStop = true;
            this.rdbEstocaveisTiposRemocao.Text = "Estocáveis";
            this.rdbEstocaveisTiposRemocao.UseVisualStyleBackColor = true;
            // 
            // cmbRemocao
            // 
            this.cmbRemocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRemocao.FormattingEnabled = true;
            this.cmbRemocao.Items.AddRange(new object[] {
            "*ESTOCÁVEIS*",
            "AÇÚCAR",
            "ALHO TRITURADO",
            "AMIDO DE MILHO",
            "ARROZ INTEGRAL",
            "ARROZ PARBOILIZADO",
            "ARROZ POLIDO TIPO 1",
            "AVEIA",
            "AZEITE",
            "BISCOITO",
            "BISCOITO DE POLVILHO",
            "BISC. DOCE",
            "BISC. SALGADO",
            "BISCOITO INDIVIDUAL",
            "CAFÉ SOLÚVEL",
            "CHOCOLATE EMPÓ",
            "CANJICA",
            "ERVILHA SECA PARTIDA",
            "FARINHA DE MANDIOCA",
            "FARINHA DE MILHO (FLOCÃO)",
            "FARINHA DE TRIGO",
            "FARINHA DE TRIGO INTEGRAL",
            "FEIJÃO BRANCO",
            "FEIJÃO CARIOCA",
            "FEIJÃO PRETO",
            "FERMENTO EM PÓ",
            "FLOCOS DE MILHO (SUCRILHOS)",
            "FORMULA DE PARTIDA (1)",
            "FORMULA DE SEGMENTO (2)",
            "FORMULA À BASE DE SOJA",
            "FORMULA AR",
            "FORM. PROTEINA HIDROLISADA",
            "FRANGO COZIDO DESFIADO",
            "FUBÁ",
            "GRÃO DE BICO",
            "LEITE EM PÓ",
            "LEITE SEM LACTOSE",
            "LENTILHA",
            "MACARRÃO",
            "MACARRÃO GRÃO DE BICO",
            "MACARRÃO VEGETAIS",
            "MACARRÃO MINI FUSILLI",
            "MISTURA PARA BOLO",
            "MISTURA PARA TORTA",
            "MIX: ESPECIARIAS P/ TEMPERO",
            "ÓLEO DE",
            "OVO EM PÓ",
            "PERNIL COZIDO DESFIADO",
            "POLPA DE TOMATE",
            "PROTEÍNA TEXT DE SOJA (PTS)",
            "RECHEIO DE ATUM",
            "RECHEIO DE FRANGO",
            "SAL",
            "SUCO INDIVIDUAL",
            "SUCO UVA INTEGRAL",
            "VINAGRE",
            "*CONGELADOS*",
            "ABÓBORA CONGELADA",
            "ACÉM CUBOS",
            "ACÉM MOÍDO",
            "ALHO CONGELADO",
            "BOLINHO MISTO DE CARNE",
            "BRÓCOLIS CONGELADO",
            "COUVE-FLOR CONGELADA",
            "COXINHA DA ASA",
            "EMPANADO DE FRANGO",
            "EMPANADO DE PEIXE",
            "ESPINAFRE CONGELADO",
            "FILÉ DE TILÁPIA",
            "FRANGO CUBOS LEGUMES",
            "FRANGO EM TIRAS",
            "LAGARTO CONGELADO",
            "MANDIOCA CONGELADA",
            "MANDIOQUINHA CONGELADA",
            "MIGNON SUÍNO",
            "MILHO VERDE CONGELADO",
            "MIX DE LEGUMES",
            "MÚSCULO EM CUBOS",
            "MÚSCULO MEDALHÕES",
            "NHOQUE DE SOJA",
            "PÃO VEGANO",
            "PATINHO EM CUBOS",
            "PATINHO ÍSCAS LEGUMES",
            "PATINHO MOÍDO",
            "PERNIL CUBOS LEGUMES",
            "POLPA DE ABACAXI",
            "POLPA DE AÇAÍ",
            "POLPA DE MORANGO",
            "POLPA DE",
            "SOJA EM GRÃOS",
            "*REFRIGERADOS*",
            "CREME VEGETAL",
            "MANTEIGA",
            "*PANIFICADOS*",
            "BOLINHO INDIVIDUAL",
            "BOLINHO INDIVIDUAL INTEGRAL",
            "PÃO BISNAGUINHA",
            "PÃO BISNAGUINHA INTEGRAL",
            "PÃO HOT DOG",
            "PÃO HOT DOG INTEGRAL",
            "PÃO DE FORMA INTEGRAL"});
            this.cmbRemocao.Location = new System.Drawing.Point(231, 110);
            this.cmbRemocao.Name = "cmbRemocao";
            this.cmbRemocao.Size = new System.Drawing.Size(360, 32);
            this.cmbRemocao.TabIndex = 34;
            // 
            // FormRemocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.cmbRemocao);
            this.Controls.Add(this.txbQuantidadeRemocao);
            this.Controls.Add(this.txbValidadeRemocao);
            this.Controls.Add(this.btnConfirmarRemocao);
            this.Controls.Add(this.btnLimparRemocao);
            this.Controls.Add(this.btnPesquisarRemocao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnlRemocao);
            this.Name = "FormRemocao";
            this.Text = "FormRemocao";
            this.pnlRemocao.ResumeLayout(false);
            this.gpbCategoriasRemocao.ResumeLayout(false);
            this.gpbCategoriasRemocao.PerformLayout();
            this.gpbTiposRemocao.ResumeLayout(false);
            this.gpbTiposRemocao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbQuantidadeRemocao;
        private System.Windows.Forms.TextBox txbValidadeRemocao;
        private System.Windows.Forms.Button btnConfirmarRemocao;
        private System.Windows.Forms.Button btnLimparRemocao;
        private System.Windows.Forms.Button btnPesquisarRemocao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlRemocao;
        private System.Windows.Forms.GroupBox gpbCategoriasRemocao;
        private System.Windows.Forms.RadioButton rdbPoteCategoriasRemocao;
        private System.Windows.Forms.RadioButton rdbRrcCategoriasRemocao;
        private System.Windows.Forms.RadioButton rdbUnidCategoriasRemocao;
        private System.Windows.Forms.RadioButton rdbPctCategoriasRemocao;
        private System.Windows.Forms.GroupBox gpbTiposRemocao;
        private System.Windows.Forms.RadioButton rdbPanificadosTiposRemocao;
        private System.Windows.Forms.RadioButton rdbRefrigeradosTiposRemocao;
        private System.Windows.Forms.RadioButton rdbCongeladosTiposRemocao;
        private System.Windows.Forms.RadioButton rdbEstocaveisTiposRemocao;
        private System.Windows.Forms.ComboBox cmbRemocao;
    }
}