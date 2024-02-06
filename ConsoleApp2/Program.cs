class Program
{

    static void Main(string[] args)
    {
        int x = 4;
        int y = 5;
        int count = Multiply(x,y);
        Console.WriteLine(count);
    }

    public static int Multiply(int j, int k)
    {
        int hasil = 0;

        while (true)
        {
            k *= j;
            hasil = k;
            break;
        }

        return hasil;
    }
}

