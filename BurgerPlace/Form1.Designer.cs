
namespace BurgerPlace
{
    partial class LoginForm
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.login_button = new System.Windows.Forms.Button();
            this.signup_button = new System.Windows.Forms.Button();
            this.forgot_button = new System.Windows.Forms.Button();
            this.email_tb = new System.Windows.Forms.TextBox();
            this.pwd_tb = new System.Windows.Forms.TextBox();
            this.email_label = new System.Windows.Forms.Label();
            this.pwd_label = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.burger_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.burger_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(141)))), ((int)(((byte)(60)))));
            this.login_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.login_button.FlatAppearance.BorderSize = 0;
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(162)));
            this.login_button.Location = new System.Drawing.Point(450, 506);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(450, 38);
            this.login_button.TabIndex = 1;
            this.login_button.Text = "Log-in";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // signup_button
            // 
            this.signup_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(141)))), ((int)(((byte)(60)))));
            this.signup_button.FlatAppearance.BorderSize = 0;
            this.signup_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup_button.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(162)));
            this.signup_button.Location = new System.Drawing.Point(450, 562);
            this.signup_button.Name = "signup_button";
            this.signup_button.Size = new System.Drawing.Size(200, 35);
            this.signup_button.TabIndex = 2;
            this.signup_button.Text = "Sign-up";
            this.signup_button.UseVisualStyleBackColor = false;
            this.signup_button.Click += new System.EventHandler(this.signup_button_Click);
            // 
            // forgot_button
            // 
            this.forgot_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(141)))), ((int)(((byte)(60)))));
            this.forgot_button.FlatAppearance.BorderSize = 0;
            this.forgot_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forgot_button.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(162)));
            this.forgot_button.Location = new System.Drawing.Point(700, 562);
            this.forgot_button.Name = "forgot_button";
            this.forgot_button.Size = new System.Drawing.Size(200, 35);
            this.forgot_button.TabIndex = 3;
            this.forgot_button.Text = "Forgot my password";
            this.forgot_button.UseVisualStyleBackColor = false;
            // 
            // email_tb
            // 
            this.email_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.email_tb.Location = new System.Drawing.Point(450, 274);
            this.email_tb.Name = "email_tb";
            this.email_tb.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.email_tb.Size = new System.Drawing.Size(450, 38);
            this.email_tb.TabIndex = 4;
            this.email_tb.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // pwd_tb
            // 
            this.pwd_tb.AcceptsReturn = true;
            this.pwd_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pwd_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pwd_tb.Location = new System.Drawing.Point(450, 378);
            this.pwd_tb.Name = "pwd_tb";
            this.pwd_tb.PasswordChar = '*';
            this.pwd_tb.Size = new System.Drawing.Size(450, 38);
            this.pwd_tb.TabIndex = 5;
            this.pwd_tb.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.pwd_tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pwd_tb_KeyDown);
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.email_label.ForeColor = System.Drawing.Color.DarkRed;
            this.email_label.Location = new System.Drawing.Point(562, 229);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(223, 42);
            this.email_label.TabIndex = 6;
            this.email_label.Text = "E-mail address";
            this.email_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // pwd_label
            // 
            this.pwd_label.AutoSize = true;
            this.pwd_label.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pwd_label.ForeColor = System.Drawing.Color.DarkRed;
            this.pwd_label.Location = new System.Drawing.Point(598, 333);
            this.pwd_label.Name = "pwd_label";
            this.pwd_label.Size = new System.Drawing.Size(153, 42);
            this.pwd_label.TabIndex = 7;
            this.pwd_label.Text = "Password";
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.exit_button.FlatAppearance.BorderSize = 0;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exit_button.ForeColor = System.Drawing.Color.DarkRed;
            this.exit_button.Location = new System.Drawing.Point(1298, 1);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(75, 40);
            this.exit_button.TabIndex = 8;
            this.exit_button.Text = "X";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // burger_logo
            // 
            this.burger_logo.Image = global::BurgerPlace.Properties.Resources.hamburger_logo;
            this.burger_logo.Location = new System.Drawing.Point(600, 65);
            this.burger_logo.Name = "burger_logo";
            this.burger_logo.Size = new System.Drawing.Size(150, 100);
            this.burger_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.burger_logo.TabIndex = 0;
            this.burger_logo.TabStop = false;
            this.burger_logo.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1372, 700);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.pwd_label);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.pwd_tb);
            this.Controls.Add(this.email_tb);
            this.Controls.Add(this.forgot_button);
            this.Controls.Add(this.signup_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.burger_logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.burger_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox burger_logo;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label pwd_label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.TextBox pwd_tb;
        private System.Windows.Forms.TextBox email_tb;
        private System.Windows.Forms.Button forgot_button;
        private System.Windows.Forms.Button signup_button;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button exit_button;
    }
}


