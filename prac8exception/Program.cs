using System;

class MultipleExceptionsDemo
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter a number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter another number to divide:");
            int num2 = int.Parse(Console.ReadLine());

            // Division operation
            int result = num1 / num2;     
            Console.WriteLine("Result: " + result);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: Please enter a valid integer. " + ex.Message);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: Division by zero is not allowed. " + ex.Message);
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("Error: Number is too large or too small. " + ex.Message);
        }
        catch (Exception ex)
        {
            // Generic exception handler for any other exceptions
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
        finally
        {
            // Code in the finally block will always execute
            Console.WriteLine("End of the program.");
        }
    }
}
