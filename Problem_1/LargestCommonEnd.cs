class LargestCommonEnd
{
    static void Main(string[] args)
    {
        string input1 = Console.ReadLine();
        string input2 = Console.ReadLine();
        string[] array1, array2;

        if (input1.Length < input2.Length)
        {
            array1 = input1.Split(" ");
            array2 = input2.Split(" ");
        } else {
            array1 = input2.Split(" ");
            array2 = input1.Split(" ");
        }
        
        int output = 0;
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < array1.Length; j++)
            {
                if (array1[j].Equals(array2[j]))
                {
                    output++;
                }
                else
                {
                    array1.Reverse();
                    array2.Reverse();
                    break;
                }
            }
        }
        Console.WriteLine(output);
    }
}
