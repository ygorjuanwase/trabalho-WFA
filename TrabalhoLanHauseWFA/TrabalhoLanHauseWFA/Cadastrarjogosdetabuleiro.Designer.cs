namespace TrabalhoLanHauseWFA
{
    partial class Cadastrarjogosdetabuleiro
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
            this.cbEstiloTAbuleiro = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNomeDoJogo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbEstiloJogo = new System.Windows.Forms.ComboBox();
            this.txtQuantidadeJogadores = new System.Windows.Forms.TextBox();
            this.txtCriadorJogo = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.mtbAnoFabricacao = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Do Jogo";
            // 
            // cbEstiloTAbuleiro
            // 
            this.cbEstiloTAbuleiro.FormattingEnabled = true;
            this.cbEstiloTAbuleiro.Items.AddRange(new object[] {
            "Quadrado ",
            "Redondo ",
            "Online",
            "Pessoal",
            "Multiplayer"});
            this.cbEstiloTAbuleiro.Location = new System.Drawing.Point(638, 173);
            this.cbEstiloTAbuleiro.Name = "cbEstiloTAbuleiro";
            this.cbEstiloTAbuleiro.Size = new System.Drawing.Size(336, 21);
            this.cbEstiloTAbuleiro.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.button1.ForeColor = System.Drawing.Color.DarkBlue;
            this.button1.Location = new System.Drawing.Point(714, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNomeDoJogo
            // 
            this.txtNomeDoJogo.Location = new System.Drawing.Point(148, 24);
            this.txtNomeDoJogo.Name = "txtNomeDoJogo";
            this.txtNomeDoJogo.Size = new System.Drawing.Size(306, 20);
            this.txtNomeDoJogo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(31, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ano de Fabricação";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(31, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Criador do Jogo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(495, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantidade de Jogadores";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(509, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Estilo do Jogo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(495, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Estilo do Tabuleiro";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(509, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "dados";
            // 
            // cbEstiloJogo
            // 
            this.cbEstiloJogo.FormattingEnabled = true;
            this.cbEstiloJogo.Items.AddRange(new object[] {
            "Go",
            "Luta na Selva",
            "Mancala",
            "Tafl",
            "Trilha",
            "Xadrez",
            "Shogi",
            "Xiangqi ",
            "Chaturanga ",
            "Chaturaji ",
            "RPGS"});
            this.cbEstiloJogo.Location = new System.Drawing.Point(638, 98);
            this.cbEstiloJogo.Name = "cbEstiloJogo";
            this.cbEstiloJogo.Size = new System.Drawing.Size(336, 21);
            this.cbEstiloJogo.TabIndex = 10;
            // 
            // txtQuantidadeJogadores
            // 
            this.txtQuantidadeJogadores.Location = new System.Drawing.Point(676, 24);
            this.txtQuantidadeJogadores.Name = "txtQuantidadeJogadores";
            this.txtQuantidadeJogadores.Size = new System.Drawing.Size(315, 20);
            this.txtQuantidadeJogadores.TabIndex = 12;
            // 
            // txtCriadorJogo
            // 
            this.txtCriadorJogo.Location = new System.Drawing.Point(166, 176);
            this.txtCriadorJogo.Name = "txtCriadorJogo";
            this.txtCriadorJogo.Size = new System.Drawing.Size(306, 20);
            this.txtCriadorJogo.TabIndex = 13;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.radioButton1.ForeColor = System.Drawing.Color.DarkBlue;
            this.radioButton1.Location = new System.Drawing.Point(638, 219);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 29);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "SIm";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.radioButton2.ForeColor = System.Drawing.Color.DarkBlue;
            this.radioButton2.Location = new System.Drawing.Point(782, 219);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(62, 29);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Não";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.button2.ForeColor = System.Drawing.Color.DarkBlue;
            this.button2.Location = new System.Drawing.Point(838, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 38);
            this.button2.TabIndex = 16;
            this.button2.Text = "Cadastrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mtbAnoFabricacao
            // 
            this.mtbAnoFabricacao.Location = new System.Drawing.Point(166, 98);
            this.mtbAnoFabricacao.Mask = "00/00/0000";
            this.mtbAnoFabricacao.Name = "mtbAnoFabricacao";
            this.mtbAnoFabricacao.Size = new System.Drawing.Size(306, 20);
            this.mtbAnoFabricacao.TabIndex = 17;
            this.mtbAnoFabricacao.ValidatingType = typeof(System.DateTime);
            // 
            // Cadastrarjogosdetabuleiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1032, 554);
            this.Controls.Add(this.mtbAnoFabricacao);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.txtCriadorJogo);
            this.Controls.Add(this.txtQuantidadeJogadores);
            this.Controls.Add(this.cbEstiloJogo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeDoJogo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbEstiloTAbuleiro);
            this.Controls.Add(this.label1);
            this.Name = "Cadastrarjogosdetabuleiro";
            this.Text = "Cadastrarjogosdetabuleiro";
            this.Load += new System.EventHandler(this.Cadastrarjogosdetabuleiro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEstiloTAbuleiro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNomeDoJogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbEstiloJogo;
        private System.Windows.Forms.TextBox txtQuantidadeJogadores;
        private System.Windows.Forms.TextBox txtCriadorJogo;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox mtbAnoFabricacao;
    }
}