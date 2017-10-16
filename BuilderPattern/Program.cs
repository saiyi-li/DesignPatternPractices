using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MealBuilder mealBuilder = new MealBuilder();
            Meal vegMeal = mealBuilder.PrepareVegMeal();
            Console.WriteLine("Veg Meal");
            vegMeal.ShowItems();
            Console.WriteLine("Total Cost: " + vegMeal.GetCost());

            Meal nonVegMeal = mealBuilder.PrepareNonVegMeal();
            Console.WriteLine("Non-Veg Meal");
            nonVegMeal.ShowItems();
            Console.WriteLine("Total Cost: " + nonVegMeal.GetCost());

            Console.Read();
        }
    }
}
