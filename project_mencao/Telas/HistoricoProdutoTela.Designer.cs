namespace project_mencao.Telas
{
    partial class HistoricoProdutoTela
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
            this.TabelaDeHistorico = new System.Windows.Forms.DataGridView();
            this.HistoricoCompraLabel = new System.Windows.Forms.Label();
            this.VoltarParaComprasBot = new System.Windows.Forms.Button();
            this.IdDoPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeDoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeDoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataDoPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaDeHistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // TabelaDeHistorico
            // 
            this.TabelaDeHistorico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TabelaDeHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelaDeHistorico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdDoPedido,
            this.NomeDoUsuario,
            this.NomeDoProduto,
            this.Quantidade,
            this.DataDoPedido});
            this.TabelaDeHistorico.Location = new System.Drawing.Point(12, 112);
            this.TabelaDeHistorico.Name = "TabelaDeHistorico";
            this.TabelaDeHistorico.Size = new System.Drawing.Size(776, 326);
            this.TabelaDeHistorico.TabIndex = 0;
            // 
            // HistoricoCompraLabel
            // 
            this.HistoricoCompraLabel.AutoSize = true;
            this.HistoricoCompraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.HistoricoCompraLabel.Location = new System.Drawing.Point(216, 16);
            this.HistoricoCompraLabel.Name = "HistoricoCompraLabel";
            this.HistoricoCompraLabel.Size = new System.Drawing.Size(355, 76);
            this.HistoricoCompraLabel.TabIndex = 1;
            this.HistoricoCompraLabel.Text = "Historico Das Compras\r\nDe {PlaceHolder}";
            this.HistoricoCompraLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.HistoricoCompraLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // VoltarParaComprasBot
            // 
            this.VoltarParaComprasBot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.VoltarParaComprasBot.Location = new System.Drawing.Point(12, 16);
            this.VoltarParaComprasBot.Name = "VoltarParaComprasBot";
            this.VoltarParaComprasBot.Size = new System.Drawing.Size(198, 38);
            this.VoltarParaComprasBot.TabIndex = 2;
            this.VoltarParaComprasBot.Text = "Voltar Para a Compra";
            this.VoltarParaComprasBot.UseVisualStyleBackColor = true;
            this.VoltarParaComprasBot.Click += new System.EventHandler(this.VoltarParaComprasBot_Click);
            // 
            // IdDoPedido
            // 
            this.IdDoPedido.HeaderText = "IdDoPedido";
            this.IdDoPedido.Name = "IdDoPedido";
            this.IdDoPedido.ReadOnly = true;
            // 
            // NomeDoUsuario
            // 
            this.NomeDoUsuario.HeaderText = "NomeDoComprador";
            this.NomeDoUsuario.Name = "NomeDoUsuario";
            this.NomeDoUsuario.ReadOnly = true;
            // 
            // NomeDoProduto
            // 
            this.NomeDoProduto.HeaderText = "NomeDoProduto";
            this.NomeDoProduto.Name = "NomeDoProduto";
            this.NomeDoProduto.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // DataDoPedido
            // 
            this.DataDoPedido.HeaderText = "DataDaCompra";
            this.DataDoPedido.Name = "DataDoPedido";
            this.DataDoPedido.ReadOnly = true;
            // 
            // HistoricoProdutoTela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VoltarParaComprasBot);
            this.Controls.Add(this.HistoricoCompraLabel);
            this.Controls.Add(this.TabelaDeHistorico);
            this.Name = "HistoricoProdutoTela";
            this.Text = "HistoricoProdutoTela";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HistoricoProdutoTela_FormClosing);
            this.Shown += new System.EventHandler(this.HistoricoProdutoTela_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.TabelaDeHistorico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TabelaDeHistorico;
        private System.Windows.Forms.Label HistoricoCompraLabel;
        private System.Windows.Forms.Button VoltarParaComprasBot;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDoPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeDoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeDoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataDoPedido;
    }
}