using CodeBlogFitnes.CMD.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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
        public List<User> Users { get; set; }
        public User currentUser { get; }
        public bool IsNewUser { get; set; } = false;
        public UserController()
        {
            
        }
        /// <summary>
        /// Создать нового пользователя
        /// </summary>
        /// <param name="userName"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public UserController(string userName)
        {
            if (string.IsNullOrWhiteSpace(userName))
            {
                throw new ArgumentNullException("Имя не может быть null ", nameof(userName));
            }
            Users = GetUsersData(); 

            currentUser = Users.SingleOrDefault(u => u.Name == userName);
            if (currentUser == null)
            {
                currentUser = new User(userName);
                IsNewUser = true;
                Users.Add(currentUser);
                Save();
            }
        }

        public void SetNewUserData(string genderName, DateTime brithData, double weight, double height)
        {
            currentUser.Gender = new Gender(genderName);
            currentUser.BirthDate = brithData;
            currentUser.Weight = weight;
            currentUser.Height = height;
            Save();

        }

        private List<User> GetUsersData()
        {
            var formater = new BinaryFormatter();

            using (var fs = new FileStream("user.dat", FileMode.OpenOrCreate))
            {
                if (formater.Deserialize(fs) is List<User> users)
                {
                    return users;
                }
                else
                {

                    return new List<User>();
                }
            }
        }
        public void SenNewUserData(string genderName, DateTime birthData, double weight = 1, double heigh = 1)
        {
            // TODO проверка

            currentUser.Gender = new Gender(genderName);
            currentUser.BirthDate = birthData;
            currentUser.Weight = weight;
            currentUser.Height = heigh;
            Save();

        }

        /// <summary>
        /// Сохранить данные пользователя
        /// </summary>
        public void Save()
        {
            BinaryFormatter formater = new BinaryFormatter();
            using (FileStream fs = new FileStream("user.dat",FileMode.OpenOrCreate))
            {
                formater.Serialize(fs, Users);   
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
    }
            
}
