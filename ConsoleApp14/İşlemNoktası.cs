using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class İşlemNoktası
    {
        static void Main(string[] args) 
        {
            Müşteriler müşteriler = new Müşteriler();
            müşteriler.HesapNo = 292636;
            müşteriler.İsim = "Fatih";
            müşteriler.Soyisim = "Gart";
            müşteriler.Malvarlıkları = "Nike Air Jordan(Sınırsız)";
            Console.WriteLine(müşteriler.HesapNo);
            Console.WriteLine(müşteriler.İsim);
            Console.WriteLine(müşteriler.Soyisim);
            Console.WriteLine(müşteriler.Malvarlıkları);
            Console.ReadLine();

        }        
    }

       
}
