using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace АРМ_Кассира.Views
{
    public interface IMainFormView : BaseView
    {
        event Action ClearTable;
        event Action Start;
        event Action AllProdClick;
        event Action WeightClick;
        event Action DelProdClick;
        event Action PaymentClick;
        event Action<ListView> ResizeWindow;
        event Action<CheckBox, ListView> DiscountCheck;
        void Show();
        Form GetForm();
    }
}
