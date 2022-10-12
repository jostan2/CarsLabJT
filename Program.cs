using System;

namespace CarsLabJT
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            bool start = true;
            while (start == true)
            {

                //make list of cars here, put 3 used and 3 new cars.
                //ignore "remove" method. See list method of 
                //see list method of RemoteAt(int index) (theres one built in)
                //google overriding toString in c#

                Car c = new Car("make0", "model0", 2000, 10000);
                //Console.WriteLine(c); // because of the toString override, Type Coercion(?)

                List<Car> carsInventory = new List<Car>();
                carsInventory.Add(c);

                carsInventory.Add(new Car("make1", "model1", 2001, 2500.00m));
                carsInventory.Add(new Car("make2", "model2", 2002, 5000));
                carsInventory.Add(new Car("make3", "model3", 2003, 6000.00m));

                carsInventory.Add(new UsedCar("make4", "model4", 2004, 8000, 1000)); //remember to add in milage for used cars
                carsInventory.Add(new UsedCar("make5", "model5", 2005, 7000, 5000));
                carsInventory.Add(new UsedCar("make6", "model6", 2006, 3000, 74508));

                Console.WriteLine("Car Inventory");
                Console.WriteLine("------------------------------------------------------------------");
                PrintList(carsInventory); //list carsInventory
                Console.WriteLine();

                Console.WriteLine("Which car would you like to buy? Please select by index 1-7");
<<<<<<< HEAD
                int userinput = -1;
				while (userinput == -1)
				{
					try
					{
						userinput = int.Parse(Console.ReadLine());
					}
					catch (FormatException)
					{
						Console.WriteLine("that wasnt an index in our system! try again");
					}
                    if (!(userinput <= carsInventory.Count && userinput > 0))
                    {
						Console.WriteLine("that wasnt an index in our system! try again");
						userinput = -1;
					}
				}
				Console.WriteLine();
                Console.WriteLine(carsInventory.ElementAt(userinput-1).ToString()); //prints out user's selection
                Console.WriteLine();
=======

                try
                {
                    int userinput = int.Parse(Console.ReadLine());

                    if (userinput > 0 && userinput < 8)
                    {
                        Console.WriteLine(carsInventory.ElementAt(userinput - 1).ToString()); //prints out user's selection
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Your input was not a valid number, please try again. Enter a number between 1-7.");
                        Console.WriteLine();
                        continue;
                    }                        
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Your input was not a valid number please try again, the valid range for indexes is 1 to 7.");
                    Console.WriteLine(e.Message);
                    continue;
                    Console.WriteLine();
                }
>>>>>>> 0eb566cbe14320315a55476c68d0975773dfc00d

                //remove car from list
                Console.WriteLine("Which car would you like to remove? Please select by index. Type 0 to quit.");
                string input = Console.ReadLine();
                int pick = int.Parse(input);
                Remove(pick-1, carsInventory);
               
                Console.WriteLine();

                start = restart();
            }
        }

        public static void Remove(int pick, List<Car> carsInventory)
        {  
            if (pick > 7 || pick < 0)
            {
                Console.WriteLine("Invalid entry, please select a number from 1-7.");
                ;
            }
            else if (pick == 0)
            {

            }
            else
            {

                carsInventory.RemoveAt(pick);

                PrintList(carsInventory); //relist carsInventory

            }
        }

        public static void PrintList(List<Car> carsInventory)
        {
            int index = 1;
            foreach (Car car in carsInventory)
            {
                Console.WriteLine(index + ": " + car);
                index++;
            }
        }


        public static bool restart()
        {
            Console.WriteLine("Do you want to buy another car? Y/N");
            string input = Console.ReadLine().ToLower();

            if (input == "y")
            {
                return true;
            }
            else if (input == "n")
            {
                //Console.WriteLine($"Goodbye. You created circles");
                return false;
            }
            else //if user input is not "y" or "n"
            {
                Console.WriteLine("I'm sorry, I'm afraid I can't do that, invalid input. Please try again.");
                return restart();
            }
        }
    }
}