using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var myBird = new Bird();
            myBird.WingColor = "Blue";
            myBird.CanFly = true;
            myBird.willMigrate = true;
            myBird.BeakLength = 3.5;

            var lizard = new Reptile()
            {
                IsColdBlooded = true,
                IsScaly = true,
                Habitat = "swamp",
                CanGrowTail = true
            };

            var myAnimals = new Animal[] {myBird, lizard}; //instantiates animal - made an array of animals

            Console.WriteLine("Reptile & Bird!");
            Console.WriteLine("---------------------");
            Console.WriteLine();
            foreach(var Animal in myAnimals)
            {
                Console.WriteLine($"Alive:{Animal.IsAlive}");
                Console.WriteLine($"Age:{Animal.Age} years old");
                Console.WriteLine($"It has {Animal.LegCount} legs");
                Console.WriteLine($"It lives by {Animal.LandSeaAir}");
                Console.WriteLine($"");
            }   

            



            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */



            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
