using System;

public class TemperatureConverter
{
    static void mainMenu()
    {
        Console.WriteLine("\n--This is the menu for the conversion--");
        Console.WriteLine("1: Celsius to Fahrenheit");
        Console.WriteLine("2: Fahrenheit to Celsius");
        Console.WriteLine("3: Celsius to Kelvin");
        Console.WriteLine("4: Kelvin to Celsius");
        Console.WriteLine("5: Fahrenheit to Kelvin");
        Console.WriteLine("6: Kelvin to Fahrenheit");
        Console.WriteLine("7: Exit");
    }

    static double getInputFromUser(string prompt)
    {
        Console.WriteLine(prompt);
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out double number))
                return number;
            else
                Console.WriteLine("Not a valid input, please enter a valid number.");
        }
    }

    static double performConversions(int choice, double temperature)
    {
        switch (choice)
        {
            case 1: // Celsius to Fahrenheit
                return (temperature * 9 / 5) + 32;

            case 2: // Fahrenheit to Celsius
                return (temperature - 32) * 5 / 9;

            case 3: // Celsius to Kelvin
                return temperature + 273.15;

            case 4: // Kelvin to Celsius
                return temperature - 273.15;

            case 5: // Fahrenheit to Kelvin
                return (temperature - 32) * 5 / 9 + 273.15;

            case 6: // Kelvin to Fahrenheit
                return (temperature - 273.15) * 9 / 5 + 32;

            default:
                Console.WriteLine("Invalid conversion type");
                return double.NaN;
        }
    }

    public static void TemperatureConverterProcess()
    {
        Console.WriteLine("--Welcome to the Temperature Converter--");
        bool keepConverting = true;

        while (keepConverting)
        {
            mainMenu();
            Console.Write("\nSelect an option from 1-7: ");
            if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > 7)
            {
                Console.WriteLine("You have selected an invalid choice, please select a number between 1-7.");
                continue;
            }

            if (choice == 7)
            {
                keepConverting = false;
                Console.WriteLine("Thank you for using the Temperature Converter!");
                break;
            }

            double temperature = getInputFromUser("Enter the temperature to convert: ");
            double result = performConversions(choice, temperature);

            if (!double.IsNaN(result))
                Console.WriteLine($"Converted result: {result}");
        }
    }
}
