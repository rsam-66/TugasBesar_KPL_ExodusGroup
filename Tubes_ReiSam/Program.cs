using System;

namespace Program
{
    class Program
    {
        enum state { PRODUK, KERANJANG, BAYAR, KELUAR };
        static void Main(string[] args)
        {
            state posisi = state.PRODUK;
            string[] screenName = { "PRODUK", "KERANJANG", "BAYAR", "KELUAR" };
            while (posisi != state.KELUAR)
            {
                Console.WriteLine("Halaman " + screenName[(int)posisi]);

                switch (posisi)
                {
                    case state.PRODUK:

                        Console.WriteLine("");
                        Console.WriteLine("1. Tambahkan Produk");
                        Console.WriteLine("2. Lihat Keranjang");
                        Console.WriteLine("0. Keluar");
                        Console.WriteLine("");
                        Console.WriteLine("Pilihan :");
                        string aksi = Console.ReadLine();

                        if (aksi == "1")
                        {
                            Console.WriteLine("Masukkan Nama Produk yang Ingin Ditambahkan");
                            string nama_produk = Console.ReadLine();
                            // kondisi barang apakah ada atau tidak
                            // kondisi dibawah jika produk tersebut ada
                            Console.WriteLine("Produk Ditambahkan!");
                            Console.WriteLine("");
                            posisi = state.PRODUK;
                        }
                        else if (aksi == "2")
                        {
                            Console.WriteLine("");
                            posisi = state.KERANJANG;
                        }
                        else if (aksi == "0")
                        {
                            posisi = state.KELUAR;
                        }
                        else
                        {
                            Console.WriteLine("Pilihan Tidak Valid!");
                            Console.WriteLine("");
                            posisi = state.PRODUK;
                        }
                        break;

                    case state.KERANJANG:
                        Console.WriteLine("Keranjang Belanja Anda");
                        // ditampilkan isi keranjang
                        Console.WriteLine("");
                        Console.WriteLine("3. Hapus Produk");
                        Console.WriteLine("4. Bayar");
                        Console.WriteLine("5. Kembali Ke Halaman Produk");
                        Console.WriteLine("Pilihan :");

                        string aksi2 = Console.ReadLine();

                        if (aksi2 == "3")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Masukkan Nama Produk yang Ingin Dihapus");
                            string nama_produk = Console.ReadLine();
                            // kondisi cek apakah produk ada atau tidak
                            // kondisi produk ada
                            Console.WriteLine("Produk Berhasil Dihapus!");
                            Console.WriteLine("");
                            posisi = state.KERANJANG;
                        }
                        else if (aksi2 == "4")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Pilih pembayaran :");
                            // kondisi memilih pembayaran
                            // kondisi pembayaran berhasil
                            Console.WriteLine("");
                            Console.WriteLine("Terimakasih Telah Berbelanja!");
                            Console.WriteLine("");
                            posisi = state.KELUAR;
                        }
                        else if (aksi2 == "5") {
                            Console.WriteLine("");
                            posisi = state.PRODUK;
                        } else {
                            Console.WriteLine("Pilihan Tidak Valid!");
                            Console.WriteLine("");
                            posisi = state.KERANJANG;
                        }
                        break;
                }

            }
            Console.WriteLine("Terimakasih Telah Menggunakan Prorgam Kami!");
        }
    }
}