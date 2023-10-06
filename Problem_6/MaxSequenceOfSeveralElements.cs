class MaxSequence
{
    static void Main(string[] args)
    {
        int[] ints = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int start = 0, len = 1, bestStart = 0, bestLen = 1;
        for (int i = 1; i < ints.Length; i++)
        {
            if (ints[i] == ints[start])
            {
                len++;
            }
            else
            {
                if (bestLen < len)
                {
                    bestLen = len;
                    bestStart = start;
                }
                start = i;
                len = 1;
            }

            if(i == ints.Length - 1)
            {
               if (bestLen < len)
                {
                    bestLen = len;
                    bestStart = start;
                }
            }
        }
        for (int i = bestStart; i < bestStart+bestLen; i++)
        {
            Console.Write(ints[i] + " ");
        }
    } 
}