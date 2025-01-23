//Author: Jean Bryant Figueroa
//Course: COMP003A
//Faculty: Johnathan Cruz
//Purpose: Assignment 2. A program calculating discounts for different users

namespace COMP003A.Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName; //store name as a string
            string lastName; //store name as a string
            int userAge; //store age as an number
            double itemPrice; //store the product price
            bool isStudent; //true / false statement

            string asteriskLine = "************************************************************"; //Stores the string for the large asterisk line

            Console.WriteLine(asteriskLine+"\n Welcome to the Discount Calculator"+"\n"+asteriskLine); //Displays title message

            Console.Write("What is your first name?: "); //prompts user for first name
            firstName = Console.ReadLine(); //logs the first name

            Console.Write("What is your last name?: "); //prompt user for last name
            lastName = Console.ReadLine(); //logs last name

            Console.Write("How old are you?: "); //prompts user for age
            userAge = int.Parse(Console.ReadLine()); //logs age as an int

            Console.Write("What is the price of the item you're interested in?: "); //prompt the price of desired item
            itemPrice = double.Parse(Console.ReadLine()); //prompts the price as an double

            Console.Write("Are you a student? (true/false): "); //prompts user if their a student
            isStudent = bool.Parse(Console.ReadLine()); //logs result an a boolean

            int futureAge = userAge + 5; //adds 5 to user age
            bool isSenior = userAge >= 60; //checks if senior
            double studentDiscount = itemPrice * .9; //discounts the price by 10%
            double seniorDiscount = itemPrice * .8; //discounts the price by 20%

            Console.WriteLine("\n\n\n"+asteriskLine); //go down 3 line spaces and displays the asterisk line
            Console.WriteLine($"Hello {firstName} {lastName}!"); //displays name
            Console.WriteLine($"You are current age {userAge} years old."); //displays age
            Console.WriteLine($"In five years you will be {futureAge}."); //displays future age
            Console.WriteLine($"The original price of the item is {itemPrice}."); //displays original price
            Console.WriteLine($"As a student, your discounted price is {studentDiscount}.00."); //displays student discount
            Console.WriteLine($"As a student, your discounted price is {seniorDiscount}.00."); //displays senior discount
            Console.WriteLine(asteriskLine); //displays asterisk line
        }
    }
}
