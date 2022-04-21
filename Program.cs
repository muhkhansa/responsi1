using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4514
{
    public class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan = new Karyawan();

            karyawan.Nik = 190302123;
            karyawan.Nama = "Paijo";
            karyawan.GajiBulanan = 3000000;

            karyawan.NikB = 190302124;
            karyawan.NamaB = "Jono";
            karyawan.GajiBulananB = 2200000;

            karyawan.KeteranganA();
            karyawan.KeteranganB();

            Console.ReadKey();

        }

    }
}


