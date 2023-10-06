class CompareTwoArr
{
    static void Main(string[] args)
    {
        string[] arr1 = Console.ReadLine().Split(' ');
        string[] arr2 = Console.ReadLine().Split(' ');

        char[] char_arr1, char_arr2;
        if (arr1.Length > arr2.Length) 
        {
            char_arr1 = Array.ConvertAll(arr2, char.Parse);
            char_arr2 = Array.ConvertAll(arr1, char.Parse);
        }
        else
        {
            char_arr1 = Array.ConvertAll(arr1, char.Parse);
            char_arr2 = Array.ConvertAll(arr2, char.Parse);
        }

        int i = 0;
        while (i < char_arr1.Length)
        {
            if (char_arr1[i] > char_arr2[i])
            {
                print(char_arr2);
                print(char_arr1);
                break;
            }
            else if (char_arr1[i] < char_arr2[i] || i == char_arr1.Length - 1)
            {
                print(char_arr1);
                print(char_arr2);
                break;
            }
            else
            {
                i++;
            }
        }
    }

    static void print(char[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
        }
        Console.WriteLine();
    }
} 