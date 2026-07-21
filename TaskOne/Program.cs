namespace TaskOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Islam's Carpet Cleaning Service Applicatoin ");
            Console.WriteLine("The price of small carpet is : 25 $");
            Console.WriteLine("The price of Large carpet is : 35 $");

            Console.WriteLine("Please Enter The Number of small carpets");
            int nNoSmallCarpets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter The Number of Large carpets");
            int nNoLargeCarpets = Convert.ToInt32(Console.ReadLine());

            int priceSmallCarpet = 25;
            int priceLargeCarpet = 35;
            double Taxes = 0.06;

            int TotalPriceSmallCarpets = nNoSmallCarpets * priceSmallCarpet;
            Console.WriteLine($"The Price of small carpet is : {TotalPriceSmallCarpets}");

            int TotalPriceLargeCarpets = nNoLargeCarpets * priceLargeCarpet;
            Console.WriteLine($"The Price of Large carpet is : {TotalPriceLargeCarpets}");

            int TotalPrice = TotalPriceSmallCarpets + TotalPriceLargeCarpets;
            Console.WriteLine($"Cost : {TotalPrice}");

            double TotalTaxes = TotalPrice * Taxes;
            Console.WriteLine($"Taxes is : {TotalTaxes:F2}");

            double TotalPriceWithTaxes = TotalPrice + TotalTaxes;
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine($"The Total Cost with Taxes is : {TotalPriceWithTaxes}");

            Console.WriteLine("This estimate is valid for 30 days");
        }
    }
}
