namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter vehicle type number 1 for Car,2 for Truck.");
            string vehicleType = Console.ReadLine();

            IVehicle vehicle = VehicleFactory.GetVehicle(vehicleType);
            vehicle.Drive();
        }
    }
}
