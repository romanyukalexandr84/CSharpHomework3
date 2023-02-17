Console.WriteLine ("Введите целое число N");
int number = Convert.ToInt32 (Console.ReadLine());
int index = 1;
Console.WriteLine ("Кубы чисел от 1 до N включительно:");
if (number>=1)
{
    while (index <= number)
{
    Console.Write (Math.Pow(index,3) + " ");
    index++;
}
}
else
{
    while (index >= number)
{
    Console.Write (Math.Pow(index,3) + " ");
    index--;
}
}
Console.WriteLine();