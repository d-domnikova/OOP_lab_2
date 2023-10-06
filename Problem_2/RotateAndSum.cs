class RotateAndSum
{
    static void Main(string[] args)
    {
        int[] ints = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int k = int.Parse(Console.ReadLine());
        int[] sum = new int[ints.Length];

        for (int r = 0; r < k; r++)
        {
            int[] rotated = new int[ints.Length];
            int temp = ints[rotated.Length-1];
            for (int i = 1; i <rotated.Length; i++)
            {
                rotated[i] = ints[(i-1)];
                sum[i] = sum[i] + rotated[i];
            }
            rotated[0] = temp;
            sum[0] = sum[0] + rotated[0];
            ints = rotated;
        }

        for (int m = 0; m < sum.Length; m++)
        {
            Console.Write(sum[m] + " ");
        }
        Console.WriteLine();
    }
}