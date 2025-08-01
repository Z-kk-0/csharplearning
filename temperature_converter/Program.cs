namespace temperature_converter;

class Program
{
    static void Main(string[] args)
    {
        double temperature;
        double convertedTemp;

        Console.WriteLine("please input a temperature");

        string? input1 = Console.ReadLine();

        if (!double.TryParse(input1, out temperature))
        {
            Console.WriteLine("Invalid number. Please enter a valid Temperature");
            return;
        }

        Console.WriteLine("Convert to Celsius(C) or Farenheit(F)?");
        string? measurement = Console.ReadLine()?.Trim().ToUpper();

        switch (measurement) {
            case "F":
                Console.WriteLine("Converting to Fahrenheit");
                convertedTemp = (temperature * 9/5) + 32;
                Console.WriteLine($"{temperature:F2} °C is {convertedTemp:F2} °F");
                break;
            case "C":
                Console.WriteLine("Converting to Celsius");
                convertedTemp = (temperature - 32) * 5 / 9;
                Console.WriteLine($"{temperature:F2} °F is {convertedTemp:F2} °C");
                break;
            default:
                Console.WriteLine("Invalid Option. Please enter C or F");
                break; 
        }


    }
}
