public class SequentialSearch
{
    public static void Main()
    {
        Console.Clear();

        int[] numbers = new int[15] { 87, 75, 98, 100, 82, 14, 76, 3, 91, 34, 27, 4, 63, 12, 88 };
        int target;

        Console.Write("Enter an integer you wanted to search for: ");
        target = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == target)
            {
                Console.WriteLine("Target `{0}` foundend in position `{1}`.", numbers[i], i);
                return;
            }
        }
        Console.WriteLine("Target `{0}` was not found in the array.", target);
    }
}
