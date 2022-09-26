using System;


namespace Degiskenler{
class Programn
{
    private static void Main(string[] args)
    {
        Console.WriteLine("");

        byte b = 5; //1 byte
        sbyte c = 5; //1 byte

        short s = 5; //2 byte
        ushort us = 5; //2 byte

        Int16 i16 = 2; //2 byte
        int i = 2;  //4 byte
        Int32 i32 = 2; //4 byte
        Int64 i64 =2; //8byte

        uint ui = 2; //4 byte
        long l = 4; //8 byte
        ulong ul = 4; //8 byte

        float f = 5; //4byte
        double d = 5; //8 byte
        decimal de = 5; //16 byte

        char ch = '2'; // 2 byte
        string str = "kerim"; // sınırsız
        bool b1 = true;
        bool b2 = false;

        DateTime dt = DateTime.Now;
        Console.WriteLine(dt);

        object a1 = "x";
        object a2 = 'y';
        object a3 = 4 ;
        object a4 = 4.3;

        //string ifadeler

        string str1 = "kerim çetinkaya";
        string ad = "kerim";
        string soyAd = "çetinkaya";
        string tamIsim = ad + " " + soyAd;

        //integer ifadeler

        int integer1 = 5;
        int integer2 = 3;
        int integer3 = integer1 * integer2;

        //boolean

        bool bool1 = 10<2;

        //Tip Dönüşümleri

        string str20 = "20";
        int int20 = 20;

        string yeniDeger = str20 + int20.ToString();
        Console.WriteLine(yeniDeger); // çıktısı 2020

        int int21 = int20 + Convert.ToInt32(str20);
        Console.WriteLine(int21); // çıktısı 40

        int int22 = int20 + int.Parse(str20);
        Console.WriteLine(int22); // çıktısı 40

        // datetime

        string datetime = DateTime.Now.ToString("dd.mm.yyyy");
        Console.WriteLine(datetime);

        string datetime1 = DateTime.Now.ToString("dd/mm/yyyy");
        Console.WriteLine(datetime1);

        string datetime2 = DateTime.Now.ToString("hh:mm");
        Console.WriteLine(datetime2);


    }
}
}