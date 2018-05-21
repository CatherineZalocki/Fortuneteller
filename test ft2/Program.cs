using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_ft2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Cathy Zalocki, Fortune Teller final copy


            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();



            //retirement modulus

            string resultRetire;

            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());


            if (age % 2 == 0)
            {
                resultRetire = "10";
            }

            else
            {
                resultRetire = "20";
            }

            // money in the bank

            string resultBank = "";

            Console.WriteLine("What month were you born? Please use a number to answer.");
            int month = int.Parse(Console.ReadLine());


            if (month >= 1 && month <= 4)
            {
                resultBank = " $10,000.00";
            }
            else if (month >= 5 && month <= 8)
            {
                resultBank = " $30,000.00";
            }
            else if (month >= 9 && month <= 12)
            {
                resultBank = " $50,000.00";
            }
            else if (month < 1 || month > 12)
            {
                resultBank = " $0.00";
            }


            // Vacation home 

            string resultHouse = "";

            Console.WriteLine("How many siblings do you have? Please use a number to answer.");
            int siblings = int.Parse(Console.ReadLine());


            if (siblings.Equals(0))
            {
                resultHouse = " Tuscany";
            }
            else if (siblings.Equals(1))
            {
                resultHouse = " Cancun";
            }
            else if (siblings.Equals(2))
            {
                resultHouse = " Paris";
            }
            else if (siblings.Equals(3))
            {
                resultHouse = " Hawaii";
            }
            else if (siblings > 3)
            {
                resultHouse = " London";
            }
            else if (siblings < 0)
            {
                resultHouse = " Ohio";
            }


            //rainbow
            string resultColor = "";

            string answer = ("help");
            Console.WriteLine("Please pick your favorite color from the ROYGBIV spectrum.");
            Console.WriteLine("If you don't understand, please type the word help.");
            string response = Console.ReadLine().ToLower();

            switch (response)
            {
                case "red":
                    resultColor = "bicycle";
                    break;

                case "orange":
                    resultColor = "plane";
                    break;

                case "yellow":
                    resultColor = "train";
                    break;

                case "green":
                    resultColor = "sprots car";
                    break;

                case "blue":
                    resultColor = "unicycle";
                    break;

                case "indigo":
                    resultColor = "horse";
                    break;

                case "violet":
                    resultColor = "hang glider";
                    break;

                default:

                    if (response.Equals("help"))
                    {
                        Console.WriteLine("Please chooses from the colors: red, orange, yellow, green, blue, indigo, or violet.");
                        string transport = Console.ReadLine().ToLower();

                        switch (transport)

                        {                            
                          
                            case "red":
                                resultColor = "bicycle";
                                break;

                            case "orange":
                                resultColor = "plane";
                                break;

                            case "yellow":
                                resultColor = "train";
                                break;

                            case "green":
                                resultColor = "sprots car";
                                break;

                            case "blue":
                                resultColor = "unicycle";
                                break;

                            case "indigo":
                                resultColor = "horse";
                                break;

                            case "violet":
                                resultColor = "hang glider";
                                break;

                        }
                    }


                        break;

                    


                    

            }

                    Console.WriteLine("{0} {1} will retire in {2} years with {3} in the bank, a vacation home in {4} and a {5}.", firstName, lastName, resultRetire, resultBank, resultHouse, resultColor);






            
        }
    }
}

   