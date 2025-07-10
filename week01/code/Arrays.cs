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

        //Step 1: Create an empty array with the size of "length"
        double[] result = new double[length];

        //Step 2: Use a loop that starts from 0 and goes up to one less than length
        for (int i = 0; i < length; i++)
        {
            //Step 3: At each step, calculate number * (i + 1)
            //Save it in the result arrat at position i    
            result[i] = number * (i + 1);
        }

        //Step 4: Return the array after the loop is done
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

        //Step 1: Get the last 'amount' of items from the list and save
        //For example, if amount is 3 and the list is [1,2,3,4,5,6,7,8,9], this will get [7,8,9] 
        List<int> range = data.GetRange(data.Count - amount, amount);

        //Step 2: Remove those 'amount' of items from the end of the original list.
        //In the same example, the list will now be [1,2,3,4,5,6]
        data.RemoveRange(data.Count - amount, amount);

        //Step 3: Insert the saved items ('range') at the beginning (index 0) of the list
        //After inserting, the list becomes [7,8,9,1,2,3,4,5] - rotated right by the specified amount.
        data.InsertRange(0, range);
    }
}
