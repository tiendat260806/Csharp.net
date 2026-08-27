class kiemtraso
{
    static void Isprime(int n)
    {
        if (n < 2)
        {
            Console.WriteLine($"{n} ko phai so nguyen to");
        }
        else
        {
            for(int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % 1 == 0)
                {
                    Console.WriteLine($"{n} ko phai so nguyen to");
                    return;
                }
            }
            Console.WriteLine($"{n} la so nguyen to");
        }
    }
    static void IsPerfectNumber(int n)
    {
        int sum = 0;
        for(int i = 1; i < n; i++)
        {
            if (n % i == 0)
            {
                sum += i;
            }
        }
        if (sum == n)
        {
            Console.WriteLine($"{n} la so hoan hao");
        }
        else
        {
            Console.WriteLine($"{n} ko phai so hoan hao");
        }
    }
    static void Fibonacci(int n)
    {
        int a = 0, b = 1, c;
        Console.Write("Day fibonacci: ");
        while (a <= n)
        {
            Console.Write(a + " ");
            c = a + b;
            a = b;
            b = c;
        }
        Console.WriteLine();
    }
    public static void Run()
    {
        Console.WriteLine("Nhap mot so nguyen: ");
        int n = int.Parse(Console.ReadLine());
        IsPerfectNumber(n);
        Isprime(n);
        Fibonacci(n);
    }
}