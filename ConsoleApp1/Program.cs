using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "USOMAANAPAIUMASYDNIP";
        int count = CountWords(input);
        Console.WriteLine("Jumlah Kata yang dihasilkan = " + count);
    }

    static int CountWords(string input)
    {
        int countS = 0, countI = 0, countA = 0, countP = 0;

        foreach (char c in input)
        {
            switch (c)
            {
                case 'S':
                case 's':
                    countS++;
                    break;
                case 'I':
                case 'i':
                    countI++;
                    break;
                case 'A':
                case 'a':
                    countA++;
                    break;
                case 'P':
                case 'p':
                    countP++;
                    break;
                default:
                    break;
            }
        }

        int wrd = Math.Min(countS, Math.Min(countI, Math.Min(countA, countP)));
        return wrd;
    }
}
