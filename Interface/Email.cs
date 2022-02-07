using System;

namespace Interface
{
    public class Email : ISendable
    {
        private string email = "richie.kwon1@gmail.com";

        public void Send(string msg)
        {
            Console.WriteLine($"Email {msg} to {email}");
        }
    }
}