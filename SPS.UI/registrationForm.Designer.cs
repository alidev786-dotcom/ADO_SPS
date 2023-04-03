namespace SPS.UI
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
            this.label5 = new System.Windows.Forms.Label();
            this.nameTF = new System.Windows.Forms.TextBox();
            this.emailTF = new System.Windows.Forms.TextBox();
            this.confirmPassTF = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.isAdmin = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.passwordTF = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(121, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register Yourself!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "email";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "password";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "confirm password";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // nameTF
            // 
            this.nameTF.Location = new System.Drawing.Point(182, 104);
            this.nameTF.Name = "nameTF";
            this.nameTF.Size = new System.Drawing.Size(126, 20);
            this.nameTF.TabIndex = 5;
            this.nameTF.TextChanged += new System.EventHandler(this.nameTF_TextChanged);
            // 
            // emailTF
            // 
            this.emailTF.Location = new System.Drawing.Point(182, 146);
            this.emailTF.Name = "emailTF";
            this.emailTF.Size = new System.Drawing.Size(126, 20);
            this.emailTF.TabIndex = 6;
            this.emailTF.TextChanged += new System.EventHandler(this.emailTF_TextChanged);
            // 
            // confirmPassTF
            // 
            this.confirmPassTF.Location = new System.Drawing.Point(182, 233);
            this.confirmPassTF.Name = "confirmPassTF";
            this.confirmPassTF.Size = new System.Drawing.Size(126, 20);
            this.confirmPassTF.TabIndex = 8;
            this.confirmPassTF.UseSystemPasswordChar = true;
            this.confirmPassTF.TextChanged += new System.EventHandler(this.confirmPassTF_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // isAdmin
            // 
            this.isAdmin.AutoSize = true;
            this.isAdmin.Location = new System.Drawing.Point(213, 274);
            this.isAdmin.Name = "isAdmin";
            this.isAdmin.Size = new System.Drawing.Size(54, 17);
            this.isAdmin.TabIndex = 10;
            this.isAdmin.TabStop = true;
            this.isAdmin.Text = "Admin";
            this.isAdmin.UseVisualStyleBackColor = true;
            this.isAdmin.CheckedChanged += new System.EventHandler(this.isAdmin_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(202, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // passwordTF
            // 
            this.passwordTF.Location = new System.Drawing.Point(182, 190);
            this.passwordTF.Name = "passwordTF";
            this.passwordTF.Size = new System.Drawing.Size(126, 20);
            this.passwordTF.TabIndex = 12;
            this.passwordTF.UseSystemPasswordChar = true;
            this.passwordTF.TextChanged += new System.EventHandler(this.passwordTF_TextChanged);
            // 
            // registrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 441);
            this.Controls.Add(this.passwordTF);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.isAdmin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.confirmPassTF);
            this.Controls.Add(this.emailTF);
            this.Controls.Add(this.nameTF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "registrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameTF;
        private System.Windows.Forms.TextBox emailTF;
        private System.Windows.Forms.TextBox confirmPassTF;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton isAdmin;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox passwordTF;
    }
}