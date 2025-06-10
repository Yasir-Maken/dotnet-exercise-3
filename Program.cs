// Program.cs
// It demonstrates how to programming using OOP.


// The main class where the application execution begins.
class Program
{
    // Where the program starts running.
    static void Main(string[] args)
    {
        Console.WriteLine("------ Week 3 Exercise: Objects! ------");
        Console.WriteLine("---------- Yasir QTS Intern! ----------\n");

        // ----------------------------------------------------------------------------------
        // ------------------------- Exercise 1: The Anatomy of a Class ---------------------

        // Display a welcoming message to the console.
        Console.WriteLine("--- TAsk 1: Book Catalog App! ---");
        Console.WriteLine("Let's create some book objects and see their details.\n");

        // --- Task 1: Create a Book object using the default constructor ---
        // This creates a book with default values: "Unknown" title/author, and current year.
        Console.WriteLine("Creating a book using the DEFAULT constructor:");
        Book defaultBook = new Book(); // Calling the default (parameterless) constructor

        // Call the public method to display the details of the default book.
        defaultBook.DisplayBookInfo();

        // --- Task 2: Create a Book object using the parameterized constructor ---
        // This creates a book with specific values provided during creation.
        Console.WriteLine("\nCreating a book using the PARAMETERIZED constructor:");
        Book customBook = new Book("The Hitchhiker's Guide to the Galaxy", "Douglas Adams", 1979); // Calling the parameterized constructor

        // Call the public method to display the details of the custom book.
        customBook.DisplayBookInfo();

        Console.WriteLine("\n------ Book Catalog App Finished! ------");
        Console.WriteLine(new string('-', 40)); // Separator for readability


        // ------------------------------------------------------------------------------------
        // ------------------------- Exercise 2: All About static 💡 --------------------------

        // Display a welcoming message for the Temperature Converter section.
        Console.WriteLine("\n--- Task 2: Temperature Converter App! ---");
        Console.WriteLine("----- Create a Static object to use! -----\n");

        // --- Task: Call static methods directly from the class ---
        // Convert Celsius to Fahrenheit
        double celsius1 = 25.0;
        // Call the static CelsiusToFahrenheit method directly on the class name.
        // There's no 'new TemperatureConverter()' required!
        double fahrenheit1 = TemperatureConverter.CelsiusToFahrenheit(celsius1);
        Console.WriteLine($"{celsius1}°C is {fahrenheit1}°F");

        double celsius2 = 0.0;
        double fahrenheit2 = TemperatureConverter.CelsiusToFahrenheit(celsius2);
        Console.WriteLine($"{celsius2}°C is {fahrenheit2}°F");

        Console.WriteLine();

        // Convert Fahrenheit to Celsius
        double fahrenheit3 = 68.0;
        // Call the static FahrenheitToCelsius method directly on the class name.
        double celsius3 = TemperatureConverter.FahrenheitToCelsius(fahrenheit3);
        Console.WriteLine($"{fahrenheit3}°F is {celsius3}°C");


        double fahrenheit4 = 32.0;
        double celsius4 = TemperatureConverter.FahrenheitToCelsius(fahrenheit4);
        Console.WriteLine($"{fahrenheit4}°F is {celsius4}°C");


        // --- Bonus: Demonstrating the static readonly field ---
        // We can access the static readonly field directly from the class as well.
        Console.WriteLine($"Fahrenhit Static Conversion Ratio (9/5): {TemperatureConverter.FahrenheitConversionRatio}");
        Console.WriteLine($"Celsius Conversion Ratio (5/9): {TemperatureConverter.CelsiusConversionRatio}");

        Console.WriteLine("\n--- Temperature Conversion Complete! ---");
        Console.WriteLine(new string('-', 40)); // Separator for readability


        // -----------------------------------------------------------------------------------------
        // ------------------ Exercise 3:  Method Parameters and a "TryParse" Challenge ------------

        // Display a welcoming message for the Method Parameters section.
        Console.WriteLine("\n---------- Task 3: The TryParse Challenge! ------------");
        Console.WriteLine("Let's see how we can safely parse strings into numbers.\n");

        // --- Test Case 1: Valid Integer String ---
        string validInput = "123";
        int parsedValue1; // Declare the integer variable to receive the 'out' parameter.
                          // It doesn't need to be initialized because 'out' ensures it's set.

        // Call the custom TryParseInteger method with a valid string.
        Console.WriteLine($"Attempting to parse \"{validInput}\"...");
        bool isSuccess1 = TryParseInteger(validInput, out parsedValue1); // 'out' keyword here too!

        // Check the return value to determine success or failure.
        if (isSuccess1)
        {
            Console.WriteLine($"SUCCESS! Parsed value: {parsedValue1}");
        }
        else
        {
            // This block won't be hit for validInput.
            Console.WriteLine($"FAILURE! Could not parse \"{validInput}\". Result was: {parsedValue1}");
        }

        Console.WriteLine(); // Separator for readability

        // --- Test Case 2: Invalid Integer String ---
        string invalidInput = "abc";
        int parsedValue2; // Declare another integer variable for the second test.

        // Call the custom TryParseInteger method with an invalid string.
        Console.WriteLine($"Attempting to parse \"{invalidInput}\"...");
        bool isSuccess2 = TryParseInteger(invalidInput, out parsedValue2); // 'out' keyword here too!

        // Check the return value to determine success or failure.
        if (isSuccess2)
        {
            // This block won't be hit for invalidInput.
            Console.WriteLine($"SUCCESS! Parsed value: {parsedValue2}");
        }
        else
        {
            Console.WriteLine($"FAILURE! Could not parse \"{invalidInput}\". Result was: {parsedValue2}");
        }

        Console.WriteLine(new string('-', 40)); // Separator for readability

        // --- Test Case 3: Another Valid Integer String ---
        string anotherValidInput = "-42";
        // 'out' variables can be declared directly in the method call for convenience
        // This is a C# 7.0+ feature, often called 'out variables'.
        Console.WriteLine($"Attempting to parse \"{anotherValidInput}\"...");
        if (TryParseInteger(anotherValidInput, out int parsedValue3))
        {
            Console.WriteLine($"SUCCESS! Parsed value: {parsedValue3}");
        }
        else
        {
            Console.WriteLine($"FAILURE! Could not parse \"{anotherValidInput}\". Result was: {parsedValue3}");
        }
        Console.WriteLine("\n--- TryParse Challenge Complete! ---");
    }

    // --- Task 3: Implement TryParseInteger Method ---
    /// <summary>
    /// Attempts to parse an input string into an integer.
    /// </summary>
    /// <param name="input">The string to be parsed.</param>
    /// <param name="result">An 'out' parameter that will hold the parsed integer if successful,
    /// otherwise it will be set to 0.</param>
    /// <returns>True if the parsing was successful; otherwise, false.</returns>
public static bool TryParseInteger(string input, out int result)
{
    // Use the built-in int.TryParse method for robust parsing.
    // int.TryParse itself follows the 'TryParse' pattern, returning a bool and setting an 'out' parameter.
    if (int.TryParse(input, out result)) // 'result' is assigned directly by int.TryParse
    {
        // Parsing was successful, return true.
        return true;
    }
    else
    {
        // Parsing failed. Set 'result' to its default invalid value (0 as per task).
        // This is crucial because 'out' parameters MUST be assigned a value before the method returns.
        result = 0;
        // Return false to indicate parsing failure.
        return false;
    }
}
}