// Define the TemperatureConverter class as 'static'.

public static class TemperatureConverter
{
    // --- Static Readonly Field (Bonus) ---
    public static readonly double FahrenheitConversionRatio = 9.0 / 5.0; // 9/5 as a double
    public static readonly double CelsiusConversionRatio = 5.0 / 9.0; // 5/9 as a double


    // --- Static Method: CelsiusToFahrenheit ---
    /// <summary>
    /// Converts a temperature from Celsius to Fahrenheit.
    /// Formula: Fahrenheit = (Celsius * 9/5) + 32
    /// </summary>
    /// <param name="celsius">The temperature in Celsius.</param>
    /// <returns>The equivalent temperature in Fahrenheit.</returns>
    public static double CelsiusToFahrenheit(double celsius)
    {
        // Use the static readonly field for the conversion ratio.
        return (celsius * FahrenheitConversionRatio) + 32;
    }

    // --- Static Method: FahrenheitToCelsius ---
    // Another static method for the reverse conversion.
    /// <summary>
    /// Converts a temperature from Fahrenheit to Celsius.
    /// Formula: Celsius = (Fahrenheit - 32) * 5/9
    /// </summary>
    /// <param name="fahrenheit">The temperature in Fahrenheit.</param>
    /// <returns>The equivalent temperature in Celsius.</returns>
    public static double FahrenheitToCelsius(double fahrenheit)
    {
        // Use the static readonly field for the conversion ratio.
        return (fahrenheit - 32) * CelsiusConversionRatio;
    }
}