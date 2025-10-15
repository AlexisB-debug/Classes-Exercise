namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car();
            car1.Make = "DeLorean";
            car1.Model = "DMC-12";
            car1.Year = 1981;
            
            Console.WriteLine($"The 'Back to the Future' time machine is a {car1.Year} {car1.Make} {car1.Model}");
        }
    }
}
