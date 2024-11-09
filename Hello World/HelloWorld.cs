using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    internal class HelloWorld
    {
        private readonly List<Greeting> _greetings;

        public HelloWorld()
        {
            _greetings = new List<Greeting>();
        }

        public void AddGreeting(Greeting greeting)
        {
            _greetings.Add(greeting);
        }

        public void Run()
        {
            try
            {
                Console.WriteLine("Welcome to the Complex HelloWorld Program!");

                // Add the HelloWorld greeting to the list
                AddGreeting(new HelloWorldGreeting("Hello, World!"));

                // Display the normal greeting
                foreach (var greeting in _greetings)
                {
                    greeting.DisplayMessage();
                }

                // Display the reversed greeting
                string reversedMessage = GreetingUtilities.ReverseMessage("Hello, World!");
                Console.WriteLine($"Reversed Greeting: {reversedMessage}");

                // Display the capitalized greeting
                string capitalizedMessage = GreetingUtilities.CapitalizeMessage("Hello, World!");
                Console.WriteLine($"Capitalized Greeting: {capitalizedMessage}");

                // Process the greeting asynchronously
                var processor = new HelloWorldProcessor("Hello, Asynchronous World!");
                Task.Run(() => processor.ProcessGreetingAsync()).Wait();

            }
            catch (HelloWorldException hwEx)
            {
                Console.WriteLine($"Custom Error: {hwEx.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General Error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Program execution completed.");
            }
        }
    }
}
