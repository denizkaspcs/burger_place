
namespace BurgerPlace
{
    partial class SignupForm
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
            this.burger_logo = new System.Windows.Forms.PictureBox();
            this.exit_button = new System.Windows.Forms.Button();
            this.bg_panel = new System.Windows.Forms.Panel();
            this.email_label = new System.Windows.Forms.Label();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.surname_tb = new System.Windows.Forms.TextBox();
            this.email_tb = new System.Windows.Forms.TextBox();
            this.pwd_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.register_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.burger_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // burger_logo
            // 
            this.burger_logo.Image = global::BurgerPlace.Properties.Resources.hamburger_logo;
            this.burger_logo.Location = new System.Drawing.Point(175, 65);
            this.burger_logo.Name = "burger_logo";
            this.burger_logo.Size = new System.Drawing.Size(150, 100);
            this.burger_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.burger_logo.TabIndex = 11;
            this.burger_logo.TabStop = false;
            this.burger_logo.Click += new System.EventHandler(this.burger_logo_Click);
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.DarkRed;
            this.exit_button.FlatAppearance.BorderSize = 0;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exit_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.exit_button.Location = new System.Drawing.Point(425, 0);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(75, 40);
            this.exit_button.TabIndex = 12;
            this.exit_button.Text = "X";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click_1);
            // 
            // bg_panel
            // 
            this.bg_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.bg_panel.Location = new System.Drawing.Point(0, 65);
            this.bg_panel.Name = "bg_panel";
            this.bg_panel.Size = new System.Drawing.Size(500, 100);
            this.bg_panel.TabIndex = 18;
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.email_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(141)))), ((int)(((byte)(60)))));
            this.email_label.Location = new System.Drawing.Point(149, 179);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(202, 42);
            this.email_label.TabIndex = 19;
            this.email_label.Text = "Sign-up Form";
            this.email_label.Click += new System.EventHandler(this.email_label_Click);
            // 
            // name_tb
            // 
            this.name_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.name_tb.Location = new System.Drawing.Point(175, 245);
            this.name_tb.Name = "name_tb";
            this.name_tb.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.name_tb.Size = new System.Drawing.Size(250, 38);
            this.name_tb.TabIndex = 20;
            // 
            // surname_tb
            // 
            this.surname_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.surname_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.surname_tb.Location = new System.Drawing.Point(175, 305);
            this.surname_tb.Name = "surname_tb";
            this.surname_tb.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.surname_tb.Size = new System.Drawing.Size(250, 38);
            this.surname_tb.TabIndex = 21;
            // 
            // email_tb
            // 
            this.email_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.email_tb.Location = new System.Drawing.Point(175, 365);
            this.email_tb.Name = "email_tb";
            this.email_tb.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.email_tb.Size = new System.Drawing.Size(250, 38);
            this.email_tb.TabIndex = 22;
            // 
            // pwd_tb
            // 
            this.pwd_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pwd_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pwd_tb.Location = new System.Drawing.Point(175, 425);
            this.pwd_tb.Name = "pwd_tb";
            this.pwd_tb.PasswordChar = '*';
            this.pwd_tb.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.pwd_tb.Size = new System.Drawing.Size(250, 38);
            this.pwd_tb.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(141)))), ((int)(((byte)(60)))));
            this.label1.Location = new System.Drawing.Point(40, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(141)))), ((int)(((byte)(60)))));
            this.label2.Location = new System.Drawing.Point(40, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 29);
            this.label2.TabIndex = 25;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(141)))), ((int)(((byte)(60)))));
            this.label3.Location = new System.Drawing.Point(40, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 29);
            this.label3.TabIndex = 26;
            this.label3.Text = "Email";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(141)))), ((int)(((byte)(60)))));
            this.label4.Location = new System.Drawing.Point(40, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 29);
            this.label4.TabIndex = 27;
            this.label4.Text = "Password";
            // 
            // register_button
            // 
            this.register_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(141)))), ((int)(((byte)(60)))));
            this.register_button.FlatAppearance.BorderSize = 0;
            this.register_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register_button.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.register_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.register_button.Location = new System.Drawing.Point(0, 510);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(500, 89);
            this.register_button.TabIndex = 28;
            this.register_button.Text = "Register";
            this.register_button.UseVisualStyleBackColor = false;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(500, 700);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pwd_tb);
            this.Controls.Add(this.email_tb);
            this.Controls.Add(this.surname_tb);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.burger_logo);
            this.Controls.Add(this.bg_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.SignupForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SignupForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SignupForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SignupForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.burger_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox burger_logo;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Panel bg_panel;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.TextBox surname_tb;
        private System.Windows.Forms.TextBox email_tb;
        private System.Windows.Forms.TextBox pwd_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button register_button;
    }
}