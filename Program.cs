using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
       static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..3]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahMahasiswa();
                        break;

                    case 2:
                        TampilMahasiswa();
                        break;

                    case 3: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            Console.WriteLine("Pilih Menu Aplikasi");           
            Console.WriteLine("1. Tambah Mahasiswa");           
            Console.WriteLine("2. Tampil Mahasiswa");           
            Console.WriteLine("3. Keluar");           
        }

        static void TambahMahasiswa()
        {
            Console.Clear();
            Console.WriteLine("TAMBAH MAHASISWA");
            Console.WriteLine("===========================");

            // PERINTAH: lengkapi kode untuk menambahkan objek mahasiswa ke dalam collection
            Mahasiswa mhs = new Mahasiswa();
            Console.Write("NIM \t: ");
            mhs.Nim = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nama \t: ");
            mhs.Nama = Console.ReadLine();
            Console.Write("Jenis Kelamin [L/P] : ");
            mhs.Gender = Console.ReadLine().ToUpper() == "L" ? "Laki-Laki" : "Perempuan";
            Console.Write("IPK \t: ");
            mhs.IPK = Convert.ToDouble(Console.ReadLine());
            daftarMahasiswa.Add(mhs);
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilMahasiswa()
        {
            Console.Clear();
            Console.WriteLine("DATA MAHASISWA");
            Console.WriteLine("==========================");
            // PERINTAH: lengkapi kode untuk menampilkan daftar mahasiswa yang ada di dalam collection
            var no = 0;
            foreach (Mahasiswa mhs in daftarMahasiswa)
            {
                no++;
                Console.Write(no + ". ");
                Console.WriteLine("{0},{1},{2},{3}", mhs.Nim, mhs.Nama, mhs.Gender, mhs.IPK);

            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
