using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public partial class Food
{
    public static List<string> orderedFoods = new List<string>();
    public static string nameOfRestaurant;

    public string TypeOfFood { get; set; }
    public int NumOfFood { get; set; }
    public float Price { get; set; }
    public string ingridients { get; set; }

    static Food()
    {
        nameOfRestaurant = "McDonalds";
    }

    public Food()
    {
        TypeOfFood = "NoType";
        NumOfFood = 0;
        Price = 0;
    }
    public Food(string typeOfFood, int numOfFood, float price, string _ingridients)
    {
        TypeOfFood = typeOfFood;
        NumOfFood = numOfFood;
        Price = price;
        ingridients = _ingridients;
        orderedFoods.Add(typeOfFood);
    }

    public void PrintFood()
    {
        Console.WriteLine($"Type of food: {TypeOfFood}");
        Console.WriteLine($"Number of this food: {NumOfFood}");
        Console.WriteLine($"Price of food: {Price}$");
        Console.WriteLine($"Ingridients: {ingridients}");
    }
    public static void ShowOrderedFoods()
    {
        Console.WriteLine("Order:");
        for (int i = 0; i < orderedFoods.Count; i++)
        {
            Console.WriteLine(orderedFoods[i]);
        }
    }
}

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            Food.ShowRestaurant();

            Food[] order1 = new Food[5];

            for (int i = 0; i < order1.Length; i++)
            {

                Console.WriteLine($"\n Food #{i+1}");
                Console.WriteLine("Enter the food you wanna buy:");
                string TypeOfFood = Console.ReadLine();
                Console.WriteLine("Number of ordered foods:");
                int NumOfFood = int.Parse(Console.ReadLine());
                Console.WriteLine("Price of this food:");
                float Price = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter the ingridients:");
                string ingridients = Console.ReadLine();
                order1[i] = new Food(TypeOfFood,NumOfFood,Price,ingridients);
            }

            for (int i = 0; i < order1.Length; i++)
            {
                Console.WriteLine();
                order1[i].PrintFood();
            }

            Console.WriteLine();
            Food.ShowOrderedFoods();

        }
    }
}
