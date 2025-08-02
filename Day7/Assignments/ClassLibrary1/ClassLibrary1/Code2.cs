using System;

class CustomCollection
{
    // Define internal data structure
    // Complete Step 1:............
    private string[] items = new string[10];

    // Implement indexer
    // Complete Step 2:............
    public string this[int index]
    {
        get
        {
            if (index < 0 || index >= items.Length) throw new IndexOutOfRangeException("Index is out of range.");
            return items[index];
        }
        set
        {
            if (index < 0 || index >= items.Length) throw new IndexOutOfRangeException("Index is out of range.");
            items[index] = value;
        }
    }

    // Define method to set elements
    // Complete Step 3:............
    public void SetElement(int index, string value)
    {
        this[index] = value;
    }

    // Define method to get elements
    // Complete Step 4:............
    public string GetElement(int index)
    {
        return this[index];
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create instance of CustomCollection
        // Complete Step 7:............
        CustomCollection collection = new CustomCollection();

        // Loop to set and get values based on user input
        for (int i = 0; i < 3; i++)
        {
            try
            {
                // Prompt the user to set elements
                Console.WriteLine("Enter index to set:");
                // Complete Step 5:............
                int setIndex = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter value to set:");
                // Complete Step 6:............
                string value = Console.ReadLine();
                collection.SetElement(setIndex, value);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error setting value: " + ex.Message);
            }

            try
            {
                // Prompt the user to get the elements
                Console.WriteLine("Enter index to get:");
                // Complete Step 8:............
                int getIndex = int.Parse(Console.ReadLine());
                string retrieved = collection.GetElement(getIndex);
                Console.WriteLine("Retrieved value: " + retrieved);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving value: " + ex.Message);
            }
        }
    }
}