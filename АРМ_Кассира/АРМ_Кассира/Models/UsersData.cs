using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Web.Script.Serialization;

namespace АРМ_Кассира
{
    public class UsersData
    {
        readonly string fullpath = "Workers.json";
        public int FindUser(string UserName, string Pass)
        {
            List<Users> AllUsers = ReadAllFromDB(); // Считываем данные из json
            for (int i = 0; i < AllUsers.Count; i++)
            {
                if (AllUsers[i].Login == UserName && AllUsers[i].Password == System.Text.Encoding.UTF8.GetString(HashPassword(Pass))) // Если есть такие логин и пароль в считанном массиве, то возвращаем true
                {
                    if(AllUsers[i].Root)
                    {
                        return 2;
                    }
                    return 1;
                }
            }
            return 0;
        }
        public List<Users> ReadAllFromDB()
        {
            if (!File.Exists(fullpath)) // Проверяем существование файла
            {
                var file = File.Create(fullpath);
                file.Close();
            }
            string json = File.ReadAllText(fullpath); //Считываем весь текст в изначальном виде

            List<Users> CurrUsers = JsonConvert.DeserializeObject<List<Users>>(json); //Десериализуем(Сопоставляем содержмое. "Name":"ABC" - запишет только ABC в переменную Name) все данные из считанного текста в Список
            return CurrUsers ?? new List<Users>(); //Возвращаем полученный список, если его нет, то создаём пустой и его возвращаем
        }
        public void WriteIntoDB(List<Users> CurrUsers)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            string jsonData = js.Serialize(CurrUsers);
            File.WriteAllText(fullpath, jsonData);
        }
        public byte[] HashPassword(string pass)
        {
            UnicodeEncoding ue = new UnicodeEncoding();
            byte[] PassBytes = ue.GetBytes(pass);
            SHA256 shHash = SHA256.Create();
            byte[] Hash = shHash.ComputeHash(PassBytes);
            return Hash;
            
        }
    }
}
