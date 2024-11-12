public class BinarySearchDemo
{
    public static void Main()
    {
        Console.Clear();
        int[] numbers = new int[13] { 12, 23, 36, 48, 51, 63, 72, 88, 94, 100, 111, 122, 131 };
        int result,
            searchValue;
        char input;

        do
        {
            Console.Write("Enter the value to search for: ");
            searchValue = Convert.ToInt32(Console.ReadLine());
            result = BinarySearchImpl(numbers, searchValue);

            if (result == -1)
            {
                Console.WriteLine("{0} Not found", searchValue);
            }
            else
            {
                Console.WriteLine("{0} found at the position {1}", searchValue, result);
            }

            Console.Write("Do you want to search agin? (Y) or (N): ");
            input = Convert.ToChar(Console.ReadLine());
        } while (char.ToUpper(input) == 'Y');
        Console.WriteLine("Exit...");
    }

    public static int BinarySearchImpl(int[] nums, int value)
    {
        // Variable declaration
        int bot, // Bottom, First element of the array
            top, // Top, Last element of the array
            mid, // Midpoint, Middle element of the array
            pos; // Position of the search value
        bool isFound; // Flag

        // Initialization
        bot = 0;
        top = nums.Length - 1; // -1 because the out of bound issue.
        pos = -1; // Not found by default
        isFound = false; // Not found by default

        // Search for the value
        while (!isFound && bot <= top) // Bottom must be lower than or equal to the top
        {
            mid = (bot + top) / 2; // Midpoint calculation

            // If middle element excatly is the value
            if (nums[mid] == value)
            {
                isFound = true; // Value Found
                pos = mid; // Done
            }
            // If value in the bottom half
            else if (value < nums[mid])
            {
                top = mid - 1; // Set the top value as bottom half's last index
            }
            else
            {
                bot = mid + 1; // Set the bot value as top half's first index
            }
        }
        return pos;
    }
}
