int a0 = 0, a1 = 1, a2, n = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    a2 = a1 + a0;
    a0 = a1;
    a1 = a2;
    Console.Write(a2);
    Console.Write(" ");
}
