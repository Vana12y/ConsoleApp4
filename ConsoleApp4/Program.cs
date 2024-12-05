// Задание 1
Console.WriteLine("Введите число: ");
string c = Console.ReadLine();
int a = Convert.ToInt32(c);
Persistenc(a);
static int Persistenc(int a)
{
    int t = 0;
    string b = Convert.ToString(a, 2);
    Console.WriteLine(b);

    foreach (char g in b)
    {
        if (g == '1')
        {
            t += 1;
        }
    }
    Console.WriteLine("Ответ: " + t);
    return 0;
}



// Задание 2
Console.WriteLine("Введите число: ");
string n = Console.ReadLine();
int num = Convert.ToInt32(n);
Persistence(num);
static int Persistence(int num)
{
    if (num <= 9)
        return 0;

    int ccc = 0;

    while (num >= 10)
    {
        int ggg = 1;

        while (num > 0)
        {
            ggg *= num % 10;
            num /= 10;
        }

        num = ggg;
        ccc++;
    }
    Console.WriteLine(num);
    return ccc;

}


// Задание 3
Console.WriteLine("Введите число: ");
string nn = Console.ReadLine();
int num2 = Convert.ToInt32(nn);
DigitalRoot(num);
static int DigitalRoot(int num)
{
    if (num <= 9)
        return 0;

    int ccc = 0;

    while (num >= 10)
    {
        int ggg = 1;

        while (num > 0)
        {
            ggg += num % 10;
            num /= 10;
        }

        num = ggg;
        ccc++;
    }
    Console.WriteLine(num);
    return ccc;

}
