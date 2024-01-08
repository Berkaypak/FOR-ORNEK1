using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOR_ORNEK1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // KULLANICI TARAFINDAN GİRİLEN 2 SAYININ ARASINDAKİ SAYILARIN FAKTÖRİYELLERİNİN TOPLAMI
            Console.Write("1.SAYIYI GİRİNİZ : ");
            int gs1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. SAYIYI GİRİNİZ : ");
            int gs2 = Convert.ToInt32(Console.ReadLine());
            int k = (gs1 < gs2) ? gs1 : gs2;
            int b = (gs1 > gs2) ? gs1 : gs2;
            int f ; int t = 0;
            for ( int i=k; i<=b;i++)
            {
                f = 1;
                for (int j = i; j > 0; j--)
                {
                    f = f * j;
                }
                t = f + t;
            }
            Console.WriteLine("TOPLAM : "+t);
            Console.ReadLine();
        }
    }
}
