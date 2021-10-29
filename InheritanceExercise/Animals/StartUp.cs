using System;
namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string command = Console.ReadLine();
            
            
            while(command!="Beast!")
            {
                Animal animal;
                string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                int age = int.Parse(input[1]);
                string gender = input[2];
                if (age > 0)
                {
                    if (command == "Cat")
                    {
                        animal = new Cat(name, age, gender);
                    }
                    else if (command == "Dog")
                    {
                        animal= new Dog(name, age, gender);
                    }
                    else if (command == "Frog")
                    {
                       animal = new Frog (name, age, gender);
                    }
                    else if (command == "Kitten")
                    {
                        animal= new Kitten(name, age);
                    }
                    else if (command == "Tomcat")
                    {
                        animal= new Tomcat(name, age);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                        command = Console.ReadLine();
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    command = Console.ReadLine();
                    continue;
                }
                Console.WriteLine(animal);
                command = Console.ReadLine();
            }
        }
    }
}
