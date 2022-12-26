using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using АРМ_Кассира.Views;

namespace АРМ_Кассира.Presenters
{
    public class DelProdPresenter
    {
        private readonly IDelItemView _itemView;
        private readonly DelItem _weightForm;

        public DelProdPresenter(IDelItemView _view)
        {
            _itemView = _view;
            _weightForm = (DelItem)_itemView.GetForm();
            _itemView.Start += DelItem_Start;
            _itemView.RemoveButtClick += DelItem_DelButtClick;
        }

        private void DelItem_Start(ListBox CheckList)
        {
            ListView lv = Program.mf.ListView1;
            for (int i = 0; i < Program.mf.ListView1.Items.Count; i++)
            {
                CheckList.Items.Add(i + "    ID: " + lv.Items[i].SubItems[1].Text + "       " + lv.Items[i].SubItems[2].Text + "      " + " Количество: " + lv.Items[i].SubItems[4].Text + " Цена: " + lv.Items[i].SubItems[5].Text + 'p');
            }
        }

        private void DelItem_DelButtClick(int indx)
        {
            string[] amm = Program.mf.ListView1.Items[indx].SubItems[4].Text.Split('к');
            Program.mf.Products[Int32.Parse(Program.mf.ListView1.Items[indx].SubItems[1].Text)].Ammount += double.Parse(amm[0]);
            Program.mf.AllSum -= double.Parse(Program.mf.ListView1.Items[indx].SubItems[5].Text);
            Program.mf.ListView1.Items[indx].Remove();
            _weightForm.Close();
        }
        public void Run()
        {
            _itemView.ShowWindow();
        }
    }
}
