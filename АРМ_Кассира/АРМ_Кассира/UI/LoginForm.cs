using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using АРМ_Кассира.Views;

namespace АРМ_Кассира
{
    public partial class LoginForm : Form, ILoginView
    {
        public event Action<string, string> SignIn;
        public event Action<Button> SignInMouseEnter;
        public event Action<Button> SignInMouseLeave;
        public event Action<Label> ButtMouseEnter;
        public event Action<Label> ButtMouseLeave;

        Point lastPoint;
        public LoginForm()
        {
            InitializeComponent();
            PassText.AutoSize = false; //Для того, чтобы "****" было в пункте с паролем, то требуется отключить функцию multyline, из-за чего нельзя нормально регулировать размер окна ввода, так что выключаем функцию авто регулировки размера
            PassText.Size = new Size(PassText.Width, LoginText.Height); // Новый размер окна ввода пароля равен окну ввода логина
        }

        public new void Show()
        {
            Application.Run(this);
        }

        private void SignInButt_Click(object sender, EventArgs e) // При нажатии на кнопку входа
        {
            SignIn(LoginText.Text, PassText.Text);
        }

        private void SignInButt_MouseEnter(object sender, EventArgs e) // Вызывается, когда наводишь мышь на кнопку
        {
            SignInMouseEnter?.Invoke(SignInButt);
        }

        private void SignInButt_MouseLeave(object sender, EventArgs e) // Вызывается, когда уводишь мышь с кнопки
        {
            SignInMouseLeave?.Invoke(SignInButt);
        }
        // Все функции ниже описаны в коде MainForm
        private void ExitButt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExitButt_MouseEnter(object sender, EventArgs e)
        {
            ButtMouseEnter?.Invoke(ExitButt);
        }

        private void ExitButt_MouseLeave(object sender, EventArgs e)
        {
            ButtMouseLeave?.Invoke(ExitButt);
        }

        private void Autorization_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        private void Autorization_MouseDown(object sender, MouseEventArgs e)
        {

            lastPoint = new Point(e.X, e.Y);
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Minimize_MouseEnter(object sender, EventArgs e)
        {
            ButtMouseEnter?.Invoke(Minimize);
        }

        private void Minimize_MouseLeave(object sender, EventArgs e)
        {
            ButtMouseLeave?.Invoke(Minimize);
        }

        public void ShowFailedMessage()
        {
            MessageBox.Show("Пользователь не найден!");
        }
    }
}


