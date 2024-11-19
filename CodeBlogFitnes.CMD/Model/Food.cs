using System;

namespace CodeBlogFitnes.CMD.Model
{
    public class Food
    {
        public string Name { get; }
        public double Calories { get; }
        public double Fats { get; }
        public double Carbohydrates { get; }

        public Food(string name) : this(name, 0, 0, 0)
        {
            Name = name;
        }
        public Food(string name, double calories, double fats, double carbohydrates)
        {
            Name = name;
            Calories = calories;
            Fats = fats;
            Carbohydrates = carbohydrates;
        }
    }
}
