using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vitorlas
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = File.ReadAllLines("vitorlas.be").Select(x=>x.Split().Select(y=>int.Parse(y)).ToList()).ToList();
            var n = a[0][0];
            var k = a[0][1];
            var l = a[0][2];
            var m = a[0][3];
            a.RemoveAt(0);
            var f1 = a.SelectMany(x => x).GroupBy(x => x).Where(x=>x.Count() == n).ToList();
            var b = a.Select(x=>x.Select((y, i) => new { y, i, p = k-i}));
            var c = b.SelectMany(x => x).GroupBy(x => x.y).ToList();
            var f2 = c.Select(x => new {x.Key,p=x.OrderByDescending(y=>y.p).Take(l).Sum(y=>y.p),s = string.Join("",x.OrderByDescending(y=>y.p).Take(l).Select(y=>y.i)) }).OrderByDescending(x=>x.p).ThenByDescending(x=>x.s).ToList();
            StreamWriter sw = new StreamWriter("vitorlas.ki") { AutoFlush = true };
            sw.WriteLine(f1.Count);
            sw.WriteLine(string.Join(" ",f1.Select(x=>x.Key)));
            sw.WriteLine(f2.Count);
            sw.WriteLine(string.Join("\r\n", f2.Select(x => x.Key + " " + x.p)));

         }
    }
}
