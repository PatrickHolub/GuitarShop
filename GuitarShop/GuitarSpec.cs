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
        // public int numOfString { get; set; }
        public Builder GuitarBuilder { get; set; }

        public GuitarSpec(string model, Type type, Wood backwood, Wood topwood, Builder builder)
        {
            this.Model = model;
            this.GuitarType = type;
            this.Backwood = backwood;
            this.Topwood = topwood;
            //    this.numOfString = numOfString;
            this.GuitarBuilder = builder;
        }
    }
}
