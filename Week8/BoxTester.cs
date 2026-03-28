namespace Week8;

public static class BoxTester
{
    public static void Test()
    {
        int a = 10;
        object b = a;
        int c = (int)b;

        Console.WriteLine($"Original a - {a}");
        Console.WriteLine($"Boxed b - {b}");
        Console.WriteLine($"Unboxed c - {c}");

        //Оскільки b це окрема копія в купі, то значення b не зміниться при зміні a

    }
}