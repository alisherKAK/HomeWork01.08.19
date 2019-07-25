using System;

namespace HomeWork01_08_19
{
    //Facade
    public interface ISubsystem
    {
        string Operation();
    }

    public class DataBaseSubSystem : ISubsystem
    {
        public string Operation()
        {
            return "This subsystem wroks with database";
        }
    }

    public class FileSubSystem : ISubsystem
    {
        public string Operation()
        {
            return "This subsystem wroks with file";
        }
    }

    public class Facade
    {
        private DataBaseSubSystem _dataBaseSubSystem;
        private FileSubSystem _fileSubSystem;

        public Facade(DataBaseSubSystem dataBaseSubSystem, FileSubSystem fileSubSystem)
        {
            _dataBaseSubSystem = dataBaseSubSystem;
            _fileSubSystem = fileSubSystem;
        }

        public string Operation()
        {
            string result = "Facade initializes subsystems:\n";
            result += _dataBaseSubSystem.Operation() + "\n";
            result += _fileSubSystem.Operation() + "\n";
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DataBaseSubSystem dataBaseSubSystem = new DataBaseSubSystem();
            FileSubSystem fileSubSystem = new FileSubSystem();
            Facade facade = new Facade(dataBaseSubSystem, fileSubSystem);

            Console.WriteLine(facade.Operation());
        }
    }
}
