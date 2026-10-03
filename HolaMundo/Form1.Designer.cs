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
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(485, 171);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(215, 27);
            txtPassword.TabIndex = 0;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += textBox1_TextChanged;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(485, 266);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(215, 27);
            txtConfirmPassword.TabIndex = 1;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // btnValidate
            // 
            btnValidate.Font = new Font("Segoe UI", 15F);
            btnValidate.Location = new Point(306, 362);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(186, 69);
            btnValidate.TabIndex = 2;
            btnValidate.Text = "Validate";
            btnValidate.UseVisualStyleBackColor = true;
            btnValidate.Click += button1_Click;
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Font = new Font("Segoe UI", 25F);
            label_title.Location = new Point(223, 41);
            label_title.Name = "label_title";
            label_title.Size = new Size(395, 57);
            label_title.TabIndex = 3;
            label_title.Text = "Password Validation";
            label_title.Click += label1_Click;
            // 
            // label_password
            // 
            label_password.AutoSize = true;
            label_password.Font = new Font("Segoe UI", 13F);
            label_password.Location = new Point(329, 166);
            label_password.Name = "label_password";
            label_password.Size = new Size(108, 30);
            label_password.TabIndex = 4;
            label_password.Text = "Password:";
            // 
            // label_confirm_password
            // 
            label_confirm_password.AutoSize = true;
            label_confirm_password.Font = new Font("Segoe UI", 13F);
            label_confirm_password.Location = new Point(262, 261);
            label_confirm_password.Name = "label_confirm_password";
            label_confirm_password.Size = new Size(192, 30);
            label_confirm_password.TabIndex = 5;
            label_confirm_password.Text = "Confirm Password:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 505);
            Controls.Add(label_confirm_password);
            Controls.Add(label_password);
            Controls.Add(label_title);
            Controls.Add(btnValidate);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Name = "Form1";
            Text = "Form1";
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
    }
}
