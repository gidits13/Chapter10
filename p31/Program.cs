namespace p31
{
    public interface IWriter
    {
        void Write();
    }

    public interface IReader
    {
        void Read();
    }

    public interface IMailer
    {
        void SendEmail();
    }

    public class FileManager : IWriter, IReader, IMailer
    {
        void IReader.Read()
        {
            throw new NotImplementedException();
        }

        void IMailer.SendEmail()
        {
            throw new NotImplementedException();
        }

        void IWriter.Write()
        {
            throw new NotImplementedException();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}