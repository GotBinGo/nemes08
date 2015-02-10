using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ismer
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = File.ReadAllLines("ismer.be").Where(x=> x.Trim() != "").Select(x => x.Trim().Split().Select(y => int.Parse(y)).ToList()).ToList();
            var n = a[0][0];
            a.RemoveAt(0);
            var b = Enumerable.Range(1, n).Select(x => new {i = x, val = a.Where(y => y[0] == x).Select(y => y[1]).ToList().Union(a.Where(y => y[1] == x).Select(y => y[0]).ToList()).OrderBy(y=>y).ToList()}).ToList();            
            var w = b.Join(b, x => 0, y => 0, (x, y) => new { x, y });
            var ww = w.Select(x => new { xv = x.x.val, yv = x.x.val, xi = x.x.i, yi = x.y.i, x = string.Join("", x.x.val.Except(new int[] { x.y.i })), y = string.Join("", x.y.val.Except(new int[] { x.x.i })), ki = x.x.i + " " + x.y.i }).Where(x => x.xi != x.yi && x.x == x.y && x.x != "" && x.xi < x.yi);
            var aa = a.Select((x, i) => new { i, x });
            var ca = aa.Join(aa, x => x.x[0], y => y.x[0], (x, y) => new { x, y }).Where(x=>x.x.i  != x.y.i && x.x.i < x.y.i).ToList();
            var cb = aa.Join(aa, x => x.x[0], y => y.x[1], (x, y) => new { x, y }).Where(x => x.x.i != x.y.i && x.x.i < x.y.i).ToList();
            var cc = aa.Join(aa, x => x.x[1], y => y.x[0], (x, y) => new { x, y }).Where(x => x.x.i != x.y.i && x.x.i < x.y.i).ToList();
            var cd = aa.Join(aa, x => x.x[1], y => y.x[1], (x, y) => new { x, y }).Where(x => x.x.i != x.y.i && x.x.i > x.y.i).ToList();
            var d = ca.Union(cb.Union(cd.Union(cc))).Select(x => (x.x.x[0]  + " " +  x.x.x[1]+" " + x.y.x[0] +" " + x.y.x[1]).Split().OrderBy(y=>y).ToList());
            var dd = d.Select(t => t.Where(x => t.Where(y => y == x).Count() == 1).OrderBy(x=>x).ToList()).Select(x=>string.Join(" ",x)).OrderBy(x=>x).ToList().Distinct();
            StreamWriter sw = new StreamWriter("ismer.ki"){AutoFlush = true};
            sw.WriteLine(ww.Count());
            sw.WriteLine(string.Join("\r\n", ww.Select(x=>x.ki).ToList()));
            sw.WriteLine(dd.Count());
            sw.WriteLine(string.Join("\r\n", dd));
            
        }
    }
}
