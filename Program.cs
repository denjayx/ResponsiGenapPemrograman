using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
       static List<string> daftarMahasiswa = new List<string>();

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

            // PERINTAH: lengkapi kode untuk menambahkan objek mahasiswa ke dalam collection
            Mahasiswa mhs = new Mahasiswa();
            Console.Write("NIM \t: ");
            mhs.nim = Console.ReadLine();
            Console.Write("Nama \t: ");
            mhs.nama = Console.ReadLine();
            Console.Write("Jenis Kelamin : ");
            mhs.gender = Console.ReadLine();
            Console.Write("IPK \t: ");
            mhs.ipk = Console.ReadLine();

            List<Mahasiswa> list = new List<Mahasiswa>();
            list.Add(mhs);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilMahasiswa()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar mahasiswa yang ada di dalam collection
            Mahasiswa mhs = daftarMahasiswa;
            Console.WriteLine("{0},{1}", mhs.nim, mhs.nama, mhs.gender, mhs.ipk);
           

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
