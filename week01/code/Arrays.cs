public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        // Step 1: Create a new array of doubles with the given length.
        // This array will store the multiples of the given number.
        var result = new double[length];

        // Step 2: Loop through each position in the array.
        for (int i = 0; i < length; i++)
        {
            // Step 3: Calculate the multiple.
            // Since array indexes start at 0, the first multiple is number * 1,
            // so we use (i + 1).
            result[i] = number * (i + 1);
        }

        // Step 4: Return the completed array of multiples.

        return result; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        // Step 1: Determine where to split the list.
        // The elements to move are the last 'amount' elements.
        int splitIndex = data.Count - amount;

        // Step 2: Copy the elements that will be rotated to the front.
        // These are the last 'amount' elements in the list.
        var rightPart = data.GetRange(splitIndex, amount);

        // Step 3: Remove those elements from the original list.
        data.RemoveRange(splitIndex, amount);

        // Step 4: Insert the copied elements at the beginning of the list.
        data.InsertRange(0, rightPart);
    }
}
