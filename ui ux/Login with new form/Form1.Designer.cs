namespace Login_with_new_form
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
            this.Loginpanel = new System.Windows.Forms.Panel();
            this.Registerpanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.usertext = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.passboxrpt = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.Loginpanel.SuspendLayout();
            this.Registerpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Loginpanel
            // 
            this.Loginpanel.Controls.Add(this.button2);
            this.Loginpanel.Controls.Add(this.button1);
            this.Loginpanel.Controls.Add(this.textBox2);
            this.Loginpanel.Controls.Add(this.userBox);
            this.Loginpanel.Controls.Add(this.label2);
            this.Loginpanel.Controls.Add(this.label1);
            this.Loginpanel.Location = new System.Drawing.Point(12, 30);
            this.Loginpanel.Name = "Loginpanel";
            this.Loginpanel.Size = new System.Drawing.Size(246, 224);
            this.Loginpanel.TabIndex = 0;
            // 
            // Registerpanel
            // 
            this.Registerpanel.Controls.Add(this.button4);
            this.Registerpanel.Controls.Add(this.passboxrpt);
            this.Registerpanel.Controls.Add(this.passBox);
            this.Registerpanel.Controls.Add(this.usertext);
            this.Registerpanel.Controls.Add(this.label5);
            this.Registerpanel.Controls.Add(this.label4);
            this.Registerpanel.Controls.Add(this.label3);
            this.Registerpanel.Location = new System.Drawing.Point(280, 30);
            this.Registerpanel.Name = "Registerpanel";
            this.Registerpanel.Size = new System.Drawing.Size(246, 224);
            this.Registerpanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(111, 45);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(100, 20);
            this.userBox.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(111, 95);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(21, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(136, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Register";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Repeat password:";
            // 
            // textBox3
            // 
            this.usertext.Location = new System.Drawing.Point(117, 38);
            this.usertext.Name = "textBox3";
            this.usertext.Size = new System.Drawing.Size(100, 20);
            this.usertext.TabIndex = 4;
            // 
            // textBox4
            // 
            this.passBox.Location = new System.Drawing.Point(117, 81);
            this.passBox.Name = "textBox4";
            this.passBox.PasswordChar = '*';
            this.passBox.Size = new System.Drawing.Size(100, 20);
            this.passBox.TabIndex = 5;
            // 
            // textBox5
            // 
            this.passboxrpt.Location = new System.Drawing.Point(117, 121);
            this.passboxrpt.Name = "textBox5";
            this.passboxrpt.PasswordChar = '*';
            this.passboxrpt.Size = new System.Drawing.Size(100, 20);
            this.passboxrpt.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(76, 158);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Create";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 298);
            this.Controls.Add(this.Registerpanel);
            this.Controls.Add(this.Loginpanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Loginpanel.ResumeLayout(false);
            this.Loginpanel.PerformLayout();
            this.Registerpanel.ResumeLayout(false);
            this.Registerpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Loginpanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Registerpanel;
        private System.Windows.Forms.TextBox passboxrpt;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.TextBox usertext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
    }
}

