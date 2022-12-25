using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace АРМ_Кассира.Views
{
    public interface IAdminView : BaseView
    {
        event Action<Button, CheckBox, TextBox, Label, TextBox, Label> AddUserClick;
        event Action<Button, CheckBox, TextBox, Label, TextBox, Label, ListBox> AddUserButtClick;

        event Action<ListBox, Button> DelUserClick;
        event Action<ListBox, Button, int> DelUserButtClick;

        event Action<Label, Label, Label, Label, Label, Label, TextBox, TextBox, TextBox, TextBox, CheckBox, DateTimePicker, TextBox, Button>  AddProdClick;
        event Action<Label, Label, Label, Label, Label, Label, TextBox, TextBox, TextBox, TextBox, CheckBox, DateTimePicker, TextBox, Button, ListBox>  AddProdButtClick;

        event Action<ListBox, Button> DelProdClick;
        event Action<ListBox, Button, int> DelProdButtClick;

        event Action<Label, Label, TextBox, TextBox, Button> ChangeDiscClick;
        event Action<Label, Label, TextBox, TextBox, Button> ChangeDiscButtClick;

        event Action<ListBox, ListBox> Start;
        event Action<Form> Back;

        void Show();
    }
}
