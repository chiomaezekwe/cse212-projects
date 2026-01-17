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
        
        // My Solution - I added lines 16 - to - 36
        // PLAN:
        // 1. Create a new array of doubles with a size equal to 'length'.
        // 2. Use a loop that runs from index 0 up to length - 1.
        // 3. For each index i:
        //     Calculate the multiple by multiplying the 'number' by (i + 1).
        //     Store the result in the array at index i.
        // 4. After the loop finishes, return the filled array.

        // Step 1: Create the array
        double[] result = new double[length];

        // Step 2 & 3: Fill the array with multiples
        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        // Step 4: Return the array
        return result;
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

        // My Solution - I added lines 52 - to - 78
        // PLAN:
        // 1. Determine how many elements need to move from the end of the list to the front.
        //    This number is equal to 'amount'.
        // 2. Create a temporary list to store the elements that will be moved.
        // 3. Copy the last 'amount' elements from 'data' into the temporary list.
        // 4. Remove those last 'amount' elements from the original list.
        // 5. Insert the temporary list elements at the beginning of 'data'.
        // 6. The original list will now be rotated to the right.

        // Step 2: Create a temporary list
        List<int> temp = new List<int>();

        // Step 3: Copy last 'amount' elements into temp
        for (int i = data.Count - amount; i < data.Count; i++)
        {
            temp.Add(data[i]);
        }

        // Step 4: Remove the last 'amount' elements from the original list
        data.RemoveRange(data.Count - amount, amount);

        // Step 5: Insert the saved elements at the beginning
        data.InsertRange(0, temp);
    }
    
}
