namespace АРМ_Кассира
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.Minimize = new System.Windows.Forms.Label();
            this.ExitButt = new System.Windows.Forms.Label();
            this.PassText = new System.Windows.Forms.TextBox();
            this.LoginText = new System.Windows.Forms.TextBox();
            this.SignInButt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Autorization = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.MainPanel.Controls.Add(this.Minimize);
            this.MainPanel.Controls.Add(this.ExitButt);
            this.MainPanel.Controls.Add(this.PassText);
            this.MainPanel.Controls.Add(this.LoginText);
            this.MainPanel.Controls.Add(this.SignInButt);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.Autorization);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(360, 360);
            this.MainPanel.TabIndex = 1;
            // 
            // Minimize
            // 
            this.Minimize.AutoSize = true;
            this.Minimize.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Minimize.ForeColor = System.Drawing.Color.White;
            this.Minimize.Location = new System.Drawing.Point(289, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(23, 31);
            this.Minimize.TabIndex = 7;
            this.Minimize.Text = "-";
            this.Minimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            this.Minimize.MouseEnter += new System.EventHandler(this.Minimize_MouseEnter);
            this.Minimize.MouseLeave += new System.EventHandler(this.Minimize_MouseLeave);
            // 
            // ExitButt
            // 
            this.ExitButt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButt.ForeColor = System.Drawing.Color.White;
            this.ExitButt.Location = new System.Drawing.Point(327, 0);
            this.ExitButt.Name = "ExitButt";
            this.ExitButt.Size = new System.Drawing.Size(25, 33);
            this.ExitButt.TabIndex = 6;
            this.ExitButt.Text = "X";
            this.ExitButt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExitButt.Click += new System.EventHandler(this.ExitButt_Click);
            this.ExitButt.MouseEnter += new System.EventHandler(this.ExitButt_MouseEnter);
            this.ExitButt.MouseLeave += new System.EventHandler(this.ExitButt_MouseLeave);
            // 
            // PassText
            // 
            this.PassText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassText.Location = new System.Drawing.Point(102, 198);
            this.PassText.Name = "PassText";
            this.PassText.Size = new System.Drawing.Size(150, 29);
            this.PassText.TabIndex = 5;
            this.PassText.UseSystemPasswordChar = true;
            // 
            // LoginText
            // 
            this.LoginText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginText.Location = new System.Drawing.Point(102, 142);
            this.LoginText.Multiline = true;
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(150, 25);
            this.LoginText.TabIndex = 4;
            // 
            // SignInButt
            // 
            this.SignInButt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.SignInButt.FlatAppearance.BorderSize = 0;
            this.SignInButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.SignInButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignInButt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SignInButt.Location = new System.Drawing.Point(139, 242);
            this.SignInButt.Name = "SignInButt";
            this.SignInButt.Size = new System.Drawing.Size(75, 23);
            this.SignInButt.TabIndex = 3;
            this.SignInButt.Text = "Войти";
            this.SignInButt.UseVisualStyleBackColor = false;
            this.SignInButt.Click += new System.EventHandler(this.SignInButt_Click);
            this.SignInButt.MouseEnter += new System.EventHandler(this.SignInButt_MouseEnter);
            this.SignInButt.MouseLeave += new System.EventHandler(this.SignInButt_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(149, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(156, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин";
            // 
            // Autorization
            // 
            this.Autorization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Autorization.Dock = System.Windows.Forms.DockStyle.Top;
            this.Autorization.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Autorization.ForeColor = System.Drawing.Color.White;
            this.Autorization.Location = new System.Drawing.Point(0, 0);
            this.Autorization.Name = "Autorization";
            this.Autorization.Size = new System.Drawing.Size(360, 67);
            this.Autorization.TabIndex = 0;
            this.Autorization.Text = "Авторизация";
            this.Autorization.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Autorization.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Autorization_MouseDown);
            this.Autorization.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Autorization_MouseMove);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(360, 360);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label Minimize;
        private System.Windows.Forms.Label ExitButt;
        private System.Windows.Forms.TextBox PassText;
        private System.Windows.Forms.TextBox LoginText;
        private System.Windows.Forms.Button SignInButt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Autorization;
    }
}