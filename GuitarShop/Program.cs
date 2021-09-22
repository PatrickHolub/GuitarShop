using System;
using System.Collections.Generic;

namespace GuitarShop
{
    class Program
    {
        static void Main(string[] args) 
            
            /*
            the very fist step in writing good software is to make it do what the customer wants 
            start with pencil and paper, figure out the classes and attributes, draw out a UML, then start the code
            code incramentally, one step at a time, to help understand and build the software (start with simple logic,
            if it works, add complexitly to it)

            The second step is that every object or class or program should be named after what it is designed to do. 
                1) Object of a class should only do what its name indicates.
                2) Each object (or class) should represent a single concept [Cohesion Principle]. Always try to achieve 
                   high coehesion in our software. 
                3) Whenever object has unused properties, then try to simplify the object
            */
        {
            Inventory inventory = new Inventory();
            initalizeInventory(inventory);

            GuitarSpec customerChoice = new GuitarSpec("Stratocaster", Type.ACOUSTIC, Wood.ROSEWOOD, Wood.MAPLE, Builder.FENDER);

            List<Guitar> result = inventory.search(customerChoice);
            if(result.Count != 0)
            {
                Console.WriteLine("Congratulations, we found your choice of guitars!");
            }
            else
            {
                Console.WriteLine("Sorry, we have no guitar of your choice in our inventory.");
            }


        }

        public static void initalizeInventory(Inventory inventory)
        {
            inventory.addGuitar(new Guitar("A124", 569.99, new GuitarSpec( "stratocaster",Type.ACOUSTIC, Wood.ROSEWOOD, Wood.MAPLE, Builder.FENDER))); //these are using the enum modifiers to where the attibutes can only be of a specific type
            inventory.addGuitar(new Guitar("E456", 789.99, new GuitarSpec( "telecaster", Type.ELECTRIC, Wood.ALDER, Wood.MAHOGANY, Builder.MARTIN)));
        }

    }
}
