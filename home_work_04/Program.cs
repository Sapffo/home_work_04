/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


Console.WriteLine("введите число A");
int Z = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите число B");
int C = Convert.ToInt32(Console.ReadLine());

int Multiply ( int A, int B)
{
int num = 1;
for ( int i = 1; i <= B; i++)
{
if ( B != 1) num = num * A;
else num = A;
}

return num;

}

int N = Multiply (Z, C);

Console.WriteLine(N);*/

//--------------------------------------------------------------------------------------------------------------------------------------------------------


/* 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());


int Sum ( int A)
{
int num1 = 0;

for ( int i = A; i > 0; i/=10)
{
num1 = num1 + i % 10;
}
return num1;
}

int M = Sum(num);
Console.WriteLine(M); */

//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

/* 29.  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.WriteLine(" Введите восемь чисел: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
int num4 = Convert.ToInt32(Console.ReadLine());
int num5 = Convert.ToInt32(Console.ReadLine());
int num6 = Convert.ToInt32(Console.ReadLine());
int num7 = Convert.ToInt32(Console.ReadLine());
int num8 = Convert.ToInt32(Console.ReadLine());

string text1 = Convert.ToString(num1);
string text2 = Convert.ToString(num2);
string text3 = Convert.ToString(num3);
string text4 = Convert.ToString(num4);
string text5 = Convert.ToString(num5);
string text6 = Convert.ToString(num6);
string text7 = Convert.ToString(num7);
string text8 = Convert.ToString(num8);

string mesage = text1 + text2 + text3 + text4 + text5 + text6 + text7 + text8;




    string [] mesage1 = new string [] {mesage};

    Console.WriteLine();

    
        






