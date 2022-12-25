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
    public class AllProdsPresenter : IPresenter
    {
        private readonly IAllProdView _allForm;
        private readonly AllProductsForm _apf;
        private readonly List<Products> _products;
        private string indx = "";
        public AllProdsPresenter(IAllProdView formView, List<Products> prods)
        {
            _allForm = formView;
            _products = prods;
            _apf = (AllProductsForm)_allForm.GetForm();
            _allForm.Start += AllProducts_Start;
            _allForm.AddButtClick += AllProducts_AddButtClick;
        }

        private void AllProducts_AddButtClick(TextBox CountText, int SelIndx)
        {
            int count;
            if (Int32.TryParse(CountText.Text, out int res))
            {
                count = res;
            }
            else
            {
                MessageBox.Show("Неверный формат!");
                return;
            }
            if (count > 0)
            {
                int i = CharUnicodeInfo.GetDecimalDigitValue(indx[SelIndx]);
                if (_products[i].Ammount - count >= 0)
                {
                    int AllSum = (int)_products[i].Price * count;
                    ListViewItem item = new ListViewItem(Program.mf.ListView1.Items.Count.ToString());
                    item.SubItems.Add(_products[i].Key.ToString());
                    item.SubItems.Add(_products[i].Name);
                    item.SubItems.Add(_products[i].Price.ToString());
                    item.SubItems.Add(CountText.Text);
                    item.SubItems.Add(AllSum.ToString());
                    Program.mf.ListView1.Items.Add(item);
                    Program.mf.AllSum += AllSum;
                    Program.mf.Products[i].Ammount -= count;
                    _apf.Close();
                    return;
                }
                MessageBox.Show("Не хватает товаров на складе");
            }
            else
            {
                MessageBox.Show("Введи количество товаров!");
            }
        }
        private void AllProducts_Start(ListBox ProductsList)
        {
            for (int i = 0, g = 0; i < _products.Count; i++)
            {
                if (!_products[i].Weight)
                {
                    g++;
                    ProductsList.Items.Add(g + "    ID: " + _products[i].Key + "       " + _products[i].Name + "      " + _products[i].Price + 'p' + " Всего на складе: " + _products[i].Ammount + "                -       " + _products[i].Date + " годность: " + _products[i].ExpDate);
                    indx += _products[i].Key;
                }
            }
        }

        public void Run()
        {
            _allForm.ShowWindow();
        }
    }
}
