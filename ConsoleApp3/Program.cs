
#region verilmis araliqda tek ededlerin sayi
Console.WriteLine("Reqemleri daxil edin");
int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());

int count = 0;
if (n > m)
{

    Console.WriteLine("Reqemleri duzgun daxil edin");
}
else
{
    for (int i = n; i <= m; i++)
    {
        if (i % 2 == 1)
        {
            count += 1;
        }
    }
    Console.Write("Tek ededlerin sayi: ");
    Console.WriteLine(count);
}
#endregion