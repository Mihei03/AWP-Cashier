using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace АРМ_Кассира.Views
{
    public interface IPaymentView : BaseView
    {
        event Action ExitButtClick;
        event Action CardButtClick;
        event Action<Label, Label, Label, Button, TextBox, TextBox, TextBox, Button, Button> CashButtClick;
        event Action<TextBox, TextBox, TextBox, Button, Button> ChangeCountClick;
        event Action<Label, Label, Label, Button, TextBox, TextBox, TextBox, Button, Button, Button> EndOpClick;

        void ShowWindow();
        Form GetForm();
    }
}
