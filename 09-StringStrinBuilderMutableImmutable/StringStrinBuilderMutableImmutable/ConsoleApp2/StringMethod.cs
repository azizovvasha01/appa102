using System;
using System.Text;

#region 1.Verilmis string-de sait herflewrin tapilmasi
//class Program
//{
//    static void Main()
//    {
//        string cumle = "Azizovva Denizz";
//        SaitHerfler(cumle);
//    }

//    static void SaitHerfler(string cumle)
//    {
//        string saitler = "aəeiıoöuüAƏEIİOÖUÜ";
//        StringBuilder sb = new StringBuilder();

//        for (int i = 0; i < cumle.Length; i++)  
//        {
//            char herf = cumle[i];
//            if (saitler.Contains(herf)) 
//            {
//                sb.Append(herf).Append(' ');  
//            }
//        }

//        Console.WriteLine("Cümlədəki saitlər:");
//        Console.WriteLine(sb.ToString());
//    }
//} 
#endregion



#region 2.Verilmish string-de sozlerin bosluga gore sayi.
//using System;
//using System.Text;

//class Program
//{
//    static void Main()
//    {
//        string cumle = "Azizova Deniz zz";
//        StringBuilder sb = new StringBuilder(cumle);

//        int say = 0;
//        for (int i = 0; i < sb.Length; i++)
//            if (sb[i] == ' ') say++;

//        Console.WriteLine(say );
//    }
//} 
#endregion



#region 4.Verilmiş string-in bütün hərfləri böyük olan sözün özünü və indeksini çapa çıxaran proqram yazın.

using System;

//class Program
//{
//    static void Main()
//    {
//        string cumle = "Bu HEYATT və ABC123 TEST və SAALAM dünyaaa EXAMPLE!";
//        string[] sozler = cumle.Split(' ');

//        for (int i = 0; i < sozler.Length; i++)
//        {
//            if (sozler[i].ToUpper() == sozler[i])
//                Console.WriteLine($"Söz: \"{sozler[i]}\", Söz indeksi: {i}");
//        }
//    }
//}

#endregion



using System;

#region 5. Verilmiş string-in 2-dən artıq böyük hərfi olan elementlərini çapa çıxaran proqram yazın.

//class Program
//{
//    static void Main()
//    {
//        string cumle = "Bu IS və ABC123 TEST və SAALAMM dünya!";
//        string[] sozler = cumle.Split(' ');

//        for (int i = 0; i < sozler.Length; i++)
//        {
//            int boyuk = 0;
//            for (int j = 0; j < sozler[i].Length; j++)
//                if (char.IsUpper(sozler[i][j])) boyuk++;

//            if (boyuk > 2) Console.WriteLine(sozler[i]);
//        }
//    }
//} 
//#endregion



#region 3.Verilmiş stringin-in ən uzun sözünü ekrana çıxaran proqram yazın
class Program
{
    static void Main()
    {
        string cumle = "Salam necesen Dost, bugun hava necedi?";
        string[] sozler = cumle.Split(' ');

        string enUzun = "";
        for (int i = 0; i < sozler.Length; i++)
            if (sozler[i].Length > enUzun.Length)
                enUzun = sozler[i];

        Console.WriteLine("Ən uzun söz: " + enUzun);
    }
}


#endregion
