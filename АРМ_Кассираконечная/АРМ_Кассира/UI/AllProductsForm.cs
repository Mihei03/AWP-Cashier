using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using АРМ_Кассира.Views;

namespace АРМ_Кассира
{
    public partial class AllProductsForm : Form, IAllProdView
    {
        public event Action<TextBox, int> AddButtClick;
        private string DelText;
        int SelIndx;

        public event Action<ListBox> Start;

        public AllProductsForm()
        {
            InitializeComponent();
        }
        public void ShowWindow()
        {
            Start?.Invoke(ProductsList);
            ShowDialog();
        }

        private void AddButt_Click(object sender, EventArgs e)
        {
            if (DelText != "")
            {
                AddButtClick?.Invoke(CountText, SelIndx);
            }
        }

        private void ProductsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DelText = ProductsList.Text;
            SelIndx = ProductsList.SelectedIndex;
        }
        public Form GetForm()
        {
            return this;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
