using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDI
{
    internal class EmailService : IMessageService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"{message} by email");
        }
    }
}
