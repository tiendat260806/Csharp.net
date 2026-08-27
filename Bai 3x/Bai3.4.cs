class program
{
    static void Main()
    {
        int choice;
        do
        {
            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Calculator");
            Console.WriteLine("2. Giai pt bac 2");
            Console.WriteLine("3. Kiem tra so");
            Console.WriteLine("0. Exit");
            Console.Write("Nhap lua chon: ");
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Lua chon ko hop le");
                Console.WriteLine("Nhan phim bat ky de tiep tuc");
                Console.ReadKey();
                continue;
            }
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Calculator");
                    calculator.Run();
                    break;

                case 2:
                    Console.WriteLine("Phuong trinh bac 2");
                    pt2.Run();
                    break;

                case 3:
                    Console.WriteLine("Kiem tra so");
                    kiemtraso.Run();
                    break;

                case 0:
                    Console.WriteLine("Da thoat chuong trinh");
                    break;
                default:
                    Console.WriteLine("Lua chon ko hop le");
                    break;
            }
            if (choice != 0)
            {
                Console.WriteLine();
                Console.WriteLine("Nhan phim bat ky de tiep tuc");
                Console.ReadKey();
            }
        } while (choice != 0);
        Console.Clear();
    }
}