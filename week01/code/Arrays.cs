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

        // 1. Create an array of doubles with the size of 'length'.
        double[] multiples = new double[length];
        // 2. Use a for loop to iterate from 0 to length - 1.
        for (int i = 0; i < length; i++)
        {
            // 3. In each iteration, calculate the multiple of 'number' by multiplying it with the loop index + 1.
            // 4. Assign the calculated value to the corresponding index in the array.
            multiples[i] = number * (i + 1);
        }
    
        // 5. Return the array after the loop completes.
        return multiples;
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

        // 1. Check if the amount is greater than 0 and less than or equal to the size of the list.

        if (amount > 0 && amount <= data.Count)
        {
            // 2. Create a new list to store the rotated elements.
            List<int> rotatedList = new List<int>();

            // 3. Add the last 'amount' elements from the original list to the new list.
            for (int i = data.Count - amount; i < data.Count; i++)
            {
                rotatedList.Add(data[i]);
            }

            // 4. Add the remaining elements from the original list to the new list.
            for (int i = 0; i < data.Count - amount; i++)
            {
                rotatedList.Add(data[i]);
            }

            // 5. Clear the original list and add the elements from the new list back to it.
            data.Clear();
            data.AddRange(rotatedList);

        }
        // 6. If the amount is not valid, do nothing.
        
    }
}
