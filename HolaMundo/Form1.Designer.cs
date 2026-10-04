namespace HolaMundo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            btnValidate = new Button();
            label_title = new Label();
            label_password = new Label();
            label_confirm_password = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 20F);
            txtPassword.Location = new Point(82, 73);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(335, 52);
            txtPassword.TabIndex = 0;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += textBox1_TextChanged;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Segoe UI", 20F);
            txtConfirmPassword.Location = new Point(82, 217);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(335, 52);
            txtConfirmPassword.TabIndex = 1;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // btnValidate
            // 
            btnValidate.BackColor = Color.OrangeRed;
            btnValidate.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnValidate.ForeColor = Color.Yellow;
            btnValidate.Location = new Point(151, 297);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(208, 50);
            btnValidate.TabIndex = 2;
            btnValidate.Text = "Validate";
            btnValidate.UseVisualStyleBackColor = false;
            btnValidate.Click += button1_Click;
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Font = new Font("Segoe UI", 25.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label_title.ForeColor = Color.Black;
            label_title.Location = new Point(188, 33);
            label_title.Name = "label_title";
            label_title.Size = new Size(543, 57);
            label_title.TabIndex = 3;
            label_title.Text = "Password Validation Form";
            label_title.Click += label1_Click;
            // 
            // label_password
            // 
            label_password.AutoSize = true;
            label_password.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_password.ForeColor = Color.Black;
            label_password.Location = new Point(195, 20);
            label_password.Name = "label_password";
            label_password.Size = new Size(114, 31);
            label_password.TabIndex = 4;
            label_password.Text = "Password";
            // 
            // label_confirm_password
            // 
            label_confirm_password.AutoSize = true;
            label_confirm_password.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_confirm_password.ForeColor = Color.Black;
            label_confirm_password.Location = new Point(151, 157);
            label_confirm_password.Name = "label_confirm_password";
            label_confirm_password.Size = new Size(208, 31);
            label_confirm_password.TabIndex = 5;
            label_confirm_password.Text = "Confirm Password";
            label_confirm_password.Click += label_confirm_password_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Turquoise;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label_password);
            panel1.Controls.Add(label_confirm_password);
            panel1.Controls.Add(txtConfirmPassword);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(btnValidate);
            panel1.Location = new Point(205, 123);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20);
            panel1.Size = new Size(505, 372);
            panel1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(915, 543);
            Controls.Add(label_title);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private Button btnValidate;
        private Label label_title;
        private Label label_password;
        private Label label_confirm_password;
        private Panel panel1;
    }
}
