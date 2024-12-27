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
    }
}
