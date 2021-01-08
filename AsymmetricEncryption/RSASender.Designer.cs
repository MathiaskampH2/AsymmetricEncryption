
namespace AsymmetricEncryption
{
    partial class RSASender
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
            this.label3 = new System.Windows.Forms.Label();
            this.ExponentTextBox = new System.Windows.Forms.TextBox();
            this.ModulusTextBox = new System.Windows.Forms.TextBox();
            this.PlainedTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.CipherTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Public Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Exponent:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "modulus:";
            // 
            // ExponentTextBox
            // 
            this.ExponentTextBox.Location = new System.Drawing.Point(97, 70);
            this.ExponentTextBox.Name = "ExponentTextBox";
            this.ExponentTextBox.Size = new System.Drawing.Size(227, 20);
            this.ExponentTextBox.TabIndex = 3;
            // 
            // ModulusTextBox
            // 
            this.ModulusTextBox.Location = new System.Drawing.Point(97, 103);
            this.ModulusTextBox.Name = "ModulusTextBox";
            this.ModulusTextBox.Size = new System.Drawing.Size(227, 20);
            this.ModulusTextBox.TabIndex = 4;
            // 
            // PlainedTextBox
            // 
            this.PlainedTextBox.Location = new System.Drawing.Point(97, 139);
            this.PlainedTextBox.Name = "PlainedTextBox";
            this.PlainedTextBox.Size = new System.Drawing.Size(227, 20);
            this.PlainedTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Plained text:";
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(97, 165);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(75, 23);
            this.EncryptButton.TabIndex = 7;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "CipherBytes:";
            // 
            // CipherTextBox
            // 
            this.CipherTextBox.Location = new System.Drawing.Point(97, 194);
            this.CipherTextBox.Name = "CipherTextBox";
            this.CipherTextBox.Size = new System.Drawing.Size(227, 20);
            this.CipherTextBox.TabIndex = 9;
            // 
            // RSASender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 256);
            this.Controls.Add(this.CipherTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PlainedTextBox);
            this.Controls.Add(this.ModulusTextBox);
            this.Controls.Add(this.ExponentTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RSASender";
            this.Text = "RSASender";
            this.Load += new System.EventHandler(this.RSASender_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ExponentTextBox;
        private System.Windows.Forms.TextBox ModulusTextBox;
        private System.Windows.Forms.TextBox PlainedTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CipherTextBox;
    }
}