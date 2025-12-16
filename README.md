SuperConverter
A simple Windows Forms application built with C# and .NET 8.0 for performing conversions between currencies, temperatures, and length units. This tool provides a user-friendly interface for quick conversions using hardcoded rates and factors.
Features

Currency Conversion: Supports over 150 currencies (e.g., USD, EUR, GBP, INR, etc.). Conversion rates are relative to USD and hardcoded (as of the project's creation; may not reflect current market rates).
Temperature Conversion: Convert between Celsius, Fahrenheit, and Kelvin.
Length Unit Conversion: Convert between common units like meters, kilometers, centimeters, inches, feet, and yards.
Intuitive GUI with dropdowns for unit/currency selection and real-time input validation.

Note: Currency rates are static and embedded in the code. For production use or real-time rates, consider integrating a currency API (e.g., ExchangeRate-API or similar).
Screenshots
(Add screenshots here if available, e.g., via GitHub uploads. For now, imagine a main form with sections for Currency, Temperature, and Units converters.)
Requirements

.NET 8.0 SDK or runtime
Visual Studio 2022 or later (for development and building)
Windows OS (as it's a WinForms app)

Installation

Clone the repository:textgit clone https://github.com/yourusername/SuperConverter.git
Open the solution file SuperConverter.sln in Visual Studio.
Restore NuGet packages if prompted (though no external packages are required).
Build the solution (Ctrl + Shift + B).

Usage

Run the application from Visual Studio (F5) or execute the built .exe from bin/Debug/net8.0-windows/SuperConverter.exe.
The main form will open with three conversion sections:
Currency: Enter an amount, select "From" and "To" currencies, and click "Convert".
Temperature: Enter a temperature value, select input and output units, and click "Convert".
Units (Length): Enter a length value, select "From" and "To" units, and click "Convert".

Results are displayed inline below each conversion button.

Example:

Convert 100 USD to EUR: Enter 100, select USD (From), EUR (To), click Convert → Result: ~89.59 EUR (based on hardcoded rates).

Project Structure

Form1.cs: Main form logic, including conversion methods.
Form1.Designer.cs: Auto-generated designer code for the UI.
Form1.resx: Resource file for the form.
Program.cs: Application entry point.
SuperConverter.csproj: Project file.
SuperConverter.sln: Solution file.

Limitations

Currency rates are hardcoded and may become outdated. Update the conversionRates dictionary in Form1.cs as needed.
No error handling for invalid inputs beyond basic try-catch (e.g., non-numeric amounts show a message box).
Limited to the provided units/currencies; expand by modifying the combo box items and conversion logic.
No support for mobile or cross-platform (WinForms is Windows-specific).

Contributing
Contributions are welcome! Feel free to submit pull requests for features like:

Integrating a real-time currency API.
Adding more conversion types (e.g., weight, volume).
Improving UI/UX or adding themes.

Steps:

Fork the repo.
Create a feature branch.
Commit changes.
Open a pull request.
