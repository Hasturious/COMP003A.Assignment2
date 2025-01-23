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

            Console.Write("What is your first name?: ");
            firstName = Console.ReadLine();

            Console.Write("What is your last name?: ");
            lastName = Console.ReadLine();

            Console.Write("How old are you?: ");
            userAge = int.Console.ReadLine();

            Console.Write("What is the price of the item you're interested in?: ");
            itemPrice = double.Console.ReadLine();

            Console.Write("Are you a student?: ");
            isStudent = bool.Console.ReadLine();

            int futureAge = userAge + 5; // adds 5 to user age
            bool isAdult = userAge >= 18; //checks if adult
            bool isAdultStudent = isStudent && isAdult; //checks if both student and adult

            Console.WriteLine($"\nHello {userName}!"); //displays name
            Console.WriteLine($"You are current age {userAge} years old."); //displays age
            Console.WriteLine("In five years you will be {futureAge}");
            Console.WriteLine($"Are you 18 or older {isAdult}"); //displays if adult
            Console.WriteLine($"Are you both a student and 18 or older? {isAdultStudent}"); //displays if adult and student
        }
    }
}
