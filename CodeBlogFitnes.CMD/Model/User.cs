using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlogFitnes.CMD.Model
{
    /// <summary>
    /// Пользователь
    /// </summary>
    [Serializable]
    internal class User
    {
        #region Свойства
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Пол
        /// </summary>
        public Gender Gender { get; set; }
        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime BirthDate { get; set; }
        /// <summary>
        /// Вес
        /// </summary>
        public double Weight { get; set; }
        /// <summary>
        /// Рост
        /// </summary>
        public double Height { get; set; }
        #endregion
        /// <summary>
        /// Создать нового пользователя
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="gender">Гендер</param>
        /// <param name="birthDate">Дата рождения</param>
        /// <param name="weight">Вес</param>
        /// <param name="height">Рост</param>
        public User(string name, Gender gender, DateTime birthDate, double weight, double height)
        {
            #region Проверка условий
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException("Имя не может быть пустым", nameof(name));
            if (gender == null) throw new ArgumentNullException("Пол не может пыть пустым или null", nameof(gender));
            if (birthDate < DateTime.Parse("01.01.1900") || birthDate >= null) throw new ArgumentNullException(nameof(birthDate));
            if (weight <= 0) throw new ArgumentOutOfRangeException("Вес не может быть 0 или меньше",nameof(weight));
            if (height <= 0) throw new ArgumentOutOfRangeException("Рост не может быть 0 или меньше",nameof(height));
            #endregion

            this.Name = name;
            this.Gender = gender;
            this.BirthDate = birthDate;
            this.Weight = weight;
            this.Height = height;
        }
        public User(string name)
        {
            this.Name= name;
        }
        public override string ToString()
        {
            return Name;
        }
        public void Print()
        {
            Console.WriteLine($"имя: {Name} Пол: {Gender} Возраст: {BirthDate} Вес: {Weight} Рост{Height}");
        }
    }
}
