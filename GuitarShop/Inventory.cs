using System;
using System.Collections.Generic;
using System.Text;

namespace GuitarShop
{
    class Inventory
    {
        List<Guitar> guitars;

        public Inventory()
        {
            guitars = new List<Guitar>();
        }
/*
        public void addGuitar(string serialNum, double price, string model, string type, string backwood, string topwood, int numOfString, string builder)
        {
            Guitar g = new Guitar(serialNum, price, model, type, backwood, topwood, numOfString, builder);
            guitars.Add(g);
        }
*/

        public void addGuitar(Guitar g)
        {
            guitars.Add(g);
        }

        public List<Guitar> search(GuitarSpec searchGuitar)
        {
            List<Guitar> searchResults = new List<Guitar>();
            foreach(Guitar g in guitars)
            {
                if(g.guitarSpec.matches(searchGuitar) == true){ //We moved the search method to the GuitarSpec class, in which we can now call
                                                                //in order to serch through our list of guitars in order to find a match
                                                                //we have now loosely coupled the search method to guitarspec, so if we add 
                                                                //attributes we only have to make a change to one class
                
                    searchResults.Add(g);
                }
                
                    
            }
            
            return searchResults;
        }



    }
}
