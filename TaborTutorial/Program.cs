using System;

namespace TaborTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();
         
            Console.WriteLine("How old are you? ");
            int age = int.Parse(Console.ReadLine());
            //or int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 21) {
                Console.WriteLine($"Hello {name}, you are {age} years old, would you like a drink?");
            } else {
                Console.WriteLine($"Hello {name}, you are {age} years old, would you like some coffee?");
            }

            int[] numbers = new int[5];

            numbers[0] = 1;
            numbers[1] = 5;
            numbers[2] = 34;
            numbers[3] = 72;
            numbers[4] = 0;


            //Console.WriteLine(numbers[3]);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            // can also loop using foreach:
            foreach (int number in numbers)
            {
                Console.WriteLine($"Number in numbers array {number}.");
            }
            Console.WriteLine("Pick a number between 1 and 5: ");
            int pickANumber = 0;
            while (pickANumber ==0) {                   
                try{
                     pickANumber = Convert.ToInt32(Console.ReadLine());
                     switch (pickANumber)
                     {
                        case 1:
                            Console.WriteLine($"You picked the first number, {numbers[0]}");
                            break;
                        case 2:
                            Console.WriteLine($"You picked the second number, {numbers[1]}");
                            break;
                        case 3:
                            Console.WriteLine($"You picked the third number, {numbers[2]}");
                            break;
                        case 4:
                            Console.WriteLine($"You picked the fourth number, {numbers[3]}");
                            break;
                        case 5:
                            Console.WriteLine($"You picked the fifth number, {numbers[4]}");
                            break;
                        default:
                            Console.WriteLine("Read the directions and try again!");
                            pickANumber = 0;
                            break;
                        }
                } catch(Exception e) {
                    Console.WriteLine("That's not quite what I'm asking for.");
                    var except = e;
                    pickANumber = 0;
                    Console.WriteLine("Try again!");
                }
           }

            char[] nameArray = name.ToCharArray();
            //Array.Reverse(nameArray);
            //foreach (char letter in nameArray)
            //{
            //    Console.Write(letter);
            //}
            Console.Write("Your name backwards is: ");
            for (int i = nameArray.Length - 1; i >= 0; i--) {
                Console.Write(nameArray[i]);
            }
            Console.WriteLine();

            //sayHello(name);
            //Hello hi = new Hello();
            //var instance = new Hello();
            //instance.sayHello();
            Hello hi = new Hello();
            hi.sayHello();

        }

        //static void sayHello(string name) {
        //    Console.WriteLine($"Hello there {name}.");
        //}


    }
}
