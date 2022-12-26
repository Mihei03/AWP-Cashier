using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using АРМ_Кассира.Models;
using АРМ_Кассира.Views;

namespace АРМ_Кассира
{
    public partial class AdminForm : Form, IAdminView
    {
        public event Action<Button, CheckBox, TextBox, Label, TextBox, Label> AddUserClick;
        public event Action<Button, CheckBox, TextBox, Label, TextBox, Label, ListBox> AddUserButtClick;

        public event Action<ListBox, Button> DelUserClick;
        public event Action<ListBox, Button, int> DelUserButtClick;

        public event Action<Label, Label, Label, Label, Label, Label, TextBox, TextBox, TextBox, TextBox, CheckBox, DateTimePicker, TextBox, Button> AddProdClick;
        public event Action<Label, Label, Label, Label, Label, Label, TextBox, TextBox, TextBox, TextBox, CheckBox, DateTimePicker, TextBox, Button, ListBox> AddProdButtClick;

        public event Action<ListBox, Button> DelProdClick;
        public event Action<ListBox, Button, int> DelProdButtClick;

        public event Action<Label, Label, TextBox, TextBox, Button> ChangeDiscClick;
        public event Action<Label, Label, TextBox, TextBox, Button> ChangeDiscButtClick;

        public event Action<Label> ButtMouseEnter;
        public event Action<Label> ButtMouseLeave;

        public event Action<ListBox, ListBox> Start;
        public event Action<Form> Back;

        int indx;
        string DelText;
        public AdminForm()
        {
            InitializeComponent();
        }
        public new void Show()
        {
            Start?.Invoke(UserList, ProductList);
            ShowDialog();
        }

        // Все функции ниже описаны в коде MainForm
        private void ExitButt_Click(object sender, EventArgs e)
        {
            Back?.Invoke(this);
        }

        private void ExitButt_MouseEnter(object sender, EventArgs e)
        {
            ButtMouseEnter?.Invoke(ExitButt);
        }

        private void ExitButt_MouseLeave(object sender, EventArgs e)
        {
            ButtMouseLeave?.Invoke(ExitButt);
        }

        Point lastPoint;

        private void Autorization_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        private void Autorization_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Minimize_MouseEnter(object sender, EventArgs e)
        {
            ButtMouseEnter?.Invoke(Minimize);

        }

        private void Minimize_MouseLeave(object sender, EventArgs e)
        {
            ButtMouseLeave?.Invoke(Minimize);
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            AddUserClick?.Invoke(AddButt, RootCheckBox, PassText, label2, LoginText, label1);
        }
        private void AddUser_MouseEnter(object sender, EventArgs e)
        {
            ButtMouseEnter?.Invoke(AddUser);
        }
        private void AddUser_MouseLeave(object sender, EventArgs e)
        {
            ButtMouseLeave?.Invoke(AddUser);
        }
        private void DeleteUser_Click(object sender, EventArgs e)
        {
            DelUserClick?.Invoke(UserList, DelButt);
        }
        private void DeleteUser_MouseEnter(object sender, EventArgs e)
        {
            ButtMouseEnter?.Invoke(DeleteUser);
        }
        private void DeleteUser_MouseLeave(object sender, EventArgs e)
        {
            ButtMouseLeave?.Invoke(DeleteUser);
        }
        private void AddProduct_Click(object sender, EventArgs e)
        {
            AddProdClick?.Invoke(label, label3, label4, label5, label6, label7, NameText, PriceText, PensPrice, AmmText, WeightCheck, DatePicker, ExpDate, AddProdButt);
        }
        private void AddProduct_MouseEnter(object sender, EventArgs e)
        {
            ButtMouseEnter?.Invoke(AddProduct);
        }
        private void AddProduct_MouseLeave(object sender, EventArgs e)
        {
            ButtMouseLeave?.Invoke(AddProduct);
        }
        private void DeleteProduct_Click(object sender, EventArgs e)
        {
           DelProdClick?.Invoke(ProductList, DelProd);
        }
        private void DeleteProduct_MouseEnter(object sender, EventArgs e)
        {
            ButtMouseEnter?.Invoke(DeleteProduct);
        }
        private void DeleteProduct_MouseLeave(object sender, EventArgs e)
        {
            ButtMouseLeave?.Invoke(DeleteProduct);
        }

        private void LeaveButt_Click(object sender, EventArgs e)
        {
            Back?.Invoke(this);
        }

        private void ChangeDisc_Click(object sender, EventArgs e)
        {
            ChangeDiscClick?.Invoke(label8, label9, MinTime, MaxTime, ChangeBut);
        }

        private void ChangeDisc_MouseEnter(object sender, EventArgs e)
        {
            ButtMouseEnter?.Invoke(ChangeDisc);
        }

        private void ChangeDisc_MouseLeave(object sender, EventArgs e)
        {
            ButtMouseLeave?.Invoke(ChangeDisc);
        }

        private void AddButt_Click(object sender, EventArgs e)
        {
            AddUserButtClick?.Invoke(AddButt, RootCheckBox, PassText, label2, LoginText, label1, UserList);
        }
        private void AddButt_MouseLeave(object sender, EventArgs e) // Вызывается, когда уводишь мышь с кнопки
        {
            AddButt.FlatAppearance.BorderSize = 0;
        }

        private void AddButt_MouseEnter(object sender, EventArgs e)
        {
            AddButt.FlatAppearance.BorderSize = 1;
        }

        private void DelButt_Click(object sender, EventArgs e)
        {
            if (DelText != "")
            {
                DelUserButtClick?.Invoke(UserList, DelButt, indx);
                DelText = "";
                indx = -1;
            }
        }

        private void UserList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DelText = UserList.Text;
            indx = UserList.SelectedIndex;
        }
        private void AddProdButt_Click(object sender, EventArgs e)
        {
            AddProdButtClick?.Invoke(label, label3, label4, label5, label6, label7, NameText, PriceText, PensPrice, AmmText, WeightCheck, DatePicker, ExpDate, AddProdButt, ProductList);
        }
        private void ProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DelText = ProductList.Text;
            indx = ProductList.SelectedIndex;
        }
        private void DelProd_Click(object sender, EventArgs e)
        {
            if (DelText != "")
            {
                DelProdButtClick?.Invoke(ProductList, DelProd, indx);
                DelText = "";
                indx = -1;
            }
        }
        private void ChangeBut_Click(object sender, EventArgs e)
        {
            ChangeDiscButtClick?.Invoke(label8, label9, MinTime, MaxTime, ChangeBut);
        }
    }
}
