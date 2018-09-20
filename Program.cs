using System;

class Program
    {
        static void Main()
        {

            bool f1 = true;
            bool f2 = false;
            float a = 12.45f;

            Console.WriteLine(f1);
            Console.WriteLine(!f1);
        Console.WriteLine("логическое И " + (f1 && f2));
        Console.WriteLine("логическое ИЛИ " + (f1 || f2));
        Console.WriteLine("логическое исключающее ИЛИ " + (f1 ^ f2));
        Console.WriteLine(12345.456.ToString("# ## ##.##"));
        //PrintInfo();

        Console.ReadKey();

        }

    private static void PrintInfo()
    {
        Console.WriteLine("Сколько конфет у Ивана");
        int user1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Сколько конфет у Петра");
        int user2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Всего конфет " + (user1 + user2));
        Console.ReadKey();
        
    }
}
