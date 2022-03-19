using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Modul4_1302190022
{
    internal class SimpleDataBase<T>
    {
        private T[] storedData = new T[10];
        private DateTime[] inputDate = new DateTime[10];

        public void AddNewData(T[] data)
        {
            this.storedData = data;
            DateTime inputData = DateTime.Now;
        }

        public void PrintAllData()
        {
            for (int i = 0; i < storedData.Length; i++)
            {
                Console.WriteLine("Data " + i + 1 + " berisi: " + storedData[i] + " yang disimpan pada waktu" + inputDate[i]);
            }
        }
    }
}
