class FoldAndSum
{
    static void Main()
    {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int halfArr = arr.Length / 2;
        int fourthPartArr = halfArr / 2;

        int[] sumArr = new int[halfArr];
        for (int i = 0; i < fourthPartArr; i++) {
            sumArr[i] = arr[fourthPartArr+i] + arr[fourthPartArr-1-i];
            sumArr[i + fourthPartArr] = arr[i + halfArr] + arr[arr.Length-1 - i];
        }

        for (int i = 0; i < sumArr.Length; i++)
        {
            Console.Write(sumArr[i] + " ");
        }
    }
}