using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    public class HelloWorldException : Exception
    {
        public HelloWorldException(string message) : base(message) { }
    }
    // Base class to represent a greeting
    public abstract class Greeting
    {
        public string Message { get; set; }

        public Greeting(string message)
        {
            Message = message;
        }

        public abstract void DisplayMessage();
    }

    // Class that extends Greeting to implement a specific HelloWorld greeting
    public class HelloWorldGreeting : Greeting
    {
        public HelloWorldGreeting(string message) : base(message) { }

        public override void DisplayMessage()
        {
            Console.WriteLine(Message);
        }
    }

    // A class that uses multithreading to demonstrate asynchronous operations
    public class HelloWorldProcessor
    {
        private string _message;

        public HelloWorldProcessor(string message)
        {
            _message = message;
        }

        public async Task ProcessGreetingAsync()
        {
            try
            {
                Console.WriteLine("Processing greeting...");
                await Task.Delay(1000);  // Simulate some async work, like waiting for a network response or file read
                Console.WriteLine("Processing complete.");
                DisplayGreeting();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred: {ex.Message}");
            }
        }

        public void DisplayGreeting()
        {
            Console.WriteLine($"Greeting: {_message}");
        }
    }

    // A utility class for string manipulation related to the greeting
    public static class GreetingUtilities
    {
        public static string ReverseMessage(string message)
        {
            char[] charArray = message.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static string CapitalizeMessage(string message)
        {
            return message.ToUpper();
        }
    }
}
