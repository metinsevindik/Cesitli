namespace mailtest
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.KonuTxt = new System.Windows.Forms.TextBox();
            this.IcerikTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AliciTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gonderenTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.smtptxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.portTxt = new System.Windows.Forms.TextBox();
            this.sslCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Gönder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KonuTxt
            // 
            this.KonuTxt.Location = new System.Drawing.Point(94, 131);
            this.KonuTxt.Name = "KonuTxt";
            this.KonuTxt.Size = new System.Drawing.Size(201, 20);
            this.KonuTxt.TabIndex = 4;
            // 
            // IcerikTxt
            // 
            this.IcerikTxt.Location = new System.Drawing.Point(94, 157);
            this.IcerikTxt.Multiline = true;
            this.IcerikTxt.Name = "IcerikTxt";
            this.IcerikTxt.Size = new System.Drawing.Size(201, 138);
            this.IcerikTxt.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Koknu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Alıcı";
            // 
            // AliciTxt
            // 
            this.AliciTxt.Location = new System.Drawing.Point(94, 105);
            this.AliciTxt.Name = "AliciTxt";
            this.AliciTxt.Size = new System.Drawing.Size(201, 20);
            this.AliciTxt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Gönderen";
            // 
            // gonderenTxt
            // 
            this.gonderenTxt.Location = new System.Drawing.Point(94, 52);
            this.gonderenTxt.Name = "gonderenTxt";
            this.gonderenTxt.Size = new System.Drawing.Size(201, 20);
            this.gonderenTxt.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "İçeirik";
            // 
            // passtxt
            // 
            this.passtxt.Location = new System.Drawing.Point(94, 78);
            this.passtxt.Name = "passtxt";
            this.passtxt.PasswordChar = '*';
            this.passtxt.Size = new System.Drawing.Size(201, 20);
            this.passtxt.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gönderen Pass";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "SMTP Adress";
            // 
            // smtptxt
            // 
            this.smtptxt.Location = new System.Drawing.Point(94, 344);
            this.smtptxt.Name = "smtptxt";
            this.smtptxt.Size = new System.Drawing.Size(139, 20);
            this.smtptxt.TabIndex = 6;
            this.smtptxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Port";
            // 
            // portTxt
            // 
            this.portTxt.Location = new System.Drawing.Point(94, 370);
            this.portTxt.Name = "portTxt";
            this.portTxt.Size = new System.Drawing.Size(94, 20);
            this.portTxt.TabIndex = 7;
            // 
            // sslCheckbox
            // 
            this.sslCheckbox.AutoSize = true;
            this.sslCheckbox.Checked = true;
            this.sslCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sslCheckbox.Location = new System.Drawing.Point(94, 397);
            this.sslCheckbox.Name = "sslCheckbox";
            this.sslCheckbox.Size = new System.Drawing.Size(46, 17);
            this.sslCheckbox.TabIndex = 8;
            this.sslCheckbox.Text = "SSL";
            this.sslCheckbox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 429);
            this.Controls.Add(this.sslCheckbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.portTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.smtptxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gonderenTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AliciTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IcerikTxt);
            this.Controls.Add(this.KonuTxt);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox KonuTxt;
        private System.Windows.Forms.TextBox IcerikTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AliciTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox gonderenTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox smtptxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox portTxt;
        private System.Windows.Forms.CheckBox sslCheckbox;
    }
}

