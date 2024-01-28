namespace Simulator
{
    class Subject
    {
        public delegate void Callback(string s);

        public event Callback Notify;

        Simulator simulator = new Simulator();

        const int speed = 200;

        public string SubjectState { get; set; }

        public void Go()
        {
            new Thread(new ThreadStart(Run)).Start();
        }

        void Run()
        {
            foreach (string s in simulator)
            {
                Console.WriteLine("Subject: " + s);
                SubjectState = s;
                Notify(s);
                Thread.Sleep(speed); // milliseconds
            }
        }
    }
}