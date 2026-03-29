namespace project_mencao.Telas
{
    partial class CadastroProdutosTela
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MarcaBox = new System.Windows.Forms.TextBox();
            this.DescriMultiLineBox = new System.Windows.Forms.TextBox();
            this.ValorBox = new System.Windows.Forms.TextBox();
            this.NomeBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CadastroBot = new System.Windows.Forms.Button();
            this.VoltarBot = new System.Windows.Forms.Button();
            this.TipoComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.label8.Location = new System.Drawing.Point(263, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(324, 38);
            this.label8.TabIndex = 25;
            this.label8.Text = "Cadastro De Produto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label7.Location = new System.Drawing.Point(227, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Tipo";
            // 
            // MarcaBox
            // 
            this.MarcaBox.Location = new System.Drawing.Point(285, 244);
            this.MarcaBox.Name = "MarcaBox";
            this.MarcaBox.Size = new System.Drawing.Size(292, 20);
            this.MarcaBox.TabIndex = 22;
            // 
            // DescriMultiLineBox
            // 
            this.DescriMultiLineBox.Location = new System.Drawing.Point(285, 143);
            this.DescriMultiLineBox.Multiline = true;
            this.DescriMultiLineBox.Name = "DescriMultiLineBox";
            this.DescriMultiLineBox.Size = new System.Drawing.Size(292, 86);
            this.DescriMultiLineBox.TabIndex = 21;
            // 
            // ValorBox
            // 
            this.ValorBox.Location = new System.Drawing.Point(285, 108);
            this.ValorBox.Name = "ValorBox";
            this.ValorBox.Size = new System.Drawing.Size(292, 20);
            this.ValorBox.TabIndex = 20;
            // 
            // NomeBox
            // 
            this.NomeBox.Location = new System.Drawing.Point(285, 72);
            this.NomeBox.Name = "NomeBox";
            this.NomeBox.Size = new System.Drawing.Size(292, 20);
            this.NomeBox.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(212, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Marca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(222, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Valor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(184, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(215, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nome";
            // 
            // CadastroBot
            // 
            this.CadastroBot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.CadastroBot.Location = new System.Drawing.Point(285, 323);
            this.CadastroBot.Name = "CadastroBot";
            this.CadastroBot.Size = new System.Drawing.Size(292, 48);
            this.CadastroBot.TabIndex = 26;
            this.CadastroBot.Text = "Cadastrar Produto";
            this.CadastroBot.UseVisualStyleBackColor = true;
            this.CadastroBot.Click += new System.EventHandler(this.CadastroBot_Click);
            // 
            // VoltarBot
            // 
            this.VoltarBot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.VoltarBot.Location = new System.Drawing.Point(285, 377);
            this.VoltarBot.Name = "VoltarBot";
            this.VoltarBot.Size = new System.Drawing.Size(292, 48);
            this.VoltarBot.TabIndex = 27;
            this.VoltarBot.Text = "Voltar Para a Compra";
            this.VoltarBot.UseVisualStyleBackColor = true;
            this.VoltarBot.Click += new System.EventHandler(this.VoltarBot_Click);
            // 
            // TipoComboBox
            // 
            this.TipoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoComboBox.FormattingEnabled = true;
            this.TipoComboBox.Items.AddRange(new object[] {
            "Alimento",
            "Higiene",
            "Liquido",
            "Utensilio",
            "Eletrodomestico",
            "Eletronico",
            "SLA"});
            this.TipoComboBox.Location = new System.Drawing.Point(285, 277);
            this.TipoComboBox.Name = "TipoComboBox";
            this.TipoComboBox.Size = new System.Drawing.Size(292, 21);
            this.TipoComboBox.TabIndex = 28;
            // 
            // CadastroProdutosTela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TipoComboBox);
            this.Controls.Add(this.VoltarBot);
            this.Controls.Add(this.CadastroBot);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MarcaBox);
            this.Controls.Add(this.DescriMultiLineBox);
            this.Controls.Add(this.ValorBox);
            this.Controls.Add(this.NomeBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "CadastroProdutosTela";
            this.Text = "CadastroProdutosTela";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CadastroProdutosTela_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MarcaBox;
        private System.Windows.Forms.TextBox DescriMultiLineBox;
        private System.Windows.Forms.TextBox ValorBox;
        private System.Windows.Forms.TextBox NomeBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CadastroBot;
        private System.Windows.Forms.Button VoltarBot;
        private System.Windows.Forms.ComboBox TipoComboBox;
    }
}