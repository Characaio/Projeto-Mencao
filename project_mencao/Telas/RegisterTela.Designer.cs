
namespace project_mencao
{
    partial class RegisterTela
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
            this.NomeBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BotRegistro = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SenhaBox = new System.Windows.Forms.TextBox();
            this.BotVoltarRegistro = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TelefoneMBox = new System.Windows.Forms.MaskedTextBox();
            this.MateriaComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.label1.Location = new System.Drawing.Point(215, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Professor";
            // 
            // NomeBox
            // 
            this.NomeBox.Location = new System.Drawing.Point(276, 70);
            this.NomeBox.Name = "NomeBox";
            this.NomeBox.Size = new System.Drawing.Size(292, 20);
            this.NomeBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(192, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(189, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Telefone";
            // 
            // BotRegistro
            // 
            this.BotRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.BotRegistro.Location = new System.Drawing.Point(193, 302);
            this.BotRegistro.Name = "BotRegistro";
            this.BotRegistro.Size = new System.Drawing.Size(375, 49);
            this.BotRegistro.TabIndex = 6;
            this.BotRegistro.Text = "Registrar Usuario";
            this.BotRegistro.UseVisualStyleBackColor = true;
            this.BotRegistro.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(189, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email";
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(276, 159);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(292, 20);
            this.EmailBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(189, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Senha";
            // 
            // SenhaBox
            // 
            this.SenhaBox.Location = new System.Drawing.Point(276, 205);
            this.SenhaBox.Name = "SenhaBox";
            this.SenhaBox.PasswordChar = '*';
            this.SenhaBox.Size = new System.Drawing.Size(292, 20);
            this.SenhaBox.TabIndex = 4;
            // 
            // BotVoltarRegistro
            // 
            this.BotVoltarRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.BotVoltarRegistro.Location = new System.Drawing.Point(193, 357);
            this.BotVoltarRegistro.Name = "BotVoltarRegistro";
            this.BotVoltarRegistro.Size = new System.Drawing.Size(375, 49);
            this.BotVoltarRegistro.TabIndex = 7;
            this.BotVoltarRegistro.Text = "Ir Para Tela De Login";
            this.BotVoltarRegistro.UseVisualStyleBackColor = true;
            this.BotVoltarRegistro.Click += new System.EventHandler(this.BotVoltarRegistro_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(189, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 40);
            this.label6.TabIndex = 0;
            this.label6.Text = "Materia \r\nLecionada";
            // 
            // TelefoneMBox
            // 
            this.TelefoneMBox.Location = new System.Drawing.Point(276, 113);
            this.TelefoneMBox.Mask = "(99) 00000-0000";
            this.TelefoneMBox.Name = "TelefoneMBox";
            this.TelefoneMBox.Size = new System.Drawing.Size(292, 20);
            this.TelefoneMBox.TabIndex = 2;
            // 
            // MateriaComboBox
            // 
            this.MateriaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MateriaComboBox.FormattingEnabled = true;
            this.MateriaComboBox.Items.AddRange(new object[] {
            "Português",
            "Matematica",
            "Historia",
            "Geografia",
            "Quimica",
            "Biologia",
            "FIsica",
            "Etica",
            "Filosofia",
            "Sociologia",
            "Inglês",
            "Educação Fisica",
            "Banco De Dados",
            "Programação Web",
            "Programação Mobile",
            "Desenvolvimento De Sistemas"});
            this.MateriaComboBox.Location = new System.Drawing.Point(276, 256);
            this.MateriaComboBox.Name = "MateriaComboBox";
            this.MateriaComboBox.Size = new System.Drawing.Size(292, 21);
            this.MateriaComboBox.TabIndex = 8;
            // 
            // RegisterTela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MateriaComboBox);
            this.Controls.Add(this.TelefoneMBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BotVoltarRegistro);
            this.Controls.Add(this.SenhaBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BotRegistro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NomeBox);
            this.Controls.Add(this.label1);
            this.Name = "RegisterTela";
            this.Text = "Register";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterTela_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NomeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BotRegistro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SenhaBox;
        private System.Windows.Forms.Button BotVoltarRegistro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox TelefoneMBox;
        private System.Windows.Forms.ComboBox MateriaComboBox;
    }
}