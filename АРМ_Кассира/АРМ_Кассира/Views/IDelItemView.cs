using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace АРМ_Кассира.Views
{
    public interface IDelItemView
    {
        event Action<ListBox> Start;
        event Action<int> RemoveButtClick;
        void ShowWindow();
        Form GetForm();
    }
}
