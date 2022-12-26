namespace АРМ_Кассира
{
    partial class PaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentForm));
            this.Minimize = new System.Windows.Forms.Label();
            this.ExitButt = new System.Windows.Forms.Label();
            this.Autorization = new System.Windows.Forms.Label();
            this.CashText = new System.Windows.Forms.TextBox();
            this.SumText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ChangeText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CardButt = new System.Windows.Forms.Button();
            this.CashButt = new System.Windows.Forms.Button();
            this.CountChange = new System.Windows.Forms.Button();
            this.EndOp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Minimize
            // 
            this.Minimize.AutoSize = true;
            this.Minimize.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Minimize.ForeColor = System.Drawing.Color.White;
            this.Minimize.Location = new System.Drawing.Point(274, 2);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(23, 31);
            this.Minimize.TabIndex = 10;
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
            this.ExitButt.Location = new System.Drawing.Point(313, 0);
            this.ExitButt.Name = "ExitButt";
            this.ExitButt.Size = new System.Drawing.Size(25, 33);
            this.ExitButt.TabIndex = 9;
            this.ExitButt.Text = "X";
            this.ExitButt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExitButt.Click += new System.EventHandler(this.ExitButt_Click);
            this.ExitButt.MouseEnter += new System.EventHandler(this.ExitButt_MouseEnter);
            this.ExitButt.MouseLeave += new System.EventHandler(this.ExitButt_MouseLeave);
            // 
            // Autorization
            // 
            this.Autorization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Autorization.Dock = System.Windows.Forms.DockStyle.Top;
            this.Autorization.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Autorization.ForeColor = System.Drawing.Color.White;
            this.Autorization.Location = new System.Drawing.Point(0, 0);
            this.Autorization.Name = "Autorization";
            this.Autorization.Size = new System.Drawing.Size(338, 67);
            this.Autorization.TabIndex = 8;
            this.Autorization.Text = "Оплата";
            this.Autorization.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Autorization.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Autorization_MouseDown);
            this.Autorization.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Autorization_MouseMove);
            // 
            // CashText
            // 
            this.CashText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CashText.Location = new System.Drawing.Point(89, 146);
            this.CashText.Multiline = true;
            this.CashText.Name = "CashText";
            this.CashText.Size = new System.Drawing.Size(237, 25);
            this.CashText.TabIndex = 16;
            this.CashText.Visible = false;
            // 
            // SumText
            // 
            this.SumText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumText.Location = new System.Drawing.Point(89, 85);
            this.SumText.Multiline = true;
            this.SumText.Name = "SumText";
            this.SumText.ReadOnly = true;
            this.SumText.Size = new System.Drawing.Size(237, 25);
            this.SumText.TabIndex = 15;
            this.SumText.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(3, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Внесли";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Стоимость";
            this.label1.Visible = false;
            // 
            // ChangeText
            // 
            this.ChangeText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeText.Location = new System.Drawing.Point(89, 196);
            this.ChangeText.Multiline = true;
            this.ChangeText.Name = "ChangeText";
            this.ChangeText.ReadOnly = true;
            this.ChangeText.Size = new System.Drawing.Size(237, 25);
            this.ChangeText.TabIndex = 18;
            this.ChangeText.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(3, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Сдача";
            this.label3.Visible = false;
            // 
            // CardButt
            // 
            this.CardButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardButt.Location = new System.Drawing.Point(77, 181);
            this.CardButt.Name = "CardButt";
            this.CardButt.Size = new System.Drawing.Size(184, 58);
            this.CardButt.TabIndex = 21;
            this.CardButt.Text = "Картой";
            this.CardButt.UseVisualStyleBackColor = true;
            this.CardButt.Click += new System.EventHandler(this.CardButt_Click);
            // 
            // CashButt
            // 
            this.CashButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CashButt.Location = new System.Drawing.Point(77, 92);
            this.CashButt.Name = "CashButt";
            this.CashButt.Size = new System.Drawing.Size(184, 58);
            this.CashButt.TabIndex = 20;
            this.CashButt.Text = "Наличными";
            this.CashButt.UseVisualStyleBackColor = true;
            this.CashButt.Click += new System.EventHandler(this.CashButt_Click);
            // 
            // CountChange
            // 
            this.CountChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountChange.Location = new System.Drawing.Point(77, 261);
            this.CountChange.Name = "CountChange";
            this.CountChange.Size = new System.Drawing.Size(184, 58);
            this.CountChange.TabIndex = 22;
            this.CountChange.Text = "Подсчитать";
            this.CountChange.UseVisualStyleBackColor = true;
            this.CountChange.Visible = false;
            this.CountChange.Click += new System.EventHandler(this.CountChange_Click);
            // 
            // EndOp
            // 
            this.EndOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndOp.Location = new System.Drawing.Point(77, 261);
            this.EndOp.Name = "EndOp";
            this.EndOp.Size = new System.Drawing.Size(184, 58);
            this.EndOp.TabIndex = 23;
            this.EndOp.Text = "Завершить операцию";
            this.EndOp.UseVisualStyleBackColor = true;
            this.EndOp.Visible = false;
            this.EndOp.Click += new System.EventHandler(this.EndOp_Click);
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(338, 331);
            this.Controls.Add(this.EndOp);
            this.Controls.Add(this.CountChange);
            this.Controls.Add(this.CardButt);
            this.Controls.Add(this.CashButt);
            this.Controls.Add(this.ChangeText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CashText);
            this.Controls.Add(this.SumText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.ExitButt);
            this.Controls.Add(this.Autorization);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Minimize;
        private System.Windows.Forms.Label ExitButt;
        private System.Windows.Forms.Label Autorization;
        private System.Windows.Forms.TextBox CashText;
        private System.Windows.Forms.TextBox SumText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ChangeText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CardButt;
        private System.Windows.Forms.Button CashButt;
        private System.Windows.Forms.Button CountChange;
        private System.Windows.Forms.Button EndOp;
    }
}