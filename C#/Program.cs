class MyClass
{
    public static void Main()
    {
        int i = 1;
        while (true)
        {
            Console.WriteLine(i);
            if (i == 39) { i = 61; continue; }
            i++;

            if (i > 100)
            {
                break;
            }
        }
    }
}