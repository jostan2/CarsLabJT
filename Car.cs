using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsLabJT
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        public Car()  //no arg / empty constructor. gives above variables to default (zero in this case?).
        {

        }
        
        public Car(string Make, string Model, int Year, decimal Price) // constructor w/ 4 arg
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.Price = Price;
        }

        //toSring Override - will return the type of the object by default.
        // if overriding, can be customized.
        //anytime an object will be turned into a string, the toString() method gets called.
        //useful for printing out the results of an object (?)

        //put all the data into a string, and return it.
        public override string ToString()
        {
            string output = ($"Make: {Make}, Model: {Model}, Year: {Year}, Price: ${Price}");
            return output;
        }

    }
}
