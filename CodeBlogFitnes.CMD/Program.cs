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
            Console.WriteLine("Введите своё имя");
            string name = Console.ReadLine();

            var userController = new UserController(name);

            if(userController.IsNewUser)
            {
                Console.WriteLine("Введите пол");
                var gender = Console.ReadLine();
                Console.Write("Введите дату рождения");
                DateTime birthData = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Введите вес");
                double weight = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите рост");
                double height = double.Parse(Console.ReadLine());

                userController.SetNewUserData(gender, birthData, weight, height);
            }
            
            
            Console.WriteLine(userController.currentUser);
            Console.ReadLine();

        }
    }
}
