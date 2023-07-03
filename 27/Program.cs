

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int GetSum(int n)
{
    int sum = 0;
    sum = NewMethod(n, sum);
    bool i = false;
    Console.WriteLine(i);
    return sum;

    static int NewMethod(int n, int sum)
    {
        for (int i = 1; i <= n; i++)
            sum += i;
        return sum;
    }
}
Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int result = GetSum(n);
Console.WriteLine($"Сумма от 1 до {n} равна {result}");

