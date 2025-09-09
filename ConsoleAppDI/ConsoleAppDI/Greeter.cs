using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDI
{
    internal class Greeter
    {
        private readonly IMessageService _messageService;

        // Constructor Injection
        public Greeter(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public void Greet(string name)
        {
            _messageService.SendMessage($"Hello, {name}!");
        }
    }
}
