namespace Variables_Gentry_Nylen
{
    internal class Program
    {
        static void Main()
        {
            // Declare an integer variable named "favoriteNumber"
            int favoriteNumber;

            // Initialize two boolean variables "isJumping" and "isRunning" to false on the same line
            bool isJumping = false, isRunning = false;

            // Declare a floating point variable and initialize it with a floating point number
            float myFloat = 3.14f;  // 'f' denotes that this is a float, not a double

            // Assign favoriteNumber to your favorite number (e.g., 7)
            favoriteNumber = 9;

            // Assign the floating point variable "myFloat" a floating point number (e.g., 2.71)
            myFloat = 2.71f;

            // Initialize a double that you do not want to change and name it "finalGrade"
            const double finalGrade = 95.5;

            // Print out all variables on their own line
            Console.WriteLine("Favorite Number: " + favoriteNumber);
            Console.WriteLine("Is Jumping: " + isJumping);
            Console.WriteLine("Is Running: " + isRunning);
            Console.WriteLine("Floating Point Value: " + myFloat);
            Console.WriteLine("Final Grade: " + finalGrade);
        }
    }
}
