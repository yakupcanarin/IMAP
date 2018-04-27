namespace mail_IMAP
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkB_Show = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.gb_Login = new System.Windows.Forms.GroupBox();
            this.gb_Transactions = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_GetHeaders = new System.Windows.Forms.Button();
            this.txt_Dest_Email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_SearchMessageID = new System.Windows.Forms.Button();
            this.gb_Login.SuspendLayout();
            this.gb_Transactions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(157, 130);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(247, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect to Server";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mail address to connect :";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(157, 19);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(247, 20);
            this.txt_Email.TabIndex = 3;
            this.txt_Email.Text = "...@gmail.com";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(157, 55);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '•';
            this.txt_Password.Size = new System.Drawing.Size(247, 20);
            this.txt_Password.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password :";
            // 
            // checkB_Show
            // 
            this.checkB_Show.AutoSize = true;
            this.checkB_Show.Location = new System.Drawing.Point(157, 92);
            this.checkB_Show.Name = "checkB_Show";
            this.checkB_Show.Size = new System.Drawing.Size(102, 17);
            this.checkB_Show.TabIndex = 6;
            this.checkB_Show.Text = "Show Password";
            this.checkB_Show.UseVisualStyleBackColor = true;
            this.checkB_Show.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(478, 56);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(423, 446);
            this.listBox1.TabIndex = 7;
            // 
            // gb_Login
            // 
            this.gb_Login.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gb_Login.Controls.Add(this.txt_Email);
            this.gb_Login.Controls.Add(this.btnConnect);
            this.gb_Login.Controls.Add(this.checkB_Show);
            this.gb_Login.Controls.Add(this.label1);
            this.gb_Login.Controls.Add(this.txt_Password);
            this.gb_Login.Controls.Add(this.label2);
            this.gb_Login.Location = new System.Drawing.Point(12, 50);
            this.gb_Login.Name = "gb_Login";
            this.gb_Login.Size = new System.Drawing.Size(440, 178);
            this.gb_Login.TabIndex = 8;
            this.gb_Login.TabStop = false;
            this.gb_Login.Text = "Login";
            // 
            // gb_Transactions
            // 
            this.gb_Transactions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gb_Transactions.Controls.Add(this.label4);
            this.gb_Transactions.Controls.Add(this.btn_GetHeaders);
            this.gb_Transactions.Controls.Add(this.txt_Dest_Email);
            this.gb_Transactions.Controls.Add(this.label3);
            this.gb_Transactions.Controls.Add(this.btn_SearchMessageID);
            this.gb_Transactions.Location = new System.Drawing.Point(12, 50);
            this.gb_Transactions.Name = "gb_Transactions";
            this.gb_Transactions.Size = new System.Drawing.Size(440, 236);
            this.gb_Transactions.TabIndex = 9;
            this.gb_Transactions.TabStop = false;
            this.gb_Transactions.Text = "Transactions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Get Answered Mails :";
            // 
            // btn_GetHeaders
            // 
            this.btn_GetHeaders.Location = new System.Drawing.Point(150, 160);
            this.btn_GetHeaders.Name = "btn_GetHeaders";
            this.btn_GetHeaders.Size = new System.Drawing.Size(254, 23);
            this.btn_GetHeaders.TabIndex = 13;
            this.btn_GetHeaders.Text = "Get Answered Mails";
            this.btn_GetHeaders.UseVisualStyleBackColor = true;
            this.btn_GetHeaders.Click += new System.EventHandler(this.btn_GetHeaders_Click);
            // 
            // txt_Dest_Email
            // 
            this.txt_Dest_Email.Location = new System.Drawing.Point(150, 45);
            this.txt_Dest_Email.Name = "txt_Dest_Email";
            this.txt_Dest_Email.Size = new System.Drawing.Size(254, 20);
            this.txt_Dest_Email.TabIndex = 12;
            this.txt_Dest_Email.Text = "...@domain....";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mail Address :";
            // 
            // btn_SearchMessageID
            // 
            this.btn_SearchMessageID.Location = new System.Drawing.Point(150, 92);
            this.btn_SearchMessageID.Name = "btn_SearchMessageID";
            this.btn_SearchMessageID.Size = new System.Drawing.Size(254, 23);
            this.btn_SearchMessageID.TabIndex = 10;
            this.btn_SearchMessageID.Text = "Search for Mail ID\'s";
            this.btn_SearchMessageID.UseVisualStyleBackColor = true;
            this.btn_SearchMessageID.Click += new System.EventHandler(this.btn_SearchMessage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 547);
            this.Controls.Add(this.gb_Transactions);
            this.Controls.Add(this.gb_Login);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_Login.ResumeLayout(false);
            this.gb_Login.PerformLayout();
            this.gb_Transactions.ResumeLayout(false);
            this.gb_Transactions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkB_Show;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox gb_Login;
        private System.Windows.Forms.GroupBox gb_Transactions;
        private System.Windows.Forms.Button btn_SearchMessageID;
        private System.Windows.Forms.TextBox txt_Dest_Email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_GetHeaders;
    }
}

