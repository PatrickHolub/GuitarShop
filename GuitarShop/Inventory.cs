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
                if (!searchGuitar.Model.ToUpper().Equals(g.guitarSpec.Model.ToUpper()) && !searchGuitar.Model.Equals("") && searchGuitar.Model != null) //searches if it DOES NOT HAVE, if doesn't have it
                {                                                                                                       //it will continue with a new iteratio of the loop
                    continue;
                }
                if(!searchGuitar.GuitarType.Equals(g.guitarSpec.GuitarType) && !searchGuitar.GuitarType.Equals("") && searchGuitar.GuitarType != null)
                {
                    continue;
                }
                if(!searchGuitar.Backwood.Equals(g.guitarSpec.Backwood) && !searchGuitar.Backwood.Equals("") && searchGuitar.Backwood != null)
                {
                    continue;
                }
                if (!searchGuitar.Topwood.Equals(g.guitarSpec.Topwood) && !searchGuitar.Topwood.Equals("") && searchGuitar.Topwood != null)
                {
                    continue;
                }
                if (!searchGuitar.GuitarBuilder.Equals(g.guitarSpec.GuitarBuilder) && !searchGuitar.GuitarBuilder.Equals("") && searchGuitar.GuitarBuilder != null)
                {
                    continue;
                }
                searchResults.Add(g);
                    
            }
            
            return searchResults;
        }



    }
}
