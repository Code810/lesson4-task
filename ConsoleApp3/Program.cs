





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

#region task2_sade_murekkeb_eded
//Console.WriteLine("Reqemi daxil edin:");
//int n = int.Parse(Console.ReadLine());
//int m = 2;
//bool result = false;
//while (m<n)
//{
//    if (n % m == 0)
//    {
//        result = true;
//        m = n;
//    }

//    else
//        m++;
//}
//if (result)
//{
//    Console.WriteLine("Murekkeb reqem");
//}
//else
//{
//    Console.WriteLine("Sade reqem");
//}



#endregion

#region task3_2nin_quvveti
Console.WriteLine("Reqemi daxil edin");
int n = int.Parse(Console.ReadLine());
int m = 1;
bool result = false;

while (m < n)
{

    if (m * 2 == n)
    {
        result = true;
        m = n;
    }
    else

        m = m * 2;
}

if (result == true)
{
    Console.WriteLine("2-nin quvvetidir");
}
else
{
    Console.WriteLine("2-nin quvveti deyil");
}


#endregion

#region task4_mertebelerin_sayi
//Console.WriteLine("Reqem daxil edin:");
//int n = int.Parse(Console.ReadLine());
//int m = 10;
//int count = 1;
//while (n > m)
//    if (n/m!=0)
//    {
//        n=n/m;
//        count += 1;
//    }

//Console.Write("Daxil etdiyiniz reqem ");
//Console.Write(count);
//Console.WriteLine(" mertebelidir");
#endregion


