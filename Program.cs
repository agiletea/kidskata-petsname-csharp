using System;

namespace PetsName
{
    partial class Program
    {
        static void Main(string[] args)
        {
            PrintWord("Welcome to the Petsname Selector App!");
            PrintLine();
            SelectPetsName();            
            PrintWord("Program has completed.");
        }

        static void SelectPetsName()
        {
            // start your code here            
            string[] petNames = { "Chipper", "Buddy", "Rusty", "Jeff", "Socrates", "Darwin" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(petNames.Length - 1);
            string selectedName = petNames[randomIndex];
            PrintWord("The selected pet name is: ");
            PrintWord(selectedName);
            PrintLine();           

        }
    }
}
