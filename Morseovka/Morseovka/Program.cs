using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Morseovka
{
    class Program
    {
        private static string id = "qlR4TYSw1U1VimB0TqhZq6jSXwFn0yt7"; // id našeho týmu
        private static string web = "http://ioe.zcu.cz/morse.php?id="; 
        static void Main(string[] args)
        {
            var client = new WebClient();
            string url = web + id;
            string data = client.DownloadString(url);
            Console.WriteLine(data);
            Console.ReadKey();
        }

    }
}
