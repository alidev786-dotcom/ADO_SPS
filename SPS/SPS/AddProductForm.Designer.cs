namespace SPS
{
    partial class AddProductForm
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
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.idTF = new System.Windows.Forms.TextBox();
            this.nameTF = new System.Windows.Forms.TextBox();
            this.quantityTF = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.priceTF = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.categoryTF = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(74, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "quantity";
            // 
            // idTF
            // 
            this.idTF.Location = new System.Drawing.Point(131, 48);
            this.idTF.Name = "idTF";
            this.idTF.Size = new System.Drawing.Size(100, 20);
            this.idTF.TabIndex = 5;
            // 
            // nameTF
            // 
            this.nameTF.Location = new System.Drawing.Point(131, 91);
            this.nameTF.Name = "nameTF";
            this.nameTF.Size = new System.Drawing.Size(100, 20);
            this.nameTF.TabIndex = 6;
            // 
            // quantityTF
            // 
            this.quantityTF.Location = new System.Drawing.Point(131, 227);
            this.quantityTF.Name = "quantityTF";
            this.quantityTF.Size = new System.Drawing.Size(100, 20);
            this.quantityTF.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Add Product";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "price";
            // 
            // priceTF
            // 
            this.priceTF.Location = new System.Drawing.Point(131, 136);
            this.priceTF.Name = "priceTF";
            this.priceTF.Size = new System.Drawing.Size(100, 20);
            this.priceTF.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Add Product";
            // 
            // categoryTF
            // 
            this.categoryTF.Location = new System.Drawing.Point(131, 180);
            this.categoryTF.Name = "categoryTF";
            this.categoryTF.Size = new System.Drawing.Size(100, 20);
            this.categoryTF.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(145, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Go Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 372);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.categoryTF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.priceTF);
            this.Controls.Add(this.quantityTF);
            this.Controls.Add(this.nameTF);
            this.Controls.Add(this.idTF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProductForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idTF;
        private System.Windows.Forms.TextBox nameTF;
        private System.Windows.Forms.TextBox quantityTF;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox priceTF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox categoryTF;
        private System.Windows.Forms.Button button2;
    }
}