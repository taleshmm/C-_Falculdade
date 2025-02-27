class Exc5 {
    public static void Executar(){
        Console.WriteLine("Digite um valor em C° para descobrir o seu equivalente em Fahrenheit e Kelvin.");

        Console.Write("Celsius: ");
        double celsius = double.Parse(Console.ReadLine()); 

        double fahrenheit = celsius * 9/5 + 32;
        double kelvin = celsius + 273.15;

        Console.WriteLine($"\nFahrenheit: {fahrenheit:F2}°F\nKelvin: {kelvin:F2}K");

    }
}