using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using АРМ_Кассира.Models;
using АРМ_Кассира.Views;

namespace АРМ_Кассира.Presenters
{
    public class MainFormPresenter : IPresenter
    {
        private readonly IMainFormView _formView;
        private readonly MainForm _mainForm;
        private readonly List<Products> _products;
        private readonly List<Time> _time;
        double AllSum;
        bool flag = false;
        public MainFormPresenter(IMainFormView formView, ProductsDB productsDB, DiscTimeDB time)
        {
            _formView = formView;
            _time = time.ReadAllFromDB();
            _products = productsDB.ReadAllFromDB();
            _mainForm = (MainForm)_formView.GetForm();

            _formView.ClearTable += FormView_ClearTable;
            _formView.ButtMouseLeave += FormView_ButtMouseLeave;
            _formView.ButtMouseEnter += FormView_ButtMouseEnter;
            _formView.AllProdClick += FormView_AllProdClick;
            _formView.DelProdClick += FormView_DelProdClick;
            _formView.WeightClick += FormView_WeightClick;
            _formView.PaymentClick += FormView_PaymentClick;
            _formView.Start += FormView_Start;
            _formView.DiscountCheck += FormView_DiscountCheck;
            _formView.ResizeWindow += FormView_Resize;
        }

        private void FormView_Resize(ListView ListView1)
        {
            if (!flag)
            {
                ListView1.Font = new Font(ListView1.Font.Name, 20, ListView1.Font.Style);
                ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                _mainForm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                ListView1.Font = new Font(ListView1.Font.Name, 8, ListView1.Font.Style);
                ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                _mainForm.WindowState = FormWindowState.Normal;
            }
            flag = !flag;
        }

        private void FormView_DiscountCheck(CheckBox checkbox, ListView ListView1)
        {
            int HourNow = DateTime.Now.Hour;
            int MinuteNow = DateTime.Now.Minute;
            string[] temp1 = _time[0].MinTime.Split(':');
            string[] temp2 = _time[0].MaxTime.Split(':');
            if (checkbox.Checked && HourNow > Int32.Parse(temp1[0]) && HourNow < Int32.Parse(temp2[0]))
            {
                _mainForm.AllSum = ChangePriceForPens(ListView1);
                _mainForm.Products = _products;
                return;
            }
            else if (checkbox.Checked && HourNow > Int32.Parse(temp1[0]) - 1 && HourNow < Int32.Parse(temp2[0]) + 1)
            {
                if (MinuteNow > Int32.Parse(temp1[1]) || MinuteNow < Int32.Parse(temp2[1]))
                {
                    _mainForm.AllSum = ChangePriceForPens(ListView1);
                    _mainForm.Products = _products;
                    return;
                }
            }
            else
            {
                _mainForm.AllSum = StandartPrice(ListView1); 
                _mainForm.Products = _products;
            }
        }

        private void FormView_AllProdClick()
        {
            var connector = new AllProdsPresenter(new AllProductsForm(), _products);
            connector.Run();
        }
        private void FormView_DelProdClick()
        {
            var connector = new DelProdPresenter(new DelItem());
            connector.Run();
        }
        private void FormView_WeightClick()
        {
            var connector = new WeightPresenter(new WeightForm(), _products);
            connector.Run();
        }
        private void FormView_PaymentClick()
        {
            var connector = new PaymentPresenter(new PaymentForm(), _products, _mainForm.AllSum);
            connector.Run();
        }

        private void FormView_ButtMouseLeave(Label Butt)
        {
            Butt.BackColor = Color.FromArgb(31, 31, 31);
            Butt.BorderStyle = BorderStyle.None;
            Butt.ForeColor = Color.White;
        }
        private void FormView_ButtMouseEnter(Label Butt)
        {
            Butt.BackColor = Color.FromArgb(61, 61, 61);
            Butt.BorderStyle = BorderStyle.FixedSingle;
            Butt.ForeColor = Color.Red;
        }
        private void FormView_Start()
        { 
            for (int i = 0; i < _products.Count; i++)
            {
                TimeSpan ts = (DateTime.Parse(_products[i].Date) - DateTime.Now.Date).Duration();
                if (ts.Days > _products[i].ExpDate)
                {
                    _products.RemoveAt(i);
                    i--;
                }
            }
            for (int i = 0; i < _products.Count; i++)
            {
                _products[i].Key = i;
            }
            ProductsDB pd = new ProductsDB();
            pd.WriteIntoDB(_products);
            _mainForm.Products = _products;
        }
        private void FormView_ClearTable()
        {
            int Max = _mainForm.ListView1.Items.Count;
            for (int i = 0; i < Max; i++)
            {
                string[] amm = _mainForm.ListView1.Items[0].SubItems[4].Text.Split('к');
                _products[Int32.Parse(_mainForm.ListView1.Items[0].SubItems[1].Text)].Ammount += Double.Parse(amm[0]);
                _mainForm.ListView1.Items[0].Remove();
            }
            _mainForm.AllSum = 0;
        }

        public void Run()
        {
            _formView.Show();
        }
        double ChangePriceForPens(ListView ListView1)
        {
            double AllSum = 0;
            double CurSum;
            for (int i = 0; i < ListView1.Items.Count; i++)
            {
                int ID = Int32.Parse(ListView1.Items[i].SubItems[1].Text);
                ListView1.Items[i].SubItems[3].Text = _products[ID].PensPrice.ToString();
                string[] amm = Program.mf.ListView1.Items[i].SubItems[4].Text.Split('к');
                CurSum = Math.Round(double.Parse(ListView1.Items[i].SubItems[3].Text) * double.Parse(amm[0]), 2);
                AllSum += CurSum;
                ListView1.Items[i].SubItems[5].Text = CurSum.ToString();
            }
            return AllSum;
        }
        double StandartPrice(ListView ListView1)
        {
            double AllSum = 0;
            double CurSum;
            for (int i = 0; i < ListView1.Items.Count; i++)
            {
                int ID = Int32.Parse(ListView1.Items[i].SubItems[1].Text);
                ListView1.Items[i].SubItems[3].Text = _products[ID].Price.ToString();
                string[] amm = Program.mf.ListView1.Items[i].SubItems[4].Text.Split('к');
                CurSum = Math.Round(double.Parse(ListView1.Items[i].SubItems[3].Text) * double.Parse(amm[0]), 2);
                AllSum += CurSum;
                ListView1.Items[i].SubItems[5].Text = CurSum.ToString();
            }
            return AllSum;
        }
    }
}
