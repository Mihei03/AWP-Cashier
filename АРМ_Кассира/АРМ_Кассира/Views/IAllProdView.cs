using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace АРМ_Кассира.Views
{
    public interface IAllProdView
    {
        event Action<ListBox> Start;
        event Action<TextBox, int> AddButtClick;
        void ShowWindow();
        Form GetForm();
    }
}
