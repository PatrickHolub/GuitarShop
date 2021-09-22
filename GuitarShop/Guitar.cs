using System;
using System.Collections.Generic;
using System.Text;

namespace GuitarShop
{
    class Guitar
    {

        public string SerialNum { get; set; }
        public double Price { get; set; }

        public GuitarSpec guitarSpec { get; set; } //in order to deal with duplicate code you can use both inheritence or encapsulation 
                                                   //whichever one makes the most sense
                                                   
        

        public Guitar(string serialNum, double price, GuitarSpec gSpec)
        {
            this.SerialNum = serialNum;
            this.Price = price;
            this.guitarSpec = gSpec;

        }






    }
}
