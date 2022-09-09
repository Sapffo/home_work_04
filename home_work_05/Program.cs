Console.Clear();

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] RandomArray()
{
    Console.WriteLine(" Введите число элементов массива: ");
    int num = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[num];

    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(100, 1000);

    }

    return array;

}


int FilterArray(int[] array)
{
    int Sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) Sum = Sum + 1;

    }

    return Sum;
}

int[] NewArray = RandomArray();
Console.WriteLine($" [{String.Join(", ", NewArray)} ]");
int M = FilterArray(NewArray);
Console.WriteLine(M);


//*******************************************************************************************************************************************


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] RandomArray_2()
{
    Console.WriteLine(" Введите число элементов массива: ");
    int num = Convert.ToInt32(Console.ReadLine());

    int[] array_2 = new int[num];

    for (int i = 0; i < num; i++)
    {
        array_2[i] = new Random().Next(-1000, 1000);

    }

    return array_2;

}


int FilterArray_2(int[] array)
{
    int Sum_2 = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) Sum_2 = Sum_2 + 1;

    }

    return Sum_2;
}

int[] NewArray_2 = RandomArray_2();
Console.WriteLine($" [{String.Join(", ", NewArray_2)} ]");
int M_2 = FilterArray_2(NewArray_2);
Console.WriteLine(M_2);


//**********************************************************************************************************************************


/* Задача 38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.*/

double[] RandomArray_3()
{
    Console.WriteLine(" Введите число элементов массива: ");
    int num = Convert.ToInt32(Console.ReadLine());

    double[] array_3 = new double[num];

    for (int i = 0; i < num; i++)
    {
        array_3[i] = new Random().Next(1, 10);

    }

    return array_3;

}

double[] NewArray_3 = RandomArray_3();
Console.WriteLine($" [{String.Join(", ", NewArray_3)} ]");

double Findmax_min(double[] array)
{
    double max_number = array[0];
    double min_number = array[0];
    //double dif = max_number - min_number;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max_number) max_number = array[i];
        if (array[i] < min_number) min_number = array[i];
    }

    return max_number - min_number;

}

double M_3 = Findmax_min(NewArray_3);
Console.WriteLine(M_3);

