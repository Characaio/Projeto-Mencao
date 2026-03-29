namespace project_mencao.Telas
{
    partial class ComprarProdutosTela
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
            this.CarregarProdutoBot = new System.Windows.Forms.Button();
            this.ProdutoSelecionadoCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NomeBox = new System.Windows.Forms.TextBox();
            this.ValorBox = new System.Windows.Forms.TextBox();
            this.DescriMultiLineBox = new System.Windows.Forms.TextBox();
            this.MarcaBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TipoBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PainelDeCompra = new System.Windows.Forms.Panel();
            this.QuantBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.CompraProdutoBot = new System.Windows.Forms.Button();
            this.ValorFinalLabel = new System.Windows.Forms.Label();
            this.ValorDoFreteLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.EstadoComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.IrParaHistoricoDeCompraBot = new System.Windows.Forms.Button();
            this.VoltarTelaPrincipalBot = new System.Windows.Forms.Button();
            this.IrParaCadastro = new System.Windows.Forms.Button();
            this.PainelDeCompra.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.label1.Location = new System.Drawing.Point(296, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produtos";
            // 
            // CarregarProdutoBot
            // 
            this.CarregarProdutoBot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.CarregarProdutoBot.Location = new System.Drawing.Point(16, 125);
            this.CarregarProdutoBot.Name = "CarregarProdutoBot";
            this.CarregarProdutoBot.Size = new System.Drawing.Size(321, 37);
            this.CarregarProdutoBot.TabIndex = 1;
            this.CarregarProdutoBot.Text = "Carregar Produto";
            this.CarregarProdutoBot.UseVisualStyleBackColor = true;
            this.CarregarProdutoBot.Click += new System.EventHandler(this.CarregarProdutoBot_Click);
            // 
            // ProdutoSelecionadoCombo
            // 
            this.ProdutoSelecionadoCombo.FormattingEnabled = true;
            this.ProdutoSelecionadoCombo.Location = new System.Drawing.Point(181, 84);
            this.ProdutoSelecionadoCombo.Name = "ProdutoSelecionadoCombo";
            this.ProdutoSelecionadoCombo.Size = new System.Drawing.Size(156, 21);
            this.ProdutoSelecionadoCombo.TabIndex = 2;
            this.ProdutoSelecionadoCombo.SelectedIndexChanged += new System.EventHandler(this.ProdutoSelecionadoCombo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Produto Selecionado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(516, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(478, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Descrição";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(516, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Valor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(508, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Marca";
            // 
            // NomeBox
            // 
            this.NomeBox.Location = new System.Drawing.Point(580, 114);
            this.NomeBox.Name = "NomeBox";
            this.NomeBox.ReadOnly = true;
            this.NomeBox.Size = new System.Drawing.Size(172, 20);
            this.NomeBox.TabIndex = 8;
            // 
            // ValorBox
            // 
            this.ValorBox.Location = new System.Drawing.Point(580, 154);
            this.ValorBox.Name = "ValorBox";
            this.ValorBox.ReadOnly = true;
            this.ValorBox.Size = new System.Drawing.Size(172, 20);
            this.ValorBox.TabIndex = 9;
            // 
            // DescriMultiLineBox
            // 
            this.DescriMultiLineBox.Location = new System.Drawing.Point(580, 196);
            this.DescriMultiLineBox.Multiline = true;
            this.DescriMultiLineBox.Name = "DescriMultiLineBox";
            this.DescriMultiLineBox.ReadOnly = true;
            this.DescriMultiLineBox.Size = new System.Drawing.Size(172, 86);
            this.DescriMultiLineBox.TabIndex = 10;
            // 
            // MarcaBox
            // 
            this.MarcaBox.Location = new System.Drawing.Point(580, 300);
            this.MarcaBox.Name = "MarcaBox";
            this.MarcaBox.ReadOnly = true;
            this.MarcaBox.Size = new System.Drawing.Size(172, 20);
            this.MarcaBox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label7.Location = new System.Drawing.Point(516, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tipo";
            // 
            // TipoBox
            // 
            this.TipoBox.Location = new System.Drawing.Point(580, 347);
            this.TipoBox.Name = "TipoBox";
            this.TipoBox.ReadOnly = true;
            this.TipoBox.Size = new System.Drawing.Size(172, 20);
            this.TipoBox.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label8.Location = new System.Drawing.Point(477, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(296, 26);
            this.label8.TabIndex = 14;
            this.label8.Text = "Informações Sobre o Produto";
            // 
            // PainelDeCompra
            // 
            this.PainelDeCompra.Controls.Add(this.QuantBox);
            this.PainelDeCompra.Controls.Add(this.label13);
            this.PainelDeCompra.Controls.Add(this.CompraProdutoBot);
            this.PainelDeCompra.Controls.Add(this.ValorFinalLabel);
            this.PainelDeCompra.Controls.Add(this.ValorDoFreteLabel);
            this.PainelDeCompra.Controls.Add(this.label12);
            this.PainelDeCompra.Controls.Add(this.label11);
            this.PainelDeCompra.Controls.Add(this.label10);
            this.PainelDeCompra.Controls.Add(this.EstadoComboBox);
            this.PainelDeCompra.Controls.Add(this.label9);
            this.PainelDeCompra.Location = new System.Drawing.Point(16, 186);
            this.PainelDeCompra.Name = "PainelDeCompra";
            this.PainelDeCompra.Size = new System.Drawing.Size(428, 252);
            this.PainelDeCompra.TabIndex = 15;
            this.PainelDeCompra.Visible = false;
            // 
            // QuantBox
            // 
            this.QuantBox.Location = new System.Drawing.Point(103, 76);
            this.QuantBox.Name = "QuantBox";
            this.QuantBox.Size = new System.Drawing.Size(172, 20);
            this.QuantBox.TabIndex = 17;
            this.QuantBox.TextChanged += new System.EventHandler(this.QuantBox_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label13.Location = new System.Drawing.Point(3, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 20);
            this.label13.TabIndex = 22;
            this.label13.Text = "Quantidade";
            // 
            // CompraProdutoBot
            // 
            this.CompraProdutoBot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.CompraProdutoBot.Location = new System.Drawing.Point(7, 198);
            this.CompraProdutoBot.Name = "CompraProdutoBot";
            this.CompraProdutoBot.Size = new System.Drawing.Size(407, 42);
            this.CompraProdutoBot.TabIndex = 21;
            this.CompraProdutoBot.Text = "Comprar Produto";
            this.CompraProdutoBot.UseVisualStyleBackColor = true;
            this.CompraProdutoBot.Click += new System.EventHandler(this.CompraProdutoBot_Click);
            // 
            // ValorFinalLabel
            // 
            this.ValorFinalLabel.AutoSize = true;
            this.ValorFinalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ValorFinalLabel.Location = new System.Drawing.Point(124, 159);
            this.ValorFinalLabel.Name = "ValorFinalLabel";
            this.ValorFinalLabel.Size = new System.Drawing.Size(14, 20);
            this.ValorFinalLabel.TabIndex = 20;
            this.ValorFinalLabel.Text = ";";
            // 
            // ValorDoFreteLabel
            // 
            this.ValorDoFreteLabel.AutoSize = true;
            this.ValorDoFreteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ValorDoFreteLabel.Location = new System.Drawing.Point(124, 123);
            this.ValorDoFreteLabel.Name = "ValorDoFreteLabel";
            this.ValorDoFreteLabel.Size = new System.Drawing.Size(14, 20);
            this.ValorDoFreteLabel.TabIndex = 19;
            this.ValorDoFreteLabel.Text = ";";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label12.Location = new System.Drawing.Point(3, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 20);
            this.label12.TabIndex = 18;
            this.label12.Text = "Valor do Final";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label11.Location = new System.Drawing.Point(3, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "Valor do Frete";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label10.Location = new System.Drawing.Point(62, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(298, 26);
            this.label10.TabIndex = 16;
            this.label10.Text = "Informações Sobre a Compra";
            // 
            // EstadoComboBox
            // 
            this.EstadoComboBox.FormattingEnabled = true;
            this.EstadoComboBox.Items.AddRange(new object[] {
            "AC - Acre  ",
            "AL - Alagoas  ",
            "AP - Amapá  ",
            "AM - Amazonas  ",
            "BA - Bahia  ",
            "CE - Ceará  ",
            "DF - Distrito Federal  ",
            "ES - Espírito Santo  ",
            "GO - Goiás  ",
            "MA - Maranhão  ",
            "MT - Mato Grosso  ",
            "MS - Mato Grosso do Sul  ",
            "MG - Minas Gerais  ",
            "PA - Pará  ",
            "PB - Paraíba  ",
            "PR - Paraná  ",
            "PE - Pernambuco  ",
            "PI - Piauí  ",
            "RJ - Rio de Janeiro  ",
            "RN - Rio Grande do Norte  ",
            "RS - Rio Grande do Sul  ",
            "RO - Rondônia  ",
            "RR - Roraima  ",
            "SC - Santa Catarina  ",
            "SP - São Paulo  ",
            "SE - Sergipe  ",
            "TO - Tocantins  "});
            this.EstadoComboBox.Location = new System.Drawing.Point(187, 37);
            this.EstadoComboBox.Name = "EstadoComboBox";
            this.EstadoComboBox.Size = new System.Drawing.Size(227, 21);
            this.EstadoComboBox.TabIndex = 16;
            this.EstadoComboBox.SelectedIndexChanged += new System.EventHandler(this.EstadoComboBox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label9.Location = new System.Drawing.Point(3, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Estado Para a Entrega";
            // 
            // IrParaHistoricoDeCompraBot
            // 
            this.IrParaHistoricoDeCompraBot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.IrParaHistoricoDeCompraBot.Location = new System.Drawing.Point(540, 12);
            this.IrParaHistoricoDeCompraBot.Name = "IrParaHistoricoDeCompraBot";
            this.IrParaHistoricoDeCompraBot.Size = new System.Drawing.Size(248, 44);
            this.IrParaHistoricoDeCompraBot.TabIndex = 16;
            this.IrParaHistoricoDeCompraBot.Text = "Ver Historico De Compras";
            this.IrParaHistoricoDeCompraBot.UseVisualStyleBackColor = true;
            this.IrParaHistoricoDeCompraBot.Click += new System.EventHandler(this.IrParaHistoricoDeCompraBot_Click);
            // 
            // VoltarTelaPrincipalBot
            // 
            this.VoltarTelaPrincipalBot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.VoltarTelaPrincipalBot.Location = new System.Drawing.Point(16, 12);
            this.VoltarTelaPrincipalBot.Name = "VoltarTelaPrincipalBot";
            this.VoltarTelaPrincipalBot.Size = new System.Drawing.Size(248, 44);
            this.VoltarTelaPrincipalBot.TabIndex = 17;
            this.VoltarTelaPrincipalBot.Text = "Voltar a Tela Principal";
            this.VoltarTelaPrincipalBot.UseVisualStyleBackColor = true;
            this.VoltarTelaPrincipalBot.Click += new System.EventHandler(this.VoltarTelaPrincipalBot_Click);
            // 
            // IrParaCadastro
            // 
            this.IrParaCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.IrParaCadastro.Location = new System.Drawing.Point(540, 394);
            this.IrParaCadastro.Name = "IrParaCadastro";
            this.IrParaCadastro.Size = new System.Drawing.Size(247, 44);
            this.IrParaCadastro.TabIndex = 18;
            this.IrParaCadastro.Text = "Ir Para Tela de Cadastro";
            this.IrParaCadastro.UseVisualStyleBackColor = true;
            this.IrParaCadastro.Click += new System.EventHandler(this.IrParaCadastro_Click);
            // 
            // ComprarProdutosTela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IrParaCadastro);
            this.Controls.Add(this.VoltarTelaPrincipalBot);
            this.Controls.Add(this.IrParaHistoricoDeCompraBot);
            this.Controls.Add(this.PainelDeCompra);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TipoBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MarcaBox);
            this.Controls.Add(this.DescriMultiLineBox);
            this.Controls.Add(this.ValorBox);
            this.Controls.Add(this.NomeBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProdutoSelecionadoCombo);
            this.Controls.Add(this.CarregarProdutoBot);
            this.Controls.Add(this.label1);
            this.Name = "ComprarProdutosTela";
            this.Text = "Produtos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ComprarProdutosTela_FormClosing);
            this.Load += new System.EventHandler(this.ComprarProdutosTela_Load);
            this.Shown += new System.EventHandler(this.ComprarProdutosTela_Shown);
            this.VisibleChanged += new System.EventHandler(this.ComprarProdutosTela_VisibleChanged);
            this.PainelDeCompra.ResumeLayout(false);
            this.PainelDeCompra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CarregarProdutoBot;
        private System.Windows.Forms.ComboBox ProdutoSelecionadoCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NomeBox;
        private System.Windows.Forms.TextBox ValorBox;
        private System.Windows.Forms.TextBox DescriMultiLineBox;
        private System.Windows.Forms.TextBox MarcaBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TipoBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel PainelDeCompra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox EstadoComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button CompraProdutoBot;
        private System.Windows.Forms.Label ValorFinalLabel;
        private System.Windows.Forms.Label ValorDoFreteLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox QuantBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button IrParaHistoricoDeCompraBot;
        private System.Windows.Forms.Button VoltarTelaPrincipalBot;
        private System.Windows.Forms.Button IrParaCadastro;
    }
}