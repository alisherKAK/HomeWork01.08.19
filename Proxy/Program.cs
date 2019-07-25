using System;

namespace Proxy
{
    //Proxy
    public interface IEnter
    {
        void Enter();
    }

    public class Enterer : IEnter
    {
        public void Enter()
        {
            Console.WriteLine("Logined to the system");
        }
    }

    public class EnterProxy : IEnter
    {
        private Enterer _enterer;

        public void Enter()
        {
            if(CheckPassword())
            {
                _enterer = new Enterer();
                _enterer.Enter();
            }
        }

        public bool CheckPassword()
        {
            Console.WriteLine("This method checks password");

            return true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            EnterProxy enterProxy = new EnterProxy();
            enterProxy.Enter();
        }
    }
}
