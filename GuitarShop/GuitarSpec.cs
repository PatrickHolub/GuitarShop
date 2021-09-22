using System;
using System.Collections.Generic;
using System.Text;

namespace GuitarShop
{
    class GuitarSpec
    {
        public string Model { get; set; }
        public Type GuitarType { get; set; } //this is using the enum of "Type" in order to force certain inputs for the GuitarType
        public Wood Backwood { get; set; }
        public Wood Topwood { get; set; }
        public int numOfStrings { get; set; }
        public Builder GuitarBuilder { get; set; }
        /*
         * You want to achieve low coupling if possible. It can be done thorugh using delegation.
         * */

        public GuitarSpec(string model, Type type, Wood backwood, Wood topwood, int numOfStrings, Builder builder)
        {
            this.Model = model;
            this.GuitarType = type;
            this.Backwood = backwood;
            this.Topwood = topwood;
            this.numOfStrings = numOfStrings;
            this.GuitarBuilder = builder;
        }

        public bool matches(GuitarSpec searchGuitar)
        {
            {
                if (!searchGuitar.Model.Equals(this.Model))
                {
                    return false;
                }
                if (!searchGuitar.GuitarType.Equals(this.GuitarType))
                {
                    return false; 
                }
                if (!searchGuitar.Backwood.Equals(this.Backwood))
                {
                    return false;
                }
                if (!searchGuitar.Topwood.Equals(this.Topwood))
                {
                    return false;
                }
                if (!searchGuitar.GuitarBuilder.Equals(this.GuitarBuilder))
                {
                    return false;
                }
                if (!(searchGuitar.numOfStrings == this.numOfStrings))
                {
                    return false;
                }
                return true;
            }
        }

    }
}
