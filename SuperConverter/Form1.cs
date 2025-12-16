namespace SuperConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double inputTemperature = double.Parse(textBox2.Text);
            string inputUnit = comboBox4.SelectedItem.ToString();
            string outputUnit = comboBox3.SelectedItem.ToString();
            double result = ConvertTemperature(inputTemperature, inputUnit, outputUnit);
            label7.Text = $"Result: {result} {outputUnit}";
        }

        private double ConvertTemperature(double value, string fromUnit, string toUnit)
        {
            if (fromUnit == toUnit)
                return value;

            // Convert from input unit to Celsius
            if (fromUnit == "Fahrenheit")
                value = (value - 32) * 5 / 9;
            else if (fromUnit == "Kelvin")
                value = value - 273.15;

            // Convert from Celsius to output unit
            if (toUnit == "Fahrenheit")
                value = (value * 9 / 5) + 32;
            else if (toUnit == "Kelvin")
                value = value + 273.15;

            return value;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the user input value
                double value = double.Parse(textBox3.Text);

                // Get the selected units
                string fromUnit = comboBox6.SelectedItem.ToString();
                string toUnit = comboBox5.SelectedItem.ToString();

                // Perform the conversion
                double result = ConvertUnit(value, fromUnit, toUnit);

                // Display the result
                label12.Text = $"Result: {result} {toUnit}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private double ConvertUnit(double value, string fromUnit, string toUnit)
        {
            // Dictionary to hold conversion factors (from unit to meters)
            Dictionary<string, double> conversionFactors = new Dictionary<string, double>
    {
        { "meter", 1.0 },
        { "kilometer", 1000.0 },
        { "centimeter", 0.01 },
        { "inch", 0.0254 },
        { "foot", 0.3048 },
        { "yard", 0.9144 }
        // Add more units and their factors as needed
    };

            // Convert value to meters
            double valueInMeters = value * conversionFactors[fromUnit];

            // Convert from meters to the target unit
            double convertedValue = valueInMeters / conversionFactors[toUnit];

            return convertedValue;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double amount = double.Parse(textBox1.Text);
                string fromCurrency = comboBox1.SelectedItem.ToString();
                string toCurrency = comboBox2.SelectedItem.ToString();
                double result = ConvertCurrency(amount, fromCurrency, toCurrency);
                label6.Text = $"Result: {result} {toCurrency}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private double ConvertCurrency(double amount, string fromCurrency, string toCurrency)
        {
            // Conversion rates relative to USD
            Dictionary<string, double> conversionRates = new Dictionary<string, double>
    {

        {"USD", 1},
        {"AED", 3.6725},
        {"AFN", 70.7612},
        {"ALL", 89.4601},
        {"AMD", 387.9771},
        {"ANG", 1.79},
        {"AOA", 912.7455},
        {"ARS", 948.17},
        {"AUD", 1.4796},
        {"AWG", 1.79},
        {"AZN", 1.7003},
        {"BAM", 1.7523},
        {"BBD", 2},
        {"BDT", 119.4651},
        {"BGN", 1.7525},
        {"BHD", 0.376},
        {"BIF", 2877.9574},
        {"BMD", 1},
        {"BND", 1.3052},
        {"BOB", 6.9179},
        {"BRL", 5.5808},
        {"BSD", 1},
        {"BTN", 83.8763},
        {"BWP", 13.3838},
        {"BYN", 3.2302},
        {"BZD", 2},
        {"CAD", 1.3535},
        {"CDF", 2827.8587},
        {"CHF", 0.8495},
        {"CLP", 918.7255},
        {"CNY", 7.1315},
        {"COP", 4011.8437},
        {"CRC", 523.0976},
        {"CUP", 24},
        {"CVE", 98.7886},
        {"CZK", 22.4924},
        {"DJF", 177.721},
        {"DKK", 6.683},
        {"DOP", 59.6881},
        {"DZD", 133.8477},
        {"EGP", 48.7877},
        {"ERN", 15},
        {"ETB", 109.753},
        {"EUR", 0.8959},
        {"FJD", 2.2123},
        {"FKP", 0.7593},
        {"FOK", 6.683},
        {"GBP", 0.7593},
        {"GEL", 2.6982},
        {"GGP", 0.7593},
        {"GHS", 15.7015},
        {"GIP", 0.7593},
        {"GNF", 8641.5604},
        {"GTQ", 7.7363},
        {"GYD", 209.0901},
        {"HKD", 7.7981},
        {"HNL", 24.7551},
        {"HRK", 6.7503},
        {"HTG", 131.5406},
        {"HUF", 352.985},
        {"IDR", 15502.352},
        {"ILS", 3.6947},
        {"IMP", 0.7593},
        {"INR", 83.8763},
        {"IQD", 1308.1828},
        {"IRR", 42062.5003},
        {"ISK", 136.9541},
        {"JEP", 0.7593},
        {"JMD", 156.6016},
        {"JPY", 145.1715},
        {"KES", 128.7643},
        {"KGS", 85.5639},
        {"KHR", 4070.9873},
        {"KMF", 440.7637},
        {"KRW", 1334.2035},
        {"KWD", 0.3053},
        {"KYD", 0.8333},
        {"KZT", 480.8691},
        {"LAK", 21949.2973},
        {"LBP", 89500},
        {"LSL", 17.8265},
        {"LYD", 4.7757},
        {"MAD", 9.675},
        {"MDL", 17.4531},
        {"MGA", 4559.1415},
        {"MKD", 55.3002},
        {"MMK", 2099.854},
        {"MNT", 3398.2001},
        {"MOP", 8.0321},
        {"MRU", 39.7464},
        {"MUR", 45.9647},
        {"MVR", 15.4369},
        {"MWK", 1743.4685},
        {"MXN", 19.2331},
        {"MYR", 4.377},
        {"MZN", 63.9033},
        {"NAD", 17.8265},
        {"NGN", 1563.8049},
        {"NIO", 36.7777},
        {"NOK", 10.5202},
        {"NPR", 134.202},
        {"NZD", 1.6155},
        {"OMR", 0.3845},
        {"PAB", 1},
        {"PEN", 3.745},
        {"PGK", 3.9107},
        {"PHP", 56.305},
        {"PKR", 278.7702},
        {"PLN", 3.8329},
        {"PYG", 7593.9256},
        {"QAR", 3.64},
        {"RON", 4.4751},
        {"RSD", 105.1751},
        {"RUB", 91.4472},
        {"RWF", 1343.8726},
        {"SAR", 3.75},
        {"SBD", 8.4938},
        {"SCR", 13.4566},
        {"SDG", 508.7424},
        {"SEK", 10.2053},
        {"SGD", 1.3052},
        {"SHP", 0.7593},
        {"SLE", 22.4148},
        {"SLL", 22414.795},
        {"SOS", 571.3847},
        {"SRD", 29.1426},
        {"SSP", 2895.0544},
        {"STN", 21.95},
        {"SYP", 12847.0927},
        {"SZL", 17.8265},
        {"THB", 34.1093},
        {"TJS", 10.603},
        {"TMT", 3.4995},
        {"TND", 3.0409},
        {"TOP", 2.3257},
        {"TRY", 34.0085},
        {"TTD", 6.7689},
        {"TVD", 1.4796},
        {"TWD", 31.8106},
        {"TZS", 2693.6456},
        {"UAH", 41.2499},
        {"UGX", 3715.7831},
        {"UYU", 40.2325},
        {"UZS", 12668.8149},
        {"VES", 36.5888},
        {"VND", 24980.6325},
        {"VUV", 118.2927},
        {"WST", 2.6968},
        {"XAF", 587.6849},
        {"XCD", 2.7},
        {"XDR", 0.7429},
        {"XOF", 587.6849},
        {"XPF", 106.9119},
        {"YER", 250.1752},
        {"ZAR", 17.7958},
        {"ZMW", 26.0973}
    };

            // Convert amount to USD
            double amountInUSD = amount / conversionRates[fromCurrency];

            // Convert from USD to target currency
            double convertedAmount = amountInUSD * conversionRates[toCurrency];

            return convertedAmount;
        }
    }
}
