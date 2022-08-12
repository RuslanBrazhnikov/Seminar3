Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());


void PrintQuart(int a)
{
    if (n >= 0)
    {
        for (int i = 1; i <= a; i++) // Перебираем в цикле For от 1 до a
        Console.WriteLine($"{i} \t {i * i}"); // t\ - это цифра с новой строчки
    }
    

    if (n < 1) 
    {
        Console.WriteLine("Введите число > 1");
        return;
    }
}
    PrintQuart(n);