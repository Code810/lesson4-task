
#region task1_tek_ededlerin_sayi

Console.WriteLine("Reqemleri daxil edin");
int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());

int count = 0;
while (n > m)
{
    Console.WriteLine("Reqemleri duzgun daxil edin");
     n = int.Parse(Console.ReadLine());
     m = int.Parse(Console.ReadLine());
}
    
    for (int i = n; i <= m; i++)
    {
        if (i % 2 == 1)
        {
            count += 1;
        }
    }
    Console.Write("Tek ededlerin sayi: ");
    Console.WriteLine(count);

#endregion
#region sade_murekkeb eded
//int n = 5;




#endregion