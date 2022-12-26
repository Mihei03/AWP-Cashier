using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using АРМ_Кассира.Views;

namespace АРМ_Кассира.Presenters
{
    public class PaymentPresenter
    {
        private readonly IPaymentView PayView;
        private readonly PaymentForm pf;
        private readonly List<Products> products;
        readonly double AllSum;
        public PaymentPresenter(IPaymentView _view, List<Products> prod, double sum)
        {
            PayView = _view;
            products = prod;
            AllSum = sum;
            pf = (PaymentForm)PayView.GetForm();
            PayView.ExitButtClick += Payment_ExitButtClick;
            PayView.ButtMouseEnter += Payment_ButtMouseEnter;
            PayView.ButtMouseLeave += Payment_ButtMouseLeave;
            PayView.CardButtClick += Payment_CardButtClick;
            PayView.CashButtClick += Payment_CashButtClick;
            PayView.EndOpClick += Payment_EndOpClick;
            PayView.ChangeCountClick += Payment_ChangeCountClick;
        }

        private void Payment_CashButtClick(Label label1, Label label2, Label label3, Button CountChange, TextBox SumText, TextBox CashText, TextBox ChangeText, Button CashButt, Button CardButt)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            CountChange.Visible = true;
            SumText.Visible = true;
            SumText.Text = AllSum.ToString();
            CashText.Visible = true;
            ChangeText.Visible = true;
            CashButt.Visible = false;
            CardButt.Visible = false;
        }

        private void Payment_ChangeCountClick(TextBox CashText, TextBox SumText, TextBox ChangeText, Button CountChange, Button EndOp)
        {
            if (CashText.Text != "" && SumText.Text != " ")
            {
                int Cash;
                if (Int32.TryParse(CashText.Text, out int res))
                {
                    Cash = res;
                }
                else
                {
                    MessageBox.Show("Неверный формат!");
                    return;
                }
                ChangeText.Text = Math.Round((Cash - Double.Parse(SumText.Text)), 2).ToString();
                CountChange.Visible = false;
                EndOp.Visible = true;
                CashText.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("Заполните поля!");
            }
        }

        private void Payment_EndOpClick(Label label1, Label label2, Label label3, Button CountChange, TextBox SumText, TextBox CashText, TextBox ChangeText, Button EndOp, Button CashButt, Button CardButt)
        {
            double change = Double.Parse(ChangeText.Text);
            if (change < 0)
            {
                MessageBox.Show("Невозможно завершить операцию. Слишком малый взнос!");
                CashText.Clear();
                CountChange.Visible = true;
                EndOp.Visible = false;
                CashText.ReadOnly = false;
                return;
            }
            pf.Close();
            DateTime now = DateTime.Now;
            string name = now.Day + "." + now.Month + "." + now.Year + "_" + now.Hour + "." + now.Minute + ".txt";
            var file = File.Create(name);
            file.Close();
            string check = DateTime.Now.ToString() + '\n';
            for (int i = 0; i < Program.mf.ListView1.Items.Count; i++)
            {
                ListViewItem item = Program.mf.ListView1.Items[i];
                check += item.SubItems[0].Text + ": " + item.SubItems[2].Text + " Price: " + item.SubItems[3].Text + " Count: " + item.SubItems[4].Text + " AllSum: " + item.SubItems[5].Text;
                check += '\n';
            }
            check += "All Sum: " + AllSum.ToString() + '\n';
            check += "Change: " + change + '\n';
            check += "Was paid by cash";
            File.WriteAllText(name, check);
            ProductsDB pd = new ProductsDB();
            pd.WriteIntoDB(products);
            Program.mf.ListView1.Items.Clear();
            Program.mf.AllSum = 0;
            ChangeVisibility(label1, label2, label3, CountChange, SumText, CashText, ChangeText, EndOp, CashButt, CardButt);
        }

        private void Payment_CardButtClick()
        {
            pf.Close();
            DateTime now = DateTime.Now;
            string name = now.Day + "." + now.Month + "." + now.Year + "_" + now.Hour + "." + now.Minute + ".txt";
            var file = File.Create(name);
            file.Close();
            string check = DateTime.Now.ToString() + '\n';
            for (int i = 0; i < Program.mf.ListView1.Items.Count; i++)
            {
                ListViewItem item = Program.mf.ListView1.Items[i];
                check += item.SubItems[0].Text + ": " + item.SubItems[2].Text + " Price: " + item.SubItems[3].Text + " Count: " + item.SubItems[4].Text + " AllSum: " + item.SubItems[5].Text;
                check += '\n';
            }
            check += "All Sum: " + AllSum.ToString() + '\n';
            check += "Was paid by card";
            File.WriteAllText(name, check);
            ProductsDB pd = new ProductsDB();
            pd.WriteIntoDB(products);
            Program.mf.ListView1.Items.Clear();
            Program.mf.AllSum = 0;
        }

        private void Payment_ButtMouseLeave(Label Butt)
        {
            Butt.BackColor = Color.FromArgb(30, 30, 30);
            Butt.BorderStyle = BorderStyle.FixedSingle;
            Butt.ForeColor = Color.Red;
        }

        private void Payment_ButtMouseEnter(Label Butt)
        {
            Butt.BackColor = Color.FromArgb(61, 61, 61);
            Butt.BorderStyle = BorderStyle.FixedSingle;
            Butt.ForeColor = Color.Red;
        }

        private void Payment_ExitButtClick()
        {
            ChangingAmm();
            Program.mf.AllSum = 0;
            Program.mf.ListView1.Items.Clear();
            pf.Hide();
        }
        void ChangingAmm()
        {
            for (int i = 0; i < Program.mf.ListView1.Items.Count; i++)
            {
                int ID = Int32.Parse(Program.mf.ListView1.Items[i].SubItems[1].Text);
                string[] amm = Program.mf.ListView1.Items[i].SubItems[4].Text.Split('к');
                products[ID].Ammount += Double.Parse(amm[0]);
                products[ID].Ammount = Math.Round(products[ID].Ammount, 3);
            }

        }
        void ChangeVisibility(Label label1, Label label2, Label label3, Button CountChange, TextBox SumText, TextBox CashText, TextBox ChangeText, Button EndOp, Button CashButt, Button CardButt)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            CountChange.Visible = false;
            SumText.Visible = false;
            CashText.Visible = false;
            ChangeText.Visible = false;
            EndOp.Visible = false;
            SumText.ReadOnly = false;
            CashText.ReadOnly = false;
            CashButt.Visible = true;
            CardButt.Visible = true;
        }
        public void Run()
        {
            PayView.ShowWindow();
        }
    }
}
