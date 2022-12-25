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
    public partial class WeightForm : Form, IWeightView
    {
        private string DelText;
        private int SelInxd;

        public event Action<ListBox, TextBox> Start;
        public event Action<TextBox, int> AddButtClick;

        public WeightForm()
        {
            InitializeComponent();
        }

        event Action<ListBox> IAllProdView.Start
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        private void AddButt_Click(object sender, EventArgs e)
        {
            if(DelText != "")
            {
                AddButtClick?.Invoke(WeightText, SelInxd);
            }
        }

        private void ProductsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DelText = ProductsList.Text;
            SelInxd = ProductsList.SelectedIndex;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void ShowWindow()
        {
            Start?.Invoke(ProductsList, WeightText);
            ShowDialog();
        }

        public Form GetForm()
        {
            return this;
        }
    }
}
