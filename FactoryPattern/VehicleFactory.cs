namespace FactoryPattern
{
    public class VehicleFactory
    {
        public static  IVehicle GetVehicle(string typeofvehicle)
        {
            int vehicleType;

            bool isNumber = int.TryParse(typeofvehicle, out vehicleType);

            if (!isNumber)
            {
                Console.WriteLine("Invalid vehicle type, defaulting to car.");
                return new Car();
            }
            switch (vehicleType)
            {
                case 1:
                    return new Car();
                case 2: 
                    return new Truck();
                default: 
                    Console.WriteLine("Unknown vehicle type. Defaulting to car");
                    return new Car();
                
            }
        }
    }

}
