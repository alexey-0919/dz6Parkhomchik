/* Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

double InputCoordinat() 
{
Console.WriteLine("Input number");
double x = Convert.ToDouble(Console.ReadLine());
return x;
}

double k1 = InputCoordinat ();
double b1 = InputCoordinat ();
double k2 = InputCoordinat ();
double b2 = InputCoordinat ();



if (k1 == k2 && b1 == b2)
Console.WriteLine("Прямые совпадают");
else if ( k1 == k2)
Console.WriteLine("Прямые параллельны");

else
{
double z = (b2-b1)/(k1-k2);
double y1 = ((k1 * z) + b1);
double y2 = (k2 * z) + b2;
z = Math.Round(z, 3);
y1 = Math.Round(y1, 3);
Console.Write($"{z} ; {y1}");
}




