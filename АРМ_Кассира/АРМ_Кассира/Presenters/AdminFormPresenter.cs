using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using АРМ_Кассира.Models;
using АРМ_Кассира.Views;

namespace АРМ_Кассира.Presenters
{
    public class AdminFormPresenter : IPresenter
    {
        private readonly IAdminView adminForm;
        private readonly List<Users> _users;
        private readonly List<Products> _products;
        private readonly List<Time> _time;
        int SthChosen = 0;
        public AdminFormPresenter(IAdminView view, UsersData users, ProductsDB products, DiscTimeDB time)
        {
            adminForm = view;
            _users = users.ReadAllFromDB();
            _products = products.ReadAllFromDB();
            _time = time.ReadAllFromDB();;

            adminForm.ButtMouseEnter += AdminForm_ButtMouseEnter;
            adminForm.ButtMouseLeave += AdminForm_ButtMouseLeave;

            adminForm.Start += AdminForm_Start;
            adminForm.Back += AdminForm_Back;

            adminForm.AddUserClick += AdminForm_AddUserClick;
            adminForm.AddUserButtClick += AdminForm_AddUserButtClick;

            adminForm.DelUserClick += AdminForm_DelUserClick;
            adminForm.DelUserButtClick += AdminForm_DelUserButtClick;

            adminForm.AddProdClick += AdminForm_AddProdClick;
            adminForm.AddProdButtClick += AdminForm_AddProdButtClick;

            adminForm.DelProdClick += AdminForm_DelProdClick;
            adminForm.DelProdButtClick += AdminForm_DelProdButtClick;

            adminForm.ChangeDiscClick += AdminForm_ChangeDiscClick;
            adminForm.ChangeDiscButtClick += AdminForm_ChangeDiscButtClick;
        }

        public void Run()
        {
            adminForm.Show();
        }

