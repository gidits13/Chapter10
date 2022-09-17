namespace p22
{
    public interface IWorker
    {
        public void Build();
    }
    public interface IWriter
    {
        void Write();
    }
    public class Writer : IWriter
    {
        void IWriter.Write()
        { }

    }

    public class Worker : IWorker
    {
        public void Build()
        {
            throw new NotImplementedException();
        }
    }

    public class Worker2 : IWorker
    {
        void IWorker.Build()
        {
            throw new NotImplementedException();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var writer = new Writer();
            ((IWriter) writer).Write();

            var Worker2 = new Worker2();
            ((IWorker) Worker2).Build();
            Console.WriteLine("Hello, World!");
        }
    }
}