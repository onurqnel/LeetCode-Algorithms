public class SelectionSort
{
    public static void Main()
    {
        Console.Clear();
        int[] values = { 5, 7, 2, 8, 9, 1 };

        // Display the unsorted array.
        Console.WriteLine("The unsorted array is:");
        DisplayArray(values);

        // Sort the array
        SelectionSortImpl(values);

        // Display the sorted array.
        Console.WriteLine("The sorted array is:");
        DisplayArray(values);

        SelectionSortReversed(values);

        // Display the reversed sorted array.
        Console.WriteLine("The reversed sorted array is:");
        DisplayArray(values);
    }

    // Helper method to display array contents
    private static void DisplayArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine($"Index [{i}]: {arr[i]}");
        }
    }

    // Selection Sort Implementation
    public static void SelectionSortImpl(int[] arr)
    {
        // Outer loop goes through each element
        for (int i = 0; i < arr.Length - 1; i++)
        {
            // Assume the current position holds the smallest value
            int minIndex = i;

            // Inner loop finds the smallest element in the unsorted part
            for (int j = i + 1; j < arr.Length; j++)
            {
                // If a smaller element is found, update minIndex
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            // Swap the smallest element found with the element at position i
            if (minIndex != i)
            {
                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
        }
    }

    // Reversed Selection Sort Implementation
    public static void SelectionSortReversed(int[] arr)
    {
        // Outer loop goes through each position from start to end
        for (int i = 0; i < arr.Length - 1; i++)
        {
            // Assume the current position holds the largest value
            int maxIndex = i;

            // Inner loop finds the largest element in the unsorted part of the array
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] > arr[maxIndex])
                {
                    maxIndex = j;
                }
            }

            // Swap the largest element found with the element at position i
            if (maxIndex != i)
            {
                int temp = arr[i];
                arr[i] = arr[maxIndex];
                arr[maxIndex] = temp;
            }
        }
    }
}
