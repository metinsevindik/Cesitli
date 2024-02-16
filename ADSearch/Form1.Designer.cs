
namespace ADSearch
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
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SearchTxt = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.findinlisttxt = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.domaindebulunamayan = new System.Windows.Forms.TextBox();
            this.NotPermissionUserList = new System.Windows.Forms.TextBox();
            this.resultUserList = new System.Windows.Forms.TextBox();
            this.arananGrupTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.coklukisiTxt = new System.Windows.Forms.TextBox();
            this.domainTxt = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(192, 220);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 0;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SearchTxt
            // 
            this.SearchTxt.Location = new System.Drawing.Point(26, 60);
            this.SearchTxt.Multiline = true;
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(241, 138);
            this.SearchTxt.TabIndex = 1;
            this.SearchTxt.Text = "domain.user";
            this.SearchTxt.TextChanged += new System.EventHandler(this.SearchTxt_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(273, 60);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(755, 277);
            this.listBox1.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1044, 383);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.domainTxt);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.findinlisttxt);
            this.tabPage1.Controls.Add(this.SearchTxt);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.SearchBtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1036, 357);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gruplar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ara";
            // 
            // findinlisttxt
            // 
            this.findinlisttxt.Location = new System.Drawing.Point(303, 31);
            this.findinlisttxt.Name = "findinlisttxt";
            this.findinlisttxt.Size = new System.Drawing.Size(232, 20);
            this.findinlisttxt.TabIndex = 3;
            this.findinlisttxt.TextChanged += new System.EventHandler(this.findinlisttxt_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.domaindebulunamayan);
            this.tabPage2.Controls.Add(this.NotPermissionUserList);
            this.tabPage2.Controls.Add(this.resultUserList);
            this.tabPage2.Controls.Add(this.arananGrupTxt);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.coklukisiTxt);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1036, 357);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Yetki Kontrol";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Kontrol edilecek mail grubu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(414, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Yetkisi olan kullanıcılar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(622, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Yetkisi olmayan kullanıcılar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(835, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Domainde bulunamayan kullanıcılar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kullanıcı Adları (Aralarında , olmalıdır)";
            // 
            // domaindebulunamayan
            // 
            this.domaindebulunamayan.Location = new System.Drawing.Point(835, 88);
            this.domaindebulunamayan.Multiline = true;
            this.domaindebulunamayan.Name = "domaindebulunamayan";
            this.domaindebulunamayan.Size = new System.Drawing.Size(173, 237);
            this.domaindebulunamayan.TabIndex = 5;
            this.domaindebulunamayan.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NotPermissionUserList
            // 
            this.NotPermissionUserList.Location = new System.Drawing.Point(622, 88);
            this.NotPermissionUserList.Multiline = true;
            this.NotPermissionUserList.Name = "NotPermissionUserList";
            this.NotPermissionUserList.Size = new System.Drawing.Size(173, 237);
            this.NotPermissionUserList.TabIndex = 4;
            // 
            // resultUserList
            // 
            this.resultUserList.Location = new System.Drawing.Point(414, 88);
            this.resultUserList.Multiline = true;
            this.resultUserList.Name = "resultUserList";
            this.resultUserList.Size = new System.Drawing.Size(171, 237);
            this.resultUserList.TabIndex = 3;
            // 
            // arananGrupTxt
            // 
            this.arananGrupTxt.Location = new System.Drawing.Point(172, 31);
            this.arananGrupTxt.Name = "arananGrupTxt";
            this.arananGrupTxt.Size = new System.Drawing.Size(128, 20);
            this.arananGrupTxt.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // coklukisiTxt
            // 
            this.coklukisiTxt.Location = new System.Drawing.Point(35, 88);
            this.coklukisiTxt.Multiline = true;
            this.coklukisiTxt.Name = "coklukisiTxt";
            this.coklukisiTxt.Size = new System.Drawing.Size(356, 237);
            this.coklukisiTxt.TabIndex = 0;
            // 
            // domainTxt
            // 
            this.domainTxt.Location = new System.Drawing.Point(26, 26);
            this.domainTxt.Name = "domainTxt";
            this.domainTxt.Size = new System.Drawing.Size(221, 20);
            this.domainTxt.TabIndex = 5;
            this.domainTxt.Text = "LDAP://DC=domain,DC=gov,DC=tr";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 383);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox SearchTxt;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox findinlisttxt;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox arananGrupTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox coklukisiTxt;
        private System.Windows.Forms.TextBox resultUserList;
        private System.Windows.Forms.TextBox NotPermissionUserList;
        private System.Windows.Forms.TextBox domaindebulunamayan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox domainTxt;
    }
}