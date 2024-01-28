namespace Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject Subject = new Subject();
            Observer Observer = new Observer(Subject, "Center", "\t\t");
            Observer Observer2 = new Observer(Subject, "Right", "\t\t\t\t");
            Subject.Go();
            Console.ReadKey();
        }
    }
}