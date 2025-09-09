// See https://aka.ms/new-console-template for more information


namespace ConsoleAppDI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            EmailService emailService = new EmailService();

            Greeter greeter = new Greeter(emailService);
            greeter.se




        }
    }
}
