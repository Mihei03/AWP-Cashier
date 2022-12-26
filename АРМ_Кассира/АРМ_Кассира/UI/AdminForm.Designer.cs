namespace АРМ_Кассира
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.Autorization = new System.Windows.Forms.Label();
            this.AddUser = new System.Windows.Forms.Label();
            this.DeleteUser = new System.Windows.Forms.Label();
            this.LeaveButt = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Label();
            this.ExitButt = new System.Windows.Forms.Label();
            this.AddProduct = new System.Windows.Forms.Label();
            this.DeleteProduct = new System.Windows.Forms.Label();
            this.ChangeDisc = new System.Windows.Forms.Label();
            this.DelButt = new System.Windows.Forms.Button();
            this.UserList = new System.Windows.Forms.ListBox();
            this.PassText = new System.Windows.Forms.TextBox();
            this.RootCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddButt = new System.Windows.Forms.Button();
            this.ExpDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.WeightCheck = new System.Windows.Forms.CheckBox();
            this.PensPrice = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.AmmText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PriceText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.TextBox();
            this.AddProdButt = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ProductList = new System.Windows.Forms.ListBox();
            this.DelProd = new System.Windows.Forms.Button();
            this.ChangeBut = new System.Windows.Forms.Button();
            this.MaxTime = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MinTime = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Autorization
            // 
            this.Autorization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Autorization.Dock = System.Windows.Forms.DockStyle.Top;
            this.Autorization.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Autorization.ForeColor = System.Drawing.Color.White;
            this.Autorization.Location = new System.Drawing.Point(0, 0);
            this.Autorization.Name = "Autorization";
            this.Autorization.Size = new System.Drawing.Size(881, 67);
            this.Autorization.TabIndex = 1;
            this.Autorization.Text = "Админ меню";
            this.Autorization.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Autorization.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Autorization_MouseDown);
            this.Autorization.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Autorization_MouseMove);
            // 
            // AddUser
            // 
            this.AddUser.AutoSize = true;
            this.AddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddUser.ForeColor = System.Drawing.SystemColors.Control;
            this.AddUser.Location = new System.Drawing.Point(12, 67);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(150, 16);
            this.AddUser.TabIndex = 2;
            this.AddUser.Text = "Добавить сотрудника";
            this.AddUser.Click += new System.EventHandler(this.AddUser_Click);
            this.AddUser.MouseEnter += new System.EventHandler(this.AddUser_MouseEnter);
            this.AddUser.MouseLeave += new System.EventHandler(this.AddUser_MouseLeave);
            // 
            // DeleteUser
            // 
            this.DeleteUser.AutoSize = true;
            this.DeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteUser.ForeColor = System.Drawing.SystemColors.Control;
            this.DeleteUser.Location = new System.Drawing.Point(179, 67);
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Size = new System.Drawing.Size(142, 16);
            this.DeleteUser.TabIndex = 3;
            this.DeleteUser.Text = "Удалить сотрудника";
            this.DeleteUser.Click += new System.EventHandler(this.DeleteUser_Click);
            this.DeleteUser.MouseEnter += new System.EventHandler(this.DeleteUser_MouseEnter);
            this.DeleteUser.MouseLeave += new System.EventHandler(this.DeleteUser_MouseLeave);
            // 
            // LeaveButt
            // 
            this.LeaveButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeaveButt.Location = new System.Drawing.Point(12, 12);
            this.LeaveButt.Name = "LeaveButt";
            this.LeaveButt.Size = new System.Drawing.Size(80, 31);
            this.LeaveButt.TabIndex = 4;
            this.LeaveButt.Text = "Назад";
            this.LeaveButt.UseVisualStyleBackColor = true;
            this.LeaveButt.Click += new System.EventHandler(this.LeaveButt_Click);
            // 
            // Minimize
            // 
            this.Minimize.AutoSize = true;
            this.Minimize.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Minimize.ForeColor = System.Drawing.Color.White;
            this.Minimize.Location = new System.Drawing.Point(806, 2);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(23, 31);
            this.Minimize.TabIndex = 8;
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
            this.ExitButt.Location = new System.Drawing.Point(844, 0);
            this.ExitButt.Name = "ExitButt";
            this.ExitButt.Size = new System.Drawing.Size(25, 33);
            this.ExitButt.TabIndex = 9;
            this.ExitButt.Text = "X";
            this.ExitButt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExitButt.Click += new System.EventHandler(this.ExitButt_Click);
            this.ExitButt.MouseEnter += new System.EventHandler(this.ExitButt_MouseEnter);
            this.ExitButt.MouseLeave += new System.EventHandler(this.ExitButt_MouseLeave);
            // 
            // AddProduct
            // 
            this.AddProduct.AutoSize = true;
            this.AddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddProduct.ForeColor = System.Drawing.SystemColors.Control;
            this.AddProduct.Location = new System.Drawing.Point(336, 67);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(221, 16);
            this.AddProduct.TabIndex = 10;
            this.AddProduct.Text = "Добавить товар в номенклатуру";
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            this.AddProduct.MouseEnter += new System.EventHandler(this.AddProduct_MouseEnter);
            this.AddProduct.MouseLeave += new System.EventHandler(this.AddProduct_MouseLeave);
            // 
            // DeleteProduct
            // 
            this.DeleteProduct.AutoSize = true;
            this.DeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteProduct.ForeColor = System.Drawing.SystemColors.Control;
            this.DeleteProduct.Location = new System.Drawing.Point(572, 67);
            this.DeleteProduct.Name = "DeleteProduct";
            this.DeleteProduct.Size = new System.Drawing.Size(104, 16);
            this.DeleteProduct.TabIndex = 11;
            this.DeleteProduct.Text = "Удалить товар";
            this.DeleteProduct.Click += new System.EventHandler(this.DeleteProduct_Click);
            this.DeleteProduct.MouseEnter += new System.EventHandler(this.DeleteProduct_MouseEnter);
            this.DeleteProduct.MouseLeave += new System.EventHandler(this.DeleteProduct_MouseLeave);
            // 
            // ChangeDisc
            // 
            this.ChangeDisc.AutoSize = true;
            this.ChangeDisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeDisc.ForeColor = System.Drawing.SystemColors.Control;
            this.ChangeDisc.Location = new System.Drawing.Point(698, 67);
            this.ChangeDisc.Name = "ChangeDisc";
            this.ChangeDisc.Size = new System.Drawing.Size(171, 16);
            this.ChangeDisc.TabIndex = 12;
            this.ChangeDisc.Text = "Изменить период скидок";
            this.ChangeDisc.Click += new System.EventHandler(this.ChangeDisc_Click);
            this.ChangeDisc.MouseEnter += new System.EventHandler(this.ChangeDisc_MouseEnter);
            this.ChangeDisc.MouseLeave += new System.EventHandler(this.ChangeDisc_MouseLeave);
            // 
            // DelButt
            // 
            this.DelButt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.DelButt.FlatAppearance.BorderSize = 0;
            this.DelButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.DelButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelButt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DelButt.Location = new System.Drawing.Point(389, 341);
            this.DelButt.Name = "DelButt";
            this.DelButt.Size = new System.Drawing.Size(94, 37);
            this.DelButt.TabIndex = 24;
            this.DelButt.Text = "Удалить";
            this.DelButt.UseVisualStyleBackColor = false;
            this.DelButt.Visible = false;
            this.DelButt.Click += new System.EventHandler(this.DelButt_Click);
            // 
            // UserList
            // 
            this.UserList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.UserList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserList.ForeColor = System.Drawing.Color.White;
            this.UserList.FormattingEnabled = true;
            this.UserList.ItemHeight = 20;
            this.UserList.Location = new System.Drawing.Point(135, 115);
            this.UserList.Name = "UserList";
            this.UserList.Size = new System.Drawing.Size(621, 220);
            this.UserList.TabIndex = 23;
            this.UserList.Visible = false;
            this.UserList.SelectedIndexChanged += new System.EventHandler(this.UserList_SelectedIndexChanged);
            // 
            // PassText
            // 
            this.PassText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassText.Location = new System.Drawing.Point(366, 224);
            this.PassText.Multiline = true;
            this.PassText.Name = "PassText";
            this.PassText.Size = new System.Drawing.Size(150, 25);
            this.PassText.TabIndex = 30;
            this.PassText.Visible = false;
            // 
            // RootCheckBox
            // 
            this.RootCheckBox.AutoSize = true;
            this.RootCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RootCheckBox.ForeColor = System.Drawing.Color.White;
            this.RootCheckBox.Location = new System.Drawing.Point(360, 266);
            this.RootCheckBox.Name = "RootCheckBox";
            this.RootCheckBox.Size = new System.Drawing.Size(156, 28);
            this.RootCheckBox.TabIndex = 29;
            this.RootCheckBox.Text = "Права админа";
            this.RootCheckBox.UseVisualStyleBackColor = true;
            this.RootCheckBox.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(405, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Логин";
            this.label1.Visible = false;
            // 
            // LoginText
            // 
            this.LoginText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginText.Location = new System.Drawing.Point(366, 142);
            this.LoginText.Multiline = true;
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(150, 25);
            this.LoginText.TabIndex = 28;
            this.LoginText.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(406, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Пароль";
            this.label2.Visible = false;
            // 
            // AddButt
            // 
            this.AddButt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.AddButt.FlatAppearance.BorderSize = 0;
            this.AddButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.AddButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddButt.Location = new System.Drawing.Point(389, 309);
            this.AddButt.Name = "AddButt";
            this.AddButt.Size = new System.Drawing.Size(94, 37);
            this.AddButt.TabIndex = 27;
            this.AddButt.Text = "Добавить";
            this.AddButt.UseVisualStyleBackColor = false;
            this.AddButt.Visible = false;
            this.AddButt.Click += new System.EventHandler(this.AddButt_Click);
            this.AddButt.MouseEnter += new System.EventHandler(this.Minimize_MouseEnter);
            this.AddButt.MouseLeave += new System.EventHandler(this.AddUser_MouseLeave);
            // 
            // ExpDate
            // 
            this.ExpDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExpDate.Location = new System.Drawing.Point(655, 166);
            this.ExpDate.Multiline = true;
            this.ExpDate.Name = "ExpDate";
            this.ExpDate.Size = new System.Drawing.Size(143, 25);
            this.ExpDate.TabIndex = 44;
            this.ExpDate.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label5.Location = new System.Drawing.Point(533, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 18);
            this.label5.TabIndex = 43;
            this.label5.Text = "Срок годности:";
            this.label5.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(503, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 18);
            this.label3.TabIndex = 42;
            this.label3.Text = "Дата производства:";
            this.label3.Visible = false;
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(655, 128);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(200, 20);
            this.DatePicker.TabIndex = 41;
            this.DatePicker.Visible = false;
            // 
            // WeightCheck
            // 
            this.WeightCheck.AutoSize = true;
            this.WeightCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WeightCheck.ForeColor = System.Drawing.Color.White;
            this.WeightCheck.Location = new System.Drawing.Point(64, 295);
            this.WeightCheck.Name = "WeightCheck";
            this.WeightCheck.Size = new System.Drawing.Size(120, 28);
            this.WeightCheck.TabIndex = 40;
            this.WeightCheck.Text = "На развес";
            this.WeightCheck.UseVisualStyleBackColor = true;
            this.WeightCheck.Visible = false;
            // 
            // PensPrice
            // 
            this.PensPrice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PensPrice.Location = new System.Drawing.Point(150, 209);
            this.PensPrice.Multiline = true;
            this.PensPrice.Name = "PensPrice";
            this.PensPrice.Size = new System.Drawing.Size(333, 25);
            this.PensPrice.TabIndex = 39;
            this.PensPrice.Visible = false;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label.Location = new System.Drawing.Point(52, 213);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(61, 18);
            this.label.TabIndex = 38;
            this.label.Text = "Льгота:";
            this.label.Visible = false;
            // 
            // AmmText
            // 
            this.AmmText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmmText.Location = new System.Drawing.Point(150, 249);
            this.AmmText.Multiline = true;
            this.AmmText.Name = "AmmText";
            this.AmmText.Size = new System.Drawing.Size(333, 25);
            this.AmmText.TabIndex = 37;
            this.AmmText.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(52, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 18);
            this.label4.TabIndex = 36;
            this.label4.Text = "Количество";
            this.label4.Visible = false;
            // 
            // PriceText
            // 
            this.PriceText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceText.Location = new System.Drawing.Point(150, 169);
            this.PriceText.Multiline = true;
            this.PriceText.Name = "PriceText";
            this.PriceText.Size = new System.Drawing.Size(333, 25);
            this.PriceText.TabIndex = 35;
            this.PriceText.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(52, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 18);
            this.label6.TabIndex = 34;
            this.label6.Text = "Цена";
            this.label6.Visible = false;
            // 
            // NameText
            // 
            this.NameText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameText.Location = new System.Drawing.Point(150, 123);
            this.NameText.Multiline = true;
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(333, 25);
            this.NameText.TabIndex = 33;
            this.NameText.Visible = false;
            // 
            // AddProdButt
            // 
            this.AddProdButt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.AddProdButt.FlatAppearance.BorderSize = 0;
            this.AddProdButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.AddProdButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProdButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddProdButt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddProdButt.Location = new System.Drawing.Point(68, 355);
            this.AddProdButt.Name = "AddProdButt";
            this.AddProdButt.Size = new System.Drawing.Size(94, 37);
            this.AddProdButt.TabIndex = 32;
            this.AddProdButt.Text = "Добавить";
            this.AddProdButt.UseVisualStyleBackColor = false;
            this.AddProdButt.Visible = false;
            this.AddProdButt.Click += new System.EventHandler(this.AddProdButt_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(52, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 18);
            this.label7.TabIndex = 31;
            this.label7.Text = "Название";
            this.label7.Visible = false;
            // 
            // ProductList
            // 
            this.ProductList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ProductList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductList.ForeColor = System.Drawing.Color.White;
            this.ProductList.FormattingEnabled = true;
            this.ProductList.ItemHeight = 16;
            this.ProductList.Location = new System.Drawing.Point(135, 115);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(621, 224);
            this.ProductList.TabIndex = 45;
            this.ProductList.Visible = false;
            this.ProductList.SelectedIndexChanged += new System.EventHandler(this.ProductList_SelectedIndexChanged);
            // 
            // DelProd
            // 
            this.DelProd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.DelProd.FlatAppearance.BorderSize = 0;
            this.DelProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.DelProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelProd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DelProd.Location = new System.Drawing.Point(389, 341);
            this.DelProd.Name = "DelProd";
            this.DelProd.Size = new System.Drawing.Size(94, 37);
            this.DelProd.TabIndex = 46;
            this.DelProd.Text = "Удалить";
            this.DelProd.UseVisualStyleBackColor = false;
            this.DelProd.Visible = false;
            this.DelProd.Click += new System.EventHandler(this.DelProd_Click);
            // 
            // ChangeBut
            // 
            this.ChangeBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeBut.Location = new System.Drawing.Point(377, 242);
            this.ChangeBut.Name = "ChangeBut";
            this.ChangeBut.Size = new System.Drawing.Size(90, 32);
            this.ChangeBut.TabIndex = 51;
            this.ChangeBut.Text = "Изменить";
            this.ChangeBut.UseVisualStyleBackColor = true;
            this.ChangeBut.Visible = false;
            this.ChangeBut.Click += new System.EventHandler(this.ChangeBut_Click);
            // 
            // MaxTime
            // 
            this.MaxTime.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaxTime.Location = new System.Drawing.Point(536, 173);
            this.MaxTime.Multiline = true;
            this.MaxTime.Name = "MaxTime";
            this.MaxTime.Size = new System.Drawing.Size(143, 25);
            this.MaxTime.TabIndex = 50;
            this.MaxTime.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label8.Location = new System.Drawing.Point(501, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 18);
            this.label8.TabIndex = 49;
            this.label8.Text = "До";
            this.label8.Visible = false;
            // 
            // MinTime
            // 
            this.MinTime.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinTime.Location = new System.Drawing.Point(206, 173);
            this.MinTime.Multiline = true;
            this.MinTime.Name = "MinTime";
            this.MinTime.Size = new System.Drawing.Size(143, 25);
            this.MinTime.TabIndex = 48;
            this.MinTime.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label9.Location = new System.Drawing.Point(177, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 18);
            this.label9.TabIndex = 47;
            this.label9.Text = "С:";
            this.label9.Visible = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(881, 404);
            this.Controls.Add(this.ChangeBut);
            this.Controls.Add(this.MaxTime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MinTime);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DelProd);
            this.Controls.Add(this.ProductList);
            this.Controls.Add(this.ExpDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.WeightCheck);
            this.Controls.Add(this.PensPrice);
            this.Controls.Add(this.label);
            this.Controls.Add(this.AmmText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PriceText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.AddProdButt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PassText);
            this.Controls.Add(this.RootCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddButt);
            this.Controls.Add(this.DelButt);
            this.Controls.Add(this.UserList);
            this.Controls.Add(this.ChangeDisc);
            this.Controls.Add(this.DeleteProduct);
            this.Controls.Add(this.AddProduct);
            this.Controls.Add(this.ExitButt);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.LeaveButt);
            this.Controls.Add(this.DeleteUser);
            this.Controls.Add(this.AddUser);
            this.Controls.Add(this.Autorization);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Autorization;
        private System.Windows.Forms.Label AddUser;
        private System.Windows.Forms.Label DeleteUser;
        private System.Windows.Forms.Button LeaveButt;
        private System.Windows.Forms.Label Minimize;
        private System.Windows.Forms.Label ExitButt;
        private System.Windows.Forms.Label AddProduct;
        private System.Windows.Forms.Label DeleteProduct;
        private System.Windows.Forms.Label ChangeDisc;
        private System.Windows.Forms.Button DelButt;
        private System.Windows.Forms.ListBox UserList;
        private System.Windows.Forms.TextBox PassText;
        private System.Windows.Forms.CheckBox RootCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LoginText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddButt;
        private System.Windows.Forms.TextBox ExpDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.CheckBox WeightCheck;
        private System.Windows.Forms.TextBox PensPrice;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox AmmText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PriceText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Button AddProdButt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox ProductList;
        private System.Windows.Forms.Button DelProd;
        private System.Windows.Forms.Button ChangeBut;
        private System.Windows.Forms.TextBox MaxTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MinTime;
        private System.Windows.Forms.Label label9;
    }
}