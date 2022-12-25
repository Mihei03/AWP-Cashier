using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using АРМ_Кассира.Models;

namespace АРМ_Кассира
{
    public class DiscTimeDB
    {
        readonly string fullpath = "DiscountTime.json";

        public List<Time> ReadAllFromDB()
        {
            if (!File.Exists(fullpath)) // Проверяем существование файла
            {
                var file = File.Create(fullpath);
                file.Close();
            }
            string json = File.ReadAllText(fullpath); //Считываем весь текст в изначальном виде
            List<Time> DiscTime = JsonConvert.DeserializeObject<List<Time>>(json); //Десериализуем(Сопоставляем содержмое. "Name":"ABC" - запишет только ABC в переменную Name) все данные из считанного текста в Список
            return DiscTime ?? new List<Time>(); //Возвращаем полученный список, если его нет, то создаём пустой и его возвращаем
        }
        public void WriteIntoDB(List<Time> CurrTime)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            string jsonData = js.Serialize(CurrTime);
            File.WriteAllText(fullpath, jsonData);
        }
    }
}
