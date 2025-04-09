using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("saat ra vared kon");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x >= 0 && x <= 6)
            {
                Console.WriteLine("Nime Shab Be Kheir");
            }
            else if (x >= 6 && x <= 12)
            {
                Console.WriteLine("sobh");
            }
            else if (x >= 12 && x <= 18)
            {
                Console.WriteLine("bad az zohr");
            }
            else if (x >= 18 && x <= 24)
            {
                Console.WriteLine("shab");
            }
            else
            {
                Console.WriteLine("eshtebah ast");
            }







        }
    }
}

//.برای سارا از ساعت ۰ تا ۶، نیمه شب، ۶ تا ۱۲، صبح، ۱۲ تا ۱۸، بعد از ظهر و ۱۸ تا ۲۴ شب می باش

