namespace WeatherCast
{
    internal class Observer : IObserver
    {
        string name;
        WeatherCast subject;
        string state;
        string gap;

        public Observer(WeatherCast subject, string name, string gap)
        {
            this.state = "t, °C: " + subject.temperature.ToString() + "; p, mmHg: " + subject.pressure.ToString() + "; h, %: " + subject.humidity.ToString();
            this.name = name;
            this.gap = gap;
            subject.Notify += Update;
        }

        public void Update(string state)
        {
            this.state = state;
            Console.WriteLine(gap + name + ": " + this.state);
        }
    }
}