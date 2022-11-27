using System;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Adventure of Assignment 5!");

            // TODO: Create an inventory
            // TODO: Add 2 items to the inventory
            // Verify the number of items in the inventory.

            Inventory inventory = new Inventory(5);
            var axe = new Item("Axe", 1, ItemGroup.Equipment);
            var potion = new Item("Health Potion", 3, ItemGroup.Consumable);
            inventory.AddItem(potion);
            inventory.AddItem(axe);
            Console.WriteLine(inventory.AvailableSlots);

        }
    }
}
