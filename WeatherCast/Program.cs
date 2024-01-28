namespace WeatherCast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherCast cast = new WeatherCast();
            Observer observer1 = new Observer(cast, "Observer1", "\t\t");
            Observer observer2 = new Observer(cast, "Observer2", "\t\t\t\t");
            Observer observer3 = new Observer(cast, "Observer3", "\t\t\t\t\t\t");
            cast.Go();
            cast.temperature = Convert.ToInt16(Console.ReadLine());
            cast.pressure = Convert.ToInt16(Console.ReadLine());
            cast.humidity = Convert.ToInt16(Console.ReadLine());
            cast.Go();
            Console.ReadKey();
        }
    }
}