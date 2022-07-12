using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<string> daftarPenjualan = new List<string>();

        static void Main(string[] args)
        {
            penjualan jual = new penjualan();
            
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        TampilPenjualan();
                        break;

                    case 3: 
                    // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu
            Console.WriteLine("piih menu aplikasi");
            Console.WriteLine("1. tambah penualan");
            Console.WriteLine("2. tampilkan penualan");
            Console.WriteLine("3. keluar");
        }

        static void TambahPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection
            Console.WriteLine("tambah data penjual");
            Console.WriteLine("nota : ");
            jual.nota= Console.ReadLine();
            Console.WriteLine("tanggal : ");
            jual.tanggal = Console.ReadLine();
            Console.WriteLine("costumer : ");
            jual.costumer = Console.ReadLine();
            Console.WriteLine("jenis t/k : ");
            jual.jenis = Console.ReadLine();
            Console.WriteLine("total nota : ");
            jual.nota = Console.ReadLine();


           Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection
            Console.WriteLine("tampilan data");
            Console.WriteLine(+ jual.nota[i],jual.tanggal[i], jual.costumer[i], jual.jeni[i])
            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
