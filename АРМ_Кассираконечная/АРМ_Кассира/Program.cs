using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using АРМ_Кассира.Presenters;

namespace АРМ_Кассира
{
    internal static class Program
    {
        public static MainForm mf;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var controller = new LoginPresenter(new LoginForm(), new UsersData());
            controller.Run();
        }
    }
}
