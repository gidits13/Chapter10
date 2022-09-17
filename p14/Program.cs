namespace p14
{
    public class Manager : IManager
    {
        public void Create()
        {

        }

        public void Read()
        {

        }

        public void Update()
        {

        }

        public void Delete()
        {

        }
    }
    public interface IManager
    {
        void Create();
        void Update();
        void Delete();
        void Read();
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}