namespace АРМ_Кассира
{
    partial class WeightForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeightForm));
            this.ProductsList = new System.Windows.Forms.ListBox();
            this.AddButt = new System.Windows.Forms.Button();
            this.WeightText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProductsList
            // 
            this.ProductsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ProductsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductsList.ForeColor = System.Drawing.Color.White;
            this.ProductsList.FormattingEnabled = true;
            this.ProductsList.ItemHeight = 20;
            this.ProductsList.Location = new System.Drawing.Point(23, 22);
            this.ProductsList.Name = "ProductsList";
            this.ProductsList.Size = new System.Drawing.Size(755, 344);
            this.ProductsList.TabIndex = 11;
            this.ProductsList.SelectedIndexChanged += new System.EventHandler(this.ProductsList_SelectedIndexChanged);
            // 
            // AddButt
            // 
            this.AddButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButt.Location = new System.Drawing.Point(365, 395);
            this.AddButt.Name = "AddButt";
            this.AddButt.Size = new System.Drawing.Size(100, 33);
            this.AddButt.TabIndex = 10;
            this.AddButt.Text = "Добавить";
            this.AddButt.UseVisualStyleBackColor = true;
            this.AddButt.Click += new System.EventHandler(this.AddButt_Click);
            // 
            // WeightText
            // 
            this.WeightText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WeightText.Location = new System.Drawing.Point(124, 372);
            this.WeightText.Multiline = true;
            this.WeightText.Name = "WeightText";
            this.WeightText.ReadOnly = true;
            this.WeightText.Size = new System.Drawing.Size(73, 25);
            this.WeightText.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Вес:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 33);
            this.button1.TabIndex = 12;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // WeightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ProductsList);
            this.Controls.Add(this.AddButt);
            this.Controls.Add(this.WeightText);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WeightForm";
            this.Text = "WeightForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ProductsList;
        private System.Windows.Forms.Button AddButt;
        private System.Windows.Forms.TextBox WeightText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}