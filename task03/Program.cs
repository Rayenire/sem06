int  count = 0, x, n = Convert.ToInt32(Console.ReadLine());
List<int> array = new List<int>();
while (n > 0)
{
    x = n % 2;
    array.Add(x);
    count++;
    //Console.Write(x);
    n /= 2;
}
for (int i = count - 1; i >= 0; i--)
{
    Console.Write(array[i]);
}
