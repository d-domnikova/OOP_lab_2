class FrequentNumber
{
    static void Main(string[] args)
    {
        int[] ints = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int len = 1, bestLen = 0, bestStart=0;
        for (int i = 0; i < ints.Length; i++)
        {
            for (int j = i+1; j< ints.Length; j++)
            {
                if (ints[i] == ints[j])
                {
                    len++;
                }
            }

            if(len > bestLen)
            {
                bestStart = ints[i];
                bestLen = len;

            }
            len = 1;
        }
        Console.WriteLine("The number {0} is the most frequent (occurs {1} times)", bestStart, bestLen);
    }
}