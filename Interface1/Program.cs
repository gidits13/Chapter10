using System;
namespace Interface1
{
    internal class Program
    {
        static Ilogger Logger { get; set; }
        static void Main(string[] args)
        {
            Logger = new Logger();
            var Worker1 = new Worker1(Logger);
            Worker1.Work();
        }
    }

    public interface Ilogger
    {
        void Error(string message);
        void Event(string message);

    }
    public interface IWorker
    {
        void Work();
    }
}