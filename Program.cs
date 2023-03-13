//Задача 25 Напишите цикл, который принимает на вход два числа (А и В)
// и возводит число А в натуральную степень В
Console.Write("Введите число A = ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число в которую следует возвести B = ");
int numberB = Convert.ToInt32(Console.ReadLine());
int Exsponent(int a, int b)
{
    int numberC = numberA;
    for (int i = 1; i < numberB; i++)
    {
        numberC = numberC * numberA;
    }
    return numberC;
}

bool NaturalNumbers(int b)
{
    if (b >= 1)
    {
        return true;
    }
    else
        Console.Write("Введена не натуральная степень");
    return false;
}
int exp = 1;
if (NaturalNumbers(numberB))
{
    exp = Exsponent(numberA, numberB);
    Console.WriteLine($"Введеное число = {numberA} в степени = {numberB} равно = {exp}");
}

