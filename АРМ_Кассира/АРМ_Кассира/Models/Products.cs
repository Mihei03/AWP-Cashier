using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace АРМ_Кассира
{
    public class Products
    {
        public string Name { get; set; }
        public int Key { get; set; }
        public double Price { get; set; }
        public double Ammount { get; set; }
        public double PensPrice { get; set; }
        public bool Weight { get; set; }
        public string Date { get; set; }
        public int ExpDate { get; set; }
        public Products(string name, int key, double price, double pensprice, double ammount, bool weight, string date, int expdate) // Считываем логин и пароль и наличие прав админа. НЕ МЕНЯЙ НАЗВАНИЕ ПЕРЕМЕННЫХ!
        {
            Name = name;
            Key = key;
            Price = price;
            PensPrice = pensprice;
            Ammount = ammount;
            Weight = weight;
            Date = date.ToString();
            ExpDate = expdate;
        }
    }
}
