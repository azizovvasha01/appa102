

//#region 1.Hər biri 2 parametr qəbul edib və riyazi əməlləri yerinə yetiren method yazin.

//using System.Diagnostics.CodeAnalysis;

//int Emeliyyatlar(int a, int b, char c)
//{
//    int netice = 0;
//    switch (c)
//    {
//        case '+':
//            netice = a + b;
//            break;
//        case '-':
//            netice = a - b;
//            break;
//        case '*':
//            netice = a * b;
//            break;
//        case '/':
//            netice = a / b;
//            break;

//    }
//    return netice;



//}
//int resualt = Emeliyyatlar(5, 3, '*');
//Console.WriteLine(resualt);
//#endregion

//#region 2.Verilen arqumentlere uygun tek ve cut edeleri tapan method yazin.(14, 20, 35, 40, 57, 60, 100)
//void CutTek(params int[] a)
//{
//    Console.WriteLine("cut ededler");
//    for (int i = 0; i < a.Length; i++)
//    {

//        if (a[i] % 2 == 0)
//        {
//            Console.WriteLine(a[i]);


//        }


//    }
//    Console.WriteLine("tek ededler");
//    for (int i = 0; i < a.Length; i++)
//    {

//        if (a[i] % 2 == 1)
//        {
//            Console.WriteLine(a[i]);


//        }


//    }
//}
////CutTek(14, 20, 35, 40, 57, 60, 100);
//#endregion


//#region 3.Verilmis arreyde elementlerin həm 4-ə, həm də 5-ə bölününen elementlerin cemini tapin.[14, 20, 35, 40, 57, 60, 100]
//int ElementlerinCemi(int[] a)
//{
//    int sum = 0;
//    for (int i = 0; i < a.Length; i++)
//    {
//        if (a[i] % 4 == 0 && a[i] % 5 == 0)
//        {
//            sum += a[i];

//        }





//    }
//    return sum;
//}
//int[] arr = [14, 20, 35, 40, 57, 60, 100];
//Console.WriteLine(ElementlerinCemi(arr));
//#endregion



#region Daxil edilmiş cümlədə daxil edilmis simvoldan nece eded olduğunu tapan Proqramın alqoritmini yazin.(Cumle serbestdir).
int SinvolSayi(string cumle, char sinvol)
{
    int say = 0;
    for (int i = 0; i < cumle.Length; i++)
    {
        if (cumle[i] == sinvol)
            say++;

    }
    return say;

}
string cumle = "alma almaq";
char sinvol = 'a';
Console.WriteLine(SinvolSayi(cumle, sinvol)); 
#endregion