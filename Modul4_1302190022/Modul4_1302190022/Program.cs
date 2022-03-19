using System;

namespace Modul4_1302190022
{
    class Program
    {
        static void Main (string[] args)
        {
            Penjumlahan<dynamic> penambahan = new Penjumlahan<dynamic> ();
            float x = 13; 
            float y = 02; 
            float z = 19;

            Console.WriteLine(penambahan.JumlahTigaAngka (x, y, z));

            SimpleDataBase<string> database = new SimpleDataBase<string>();
            string[] data1 = {"13"};
            database.AddNewData(data1);
            database.PrintAllData();

        }

    }
}