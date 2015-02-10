using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pakol
{
    class Program
    {
        static void Main(string[] args)
        {
            var aa = File.ReadAllLines("pakol.be").Where(x=>x.Trim()!="").Select(y=>y.Trim().Split().Select(x => int.Parse(x)).ToList()).ToList();

            var a = aa[1];
            var n = aa[1][1]-1;
            var dd = aa[0][0];
            bool ris = false;

            int db = 0;
            if (a[0] < a[1])
            {
                ris = true;
                db = 0;
            }                        
            for (int i = 1; i < dd; i++)
            {
                if (ris)
                {
                    if (a[i] > n)
                    {
                        n = a[i];
                    }
                    else
                    {                        
                        db++;
                        ris = false;
                        n = a[i];
                    }
                }
                else
                {
                    if (a[i] > n)
                    {
                        n = a[i];
                        ris = true;
                    }
                    else
                        n = a[i];
                }
            }
            
            if (ris)
                db++;
 
            StreamWriter sw = new StreamWriter("pakol.ki") { AutoFlush = true };
            sw.WriteLine(db);

        }
    }
}
