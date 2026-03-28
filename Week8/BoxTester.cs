namespace Week8;

public static class BoxTester
{
    public static void Test()
    {
        //Створюємо змінну, що зберігається в стеку
        int a = 10;
        //ми присвоюємо змінній b типу object значення змінної а
        //.NET створює новий об'єкт у купі та передає туди значення змінної а тобто 10
        object b = a;
        //Значення копіюється назад в стек і це значення буде зберігатись в змінній с
        int c = (int)b;

        Console.WriteLine($"Original a - {a}");
        Console.WriteLine($"Boxed b - {b}");
        Console.WriteLine($"Unboxed c - {c}");
        

    }
}