int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
var random = new Random();
for(int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(100, 999);
}
Console.WriteLine();
Console.WriteLine("[" + string.Join(",", array) + "]");
for(var i = 0; i < array.Length/2; i++)
{
    (array[i], array[array.Length - (i + 1)]) = (array[array.Length - (i + 1)], array[i]);
}
Console.WriteLine();
Console.WriteLine("[" + string.Join(",", array) + "]");