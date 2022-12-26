using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using АРМ_Кассира.Views;

namespace АРМ_Кассира.Presenters
{
    public class LoginPresenter : IPresenter
    {
        private readonly ILoginView loginForm;
        private readonly LoginForm lf;
        private readonly UsersData _users;
        public LoginPresenter(ILoginView view, UsersData users)
        {
            loginForm = view;
            _users = users;
            lf = new LoginForm();
            loginForm.SignIn += LoginView_SignIn;
            loginForm.SignInMouseEnter += LoginView_SignInMouseEnter;
            loginForm.SignInMouseLeave += LoginView_SignInMouseLeave;
            loginForm.ButtMouseEnter += LoginView_ButtEnter;
            loginForm.ButtMouseLeave += LoginView_ButtLeave;
        }
        public void Run()
        {
            loginForm.Show();
        }

        private void LoginView_ButtLeave(Label ExButt)
        {
            ExButt.BackColor = Color.FromArgb(31, 31, 31);
            ExButt.BorderStyle = BorderStyle.None;
            ExButt.ForeColor = Color.White;
        }

        private void LoginView_ButtEnter(Label Butt)
        {
            Butt.BackColor = Color.FromArgb(61, 61, 61);
            Butt.BorderStyle = BorderStyle.FixedSingle;
            Butt.ForeColor = Color.Red;
        }

        private void LoginView_SignInMouseLeave(Button SignInButt)
        {
            SignInButt.FlatAppearance.BorderSize = 0;
        }

        private void LoginView_SignInMouseEnter(Button SignInButt)
        {
            SignInButt.FlatAppearance.BorderSize = 1;
        }

        private void LoginView_SignIn(string login, string password)
        {
            int temp = _users.FindUser(login, password);
            if (temp == 2) // Если нашли такого пользователя и он админ
            {
                lf.Hide();
                var controller = new AdminFormPresenter(new AdminForm(), new UsersData(), new ProductsDB(), new DiscTimeDB());
                controller.Run();
            }
            else if (temp == 1)
            {
                lf.Hide(); // Скрываем окно
                var controller = new MainFormPresenter(new MainForm(), new ProductsDB(), new DiscTimeDB());
                controller.Run();
            }
            else
            {
                loginForm.ShowFailedMessage();
            }
        }
    }
}
