class BubbleSort
{
    static void Main()
    {
        int[] numbers = { 50, 2, 20, 4, 0, 6, 14 };
        Sort(ref numbers);
        Debug(numbers);
    }

    static void Sort(ref int[] array)
    {
        if(array.Length == 2)
        {
            if (array[0] > array[1])
            {
                int currentNumber = array[0];
                array[0] = array[1];
                array[1] = currentNumber;
            }
            return;
        }
        int offset = array.Length;
        bool swapped;
        do
        {
            swapped = false;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    int currentNumber = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = currentNumber;
                    swapped = true;
                }
            }
            offset--;
        } while (swapped);
    }
    static void Debug(int[] array)
    {
        Console.WriteLine(string.Join(",", array));
    }
}
