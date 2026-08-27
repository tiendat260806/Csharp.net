
class calculator
{
    static double cong(double a,double b)
    {
        return a + b;
    }
    static double hieu(double a, double b)
    {
        return a - b;
    }
    static double nhan(double a, double b)
    {
        return a * b;
    }
    static double chia(double a, double b)
    {
        if (b is 0)
        {
            throw new DivideByZeroException("Ko the chia cho 0");
        }
        return a / b;
    }
    static double chialaydu(double a, double b) {
        if (b is 0)
        {
            throw new DivideByZeroException("Ko the chia cho 0");
        }
        return a % b;
    }
    public static void Run()
    {
        Console.WriteLine("1. Cong");
        Console.WriteLine("2. Tru");
        Console.WriteLine("3. Nhan");
        Console.WriteLine("4. Chia");
        Console.WriteLine("5. Chia lay du");
        Console.WriteLine("Chon toan tu muon dung: ");
        int option = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap so thu nhat: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Nhap so thu hai: ");
        double b = double.Parse(Console.ReadLine());
        try
        {
            double ketqua = option switch
            {
                1 => cong(a, b),
                2 => hieu(a, b),
                3 => nhan(a, b),
                4 => chia(a, b),
                5 => chialaydu(a, b),
                _ => throw new InvalidOperationException("Toan tu ko hop le")
            };
            Console.WriteLine($"Ket qua: {ketqua:F2}");
        }
        catch (DivideByZeroException loi)
        {
            Console.WriteLine(loi.Message);
        }
        catch (InvalidOperationException loi)
        {
            Console.WriteLine(loi.Message);
        }
    }
}