        private void AdminForm_AddProdButtClick(Label label, Label label3, Label label4, Label label5, Label label6, Label label7, TextBox NameText, TextBox PriceText, TextBox PensPrice, TextBox AmmText, CheckBox WeightCheck, DateTimePicker DatePicker, TextBox ExpDate, Button AddProdButt, ListBox ProductList)
        {
            ProductsDB pd = new ProductsDB();
            double price, pensPrice, Amm;
            int expDate;
            if (double.TryParse(AmmText.Text, out double res))
            {
                Amm = res;
                if (Amm <= 0)
                {
                    MessageBox.Show("Неверное число товаров");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Неверный формат данных!");
                return;
            }
            if (double.TryParse(PriceText.Text, out res))
            {
                price = res;
            }
            else
            {
                MessageBox.Show("Неверный формат данных!");
                return;
            }
            if (Int32.TryParse(ExpDate.Text, out int resualt))
            {
                expDate = resualt;
                if (expDate <= 0)
                {
                    MessageBox.Show("Неверный срок годности");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Неверный формат данных!");
                return;
            }
            if (PensPrice.Text == "")
            {
                pensPrice = price;
            }
            else
            {
                if (double.TryParse(PensPrice.Text, out res))
                {
                    pensPrice = res;
                }
                else
                {
                    MessageBox.Show("Неверный формат данных!");
                    return;
                }
            }
            for (int i = 0; i < _products.Count; i++)
            {
                if (_products[i].Name == NameText.Text)
                {
                    _products[i].Price = price;
                    _products[i].Ammount += Amm;
                    MessageBox.Show("Цена и количество успешно изменены");
                    APr(label, label3, label4, label5, label6, label7, NameText, PriceText, PensPrice, AmmText, WeightCheck, DatePicker, ExpDate, AddProdButt);
                    return;
                }
            }
            Products temp;
            DateTime Date = DatePicker.Value.Date;
            temp = new Products(NameText.Text, _products.Count, price, pensPrice, Amm, WeightCheck.Checked, Date.ToString("dd.MM.yy"), expDate);
            _products.Add(temp);
            ProductList.Items.Add(temp.Key + ",    " + temp.Name + "    " + temp.Price + "p" + " Всего: " + temp.Ammount + "         - " + temp.Date);
            MessageBox.Show("Успешно добавлено");
            pd.WriteIntoDB(_products);
            APr(label, label3, label4, label5, label6, label7, NameText, PriceText, PensPrice, AmmText, WeightCheck, DatePicker, ExpDate, AddProdButt);
        }

        private void AdminForm_ChangeDiscButtClick(Label label8, Label label9, TextBox MinTime, TextBox MaxTime, Button ChangeButt)
        {
            int MinMin, MinHour, MaxMin, MaxHour;
            string[] temp = MinTime.Text.Split(':');
            if (temp.Length < 2)
            {
                MessageBox.Show("Неверный формат даты");
                return;
            }
            if (Int32.TryParse(temp[0], out int res))
            {
                MinHour = res;
            }
            else
            {
                MessageBox.Show("Неверный формат");
                return;
            }
            if (Int32.TryParse(temp[1], out res))
            {
                MinMin = res;
            }
            else
            {
                MessageBox.Show("Неверный формат");
                return;
            }
            temp = MaxTime.Text.Split(':');
            if (temp.Length < 2)
            {
                MessageBox.Show("Неверный формат даты");
                return;
            }
            if (Int32.TryParse(temp[0], out res))
            {
                MaxHour = res;
            }
            else
            {
                MessageBox.Show("Неверный формат");
                return;
            }
            if (Int32.TryParse(temp[1], out res))
            {
                MaxMin = res;
            }
            else
            {
                MessageBox.Show("Неверный формат");
                return;
            }
            Time min_max = new Time(MinHour + ":" + MinMin, MaxHour + ":" + MaxMin);
            _time[0] = min_max;
            DiscTimeDB dt = new DiscTimeDB();
            dt.WriteIntoDB(_time);
            ChDis(label8, label9, MinTime, MaxTime, ChangeButt);
            MessageBox.Show("Успешно изменено");
        }

        private void AdminForm_DelProdButtClick(ListBox ProductList, Button DelProd, int indx)
        {
            _products.RemoveAt(indx);
            ProductList.Items.RemoveAt(indx);
            ProductsDB pd = new ProductsDB();
            pd.WriteIntoDB(_products);
            MessageBox.Show("Успешно");
            DPr(ProductList, DelProd);
        }

        private void AdminForm_DelUserButtClick(ListBox UserList, Button DelButt, int indx)
        {
            for (int i = 0; i < _users.Count; i++)
            {
                if (_users[i].Login == UserList.Items[indx].ToString())
                {
                    _users.RemoveAt(i);
                }
            }
            UserList.Items.RemoveAt(indx);
            UsersData ud = new UsersData();
            ud.WriteIntoDB(_users);
            MessageBox.Show("Успешно");
            DUs(UserList, DelButt);
        }

        private void AdminForm_AddUserClick(Button AddButt, CheckBox rootCheckBox, TextBox PassText, Label label2, TextBox LoginText, Label label1)
        {
            if (SthChosen == 0 || SthChosen == 1)
            {
                AUs(AddButt, rootCheckBox, PassText, label2, LoginText, label1);
                
            }
        }
        private void AdminForm_AddUserButtClick(Button AddButt, CheckBox rootCheckBox, TextBox PassText, Label label2, TextBox LoginText, Label label1, ListBox UserList)
        {
            if (PassText.Text == "" || LoginText.Text == "")
            {
                MessageBox.Show("Заполните поля");
                return;
            }
            UsersData ud = new UsersData();
            PassText.Text = System.Text.Encoding.UTF8.GetString(ud.HashPassword(PassText.Text));
            Users Temp = new Users(LoginText.Text, PassText.Text, rootCheckBox.Checked);
            for (int i = 0; i < _users.Count; i++)
            {
                if (_users[i].Login == LoginText.Text)
                {
                    MessageBox.Show("Пользователь с таким логином уже зарегестрирован в системе");
                    PassText.Clear();
                    LoginText.Clear();
                    return;
                }
            }
            UserList.Items.Add(Temp.Login);
            _users.Add(Temp);
            PassText.Clear();
            LoginText.Clear();
            ud.WriteIntoDB(_users);
        }

        private void AdminForm_DelUserClick(ListBox UserList, Button DelButt)
        {
            if (SthChosen == 0 || SthChosen == 2)
            {
                DUs(UserList, DelButt);
            }
        }

        private void AdminForm_AddProdClick(Label label, Label label3, Label label4, Label label5, Label label6, Label label7, TextBox NameText, TextBox PriceText, TextBox PensPrice, TextBox AmmText, CheckBox WeightCheck, DateTimePicker DatePicker, TextBox ExpDate, Button AddProdButt)
        {
            if (SthChosen == 0 || SthChosen == 3)
            {
                APr(label, label3, label4, label5, label6, label7, NameText, PriceText, PensPrice, AmmText, WeightCheck, DatePicker, ExpDate, AddProdButt);
            }
        }

        private void AdminForm_DelProdClick(ListBox ProductList, Button DelProd)
        {
            if (SthChosen == 0 || SthChosen == 4)
            {
                DPr(ProductList, DelProd);
            }
        }

        private void AdminForm_ChangeDiscClick(Label label8, Label label9, TextBox MinTime, TextBox MaxTime, Button ChangeBut)
        {
            if (SthChosen == 0 || SthChosen == 5)
            {
                ChDis(label8, label9, MinTime, MaxTime, ChangeBut);
            }
        }

        private void AdminForm_Start(ListBox UserList, ListBox ProductList)
        {
            for (int i = 0; i < _users.Count; i++)
            {
                if (_users[i].Root)
                {
                    continue;
                }
                else
                {
                    UserList.Items.Add(_users[i].Login);
                }
            }
            for (int i = 0; i < _products.Count; i++)
            {
                ProductList.Items.Add(_products[i].Key + ",    " + _products[i].Name + "    " + _products[i].Price + "p" + " Всего: " + _products[i].Ammount + "         - " + _products[i].Date);
            }
        }
        private void AdminForm_Back(Form curForm)
        {
            curForm.Hide();
        }

        private void AdminForm_ButtMouseLeave(Label Butt)
        {
            Butt.BackColor = Color.FromArgb(31, 31, 31);
            Butt.BorderStyle = BorderStyle.None;
            Butt.ForeColor = Color.White;
        }

        private void AdminForm_ButtMouseEnter(Label Butt)
        {
            Butt.BackColor = Color.FromArgb(61, 61, 61);
            Butt.BorderStyle = BorderStyle.FixedSingle;
            Butt.ForeColor = Color.Red;
        }
        private void AUs(Button AddButt, CheckBox RootCheckBox, TextBox PassText, Label label2, TextBox LoginText, Label label1)
        {
            if (SthChosen == 0)
            {
                SthChosen = 1;
            }
            else
            {
                SthChosen = 0;
            }
            AddButt.Visible = !AddButt.Visible;
            RootCheckBox.Visible = !RootCheckBox.Visible;
            PassText.Visible = !PassText.Visible;
            label2.Visible = !label2.Visible;
            LoginText.Visible = !LoginText.Visible;
            label1.Visible = !label1.Visible;
        }
        private void DUs(ListBox UserList, Button DelButt)
        {
            if (SthChosen == 0)
            {
                SthChosen = 2;
            }
            else
            {
                SthChosen = 0;
            }
            UserList.Visible = !UserList.Visible;
            DelButt.Visible = !DelButt.Visible;
        }

        private void APr(Label label, Label label3, Label label4, Label label5, Label label6, Label label7, TextBox NameText, TextBox PriceText, TextBox PensPrice, TextBox AmmText, CheckBox WeightCheck, DateTimePicker DatePicker, TextBox ExpDate, Button AddProdButt)
        {
            if (SthChosen == 0)
            {
                SthChosen = 3;
            }
            else
            {
                SthChosen = 0;
            }
            label.Visible = !label.Visible;
            label3.Visible = !label3.Visible;
            label4.Visible = !label4.Visible;
            label5.Visible = !label5.Visible;
            label6.Visible = !label6.Visible;
            label7.Visible = !label7.Visible;
            NameText.Visible = !NameText.Visible;
            PriceText.Visible = !PriceText.Visible;
            PensPrice.Visible = !PensPrice.Visible;
            AmmText.Visible = !AmmText.Visible;
            WeightCheck.Visible = !WeightCheck.Visible;
            DatePicker.Visible = !DatePicker.Visible;
            ExpDate.Visible = !ExpDate.Visible;
            AddProdButt.Visible = !AddProdButt.Visible;
            NameText.Clear();
            PriceText.Clear();
            PensPrice.Clear();
            AmmText.Clear();
            ExpDate.Clear();
            WeightCheck.Checked = false;
        }

        private void DPr(ListBox ProductList, Button DelProd)
        {
            if (SthChosen == 0)
            {
                SthChosen = 4;
            }
            else
            {
                SthChosen = 0;
            }
            ProductList.Visible = !ProductList.Visible;
            DelProd.Visible = !DelProd.Visible;
        }

        private void ChDis(Label label8, Label label9, TextBox MinTime, TextBox MaxTime, Button ChangeBut)
        {
            if (SthChosen == 0)
            {
                SthChosen = 5;
            }
            else
            {
                SthChosen = 0;
            }
            label8.Visible = !label8.Visible;
            label9.Visible = !label9.Visible;
            MinTime.Visible = !MinTime.Visible;
            MaxTime.Visible = !MaxTime.Visible;
            ChangeBut.Visible = !ChangeBut.Visible;
            MinTime.Clear();
            MaxTime.Clear();
        }
    }
}
