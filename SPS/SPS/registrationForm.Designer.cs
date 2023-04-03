namespace SPS
{
    partial class registrationForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.idTF = new System.Windows.Forms.TextBox();
            this.passwordTF = new System.Windows.Forms.TextBox();
            this.emailTF = new System.Windows.Forms.TextBox();
            this.nameTF = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.confirmTF = new System.Windows.Forms.TextBox();
            this.isAdmin = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "password";
            // 
            // idTF
            // 
            this.idTF.Location = new System.Drawing.Point(165, 62);
            this.idTF.Name = "idTF";
            this.idTF.Size = new System.Drawing.Size(100, 20);
            this.idTF.TabIndex = 4;
            // 
            // passwordTF
            // 
            this.passwordTF.Location = new System.Drawing.Point(165, 192);
            this.passwordTF.Name = "passwordTF";
            this.passwordTF.Size = new System.Drawing.Size(100, 20);
            this.passwordTF.TabIndex = 5;
            // 
            // emailTF
            // 
            this.emailTF.Location = new System.Drawing.Point(165, 145);
            this.emailTF.Name = "emailTF";
            this.emailTF.Size = new System.Drawing.Size(100, 20);
            this.emailTF.TabIndex = 6;
            // 
            // nameTF
            // 
            this.nameTF.Location = new System.Drawing.Point(165, 103);
            this.nameTF.Name = "nameTF";
            this.nameTF.Size = new System.Drawing.Size(100, 20);
            this.nameTF.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "confirm password";
            // 
            // confirmTF
            // 
            this.confirmTF.Location = new System.Drawing.Point(165, 235);
            this.confirmTF.Name = "confirmTF";
            this.confirmTF.Size = new System.Drawing.Size(100, 20);
            this.confirmTF.TabIndex = 9;
            // 
            // isAdmin
            // 
            this.isAdmin.AutoSize = true;
            this.isAdmin.Location = new System.Drawing.Point(182, 291);
            this.isAdmin.Name = "isAdmin";
            this.isAdmin.Size = new System.Drawing.Size(61, 17);
            this.isAdmin.TabIndex = 10;
            this.isAdmin.TabStop = true;
            this.isAdmin.Text = "isAdmin";
            this.isAdmin.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // registrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 451);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.isAdmin);
            this.Controls.Add(this.confirmTF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nameTF);
            this.Controls.Add(this.emailTF);
            this.Controls.Add(this.passwordTF);
            this.Controls.Add(this.idTF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "registrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "registrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idTF;
        private System.Windows.Forms.TextBox passwordTF;
        private System.Windows.Forms.TextBox emailTF;
        private System.Windows.Forms.TextBox nameTF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox confirmTF;
        private System.Windows.Forms.RadioButton isAdmin;
        private System.Windows.Forms.Button button1;
    }
}