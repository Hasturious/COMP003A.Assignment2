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

            string asteriskLine = "************************************************************";

            Console.WriteLine(asteriskLine+"\n Welcome to the Discount Calculator"+"\n"+asteriskLine);

            Console.Write("What is your first name?: ");
            firstName = Console.ReadLine();

            Console.Write("What is your last name?: ");
            lastName = Console.ReadLine();

            Console.Write("How old are you?: ");
            userAge = int.Parse(Console.ReadLine());

            Console.Write("What is the price of the item you're interested in?: ");
            itemPrice = double.Parse(Console.ReadLine());

            Console.Write("Are you a student? (true/false): ");
            isStudent = bool.Parse(Console.ReadLine());

            int futureAge = userAge + 5; // adds 5 to user age
            bool isAdult = userAge >= 18; //checks if adult
            bool isSenior = userAge >= 60; //checks if senior
            double studentDiscount = itemPrice * .9;
            double seniorDiscount = itemPrice * .8;
            
            Console.WriteLine("\n\n\n"+asteriskLine);
            Console.WriteLine($"Hello {firstName} {lastName}!"); //displays name
            Console.WriteLine($"You are current age {userAge} years old."); //displays age
            Console.WriteLine($"In five years you will be {futureAge}.");
            Console.WriteLine($"Are you 18 or older {isAdult}."); //displays if adult
            Console.WriteLine($"The original price of the item is {itemPrice}.");
            Console.WriteLine($"As a student, your discounted price is {studentDiscount}.00.");
            Console.WriteLine($"As a student, your discounted price is {seniorDiscount}.00.");
            Console.WriteLine(asteriskLine);
        }
    }
}
