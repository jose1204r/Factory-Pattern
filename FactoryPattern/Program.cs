namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {

            int wcount;
            bool imput = false;




            do
            {
                
                Console.WriteLine("Plase enter the  number of wheels of the vehicle : ");
                var userImput = int.TryParse(Console.ReadLine(), out wcount);


            } while (imput == false);

                    var vh = VehicleFactory.GetVehicle(wcount);
                    vh.drive();

                

        }
    }
}
