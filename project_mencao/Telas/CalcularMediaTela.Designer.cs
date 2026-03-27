
namespace project_mencao
{
    partial class CalcularMediaTela
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
            this.label2 = new System.Windows.Forms.Label();
            this.TabelaNotas = new System.Windows.Forms.DataGridView();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota1Bim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota2Bim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota3Bim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota4Bim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotaFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BimCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NotaPlaceHolderLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NotaProvaBox = new System.Windows.Forms.TextBox();
            this.NotaAtivBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PostarButton = new System.Windows.Forms.Button();
            this.AlunoCombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NotaCompBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.IrParaCadastroAlunoBot = new System.Windows.Forms.Button();
            this.DeslogButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.label2.Location = new System.Drawing.Point(269, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Calcular Media";
            // 
            // TabelaNotas
            // 
            this.TabelaNotas.AllowUserToDeleteRows = false;
            this.TabelaNotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TabelaNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Matricula,
            this.Nome,
            this.Nota1Bim,
            this.Nota2Bim,
            this.Nota3Bim,
            this.Nota4Bim,
            this.NotaFinal});
            this.TabelaNotas.Location = new System.Drawing.Point(12, 288);
            this.TabelaNotas.Name = "TabelaNotas";
            this.TabelaNotas.ReadOnly = true;
            this.TabelaNotas.Size = new System.Drawing.Size(776, 150);
            this.TabelaNotas.TabIndex = 0;
            this.TabelaNotas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Matricula
            // 
            this.Matricula.HeaderText = "Matricula";
            this.Matricula.Name = "Matricula";
            this.Matricula.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome do Aluno";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Nota1Bim
            // 
            this.Nota1Bim.HeaderText = "1ºBim";
            this.Nota1Bim.Name = "Nota1Bim";
            this.Nota1Bim.ReadOnly = true;
            // 
            // Nota2Bim
            // 
            this.Nota2Bim.HeaderText = "2ºBim";
            this.Nota2Bim.Name = "Nota2Bim";
            this.Nota2Bim.ReadOnly = true;
            // 
            // Nota3Bim
            // 
            this.Nota3Bim.HeaderText = "3ºBim";
            this.Nota3Bim.Name = "Nota3Bim";
            this.Nota3Bim.ReadOnly = true;
            // 
            // Nota4Bim
            // 
            this.Nota4Bim.HeaderText = "4ºBim";
            this.Nota4Bim.Name = "Nota4Bim";
            this.Nota4Bim.ReadOnly = true;
            // 
            // NotaFinal
            // 
            this.NotaFinal.HeaderText = "Nota Final";
            this.NotaFinal.Name = "NotaFinal";
            this.NotaFinal.ReadOnly = true;
            // 
            // BimCombo
            // 
            this.BimCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BimCombo.FormattingEnabled = true;
            this.BimCombo.Items.AddRange(new object[] {
            "1ºBimestre",
            "2ºBimestre",
            "3ºBimestre",
            "4ºBimestre"});
            this.BimCombo.Location = new System.Drawing.Point(95, 130);
            this.BimCombo.Name = "BimCombo";
            this.BimCombo.Size = new System.Drawing.Size(150, 21);
            this.BimCombo.TabIndex = 2;
            this.BimCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(12, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bimestre";
            // 
            // NotaPlaceHolderLabel
            // 
            this.NotaPlaceHolderLabel.AutoSize = true;
            this.NotaPlaceHolderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.NotaPlaceHolderLabel.Location = new System.Drawing.Point(286, 259);
            this.NotaPlaceHolderLabel.Name = "NotaPlaceHolderLabel";
            this.NotaPlaceHolderLabel.Size = new System.Drawing.Size(227, 26);
            this.NotaPlaceHolderLabel.TabIndex = 0;
            this.NotaPlaceHolderLabel.Text = "Nota de {PlaceHolder}";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(507, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nota de Prova";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // NotaProvaBox
            // 
            this.NotaProvaBox.Location = new System.Drawing.Point(638, 94);
            this.NotaProvaBox.Name = "NotaProvaBox";
            this.NotaProvaBox.Size = new System.Drawing.Size(150, 20);
            this.NotaProvaBox.TabIndex = 3;
            this.NotaProvaBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NotaAtivBox
            // 
            this.NotaAtivBox.Location = new System.Drawing.Point(638, 131);
            this.NotaAtivBox.Name = "NotaAtivBox";
            this.NotaAtivBox.Size = new System.Drawing.Size(150, 20);
            this.NotaAtivBox.TabIndex = 4;
            this.NotaAtivBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(482, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nota de Atividade";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // PostarButton
            // 
            this.PostarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.PostarButton.Location = new System.Drawing.Point(533, 202);
            this.PostarButton.Name = "PostarButton";
            this.PostarButton.Size = new System.Drawing.Size(255, 42);
            this.PostarButton.TabIndex = 6;
            this.PostarButton.Text = "Postar Nota";
            this.PostarButton.UseVisualStyleBackColor = true;
            this.PostarButton.Click += new System.EventHandler(this.PostarButton_Click);
            // 
            // AlunoCombo
            // 
            this.AlunoCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AlunoCombo.FormattingEnabled = true;
            this.AlunoCombo.Items.AddRange(new object[] {
            "Aluno1",
            "Aluno2",
            "Aluno3"});
            this.AlunoCombo.Location = new System.Drawing.Point(95, 93);
            this.AlunoCombo.Name = "AlunoCombo";
            this.AlunoCombo.Size = new System.Drawing.Size(150, 21);
            this.AlunoCombo.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(38, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Aluno";
            // 
            // NotaCompBox
            // 
            this.NotaCompBox.Location = new System.Drawing.Point(638, 166);
            this.NotaCompBox.Name = "NotaCompBox";
            this.NotaCompBox.Size = new System.Drawing.Size(150, 20);
            this.NotaCompBox.TabIndex = 5;
            this.NotaCompBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label7.Location = new System.Drawing.Point(431, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nota de Comportamento";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // IrParaCadastroAlunoBot
            // 
            this.IrParaCadastroAlunoBot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.IrParaCadastroAlunoBot.Location = new System.Drawing.Point(16, 202);
            this.IrParaCadastroAlunoBot.Name = "IrParaCadastroAlunoBot";
            this.IrParaCadastroAlunoBot.Size = new System.Drawing.Size(229, 42);
            this.IrParaCadastroAlunoBot.TabIndex = 7;
            this.IrParaCadastroAlunoBot.Text = "Cadastrar Novo Aluno";
            this.IrParaCadastroAlunoBot.UseVisualStyleBackColor = true;
            this.IrParaCadastroAlunoBot.Click += new System.EventHandler(this.IrParaCadastroAlunoBot_Click);
            // 
            // DeslogButton
            // 
            this.DeslogButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.DeslogButton.Location = new System.Drawing.Point(13, 9);
            this.DeslogButton.Name = "DeslogButton";
            this.DeslogButton.Size = new System.Drawing.Size(204, 38);
            this.DeslogButton.TabIndex = 8;
            this.DeslogButton.Text = "DesLogar";
            this.DeslogButton.UseVisualStyleBackColor = true;
            this.DeslogButton.Click += new System.EventHandler(this.DeslogButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button1.Location = new System.Drawing.Point(533, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 38);
            this.button1.TabIndex = 9;
            this.button1.Text = "Ir para Sistema de Produtos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CalcularMediaTela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DeslogButton);
            this.Controls.Add(this.IrParaCadastroAlunoBot);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NotaCompBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AlunoCombo);
            this.Controls.Add(this.PostarButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NotaAtivBox);
            this.Controls.Add(this.NotaProvaBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NotaPlaceHolderLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BimCombo);
            this.Controls.Add(this.TabelaNotas);
            this.Controls.Add(this.label2);
            this.Name = "CalcularMediaTela";
            this.Text = "CalcularMediaTela";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CalcularMediaTela_FormClosing);
            this.Load += new System.EventHandler(this.CalcularMediaTela_Load);
            this.Shown += new System.EventHandler(this.CalcularMediaTela_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.TabelaNotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView TabelaNotas;
        private System.Windows.Forms.ComboBox BimCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NotaPlaceHolderLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NotaProvaBox;
        private System.Windows.Forms.TextBox NotaAtivBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button PostarButton;
        private System.Windows.Forms.ComboBox AlunoCombo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NotaCompBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button IrParaCadastroAlunoBot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota1Bim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota2Bim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota3Bim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota4Bim;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotaFinal;
        private System.Windows.Forms.Button DeslogButton;
        private System.Windows.Forms.Button button1;
    }
}