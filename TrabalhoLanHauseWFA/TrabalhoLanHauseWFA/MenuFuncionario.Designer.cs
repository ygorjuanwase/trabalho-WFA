namespace TrabalhoLanHauseWFA
{
    partial class MenuFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuFuncionario));
            this.dtgFuncionario = new System.Windows.Forms.DataGridView();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNascionalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgFuncionario
            // 
            this.dtgFuncionario.AllowUserToAddRows = false;
            this.dtgFuncionario.AllowUserToDeleteRows = false;
            this.dtgFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNome,
            this.ColumnCargo,
            this.ColumnNascionalidade});
            this.dtgFuncionario.Location = new System.Drawing.Point(12, 260);
            this.dtgFuncionario.Name = "dtgFuncionario";
            this.dtgFuncionario.ReadOnly = true;
            this.dtgFuncionario.Size = new System.Drawing.Size(857, 364);
            this.dtgFuncionario.TabIndex = 0;
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            this.ColumnNome.Width = 300;
            // 
            // ColumnCargo
            // 
            this.ColumnCargo.HeaderText = "Cargo";
            this.ColumnCargo.Name = "ColumnCargo";
            this.ColumnCargo.ReadOnly = true;
            this.ColumnCargo.Width = 150;
            // 
            // ColumnNascionalidade
            // 
            this.ColumnNascionalidade.HeaderText = "Nascionalidade";
            this.ColumnNascionalidade.Name = "ColumnNascionalidade";
            this.ColumnNascionalidade.ReadOnly = true;
            this.ColumnNascionalidade.Width = 150;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Buscar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 79);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menu Funcionario";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(551, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 44);
            this.button2.TabIndex = 3;
            this.button2.Text = "cadastrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(656, 210);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 44);
            this.button3.TabIndex = 4;
            this.button3.Text = "Editar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(760, 210);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 44);
            this.button4.TabIndex = 5;
            this.button4.Text = "Apagar";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(109, 234);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(323, 20);
            this.txtBusca.TabIndex = 6;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(438, 210);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 44);
            this.button5.TabIndex = 7;
            this.button5.Text = "Atualizar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // MenuFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 613);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgFuncionario);
            this.MinimizeBox = false;
            this.Name = "MenuFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuFuncionario";
            this.Load += new System.EventHandler(this.MenuFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgFuncionario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNascionalidade;
        private System.Windows.Forms.Button button5;

    }
}