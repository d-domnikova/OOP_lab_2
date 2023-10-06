class indOfLett
{
    static void Main(string[] args)
    {
        char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g',
        'h', 'i', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        string word = Console.ReadLine().ToLower();
        char[] arr = word.ToCharArray();
        for (int i = 0; i < arr.Length; i++)
        {
          for (int j = 0; j < alphabet.Length; j++)
            {
                if(arr[i] == alphabet[j])
                {
                    Console.Write("{0} -> {1}\n", arr[i], j);
                }
            }
        }
    }
}