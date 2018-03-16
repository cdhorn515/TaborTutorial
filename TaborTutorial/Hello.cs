using System;
namespace TaborTutorial
{
    public class Hello
    {
        public void sayHello() {
            Console.WriteLine("What's your name again?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello from the hello class, {name}!");
        }

    }
}
