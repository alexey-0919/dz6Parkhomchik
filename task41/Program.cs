string str = Console.ReadLine();

var arr = str.Split(" ");

int[] arrint = new int [arr.Length];

for (int i = 0; i < arr.Length; i++)
{
    arrint[i] = Convert.ToInt32(arr[i]);
}

Console.Write("[");
foreach (var item in arrint)
{
    System.Console.Write(" " + item);
}
Console.Write(" ]");

int j = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arrint[i] > 0)
    j = j + 1;
}
Console.WriteLine();
Console.WriteLine("Чисел больше нуля — " + j);