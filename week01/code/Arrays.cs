
public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.
    /// For example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start

        // PLAN:
        // Step 1: Create a new double array with the specified length.
        // Step 2: Start a for loop at index 0 and continue until the
        //         index reaches the length of the array.
        // Step 3: For each position, multiply the starting number by
        //         the index plus one to calculate the next multiple.
        // Step 4: Store the calculated multiple in the corresponding
        //         position in the array.
        // Step 5: Continue until every position in the array is filled.
        // Step 6: Return the completed array to the calling function.

        // IMPLEMENTATION:

        double[] multiples = new double[length];

        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start

        // PLAN:
        // Step 1: Find the total number of elements in the list using data.Count.
        // Step 2: Calculate the split index by subtracting the rotation amount
        //         from the total number of elements.
        // Step 3: Use GetRange() to copy the last 'amount' elements into a
        //         separate list.
        // Step 4: Use GetRange() again to copy the elements before the
        //         split index into another separate list.
        // Step 5: Clear the original list so that it can be rearranged.
        // Step 6: Add the last elements to the original list first.
        // Step 7: Add the remaining first elements after the last elements.
        // Step 8: The original list is now rotated to the right by the
        //         requested amount.

        // IMPLEMENTATION:

        int count = data.Count;

        int splitIndex = count - amount;

        List<int> lastPart = data.GetRange(splitIndex, amount);

        List<int> firstPart = data.GetRange(0, splitIndex);

        data.Clear();

        data.AddRange(lastPart);

        data.AddRange(firstPart);
    }
}
