using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4514
{
    public class Karyawan
    {
        public int Nik { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }
        public int NikB { get; set; }
        public string NamaB { get; set; }
        public int GajiBulananB { get; set; }
        public void KeteranganA()
        {
            Console.WriteLine("No  Nik/Nama            Gaji Bulanan ");
            Console.WriteLine("-------------------------------------");
            Console.Write("1.{0} ", Nik, "{0} ", Nama, "{0}    ", GajiBulanan);
            Console.WriteLine("2.{0} ", NikB, "{0} ", NamaB, "{0}    ", GajiBulananB);
        }
        public void KeteranganB()
        {
            Console.WriteLine("                                     ");
            Console.WriteLine("Asyiiiiiik kenaikan gaji 10%!!");
            Console.WriteLine("No  Nik/Nama            Gaji Bulanan ");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("1.{0} ", Nik, " {0}", Nama, "    {0}", GajiBulanan);
            Console.WriteLine("2.{0} ", NikB, " {0}", NamaB, "    {0}", GajiBulananB);
        }
    }
}
