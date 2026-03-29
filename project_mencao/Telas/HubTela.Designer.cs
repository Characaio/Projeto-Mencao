namespace project_mencao.Telas
{
    partial class HubTela
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
            this.IrParaCalculoDeMedia = new System.Windows.Forms.Button();
            this.IrParaCompraDeProdutos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DeslogarBot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IrParaCalculoDeMedia
            // 
            this.IrParaCalculoDeMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.IrParaCalculoDeMedia.Location = new System.Drawing.Point(280, 114);
            this.IrParaCalculoDeMedia.Name = "IrParaCalculoDeMedia";
            this.IrParaCalculoDeMedia.Size = new System.Drawing.Size(271, 48);
            this.IrParaCalculoDeMedia.TabIndex = 0;
            this.IrParaCalculoDeMedia.Text = "Ir para o calculo de media";
            this.IrParaCalculoDeMedia.UseVisualStyleBackColor = true;
            this.IrParaCalculoDeMedia.Click += new System.EventHandler(this.IrParaCalculoDeMedia_Click);
            // 
            // IrParaCompraDeProdutos
            // 
            this.IrParaCompraDeProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.IrParaCompraDeProdutos.Location = new System.Drawing.Point(280, 179);
            this.IrParaCompraDeProdutos.Name = "IrParaCompraDeProdutos";
            this.IrParaCompraDeProdutos.Size = new System.Drawing.Size(271, 48);
            this.IrParaCompraDeProdutos.TabIndex = 1;
            this.IrParaCompraDeProdutos.Text = "Ir Para a Compra de Produtos";
            this.IrParaCompraDeProdutos.UseVisualStyleBackColor = true;
            this.IrParaCompraDeProdutos.Click += new System.EventHandler(this.IrParaCompraDeProdutos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.label1.Location = new System.Drawing.Point(305, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tela Principal";
            // 
            // DeslogarBot
            // 
            this.DeslogarBot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.DeslogarBot.Location = new System.Drawing.Point(280, 244);
            this.DeslogarBot.Name = "DeslogarBot";
            this.DeslogarBot.Size = new System.Drawing.Size(271, 48);
            this.DeslogarBot.TabIndex = 6;
            this.DeslogarBot.Text = "DesLogar";
            this.DeslogarBot.UseVisualStyleBackColor = true;
            this.DeslogarBot.Click += new System.EventHandler(this.DeslogarBot_Click);
            // 
            // HubTela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeslogarBot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IrParaCompraDeProdutos);
            this.Controls.Add(this.IrParaCalculoDeMedia);
            this.Name = "HubTela";
            this.Text = "TelaDeHub";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HubTela_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IrParaCalculoDeMedia;
        private System.Windows.Forms.Button IrParaCompraDeProdutos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeslogarBot;
    }
}