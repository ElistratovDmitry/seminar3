//*Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void TestPallindrom(string n)
{
    int priznakpallindrom=1;
    for ( int i=0; i<2; i++)
    {
       if ( n[i] != n[ ( 5-1-i ) ]) 
       {
            Console.WriteLine( "not pallindrom");
            priznakpallindrom = 0;
            break;
        }
    }
    if (priznakpallindrom == 1) Console.WriteLine( "pallindrom !!!");
}

Console.WriteLine("Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
Console.WriteLine("enter a five digit number");
string number = Console.ReadLine();
if ( Convert.ToInt32 ( number ) < 10000 | ( Convert.ToInt32 ( number ) > 99999)) Console.WriteLine ("число не входит в диапазон"); // по условиям задачи - ТОЛЬКО ПЯТИЗНАЧНОЕ ЧИСЛО!

else TestPallindrom ( number );


/*Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84; A (7,-5, 0); B (1,-1,9) -> 11.53; */

double DistanceBetweenPpoints(int a1, int a2, int a3, int b1, int b2, int b3)
{
     double distance = Math.Sqrt( Math.Pow( (b1-a1) , 2)  + Math.Pow( (b2-a2) , 2) + Math.Pow( (b3-a3) , 2)   );
     return distance;                                    
}

Console.WriteLine();
Console.WriteLine("Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве");

Console.WriteLine("Input А(1)");
int a1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input А(2)");
int a2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input А(3)");
int a3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input B(1)");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input B(2)");
int b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input B(3)");
int b3 = Convert.ToInt32(Console.ReadLine());


double distance = DistanceBetweenPpoints(a1, a2, a3, b1, b2, b3);
Console.WriteLine ($"Дистанция меду точками : {Math.Round(distance, 2)}" );




//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void PrintCube (int number)
{
  Console.WriteLine($"таблица кубов от 1 до {number}");
  for (int i = 1; i<=number; i++)
    {
    Console.WriteLine(i*i*i);
    }  
}

Console.WriteLine("");
Console.WriteLine("Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N :");
Console.WriteLine("Input n");
int n = int.Parse(Console.ReadLine());

PrintCube(n);

