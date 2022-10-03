// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Write("В ведите размер массива: ");
int number = int.Parse(Console.ReadLine());
double[] array = new double[number];
double min = 0;
double max = 0;
for (int i = 0; i < number; i++)
{
    array[i] = new Random().NextDouble();
    min = array.Min();
    max = array.Max();
}
double diffnumber = max - min;

void PrintArrTo(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("Число мин : " + min + " Число мах : " + max + " разница между числами " + "[ " + diffnumber + " ] ");
    Console.WriteLine("Число мин : " + min);
    Console.WriteLine("Число мах : " + max );
    Console.WriteLine("Разница между числами " + "[ " + diffnumber + " ] ");
}

PrintArrTo(array);

// что то я не допер ка заполнить массиф числами введенные через консоль. Ни одна из перегрузок метода "NextDouble" не принимает 1 арг 
// ументов.




