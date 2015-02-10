using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tag
{
    public static class ext
    {
        public static int rec(this List<List<int>> a, int s)
        {
            int n = 1;
            a.Where(x => x[1] == s).ToList().ForEach(x => { n += a.rec(x[0]); });
            return n;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int asd = 0;
            var a = File.ReadAllLines("tag.be").Select(x=>x.Split().Select(y=>int.TryParse(y,out asd) ? int.Parse(y) : (y.ToUpper() == "A" ? 0 : 1)).ToList()).ToList();
            a.RemoveAt(0);
            var n = a.rec(1);
            StreamWriter sw = new StreamWriter("tag.ki") { AutoFlush = true};
            sw.WriteLine(2 - a.Where(x => x[1] == 1).Count());
            var f2 = a.Where(x => x[1] == 1 && x[2] == 0);
            if (f2.Count() == 1)
                sw.WriteLine(a.rec(f2.First()[0]) + 1);
            else
                sw.WriteLine(0);
            var f3 = a.Where(x => x[1] == 1 && x[2] == 1);
            if (f3.Count() == 1)
                sw.WriteLine(a.rec(f3.First()[0]) + 1);
            else
                sw.WriteLine(0);
        }

    }
}
