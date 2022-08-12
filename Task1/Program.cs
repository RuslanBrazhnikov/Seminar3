Console.WriteLine("Введите название четверти от 1 до 4: ");
int x = int.Parse(Console.ReadLine());



// int quarter = 0;

// if (x > 0 && y > 0) quarter = 1;
// else if (x < 0 && y > 0) quarter = 2;
// else if (x < 0 && y < 0) quarter = 3;
// else if (x > 0 && y < 0) quarter = 4;

// if (x != 0 && y != 0)
//     Console.WriteLine($"{quarter} четверть");
// else Console.WriteLine("Введены некорректные данные");


string GetCoordinat(int qua)
{
    
    if (qua == 1)  return "x > 0, а y > 0";
    if (qua == 2) return "x < 0  y > 0";
    if (qua == 3) return "x < 0  y < 0";
    if (qua == 4) return "x > 0  y < 0";
    return "Введены некорректные данные";
}

string result = GetCoordinat(x);
Console.WriteLine(result);






// if (x > 0 && y > 0) Console.WriteLine("Первая четверть");
// else if (x < 0 && y > 0) Console.WriteLine("Вторая четверть");
// else if (x < 0 && y < 0) Console.WriteLine("Третья четверть");
// else if (x > 0 && y < 0) Console.WriteLine("Четвертая четверть");
// else Console.WriteLine("Введены некорректные данные");