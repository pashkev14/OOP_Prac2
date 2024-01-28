namespace WeatherCast
{
    internal class WeatherCast
    {
        public delegate void Callback(string s);

        public event Callback Notify;

        public int temperature = 0;
        public int pressure = 760;
        public int humidity = 20;

        const int speed = 500;

        public string SubjectState { get; set; }

        public void Go()
        {
            new Thread(new ThreadStart(Run)).Start();
        }

        void Run()
        {
            string data = "t, °C: " + temperature.ToString() + "; p, mmHg: " + pressure.ToString() + "; h, %: " + humidity.ToString();
            Console.WriteLine("Subject: " + data);
            SubjectState = data;
            Notify(data);
            Thread.Sleep(speed);
        }
    }
}