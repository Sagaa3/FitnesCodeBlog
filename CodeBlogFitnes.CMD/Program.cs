using CodeBlogFitnes.CMD.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CodeBlogFitnes.CMD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserController uControler = new UserController();

            Console.WriteLine("Привет");
            Console.WriteLine("Что делаем? загрузить[n] | по новой[y]");
            string temp = Console.ReadLine();
            if (temp == "n")
            {
                uControler.Load();
                uControler.Print();
            }

            Console.WriteLine("Введите свое имя:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите свой пол");
            string gender = Console.ReadLine();

            Console.WriteLine("Введите свою дату рождения");
            DateTime birthDaTA = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Введите ваш вес");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите ваш рост");
            double height = double.Parse(Console.ReadLine());

            uControler = new UserController(name,gender,birthDaTA,weight, height);

            Console.WriteLine("Сохранить?");
            temp = Console.ReadLine();
            if (temp == "да")
            {
                uControler.Save();
                Console.WriteLine("Сохранено");
            }
        }
    }
}
