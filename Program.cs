// See https://aka.ms/new-console-template for more information

// Fibonacci Sequence


class Fibonacci
{
    // Prints out series terms of number for Fibonacci Sequence
    static long[] numbers;

    public static int Fibo(int n)
    {
        int num1 = 0;
        int num2 = 1;

        for (int i = 0; i < n; i++)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp + num1;
        }
        return num1;
    }

    static void Main()
    {
        Console.WriteLine("Input number of terms for Fibonacci series: ");
        int num00 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\n The Fibonacci series of {0} terms is: ", num00);
        for (int i = 0; i < num00; i++)
        {
            Console.WriteLine("{0} ", Fibo(i));
        }
        Console.ReadKey();
    }
}
