using System;

namespace tekmi.ciftmi;

class Program


{
    static void Main(string[] args)

    {
        Console.WriteLine("SAYI GİRİNİZ..");
        int girilensayi = int.Parse(Console.ReadLine());

        if (girilensayi %2 == 0)
         {
            Console.WriteLine("ÇİFT SAYI GİRDİNİZ.");
        }
        else
        {
            Console.WriteLine("TEK SAYI GİRDİNİZ.");
        }


    }
}
