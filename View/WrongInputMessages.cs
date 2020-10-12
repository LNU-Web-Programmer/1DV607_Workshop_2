using System;
namespace View
{
    class WrongInputMessages
    {
        public void NotCorrectPId()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nThis is not a correct social security number.");
            Console.ResetColor();
        }

        public void PrintSsnNotExisting()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nThis social security number was not found in the register.");
            Console.ResetColor();
        }

        public void MemberAlreadyExists()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nA member with this personal number already exists in the register.");
            Console.ResetColor();
        }

        public void NotCorrectName()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nYou didn't enter a correct name.");
            Console.ResetColor();
        }
    }
}