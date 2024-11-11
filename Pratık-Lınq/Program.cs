class Program
{
    public static void Main(string[] args)
    {
        Random random = new Random();

        List<int> list = new List<int>();

        for (int i = 0; i < 10; i++)
        {
            int randomValue = random.Next(-50, 50);
            list.Add(randomValue);
        }
        Console.WriteLine("Listede bulunan sayılar:");
        foreach (var i in list)
        {
            Console.WriteLine(i);
        }

        var numbers = list.Where(x => x % 2 == 0).ToList();
        Console.WriteLine("Çift Sayılar:");
        foreach (var a in numbers)
        {
            Console.WriteLine(a);
        }
        var numbers2 = list.Where(x => x % 2 != 0).ToList();
        Console.WriteLine("Tek Sayılar:");
        foreach (var b in numbers2)
        {
            Console.WriteLine(b);
        }
        var numbers3 = list.Where(x => x < 0).ToList();
        Console.WriteLine("Negatif Sayılar:");
        foreach (var c in numbers3)
        {
            Console.WriteLine(c);
        }
        var numbers4 = list.Where(x => x > 0).ToList();
        Console.WriteLine("Pozitif Sayılar:");
        foreach (var d in numbers4)
        {
            Console.WriteLine(d);
        }
        var numbers5 = from x in list
                       where (x > 15 && x < 22)
                       select x;
        Console.WriteLine("15'ten büyük ve 22'den küçük sayılar:");
        foreach (var e in numbers5)
        {
            Console.WriteLine(e);
        }
        var numbers6 = list.Select(num => num * num);
        Console.WriteLine("Listede bulunan sayıların kareleri");
        foreach (var f in numbers6)
        {
            Console.WriteLine(f);
        }
    }
}