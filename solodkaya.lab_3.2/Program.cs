int P = 1;
int n = int.MinValue;
do
{
    n = int.Parse(Console.ReadLine());
    if (n != 0) P *= n;
}
while (n != 0);
Console.WriteLine(P);