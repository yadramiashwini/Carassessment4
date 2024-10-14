namespace Carassessment4
{
    using System;

    public class Car
    {
        // Properties
        public string OwnerName { get; set; }
        public string BodyStyle { get; set; }
        public double Price { get; set; }

        // Method to validate car body style
        public bool ValidateCarBodyStyle()
        {
            return BodyStyle.Equals("SUV", StringComparison.OrdinalIgnoreCase) ||
                   BodyStyle.Equals("Sedan", StringComparison.OrdinalIgnoreCase);
        }

        // Method to calculate discounted price
        public double CalculateDiscountedPrice()
        {
            if (BodyStyle.Equals("SUV", StringComparison.OrdinalIgnoreCase))
            {
                return Price * 0.9; // 10% discount
            }
            else if (BodyStyle.Equals("Sedan", StringComparison.OrdinalIgnoreCase))
            {
                return Price * 0.95; // 5% discount
            }
            else
            {
                return Price; // No discount for invalid types
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a new Car object
            Car car = new Car();

            // Get car details from the user
            Console.Write("Enter the owner name: ");
            car.OwnerName = Console.ReadLine();

            Console.Write("Enter the car body style: ");
            car.BodyStyle = Console.ReadLine();

            Console.Write("Enter the price: ");
            car.Price = double.Parse(Console.ReadLine());

            // Validate the car body style
            if (!car.ValidateCarBodyStyle())
            {
                Console.WriteLine("Invalid Car Type");
                return;
            }

            // Calculate the discounted price
            double discountedPrice = car.CalculateDiscountedPrice();

            // Display the results
            Console.WriteLine($"The owner sells the {car.BodyStyle} type car for ${discountedPrice}");
        }
    }

}
