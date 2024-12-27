using System.Globalization;

namespace TopicosEspeciais1;

class Program
{
    static void Main(string[] args)
    {
        //inferencia: palavra var

        var x = 10;
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
    }
}
