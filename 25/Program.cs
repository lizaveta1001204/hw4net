//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


  Console.Write("Введите число   : ");
  int num1 = int.Parse(Console.ReadLine()!);
  Console.Write("Введите степень : ");
  int num2 = int.Parse(Console.ReadLine())!;
int Exponentiation(int num1, int num2)
{
  int result = 1;
  for(int i=1; i <= num2; i++){
    result = result * num1;
  }
    return result;
}
int exponentiation = Exponentiation(num1, num2);
  Console.WriteLine("Ответ: " + exponentiation);