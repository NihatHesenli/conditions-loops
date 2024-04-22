class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Ededi daxil edin: ");
        int eded = Convert.ToInt32(Console.ReadLine());

        
        int hasil = HesablaHasil(eded);

        
        Console.WriteLine("Ededin rəqəmlərinin hasilı: " + hasil);
    }

    
    static int HesablaHasil(int n)
    {
        int hasil = 1;
        while (n != 0)
        {
            hasil *= n % 10;
            n /= 10; 
        }
        return hasil;
    }
}
// verilmis ededin sade ve murekkeb oldugunu tapan alqoritm

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Ededi daxil edin: ");
        int eded = Convert.ToInt32(Console.ReadLine());

        
        if (SadeMi(eded))
        {
            Console.WriteLine(eded + " sade ededdir.");
        }
        else
        {
            Console.WriteLine(eded + " mürəkkəb ededdir.");
        }
    }

    
    static bool SadeMi(int n)
    {
        if (n <= 1)
            return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }
}
// verilmis ededin faktorialini tapan alqoritm

class Program
{
    static void Main(string[] args)
    {
        // İstifadəçidən ədəd daxil etməsini tələb edir
        Console.Write("Ededi daxil edin: ");
        int eded = Convert.ToInt32(Console.ReadLine());

        // Faktorialı hesabla
        long faktorial = HesablaFaktorial(eded);

        // Faktorialı ekrana çap et
        Console.WriteLine(eded + " ededinin faktorialı: " + faktorial);
    }

    // Faktorialı hesablamaq üçün metod
    static long HesablaFaktorial(int n)
    {
        // 0 vəya 1 üçün faktorial 1-dir
        if (n == 0 || n == 1)
            return 1;

        long faktorial = 1;
        for (int i = 2; i <= n; i++)
        {
            faktorial *= i;
        }
        return faktorial;
    }
}
