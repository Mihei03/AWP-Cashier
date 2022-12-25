namespace АРМ_Кассира
{
    partial class DelItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DelItem));
            this.CheckList = new System.Windows.Forms.ListBox();
            this.RemoveButt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CheckList
            // 
            this.CheckList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CheckList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckList.ForeColor = System.Drawing.Color.White;
            this.CheckList.FormattingEnabled = true;
            this.CheckList.ItemHeight = 20;
            this.CheckList.Location = new System.Drawing.Point(12, 44);
            this.CheckList.Name = "CheckList";
            this.CheckList.Size = new System.Drawing.Size(770, 324);
            this.CheckList.TabIndex = 27;
            this.CheckList.SelectedIndexChanged += new System.EventHandler(this.CheckList_SelectedIndexChanged);
            // 
            // RemoveButt
            // 
            this.RemoveButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveButt.Location = new System.Drawing.Point(369, 397);
            this.RemoveButt.Name = "RemoveButt";
            this.RemoveButt.Size = new System.Drawing.Size(100, 33);
            this.RemoveButt.TabIndex = 26;
            this.RemoveButt.Text = "Удалить";
            this.RemoveButt.UseVisualStyleBackColor = true;
            this.RemoveButt.Click += new System.EventHandler(this.RemoveButt_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 33);
            this.button1.TabIndex = 28;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // DelItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CheckList);
            this.Controls.Add(this.RemoveButt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DelItem";
            this.Text = "DelItem";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox CheckList;
        private System.Windows.Forms.Button RemoveButt;
        private System.Windows.Forms.Button button1;
    }
}