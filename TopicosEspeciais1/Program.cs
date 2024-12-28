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
        Console.WriteLine(d12);
        
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
        
        // Propriedades com DateTime
        
        DateTime dateTime = new DateTime(2001, 8, 15, 13, 45,58, 275);
        
        Console.WriteLine(dateTime);
        Console.WriteLine($"1 - Date: {dateTime.Date}");
        Console.WriteLine($"2 - Day: {dateTime.Day}");
        Console.WriteLine($"3 - DayOfWeek: {dateTime.DayOfWeek}");
        Console.WriteLine($"4 - DayOfYear: {dateTime.DayOfYear}");
        Console.WriteLine($"5 - Hour: {dateTime.Hour}");
        Console.WriteLine($"6 - Kind: {dateTime.Kind}");
        Console.WriteLine($"7 - Millisecond: {dateTime.Millisecond}");
        Console.WriteLine($"8 - Minute: {dateTime.Minute}");
        Console.WriteLine($"9 - Month: {dateTime.Month}");
        Console.WriteLine($"10 - Second: {dateTime.Second}");
        Console.WriteLine($"11 - Ticks: {dateTime.Ticks}");
        Console.WriteLine($"12 - TimeOfDay: {dateTime.TimeOfDay}");
        Console.WriteLine($"13 - Year: {dateTime.Year}");

        string stringLongDateTime = dateTime.ToLongDateString();
        string stringLongTime = dateTime.ToLongTimeString();
        string stringShortDateTime = dateTime.ToShortDateString();
        string stringShortTime = dateTime.ToShortTimeString();
        string stringDateTime = dateTime.ToString();
        string stringDateTimeFormated = dateTime.ToString("yyyy-MM-dd HH:mm:ss");
        string dateTimeFormated = dateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
        
        Console.WriteLine(stringLongDateTime);
        Console.WriteLine(stringLongTime);
        Console.WriteLine(stringShortDateTime);
        Console.WriteLine(stringShortTime);
        Console.WriteLine(stringDateTime);
        Console.WriteLine(stringDateTimeFormated);
        Console.WriteLine(dateTimeFormated);
        
        DateTime dateTime1 = new DateTime(2001, 8, 25, 17, 15,00, 500);
        DateTime dateTime2 = dateTime.AddHours(2);
        DateTime dateTime3 = dateTime.AddMinutes(3);
        DateTime dateTime4 = dateTime.AddDays(7);
        
        TimeSpan difference = dateTime1.Subtract(dateTime);
        
        Console.WriteLine(difference);
        
        Console.WriteLine(dateTime);
        Console.WriteLine(dateTime1);
        Console.WriteLine(dateTime2);
        Console.WriteLine(dateTime3);
        Console.WriteLine(dateTime4);
        
        // Propriedades com TimeSpan
        
        TimeSpan t1 = TimeSpan.MaxValue;
        TimeSpan t2 = TimeSpan.MinValue;
        TimeSpan t3 = TimeSpan.Zero;
        TimeSpan t4 = new TimeSpan(2, 3, 5, 7 ,11);
        TimeSpan t5 = new TimeSpan(1, 30, 10);
        TimeSpan t6 = new TimeSpan(0, 10, 5);

        Console.WriteLine(t1);
        Console.WriteLine(t2);
        Console.WriteLine(t3);
        
        Console.WriteLine($"Days: {t4.Days}");
        Console.WriteLine($"Hours: {t4.Hours}");
        Console.WriteLine($"Minutes: {t4.Minutes}");
        Console.WriteLine($"Seconds: {t4.Seconds}");
        Console.WriteLine($"Milliseconds: {t4.Milliseconds}");
        Console.WriteLine($"Ticks: {t4.Ticks}");
        
        Console.WriteLine($"TotalDays: {t4.TotalDays}");
        Console.WriteLine($"TotalHours: {t4.TotalHours}");
        Console.WriteLine($"TotalMinutes: {t4.TotalMinutes}");
        Console.WriteLine($"TotalSeconds: {t4.TotalSeconds}");
        Console.WriteLine($"TotalMilliseconds: {t4.TotalMilliseconds}");
        
        TimeSpan soma = t5.Add(t6);
        TimeSpan sub = t5.Subtract(t6);
        TimeSpan multi = t6.Multiply(2);
        TimeSpan div = t6.Divide(2);

        Console.WriteLine(soma);
        Console.WriteLine(sub);
        Console.WriteLine(multi);
        Console.WriteLine(div);
        
        // DateTimeKind e padrão ISO-8601
        // Sempre armazenar UTC, mas na hora de exibir, mostrar no Local
        
        DateTime dt = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
        DateTime dt1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
        DateTime dt2 = new DateTime(2000, 8, 15, 13, 5, 58);

        Console.WriteLine($"dt: {dt}");
        Console.WriteLine($"dt Kind: {dt.Kind}");
        Console.WriteLine($"dt To Local: {dt.ToLocalTime()}");
        Console.WriteLine($"dt To Utc: {dt.ToUniversalTime()}");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine($"dt1: {dt1}");
        Console.WriteLine($"dt1 Kind: {dt1.Kind}");
        Console.WriteLine($"dt1 To Local: {dt1.ToLocalTime()}");
        Console.WriteLine($"dt1 To Utc: {dt1.ToUniversalTime()}"); 
        Console.WriteLine("------------------------------------------");
        Console.WriteLine($"dt2: {dt2}");
        Console.WriteLine($"dt2 Kind: {dt2.Kind}");
        Console.WriteLine($"dt2 To Local: {dt2.ToLocalTime()}");
        Console.WriteLine($"dt2 To Utc: {dt2.ToUniversalTime()}");
        
        // ISO-8601
        
        DateTime dateT = DateTime.Parse("2000-08-15 13:05:58");
        DateTime dateT1 = DateTime.Parse("2000-08-15T13:05:58Z");

        Console.WriteLine(dateT);
        Console.WriteLine(dateT1);
        Console.WriteLine($"dateT: {dateT}");
        Console.WriteLine($"dateT Kind: {dateT.Kind}");
        Console.WriteLine($"dateT To Local: {dateT.ToLocalTime()}");
        Console.WriteLine($"dateT To Utc: {dateT.ToUniversalTime()}");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine($"dateT1: {dateT1}");
        Console.WriteLine($"dateT1 Kind: {dateT1.Kind}");
        Console.WriteLine($"dateT1 To Local: {dateT1.ToLocalTime()}");
        Console.WriteLine($"dateT1 To Utc: {dateT1.ToUniversalTime()}"); 
        Console.WriteLine("------------------------------------------");
        Console.WriteLine(dateT1.ToString("yyyy-MM-ddTHH:mm:ssZ")); // necessário converter para UTC antes
        Console.WriteLine(dateT1.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
    
    }
}
