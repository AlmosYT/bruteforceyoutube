using System;

namespace chars
{
    class Program
{
    static void Main(string[] args)
    {
       char[] alpha = "aAbBcCdDeEfFgGhHiIjJkKlLmMnNoOpPqQrRsStTuUvVwWxXyYzZ".ToCharArray();
            for (int count = 0; count < 53; count++)
            {
                LoopThroughChar(alpha[count]);
                Console.WriteLine("LOOPING THROUGH - " + alpha[count]);
                if (Globalss.IsFound == true)
                {
                    Console.WriteLine("Is Found!");
                    break;
                }
            }
            Console.ReadKey();
            
    }
        static void LoopThroughChar(char chartoloop)
        {
            char[] alpha = "aAbBcCdDeEfFgGhHiIjJkKlLmMnNoOpPqQrRsStTuUvVwWxXyYzZ".ToCharArray();
            for (int count = 0; count < 52; count++)
            {
                Console.WriteLine(alpha[count]);
                string contents;
                using (var wc = new System.Net.WebClient())
                {
                    contents = wc.DownloadString("https://www.youtube.com/oembed?url=http://www.youtube.com/watch?v=KkXsZJqLG" + chartoloop + alpha[count]);
                    Console.WriteLine(contents + " raw");
                }
                string url = "https://www.youtube.com/oembed?url=http://www.youtube.com/watch?v=KkXsZJqLG" + chartoloop + alpha[count];
                Console.WriteLine(url);
                if (contents == "Not Found")
                {
                    Console.WriteLine("Next...");
                }
                else if (contents == "Bad Request")
                {
                    Console.WriteLine("Next...");
                }
                else
                {
                    Console.WriteLine("FOUND!");
                    Globalss.IsFound = true;
                    break;
                }
            }
        }

   }
    static class Globalss
    {
        public static bool IsFound;
    }
}
