using CodeBlogFitnes.CMD.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CodeBlogFitnes.CMD.Controller
{
    internal class UserController
    {
        public User User { get; }

        public UserController()
        {
            
        }
        public UserController(string userName, string genderName, DateTime birth, double weight, double height)
        {
            var gender = new Gender(genderName);
            User = new User(userName, gender, birth, weight, height);
        }
        /// <summary>
        /// Сохранить данные пользователя
        /// </summary>
        public void Save()
        {
            BinaryFormatter formater = new BinaryFormatter();
            using (FileStream fs = new FileStream("user.dat",FileMode.OpenOrCreate))
            {
                formater.Serialize(fs, User);   
            }
        }
        /// <summary>
        /// Получить данные пользователя
        /// </summary>
        public void Load()
        {
            BinaryFormatter formater = new BinaryFormatter();
            using (FileStream fs = new FileStream("user.dat", FileMode.OpenOrCreate))
            {
                var user = formater.Deserialize(fs) as User;
            }
        }
        public void Print()
        {
            User.Print();
        }
    }
            
}
