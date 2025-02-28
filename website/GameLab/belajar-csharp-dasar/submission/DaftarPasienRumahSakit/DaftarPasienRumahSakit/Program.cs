namespace DaftarPasienRumahSakit
{
    internal class Program
    {
        struct Pasien
        {
            public string nama;
            public string noRekamMedik;
            public string alamat;
            public string penyakit;
            public int nomorRuang;
            public string bpjs;
            public string tanggalMasuk;
            public string tanggalKeluar;
        }

        enum KategoriBPJS
        {
            TidakMenggunakan,
            KelasI,
            KelasII,
            KelasIII
        }

        static Pasien[] daftarPasien = new Pasien[100];
        static int jumlahPasien = 0;

        static void Main(string[] args)
        {
            int pilihan;

            do
            {
                TampilkanMenu();
                if (!int.TryParse(Console.ReadLine(), out pilihan))
                {
                    Console.WriteLine("\nInput tidak valid!, tolong masukan angka.\n");
                    continue;
                }

                switch (pilihan)
                {
                    case 1:
                        TampilkanPasien();
                        break;
                    case 2:
                        TambahPasien();
                        break;
                    case 3:
                        UbahPasien();
                        break;
                    case 4:
                        hapusPasien();
                        break;
                    case 5:
                        Console.WriteLine("\nTerima kasih telah menggunakan program ini!\n");
                        break;
                    default:
                        Console.WriteLine("\nPilihan tidak valid!\n");
                        break;
                }
            } while (pilihan != 5);
        }

        static void TampilkanMenu()
        {
            Console.WriteLine("###### RS. Game Lab Indonesia ######");
            Console.WriteLine("1. Tampilkan Pasien");
            Console.WriteLine("2. Tambah Pasien");
            Console.WriteLine("3. Ubah Data Pasien");
            Console.WriteLine("4. Hapus Pasien");
            Console.WriteLine("5. Keluar");
            Console.WriteLine("###############################");
            Console.Write("Pilih menu: ");
        }

        static void TampilkanPasien()
        {
            if (jumlahPasien == 0)
            {
                Console.WriteLine("\nBelum ada data pasien. \n");
                return;
            }

            Console.WriteLine("\nDaftar Pasien:");
            for (int i = 0; i < jumlahPasien; i++)
            {
                Console.WriteLine("\nPasien Ke-{0}", i + 1);
                Console.WriteLine("No. Rekam Medik: {0}", daftarPasien[i].noRekamMedik);
                Console.WriteLine("Nama: {0}", daftarPasien[i].nama);
                Console.WriteLine("Alamat: {0}", daftarPasien[i].alamat);
                Console.WriteLine("Penyakit: {0}", daftarPasien[i].penyakit);
                Console.WriteLine("Nomor Ruang: {0}", daftarPasien[i].nomorRuang);
                Console.WriteLine("BPJS: {0}", daftarPasien[i].bpjs);
                Console.WriteLine("Tanggal Masuk: {0}", daftarPasien[i].tanggalMasuk);
                Console.WriteLine("Tanggal Keluar: {0}", daftarPasien[i].tanggalKeluar);
                Console.WriteLine("------------------------");
            }
        }

        static void TambahPasien()
        {
            if (jumlahPasien >= 100)
            {
                Console.WriteLine("\nKapasitas pasien penuh!\n");
                return;
            }

            Pasien pasienBaru = new Pasien();

            Console.WriteLine("\nMasukan data pasien baru:");

            pasienBaru.noRekamMedik = ValidasiNoRekamMedik();

            Console.Write("Nama: ");
            pasienBaru.nama = Console.ReadLine();

            Console.Write("Alamat: ");
            pasienBaru.alamat = Console.ReadLine();

            Console.Write("Penyakit: ");
            pasienBaru.penyakit = Console.ReadLine();

            pasienBaru.nomorRuang = ValidasiNomorRuangan();
            pasienBaru.bpjs = ValidasiBPJS();
            pasienBaru.tanggalMasuk = ValidasiTanggal("Tanggal Masuk [DD/MM/YYYY]: ");

            pasienBaru.tanggalKeluar = "";

            daftarPasien[jumlahPasien] = pasienBaru;
            jumlahPasien++;

            Console.WriteLine("\nPasien berhasil ditambahkan!\n");
        }

        static void UbahPasien()
        {
            if (jumlahPasien == 0)
            {
                Console.WriteLine("\nBelum ada data pasien.\n");
                return;
            }

            Console.WriteLine("\nMasukkan No. Rekam Medik pasien yang akan diubah: ");
            string noRekam = Console.ReadLine();
            bool ditemukan = false;

            for (int i = 0; i < jumlahPasien; i++)
            {
                if (daftarPasien[i].noRekamMedik == noRekam)
                {
                    Pasien pasienLama = daftarPasien[i];

                    try
                    {
                        Console.WriteLine("\nData Pasien Saat Ini:");
                        TampilkanDetailPasien(daftarPasien[i]);
                        Console.WriteLine("\nMasukkan Data Baru:");
                        
                        do
                        {
                            Console.Write("Nama (kosongkan jika tidak diubah): ");
                            string namaBaru = Console.ReadLine();
                            if (!string.IsNullOrWhiteSpace(namaBaru))
                            {
                                daftarPasien[i].nama = namaBaru;
                                break;
                            }
                        } while (false);
                        
                        do
                        {
                            Console.Write("Alamat (kosongkan jika tidak diubah): ");
                            string alamatBaru = Console.ReadLine();
                            if (!string.IsNullOrWhiteSpace(alamatBaru))
                            {
                                daftarPasien[i].alamat = alamatBaru;
                                break;
                            }
                        } while (false);
                        
                        do
                        {
                            Console.Write("Penyakit (kosongkan jika tidak diubah): ");
                            string penyakitBaru = Console.ReadLine();
                            if (!string.IsNullOrWhiteSpace(penyakitBaru))
                            {
                                daftarPasien[i].penyakit = penyakitBaru;
                                break;
                            }
                        } while (false);
                        
                        Console.Write("Ubah nomor ruang? (y/n): ");
                        if (Console.ReadLine().ToLower() == "y")
                        {
                            int ruangBaru = ValidasiNomorRuangan();
                            if (ruangBaru != daftarPasien[i].nomorRuang)
                            {
                                daftarPasien[i].nomorRuang = ruangBaru;
                            }
                        }
                        
                        Console.Write("Ubah status BPJS? (y/n): ");
                        if (Console.ReadLine().ToLower() == "y")
                        {
                            daftarPasien[i].bpjs = ValidasiBPJS();
                        }
                        
                        Console.Write("Ubah tanggal masuk? (y/n): ");
                        if (Console.ReadLine().ToLower() == "y")
                        {
                            string tanggalMasukBaru = ValidasiTanggal("Tanggal Masuk [DD/MM/YYYY]: ");
                            if (!string.IsNullOrEmpty(tanggalMasukBaru))
                            {
                                daftarPasien[i].tanggalMasuk = tanggalMasukBaru;
                            }
                        }
                        
                        Console.Write("Update tanggal keluar? (y/n): ");
                        if (Console.ReadLine().ToLower() == "y")
                        {
                            string tanggalKeluar =
                                ValidasiTanggal("Tanggal Keluar [DD/MM/YYYY] (kosongkan jika masih dirawat): ");

                            if (!string.IsNullOrEmpty(tanggalKeluar))
                            {
                                DateTime tglMasuk =
                                    DateTime.ParseExact(daftarPasien[i].tanggalMasuk, "dd/MM/yyyy", null);
                                DateTime tglKeluar = DateTime.ParseExact(tanggalKeluar, "dd/MM/yyyy", null);

                                if (tglKeluar < tglMasuk)
                                {
                                    throw new Exception("Tanggal keluar tidak boleh lebih awal dari tanggal masuk!");
                                }

                                daftarPasien[i].tanggalKeluar = tanggalKeluar;
                            }
                            else
                            {
                                daftarPasien[i].tanggalKeluar = "";
                            }
                        }

                        Console.WriteLine("\nData pasien berhasil diubah!\n");
                        TampilkanDetailPasien(daftarPasien[i]);
                        Console.WriteLine();
                        ditemukan = true;
                    }
                    catch (Exception ex)
                    {
                        daftarPasien[i] = pasienLama;
                        Console.WriteLine($"\nTerjadi kesalahan: {ex.Message}");
                        Console.WriteLine("Data tidak diubah.\n");
                    }

                    break;
                }
            }

            if (!ditemukan)
            {
                Console.WriteLine("\nPasien dengan No. Rekam Medik tersebut tidak ditemukan!\n");
            }
        }
        
        static void hapusPasien()
        {
            Console.WriteLine("\nMasukkan No. Rekam Medik pasien yang akan dihapus: ");
            string noRekam = Console.ReadLine();
            bool ditemukan = false;

            for (int i = 0; i < jumlahPasien; i++)
            {
                if (daftarPasien[i].noRekamMedik == noRekam)
                {
                    for (int j = 0; j < jumlahPasien - 1; j++)
                    {
                        daftarPasien[j] = daftarPasien[j + 1];
                    }

                    jumlahPasien--;

                    Console.WriteLine("\nData pasien berhasil dihapus!\n");
                    ditemukan = true;

                    break;
                }
            }

            if (!ditemukan)
            {
                Console.WriteLine("\nPasien dengan No. Rekam Medik tersebut tidak ditemukan!\n");
            }
        }

        static string ValidasiBPJS()
        {
            string input;
            bool isValid = false;

            do
            {
                Console.Write("BPJS [1: Tidak Menggunakan, 2: Kelas I, 3: Kelas II, 4: Kelas III]: ");

                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        return KategoriBPJS.TidakMenggunakan.ToString();
                    case "2":
                        return KategoriBPJS.KelasI.ToString();
                    case "3":
                        return KategoriBPJS.KelasII.ToString();
                    case "4":
                        return KategoriBPJS.KelasIII.ToString();
                    default:
                        Console.WriteLine("Input tidak valid! Silakan pilih 1-4.");
                        break;
                }
            } while (!isValid);

            return KategoriBPJS.TidakMenggunakan.ToString();
        }

        static string ValidasiTanggal(string prompt)
        {
            string input;
            DateTime tanggal;

            do
            {
                Console.Write(prompt);
                input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    return "";
                }

                if (!DateTime.TryParseExact(input, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None,
                        out tanggal))
                {
                    Console.WriteLine("Format tanggal tidak valid! Gunakan Format DD/MM/YYYY");
                    continue;
                }

                return input;
            } while (true);
        }

        static string ValidasiNoRekamMedik()
        {
            string input;

            do
            {
                Console.Write("No. Rekam Medik: ");
                input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("No. Rekam Medik tidak boleh kosong!");
                    continue;
                }

                bool isDuplicate = false;
                for (int i = 0; i < jumlahPasien; i++)
                {
                    if (daftarPasien[i].noRekamMedik == input)
                    {
                        Console.WriteLine("No. Rekam Medik sudah terdaftar!");
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    return input;
                }
            } while (true);
        }

        static bool IsRuanganTerpakai(int nomorRuang)
        {
            for (int i = 0; i < jumlahPasien; i++)
            {
                if (daftarPasien[i].nomorRuang == nomorRuang &&
                    string.IsNullOrEmpty(daftarPasien[i].tanggalKeluar))
                {
                    return true;
                }
            }

            return false;
        }

        static int ValidasiNomorRuangan()
        {
            int nomorRuang;
            do
            {
                Console.Write("Nomor ruangan [1 - 100]: ");
                if (!int.TryParse(Console.ReadLine(), out nomorRuang))
                {
                    Console.WriteLine("Input harus berupa angka!");
                    continue;
                }

                if (nomorRuang < 1 || nomorRuang > 100)
                {
                    Console.WriteLine("Nomor ruang harus antara 1 - 100!");
                    continue;
                }

                if (IsRuanganTerpakai(nomorRuang))
                {
                    Console.WriteLine("Ruangan sudah terpakai!");
                    continue;
                }

                return nomorRuang;
            } while (true);
        }
        
        static void TampilkanDetailPasien(Pasien pasien)
        {
            Console.WriteLine($"No. Rekam Medik: {pasien.noRekamMedik}");
            Console.WriteLine($"Nama: {pasien.nama}");
            Console.WriteLine($"Alamat: {pasien.alamat}");
            Console.WriteLine($"Penyakit: {pasien.penyakit}");
            Console.WriteLine($"Nomor Ruang: {pasien.nomorRuang}");
            Console.WriteLine($"BPJS: {pasien.bpjs}");
            Console.WriteLine($"Tanggal Masuk: {pasien.tanggalMasuk}");
            Console.WriteLine(
                $"Tanggal Keluar: {(string.IsNullOrEmpty(pasien.tanggalKeluar) ? "Masih dirawat" : pasien.tanggalKeluar)}");
        }
    }
}