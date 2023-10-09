

#region task1_tek_ededlerin_sayi

//Console.WriteLine("Reqemleri daxil edin");
//int n = int.Parse(Console.ReadLine());
//int m = int.Parse(Console.ReadLine());

//int count = 0;
//while (n > m)
//{
//    Console.WriteLine("Reqemleri duzgun daxil edin");
//     n = int.Parse(Console.ReadLine());
//     m = int.Parse(Console.ReadLine());
//}

//    for (int i = n; i <= m; i++)
//    {
//        if (i % 2 == 1)
//        {
//            count += 1;
//        }
//    }
//    Console.Write("Tek ededlerin sayi: ");
//    Console.WriteLine(count);

#endregion
#region sade_murekkeb_eded
Console.WriteLine("Reqemi daxil edin:");
int n = int.Parse(Console.ReadLine());
int m = 2;
bool result = false;
while (m<n)
{
    if (n % m == 0)
    {
        result = true;
        m = n;
    }
       
    else
        m++;
}
if (result)
{
    Console.WriteLine("Murekkeb reqem");
}
else
{
    Console.WriteLine("Sade reqem");
}



#endregion