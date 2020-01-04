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
            PrintLine();
            PrintWord("Program has completed. Press any key to exit");
        }

        static void SelectPetsName()
        {
            // start your code here
            string[] petNames = { "Derek", "Fred", "Dave", "Buddy", "Zeyd" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(petNames.Length - 1);
            string selectedName = petNames[randomIndex];
            PrintWord("The selected pet name is: ");
            PrintWord(selectedName);
        }
    }
}
