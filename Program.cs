namespace ArrayMethods;
class Program
{
    static void Main(string[] args)
    {
        int[] numbers = {2,6,4,9};

        // Sort
        foreach (var number in numbers)
            Console.WriteLine(number);    // 2  6  4  9

        Array.Sort(numbers);
        foreach (var number in numbers)
            Console.WriteLine(number);    // 2  4  6  9


        // Reverse
        Array.Reverse(numbers);
        foreach (var number in numbers)
            Console.WriteLine(number);    // 9  6  4  2


        // IndexOf
        int index = Array.IndexOf(numbers,4);
            Console.WriteLine(index);     //  2


        // Clear
        Array.Clear(numbers,2,1);
        foreach (var number in numbers)
            Console.WriteLine(number);    // 9  6  0  2

        
        // Resize
        Array.Resize<int>(ref numbers,5);
        numbers[4] = 8;
        foreach (var number in numbers)
            Console.WriteLine(number);    // 9  6  0  2  8

    }
}
