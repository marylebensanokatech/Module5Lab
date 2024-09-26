using System; //Includes the classes for reading & writing to the console

namespace ZooLab
{
    class Program {
        static void Main(string[] args) {
            //Prompt the user to enter the number of animals and read in the number of animals
            Console.Write("Enter the number of animals in the zoo: ");
            int animalCount = int.Parse(Console.ReadLine());

            //Declare and initialize an array to hold the animals
            string[] animals = new string[animalCount];

            //Populate the array with user-defined animal names
            for (int i = 0; i < animalCount; i++) {
                //Prompt the user to enter an animal name and read the name
                Console.Write($"Enter animal name {i + 1}: ");

                //Read in the animal name and assign it to an element in the array
                animals[i] = Console.ReadLine();
            } //end for loop

            //Display the list of animals using a for each loop
            Console.WriteLine("List of Zoo Animals: ");
            foreach(string animal in animals) {
                Console.WriteLine(animal);
            }//end for each loop
        }//end main method
    }//end class
}//end namespace
