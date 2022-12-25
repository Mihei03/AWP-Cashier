using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using АРМ_Кассира.Views;

namespace АРМ_Кассира
{
    public partial class PaymentForm : Form, IPaymentView
    {
        public event Action ExitButtClick;
        public event Action<Label> ButtMouseEnter;
        public event Action<Label> ButtMouseLeave;
        public event Action CardButtClick;
        public event Action<Label, Label, Label, Button, TextBox, TextBox, TextBox, Button, Button> CashButtClick;
        public event Action<TextBox, TextBox, TextBox, Button, Button> ChangeCountClick;
        public event Action<Label, Label, Label, Button, TextBox, TextBox, TextBox, Button, Button, Button> EndOpClick;

        public PaymentForm()
        {
            InitializeComponent();
        }

        public void ShowWindow()
        {
            ShowDialog();
        }
        private void ExitButt_Click(object sender, EventArgs e)
        {
            ExitButtClick?.Invoke();
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

        private void CardButt_Click(object sender, EventArgs e)
        {
            CardButtClick?.Invoke();
        }

        private void CashButt_Click(object sender, EventArgs e)
        {
            CashButtClick?.Invoke(label1, label2, label3, CountChange, SumText, CashText, ChangeText, CashButt, CardButt);
        }

        private void CountChange_Click(object sender, EventArgs e)
        {
            ChangeCountClick(CashText, SumText, ChangeText, CountChange, EndOp);
        }

        private void EndOp_Click(object sender, EventArgs e)
        {
            EndOpClick?.Invoke(label1, label2, label3, CountChange, SumText, CashText, ChangeText, EndOp, CashButt, CardButt);
        }
        public Form GetForm()
        {
            return this;
        }
    }
}
