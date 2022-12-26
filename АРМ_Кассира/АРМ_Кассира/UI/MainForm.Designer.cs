namespace АРМ_Кассира
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.Pay = new System.Windows.Forms.Button();
            this.Del = new System.Windows.Forms.Button();
            this.ClearCheck = new System.Windows.Forms.Button();
            this.CheckBox = new System.Windows.Forms.CheckBox();
            this.Weight = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Autorization = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ExitBut = new System.Windows.Forms.Label();
            this.MinBut = new System.Windows.Forms.Label();
            this.Prod = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.Prod);
            this.panel2.Controls.Add(this.Weight);
            this.panel2.Controls.Add(this.CheckBox);
            this.panel2.Controls.Add(this.ClearCheck);
            this.panel2.Controls.Add(this.Del);
            this.panel2.Controls.Add(this.Pay);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 358);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 92);
            this.panel2.TabIndex = 17;
            // 
            // Pay
            // 
            this.Pay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pay.Location = new System.Drawing.Point(516, 15);
            this.Pay.Name = "Pay";
            this.Pay.Size = new System.Drawing.Size(88, 34);
            this.Pay.TabIndex = 12;
            this.Pay.Text = "Оплата";
            this.Pay.UseVisualStyleBackColor = true;
            this.Pay.Click += new System.EventHandler(this.Pay_Click);
            // 
            // Del
            // 
            this.Del.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Del.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Del.Location = new System.Drawing.Point(257, 15);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(94, 34);
            this.Del.TabIndex = 10;
            this.Del.Text = "Убрать";
            this.Del.UseVisualStyleBackColor = true;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // ClearCheck
            // 
            this.ClearCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClearCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearCheck.Location = new System.Drawing.Point(372, 15);
            this.ClearCheck.Name = "ClearCheck";
            this.ClearCheck.Size = new System.Drawing.Size(120, 34);
            this.ClearCheck.TabIndex = 11;
            this.ClearCheck.Text = "Отмена чека";
            this.ClearCheck.UseVisualStyleBackColor = true;
            this.ClearCheck.Click += new System.EventHandler(this.ClearCheck_Click);
            // 
            // CheckBox
            // 
            this.CheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CheckBox.AutoSize = true;
            this.CheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckBox.ForeColor = System.Drawing.Color.White;
            this.CheckBox.Location = new System.Drawing.Point(629, 18);
            this.CheckBox.Name = "CheckBox";
            this.CheckBox.Size = new System.Drawing.Size(113, 28);
            this.CheckBox.TabIndex = 13;
            this.CheckBox.Text = "Льготник";
            this.CheckBox.UseVisualStyleBackColor = true;
            this.CheckBox.CheckedChanged += new System.EventHandler(this.PensionerCheck_CheckedChanged);
            // 
            // Weight
            // 
            this.Weight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Weight.Location = new System.Drawing.Point(27, 15);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(56, 34);
            this.Weight.TabIndex = 14;
            this.Weight.Text = "Вес";
            this.Weight.UseVisualStyleBackColor = true;
            this.Weight.Click += new System.EventHandler(this.Weight_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.ListView1);
            this.panel1.Location = new System.Drawing.Point(44, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 282);
            this.panel1.TabIndex = 16;
            // 
            // ListView1
            // 
            this.ListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListView1.BackColor = System.Drawing.Color.White;
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.ListView1.GridLines = true;
            this.ListView1.HideSelection = false;
            this.ListView1.Location = new System.Drawing.Point(13, 16);
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(700, 250);
            this.ListView1.TabIndex = 8;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Num";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID";
            this.columnHeader2.Width = 40;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Product";
            this.columnHeader3.Width = 300;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Price";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Count";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "All Sum";
            this.columnHeader6.Width = 120;
            // 
            // Autorization
            // 
            this.Autorization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Autorization.Dock = System.Windows.Forms.DockStyle.Top;
            this.Autorization.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Autorization.ForeColor = System.Drawing.Color.White;
            this.Autorization.Location = new System.Drawing.Point(0, 0);
            this.Autorization.Name = "Autorization";
            this.Autorization.Size = new System.Drawing.Size(800, 67);
            this.Autorization.TabIndex = 0;
            this.Autorization.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Autorization.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Autorization_MouseDown);
            this.Autorization.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Autorization_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::АРМ_Кассира.Properties.Resources.free_icon_maximize_window_1296;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(732, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.MainPanel.Controls.Add(this.MinBut);
            this.MainPanel.Controls.Add(this.pictureBox1);
            this.MainPanel.Controls.Add(this.ExitBut);
            this.MainPanel.Controls.Add(this.panel1);
            this.MainPanel.Controls.Add(this.Autorization);
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(800, 450);
            this.MainPanel.TabIndex = 2;
            // 
            // ExitBut
            // 
            this.ExitBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitBut.AutoSize = true;
            this.ExitBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitBut.ForeColor = System.Drawing.Color.White;
            this.ExitBut.Location = new System.Drawing.Point(764, 9);
            this.ExitBut.Name = "ExitBut";
            this.ExitBut.Size = new System.Drawing.Size(26, 25);
            this.ExitBut.TabIndex = 18;
            this.ExitBut.Text = "X";
            this.ExitBut.Click += new System.EventHandler(this.ExitButt_Click);
            this.ExitBut.MouseEnter += new System.EventHandler(this.ExitButt_MouseEnter);
            this.ExitBut.MouseLeave += new System.EventHandler(this.ExitButt_MouseLeave);
            // 
            // MinBut
            // 
            this.MinBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinBut.AutoSize = true;
            this.MinBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinBut.ForeColor = System.Drawing.Color.White;
            this.MinBut.Location = new System.Drawing.Point(707, 9);
            this.MinBut.Name = "MinBut";
            this.MinBut.Size = new System.Drawing.Size(19, 25);
            this.MinBut.TabIndex = 19;
            this.MinBut.Text = "-";
            this.MinBut.Click += new System.EventHandler(this.Minimize_Click);
            this.MinBut.MouseEnter += new System.EventHandler(this.Minimize_MouseEnter);
            this.MinBut.MouseLeave += new System.EventHandler(this.Minimize_MouseLeave);
            // 
            // Prod
            // 
            this.Prod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Prod.Location = new System.Drawing.Point(106, 15);
            this.Prod.Name = "Prod";
            this.Prod.Size = new System.Drawing.Size(132, 34);
            this.Prod.TabIndex = 20;
            this.Prod.Text = "Номенклатура";
            this.Prod.UseVisualStyleBackColor = true;
            this.Prod.Click += new System.EventHandler(this.Products_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Weight;
        private System.Windows.Forms.CheckBox CheckBox;
        private System.Windows.Forms.Button ClearCheck;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.Button Pay;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ListView ListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label Autorization;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label MinBut;
        private System.Windows.Forms.Label ExitBut;
        private System.Windows.Forms.Button Prod;
    }
}