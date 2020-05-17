using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ob_stringDizi
{
    class Program
    {
        static void Main(string[] args)
        {
            string yazi = "Mer!habalar";
            //string nesnelerinin tutulduğu karakterlere dizi erişim operatörleri ([]) ile erişilebilir.
            Console.WriteLine("yazi[0].....:{0}", yazi[0]);   //stringin ilk rakamını çıkarır.
            Console.WriteLine("yazi[1].....:{0}", yazi[1]);
            Console.WriteLine("yazi[2].....:{0}", yazi[2]);
            Console.WriteLine("Yazının uzunluğu kaçtır?.....:{0}", yazi.Length);  //yazının uzunluğu sayısal
            
            for(int i=0; i<yazi.Length;i++)
            {
                Console.WriteLine("Sıradaki harf..:{0}", yazi[i]);
            }

        }
    }
}
