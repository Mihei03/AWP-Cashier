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
    public partial class MainForm : Form, IMainFormView
    {
        public event Action ClearTable;
        public event Action<Label> ButtMouseEnter;
        public event Action<Label> ButtMouseLeave;
        public event Action Start;
        public event Action AllProdClick;
        public event Action WeightClick;
        public event Action DelProdClick;
        public event Action PaymentClick;
        public event Action<ListView> ResizeWindow;
        public event Action<CheckBox, ListView> DiscountCheck;

        public List<Products> Products;
        public double AllSum = 0;
        public MainForm()
        {
            Program.mf = this;
            InitializeComponent();
        }
        public new void Show()
        {
            Start?.Invoke();
            ShowDialog();
        }
        internal static List<Form> GetVisibleForms()
        {
            List<Form> result = new List<Form>();
            foreach (Form form in Application.OpenForms)
            {
                if (form.Visible)
                    result.Add(form);
            }
            return result;
        }

        private void ExitButt_Click(object sender, EventArgs e)
        {
            List<Form> openForms = GetVisibleForms();
            for(int i = 0; i < openForms.Count; i++)
            {
                if(openForms[i].Name != "LoginForm")
                {
                    openForms[i].Close();
                }
            }
            Close();
        }

        private void ExitButt_MouseEnter(object sender, EventArgs e)
        {
            ButtMouseEnter?.Invoke(ExitBut);   
        }

        private void ExitButt_MouseLeave(object sender, EventArgs e)
        {
            ButtMouseLeave?.Invoke(ExitBut);
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
            ButtMouseEnter?.Invoke(MinBut);

        }

        private void Minimize_MouseLeave(object sender, EventArgs e)
        {
            ButtMouseLeave?.Invoke(MinBut);
        }

        private void Products_Click(object sender, EventArgs e)
        {
            AllProdClick?.Invoke();
        }

        private void Del_Click(object sender, EventArgs e)
        {
            if(ListView1.Items.Count > 0)
            {
                DelProdClick?.Invoke();
            }
        }

        private void ClearCheck_Click(object sender, EventArgs e)
        {
            ClearTable?.Invoke();
        }

        private void Pay_Click(object sender, EventArgs e)
        {
            if (ListView1.Items.Count == 0)
            {
                MessageBox.Show("Нет товаров к оплате!");
                return;
            }
            PaymentClick?.Invoke();
        }

        private void PensionerCheck_CheckedChanged(object sender, EventArgs e)
        {
            DiscountCheck?.Invoke(CheckBox, ListView1);
        }

        private void Weight_Click(object sender, EventArgs e)
        {
            WeightClick?.Invoke();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            ResizeWindow?.Invoke(ListView1);
        }

        public Form GetForm()
        {
            return this;
        }

        public void ShowFailedMessage()
        {
            throw new NotImplementedException();
        }
    }
}
