class Puzzles
{
    public static void Main(string[] args)
    {
        Console.WriteLine(DateTime.Now);
        // Console.WriteLine(Puzzle1());
        // Console.WriteLine(Puzzle2());
        // Console.WriteLine(Puzzle3());
        // Console.WriteLine(Puzzle4());
        // Console.WriteLine(Puzzle5());
        // Console.WriteLine(Puzzle6());
        // Console.WriteLine(Puzzle7());
        Console.WriteLine(Puzzle8());
        Console.WriteLine(DateTime.Now);
    }

    private static int Puzzle1()
    {
        var sum = 0;
        for (var i = 0; i < 1000; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                sum += i;
            }
        }
        return sum;
    }

    private static int Puzzle2()
    {
        var x = 1;
        var y = 2;
        var sum = 3;
        
        while (y < 4000000)
        {
            var z = x + y;
            
            x = y;
            y = z;

            sum += z;
        }
        return sum;
    }

    private static long Puzzle3()
    {
        var x = 2;
        for (var i = 2; i < 600851475143 / x; i++)
        {
            if (600851475143 % i != 0) continue;
            if (IsPrime(600851475143 / i))
            {
                return (int) (600851475143 / i);
            }
        }
        return 0;
    }

    public static int Puzzle4()
    {
        var palindrome = 0;
        for (var i = 999; i > 0; i--)
        {
            for (var j = 999; j > 0; j--)
            {
                if (!IsPalindrome(j * i)) continue;
                palindrome = Math.Max(palindrome, j * i);
            }
        }
        return palindrome;
    }

    public static int Puzzle5()
    {
        var number = 2520;
        for (;; number+=20)
        {
            if (IsDividable(number))
            {
                return number;
            }
        }
    }

    public static int Puzzle6()
    {
        var sum1 = 0;
        var sum2 = 0;
        for (var i = 1; i <= 100; i++)
        {
            sum1 += i * i;
            sum2 += i;
        }
        sum2 *= sum2;

        return Math.Abs(sum2 - sum1);
    }

    public static int Puzzle7()
    {
        var i = 0;
        var j = 0;
        for (; j < 10001;)
        {
            i++;
            if (IsPrime(i))
            {
                j++;
            }
        }
        return i;
    }

    public static long Puzzle8()
    {
        const string bigNumber = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
        long highestNumber = 0;
        var bigList = bigNumber.ToCharArray().ToList();
        for (var i = 0; i <= 987; i++)
        {
            long x = bigList[i] -'0';
            for (var j = i+1; j < 13+i; j++)
            {
                // if (bigList[i + j]- '0' == 0) //multiply by 0 = 0
                // {
                //     break;
                // }
                x *= bigList[j]- '0';
            }
            if (x > highestNumber)
            {
                highestNumber = x;
            }
        }
        return highestNumber;
    }
    public static bool IsPalindrome(int maybePalindrome)
    {
        var palindrome = maybePalindrome.ToString().Aggregate("", (current, ch) => ch + current);

        return maybePalindrome.ToString() == palindrome;
    }
    
    private static List<int> Primes(int limit) //Used in slow version
    {
        List<int> primes = new();
        
        for (var i=2; i<limit; i++)
        {
            if (IsPrime(i))
            {
                primes.Add(i);
            }
        }
        return primes;
    }

    private static bool IsPrime(long maybePrime)
    {
        switch (maybePrime)
        {
            case 3 or 2:
                return true;
            case 1:
                return false;
        }

        if (maybePrime % 3 == 0 || maybePrime % 2 == 0)
        {
            return false;
        }
        for (var i = 5; i * i <= maybePrime; i+=2)
        {
            if (maybePrime % i == 0) { return false; }
        }
        return true;
    }

    private static bool IsDividable(int number)
    {
        return number % 11 == 0 && number % 12 == 0 && number % 13 == 0 && number % 14 == 0 && number % 15 == 0 &&
               number % 16 == 0 && number % 17 == 0 && number % 18 == 0 && number % 19 == 0;
    }
}


    