using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using АРМ_Кассира.Views;

namespace АРМ_Кассира
{
    public partial class DelItem : Form, IDelItemView
    {
        public event Action<ListBox> Start;
        public event Action<int> RemoveButtClick;
        int indx;
        string DelText;
        public DelItem()
        {
            InitializeComponent();
        }

        public void ShowWindow()
        {
            Start?.Invoke(CheckList);
            ShowDialog();
        }

        private void CheckList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DelText = CheckList.Text;
            indx = CheckList.SelectedIndex;
        }

        private void RemoveButt_Click(object sender, EventArgs e)
        {
            if(DelText != "")
            {
                RemoveButtClick?.Invoke(indx);
                
            }
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
