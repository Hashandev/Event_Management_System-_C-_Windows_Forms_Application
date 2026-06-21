namespace WinFormsApp1
{
    partial class loging
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            username = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            password = new Label();
            logingbutton = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            username.ForeColor = SystemColors.ControlLightLight;
            username.Location = new Point(494, 125);
            username.Name = "username";
            username.Size = new Size(82, 21);
            username.TabIndex = 0;
            username.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(494, 158);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(263, 29);
            txtUsername.TabIndex = 1;
            txtUsername.Font = new Font("Segoe UI", 11F);
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(494, 239);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(263, 29);
            txtPassword.TabIndex = 3;
            txtPassword.Font = new Font("Segoe UI", 11F);
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            password.ForeColor = SystemColors.ControlLightLight;
            password.Location = new Point(494, 206);
            password.Name = "password";
            password.Size = new Size(76, 21);
            password.TabIndex = 2;
            password.Text = "Password";
            // 
            // logingbutton
            // 
            logingbutton.Location = new Point(494, 300);
            logingbutton.Name = "logingbutton";
            logingbutton.Size = new Size(263, 45);
            logingbutton.TabIndex = 4;
            logingbutton.Text = "LOGIN";
            logingbutton.UseVisualStyleBackColor = true;
            logingbutton.Click += logingbutton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(30, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 400);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(530, 40);
            label1.Name = "label1";
            label1.Size = new Size(190, 32);
            label1.TabIndex = 6;
            label1.Text = "Welcome Back!";
            // 
            // loging
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(800, 480);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(logingbutton);
            Controls.Add(txtPassword);
            Controls.Add(password);
            Controls.Add(txtUsername);
            Controls.Add(username);
            Name = "loging";
            Text = "Login - Event Decoration";
            Load += loging_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label username;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label password;
        private Button logingbutton;
        private PictureBox pictureBox1;
        private Label label1;
    }
}