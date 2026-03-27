
namespace project_mencao
{
    partial class LoginTela
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
            this.label2 = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.SenhaBox = new System.Windows.Forms.TextBox();
            this.LoginBot = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.VoltarAoRegistroBot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(214, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(214, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(281, 121);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(275, 20);
            this.EmailBox.TabIndex = 3;
            // 
            // SenhaBox
            // 
            this.SenhaBox.Location = new System.Drawing.Point(281, 192);
            this.SenhaBox.Name = "SenhaBox";
            this.SenhaBox.PasswordChar = '*';
            this.SenhaBox.Size = new System.Drawing.Size(275, 20);
            this.SenhaBox.TabIndex = 4;
            // 
            // LoginBot
            // 
            this.LoginBot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.LoginBot.Location = new System.Drawing.Point(218, 249);
            this.LoginBot.Name = "LoginBot";
            this.LoginBot.Size = new System.Drawing.Size(338, 51);
            this.LoginBot.TabIndex = 5;
            this.LoginBot.Text = "Fazer Login";
            this.LoginBot.UseVisualStyleBackColor = true;
            this.LoginBot.Click += new System.EventHandler(this.LoginBot_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.label3.Location = new System.Drawing.Point(355, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 38);
            this.label3.TabIndex = 6;
            this.label3.Text = "Login";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // VoltarAoRegistroBot
            // 
            this.VoltarAoRegistroBot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.VoltarAoRegistroBot.Location = new System.Drawing.Point(218, 306);
            this.VoltarAoRegistroBot.Name = "VoltarAoRegistroBot";
            this.VoltarAoRegistroBot.Size = new System.Drawing.Size(338, 51);
            this.VoltarAoRegistroBot.TabIndex = 7;
            this.VoltarAoRegistroBot.Text = "Ir Para o Registro";
            this.VoltarAoRegistroBot.UseVisualStyleBackColor = true;
            this.VoltarAoRegistroBot.Click += new System.EventHandler(this.VoltarAoRegistroBot_Click);
            // 
            // LoginTela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VoltarAoRegistroBot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LoginBot);
            this.Controls.Add(this.SenhaBox);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginTela";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginTela_FormClosing);
            this.Load += new System.EventHandler(this.LoginTela_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox SenhaBox;
        private System.Windows.Forms.Button LoginBot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button VoltarAoRegistroBot;
    }
}

