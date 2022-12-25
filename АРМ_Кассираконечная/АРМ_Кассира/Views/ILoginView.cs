using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace АРМ_Кассира.Views
{
    public interface ILoginView
    {
        event Action<string, string> SignIn;
        event Action<Button> SignInMouseEnter;
        event Action<Button> SignInMouseLeave;
        event Action<Label> ButtMouseEnter;
        event Action<Label> ButtMouseLeave;
        void ShowFailedMessage();
        void Show();


    }
}
