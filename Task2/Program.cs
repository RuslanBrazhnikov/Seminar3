Console.WriteLine("Введите x координату точки 1: ");
int xa1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y координату точки 1: ");
int ya1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите x координату точки 2: ");
int xb1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y координату точки 2: ");
int yb1 = int.Parse(Console.ReadLine());


double GetDist(int xa, int ya, int xb, int yb)
{
    double dx = xa - xb;
    double dy = ya - yb;
    return Math.Sqrt(dx * dx + dy * dy);
}

double result =  GetDist(xa1, xb1, ya1, yb1);
Console.WriteLine($"A ({xa1}, {xb1}), B ({ya1}, {yb1}) --> {Math.Round(result, 2, MidpointRounding.ToZero)}"); // округляем при помощи Math.Round()
