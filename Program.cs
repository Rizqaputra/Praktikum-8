using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum8_2692
{
    public abstract class Karyawan
    {
        public string Nik { get; set; }
        public string Nama { get; set; }
        public abstract double Gaji();
    }
}

namespace Praktikum8_2692
{
    class KaryawanHarian : Karyawan
    {
        public double UpahPerJam { get; set; }
        public double JumlahJamKerja { get; set; }
        public override double Gaji()
        {
            return UpahPerJam * JumlahJamKerja;
        }
    }
}
namespace Praktikum8_2692
{
    class KaryawanTetap : Karyawan
    {
        public double GajiBulanan { get; set; }
        public override double Gaji()
        {
            return GajiBulanan;
        }
    }
}
namespace Praktikum8_2692
{
    class Program
    {
        static void Main(string[] args)
        {
        

            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.Nik = "19.11.2692";
            karyawanTetap.Nama = "Rizqa putra ananda";
            karyawanTetap.GajiBulanan = 300000;

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.Nik = "19.11.2694";
            karyawanHarian.Nama = "Yogi bimantara";
            karyawanHarian.JumlahJamKerja = 7;
            karyawanHarian.UpahPerJam = 25000;

            Sales sales = new Sales();
            sales.Nik = "19.11.2693";
            sales.Nama = "Ainun Muhammad";
            sales.JumlahPenjualan = 25;
            sales.Komisi = 20000;

            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);

            int noUrut = 1;
            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3:N0}", noUrut, karyawan.Nik, karyawan.Nama, karyawan.Gaji());
                noUrut++;
            }
            Console.ReadKey();
        }
    }
}
namespace Praktikum8_2692
{
    class Sales : Karyawan
    {
        public double JumlahPenjualan { get; set; }
        public double Komisi { get; set; }
        public override double Gaji()
        {
            return JumlahPenjualan * Komisi;
        }
    }
}
