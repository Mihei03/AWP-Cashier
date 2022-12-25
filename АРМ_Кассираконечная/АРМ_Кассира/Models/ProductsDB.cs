using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Script.Serialization;

namespace АРМ_Кассира
{
    public class ProductsDB
    {
        readonly string fullpath = "Products.json";

        public List<Products> ReadAllFromDB()
        {
            if (!File.Exists(fullpath)) // Проверяем существование файла
            {
                var file = File.Create(fullpath);
                file.Close();
            }
            string json = File.ReadAllText(fullpath); //Считываем весь текст в изначальном виде
            List<Products> AllProducts = JsonConvert.DeserializeObject<List<Products>>(json); //Десериализуем(Сопоставляем содержмое. "Name":"ABC" - запишет только ABC в переменную Name) все данные из считанного текста в Список
            return AllProducts ?? new List<Products>(); //Возвращаем полученный список, если его нет, то создаём пустой и его возвращаем
        }
        public void WriteIntoDB(List<Products> CurrUsers)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            string jsonData = js.Serialize(CurrUsers);
            File.WriteAllText(fullpath, jsonData);
        }
    }
}
