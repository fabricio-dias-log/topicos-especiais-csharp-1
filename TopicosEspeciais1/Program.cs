using System.Globalization;

namespace TopicosEspeciais1;

class Program
{
    static void Main(string[] args)
    {
        //inferencia: palavra var

        /*var x = 10;
        var y = 10.1;
        var z = "Maria";

        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(z);
        
        // switch-case
        int n = int.Parse(Console.ReadLine());
        string day;

        switch (n)
        {
            case 1:
                day = "Monday";
                break;
            case 2:
                day = "Tuesday";
                break;
            case 3:
                day = "Wednesday";
                break;
            case 4:
                day = "Thursday";
                break;
            case 5:
                day = "Friday";
                break;
            case 6:
                day = "Saturday";
                break;
            case 7:
                day = "Sunday";
                break;
            default:
                day = "Invalid value";
                break;
        }
        Console.WriteLine($"Dia: {day}");
        
        //expressão ternária
        Console.WriteLine("Digite o preço do dia: ");
        
        double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double desconto;
        
        desconto = (preco < 20.00) ? preco * 0.1 : preco * 0.05;

        Console.WriteLine($"Desconto: {desconto.ToString("F2", CultureInfo.InvariantCulture)}");
        
        //Funções para string

        string original = "abcde FGHIJ ABC abc DEFG     ";
        string s1 = original.ToUpper();
        string s2 = original.ToLower();
        string s3 = original.Trim();
        int n1 = original.IndexOf("bc");
        int n2 = original.LastIndexOf("bc");
        string s4 = original.Substring(3);
        string s5 = original.Substring(3, 5);
        string s6 = original.Replace('a', 'x');
        string s7 = original.Replace("abc", "xy");
        bool b1 = String.IsNullOrEmpty(original);
        bool b2 = String.IsNullOrWhiteSpace(original);
        
        Console.WriteLine($"Original: -{original}-");
        Console.WriteLine($"ToUpper: -{s1}-");
        Console.WriteLine($"ToLower: -{s2}-");
        Console.WriteLine($"Trim: -{s3}-");
        Console.WriteLine($"IndexOf: -{n1}-");
        Console.WriteLine($"LastIndexOf: -{n2}-");
        Console.WriteLine($"Substring(3): -{s4}-");
        Console.WriteLine($"Substring(3, 5): -{s5}-");
        Console.WriteLine($"Replace('a', 'x'): -{s6}-");
        Console.WriteLine($"Replace('abc', 'xy'): -{s7}-");
        Console.WriteLine($"String.IsNullOrEmpty: -{b1}-");
        Console.WriteLine($"String.IsNullOrWhiteSpace: -{b2}-");
        
        // Date Time
        
        DateTime d1 = new DateTime(2024, 12, 27);
        DateTime d2 = new DateTime(2024, 12, 27, 20,15, 02);
        DateTime d3 = new DateTime(2024, 12, 27, 20,15, 02, 500);
        
        DateTime d4 = DateTime.Now;
        DateTime d5 = DateTime.Today;
        DateTime d6 = DateTime.UtcNow;
        
        DateTime d7 = DateTime.Parse("2024-12-27");
        DateTime d8 = DateTime.Parse("2024-12-27 13:55:59");
        DateTime d9 = DateTime.Parse("27/12/2024");
        DateTime d10 = DateTime.Parse("27/12/2024 17:10:11");
        DateTime d11 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
        DateTime d12 = DateTime.ParseExact("30/08/2000 18:30:55", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

        Console.WriteLine(d1);
        Console.WriteLine(d2);
        Console.WriteLine(d3);
        Console.WriteLine(d4);
        Console.WriteLine(d5);
        Console.WriteLine(d6);
        Console.WriteLine(d7);
        Console.WriteLine(d8);
        Console.WriteLine(d9);
        Console.WriteLine(d10);
        Console.WriteLine(d11);
        Console.WriteLine(d12);*/
        
        // Timespan
        TimeSpan diff = new TimeSpan();
        TimeSpan diff1 = new TimeSpan(900000000L);
        TimeSpan diff2 = new TimeSpan(2, 1, 30);
        TimeSpan diff3 = new TimeSpan(1,4, 11, 30);
        TimeSpan diff4 = new TimeSpan(1,4, 11, 30, 500);
        TimeSpan diff5 = TimeSpan.FromDays(1.5);
        TimeSpan diff6 = TimeSpan.FromHours(1.5);
        TimeSpan diff7 = TimeSpan.FromMinutes(1.5);
        TimeSpan diff8 = TimeSpan.FromSeconds(1.5);
        TimeSpan diff9 = TimeSpan.FromMilliseconds(1.5);
        TimeSpan diff10 = TimeSpan.FromTicks(900000000L);

        Console.WriteLine(diff);
        Console.WriteLine(diff1);
        Console.WriteLine(diff2);
        Console.WriteLine(diff3);
        Console.WriteLine(diff4);
        Console.WriteLine(diff5);
        Console.WriteLine(diff6);
        Console.WriteLine(diff7);
        Console.WriteLine(diff8);
        Console.WriteLine(diff9);
        Console.WriteLine(diff10);
    }
}
