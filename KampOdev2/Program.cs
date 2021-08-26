using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampOdev2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> isimler = new MyDictionary<int, string>();
            isimler.Add(20, "Beyza");
            //Console.WriteLine(isimler.Length);
            isimler.Add(19, "Su");
            //Console.WriteLine(isimler.Length);

            foreach (var isim in isimler.Values)
            {
                Console.WriteLine(isim);
            }

            Console.WriteLine("Length: {0} ", isimler.Length);



            Console.ReadLine();
        
        
        }
    }
}
