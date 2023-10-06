class SieveOfEratosthenes
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        bool[] primes = new bool[n + 1];
        primes[0] = primes[1] = false;
    
        for(int i = 2; i < primes.Length; i++) {
            primes[i] = true;
        }

        for(int p = 2; p <= n; p++) {
            if (primes[p])
            {
                Console.Write(p + " ");

                for (int i = 2*p; i <= n; i+=p)
                {
                    primes[i] = false;
                }
            }
        }
    }
}
