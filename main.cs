using System;

class Program {
  public static void Main (string[] args) {
    Console.Write("Enter the wind speed in miles per hour: ");
        string input = Console.ReadLine();

        if (decimal.TryParse(input, out decimal windSpeed))
        {
            string category = GetHurricaneCategory(windSpeed);
            Console.WriteLine(category);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a numeric value for the wind speed.");
        }
    }

    static string GetHurricaneCategory(decimal windSpeed)
    {
        if (windSpeed >= 157)
        {
            return "Category 5 Hurricane";
        }
        else if (windSpeed >= 130)
        {
            return "Category 4 Hurricane";
        }
        else if (windSpeed >= 111)
        {
            return "Category 3 Hurricane";
        }
        else if (windSpeed >= 96)
        {
            return "Category 2 Hurricane";
        }
        else if (windSpeed >= 74)
        {
            return "Category 1 Hurricane";
        }
        else
        {
            return "Not a Hurricane";
        }
  }
}