using System;
using System.Collections.Generic;
using System.Linq;

namespace ProfilApp
{
    class Akun
    {
        public string Nama { get; set; }

        public Akun(string nama)
        {
            Nama = nama;
        }
    }

    class Program
    {
        private static List<Akun> daftarAkun = new List<Akun>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("Halaman Profil");
                Console.WriteLine("");
                Console.WriteLine("1. Tambah Akun");
                Console.WriteLine("2. Hapus Akun");
                Console.WriteLine("3. Tampilkan Daftar Akun");
                Console.WriteLine("4. Keluar");
                Console.WriteLine("");
                Console.Write("Pilih menu: ");
                int pilihan = int.Parse(Console.ReadLine());

                switch (pilihan)
                {
                    case 1:
                        TambahkanAkun();
                        break;
                    case 2:
                        HapusAkun();
                        break;
                    case 3:
                        TampilkanDaftarAkun();
                        break;
                    case 4:
                        Keluar();
                        return;
                    default:
                        Console.WriteLine("Pilihan tidak valid!");
                        break;
                }
            }
        }


        static void TambahkanAkun()
        {
            Console.WriteLine("");
            Console.Write("Masukkan nama akun: ");
            string namaAkun = Console.ReadLine();

            if (!string.IsNullOrEmpty(namaAkun))
            {
                Akun akunBaru = new Akun(namaAkun);
                daftarAkun.Add(akunBaru);
                Console.WriteLine("Akun baru telah ditambahkan!");
            }
            else
            {
                Console.WriteLine("Nama akun tidak boleh kosong!");
            }
        }

        static void HapusAkun()
        {
            if (daftarAkun.Count == 0)
            {
                Console.WriteLine("");
                Console.WriteLine("Daftar akun masih kosong!");
                return;
            }

            TampilkanDaftarAkun();

            Console.Write("Masukkan nomor akun yang ingin dihapus: ");
            int index = int.Parse(Console.ReadLine());

            if (index >= 1 && index <= daftarAkun.Count)
            {
                daftarAkun.RemoveAt(index - 1);
                Console.WriteLine("Akun telah dihapus!");
            }
            else
            {
                Console.WriteLine("Nomor akun tidak valid!");
            }
        }

        static void TampilkanDaftarAkun()
        {
            if (daftarAkun.Count == 0)
            {
                Console.WriteLine("Daftar akun masih kosong!");
                return;
            }

            Console.WriteLine("\nDaftar Akun");
            for (int i = 0; i < daftarAkun.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, daftarAkun[i].Nama);
            }
        }

        static void Keluar()
        {
            Console.WriteLine("Terima kasih telah menggunakan program!");
        }
    }
}
