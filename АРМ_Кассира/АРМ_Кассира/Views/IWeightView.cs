using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace АРМ_Кассира.Views
{
    public interface IWeightView : IAllProdView
    {
        new event Action<ListBox, TextBox> Start;
    }
}
