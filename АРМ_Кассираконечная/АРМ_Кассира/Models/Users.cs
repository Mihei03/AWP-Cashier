using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace АРМ_Кассира
{
    public class Users
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public bool Root { get; set; }
        public Users(string login, string password, bool root) // Считываем логин и пароль и наличие прав админа. НЕ МЕНЯЙ НАЗВАНИЕ ПЕРЕМЕННЫХ!
        {
            Login = login;
            Password = password;
            Root = root;
        }
    }
}
