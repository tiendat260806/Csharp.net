

class pt2
{
    static void PhuongTrinh(double a, double b, double c)
    {
        if (a == 0)
        {
            if (b == 0)
            {
                if (c == 0)
                {
                    Console.WriteLine("Phuong trinh vo so nghiem");
                }
                else
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
            }
            else
            {
                Console.WriteLine($"Nghiem phuong trinh la: {(-c / b):F2}");
            }
        }
        else
        {
            double delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
            else if (delta == 0)
            {
                Console.WriteLine($"Phuong trinh co nghiem kep: {(-b / 2 * a):F2}");
            }
            else
            {
                Console.WriteLine("Phuong trinh co 2 nghiem phan biet:");
                Console.WriteLine($"X1: {((-b + Math.Sqrt(delta)) / 2 * a):F2}");
                Console.WriteLine($"X2: {((-b - Math.Sqrt(delta)) / 2 * a):F2}");
            }
        }
    }
    public static void Run()
    {
        Console.WriteLine("Nhap a: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Nhap b: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Nhap c: ");
        double c = double.Parse(Console.ReadLine());
        PhuongTrinh(a, b, c);
    }
}