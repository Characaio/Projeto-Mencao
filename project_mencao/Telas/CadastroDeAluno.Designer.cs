namespace project_mencao.Telas
{
    partial class CadastroDeAluno
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
            this.IrParaCadastroAlunoBot = new System.Windows.Forms.Button();
            this.CadastAlunBot = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NomeBox = new System.Windows.Forms.TextBox();
            this.TurmaCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IrParaCadastroAlunoBot
            // 
            this.IrParaCadastroAlunoBot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.IrParaCadastroAlunoBot.Location = new System.Drawing.Point(288, 312);
            this.IrParaCadastroAlunoBot.Name = "IrParaCadastroAlunoBot";
            this.IrParaCadastroAlunoBot.Size = new System.Drawing.Size(257, 49);
            this.IrParaCadastroAlunoBot.TabIndex = 4;
            this.IrParaCadastroAlunoBot.Text = "Voltar ao Calculo da Media";
            this.IrParaCadastroAlunoBot.UseVisualStyleBackColor = true;
            this.IrParaCadastroAlunoBot.Click += new System.EventHandler(this.IrParaCadastroAlunoBot_Click);
            // 
            // CadastAlunBot
            // 
            this.CadastAlunBot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.CadastAlunBot.Location = new System.Drawing.Point(288, 254);
            this.CadastAlunBot.Name = "CadastAlunBot";
            this.CadastAlunBot.Size = new System.Drawing.Size(257, 52);
            this.CadastAlunBot.TabIndex = 3;
            this.CadastAlunBot.Text = "Cadastrar Aluno";
            this.CadastAlunBot.UseVisualStyleBackColor = true;
            this.CadastAlunBot.Click += new System.EventHandler(this.CadastAlunBot_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.label1.Location = new System.Drawing.Point(277, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 38);
            this.label1.TabIndex = 32;
            this.label1.Text = "Cadastro De Aluno";
            // 
            // NomeBox
            // 
            this.NomeBox.Location = new System.Drawing.Point(371, 127);
            this.NomeBox.Name = "NomeBox";
            this.NomeBox.Size = new System.Drawing.Size(174, 20);
            this.NomeBox.TabIndex = 1;
            // 
            // TurmaCombo
            // 
            this.TurmaCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TurmaCombo.FormattingEnabled = true;
            this.TurmaCombo.Items.AddRange(new object[] {
            "DS1",
            "DS2",
            "DS3",
            "SJ1",
            "SJ2",
            "SJ3",
            "ADM1",
            "ADM2",
            "ADM3",
            "LOG1",
            "LOG2",
            "LOG3",
            "BIO1",
            "BIO2",
            "BIO3",
            "MEI1",
            "MEI2",
            "MEI3",
            "MKT1",
            "MKT2",
            "MKT3"});
            this.TurmaCombo.Location = new System.Drawing.Point(371, 202);
            this.TurmaCombo.Name = "TurmaCombo";
            this.TurmaCombo.Size = new System.Drawing.Size(174, 21);
            this.TurmaCombo.TabIndex = 2;
            this.TurmaCombo.Tag = "";
            this.TurmaCombo.SelectedIndexChanged += new System.EventHandler(this.TurmaCombo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(284, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(284, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Turma";
            // 
            // CadastroDeAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TurmaCombo);
            this.Controls.Add(this.NomeBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CadastAlunBot);
            this.Controls.Add(this.IrParaCadastroAlunoBot);
            this.Name = "CadastroDeAluno";
            this.Text = "CadastroDeAluno";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CadastroDeAluno_FormClosing);
            this.Load += new System.EventHandler(this.CadastroDeAluno_Load);
            this.Shown += new System.EventHandler(this.CadastroDeAluno_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IrParaCadastroAlunoBot;
        private System.Windows.Forms.Button CadastAlunBot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NomeBox;
        private System.Windows.Forms.ComboBox TurmaCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}