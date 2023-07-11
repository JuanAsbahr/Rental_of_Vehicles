using Rental_of_Vehicles.Entities;
using Rental_of_Vehicles.Services;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("ENTER RENTAL DATA");
        Console.Write("Vehicle model: ");
        string model = Console.ReadLine();

        Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
        DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
        Console.Write("Return (dd/MM/yyyy hh:mm): ");
        DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

        Console.Write("Enter price per hour: $");
        double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Enter price per day: $");
        double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Rental rental = new Rental(start, finish, new Vehicle(model));

        RentalService rentalService = new RentalService(hour, day);

        rentalService.ProcessInvoice(rental);

        Console.WriteLine("INVOICE:");
        Console.WriteLine(rental.Invoice);

    }
}