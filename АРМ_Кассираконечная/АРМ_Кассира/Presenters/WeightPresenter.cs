using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using АРМ_Кассира.Views;

namespace АРМ_Кассира.Presenters
{
    public class WeightPresenter
    {
        private readonly IWeightView _weightView;
        private readonly WeightForm _wf;
        private readonly List<Products> _products;
        private string indx = "";
        public WeightPresenter(IWeightView formView, List<Products> prods)
        {
            _weightView = formView;
            _products = prods;
            _wf = (WeightForm)_weightView.GetForm();
            _weightView.Start += AllProducts_Start;
            _weightView.AddButtClick += AllProducts_AddButtClick;
        }

        private void AllProducts_AddButtClick(TextBox WeightText, int SelIndx)
        {
            double weight;
            if (double.TryParse(WeightText.Text, out double res))
            {
                weight = res;
            }
            else
            {
                MessageBox.Show("Неверный формат!");
                return;
            }
            int i = CharUnicodeInfo.GetDecimalDigitValue(indx[SelIndx]);
            if (_products[i].Ammount - weight >= 0)
            {
                double AllSum = Math.Round(_products[i].Price * weight, 2);
                ListViewItem item = new ListViewItem(Program.mf.ListView1.Items.Count.ToString());
                item.SubItems.Add(_products[i].Key.ToString());
                item.SubItems.Add(_products[i].Name);
                item.SubItems.Add(_products[i].Price.ToString());
                item.SubItems.Add(WeightText.Text + "кг");
                item.SubItems.Add(AllSum.ToString());
                Program.mf.ListView1.Items.Add(item);
                Program.mf.AllSum += AllSum;
                Program.mf.Products[i].Ammount -= weight;
                _wf.Close();
                return;
            }
            MessageBox.Show("Нет такого количества товара на складе");
        }
        private void AllProducts_Start(ListBox ProductsList, TextBox WeightText)
        {
            Random rnd = new Random();
            WeightText.Text = Math.Round(rnd.NextDouble(), 3).ToString();
            for (int i = 0, g = 0; i < _products.Count; i++)
            {
                if (_products[i].Weight)
                {
                    g++;
                    ProductsList.Items.Add(i + "    ID: " + _products[i].Key + "       " + _products[i].Name + "      " + _products[i].Price + 'p' + " Всего: " + _products[i].Ammount + "кг            -       " + _products[i].Date + " годность: " + _products[i].ExpDate);
                    indx += _products[i].Key;
                }
            }
        }

        public void Run()
        {
            _wf.ShowWindow();
        }
    }
}
