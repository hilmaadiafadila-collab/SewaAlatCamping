using System;
using System.Collections.Generic;
using System.Text;

namespace SewaAlatCamping
{
    public class AlatCamping
    {
        // PRIVATE FIELDS
        private string idBarang;
        private string namaBarang;
        private string merkBarang;
        private string kategori;
        private double beratGram;
        private int stok;
        private string satuan;
        private DateTime tanggalMasuk;
        private decimal hargaHarian;
        private decimal dendaHarian;

        // Field untuk Promo
        private bool isPromo;
        private decimal diskonPersen;

        // CONSTRUCTOR
        public AlatCamping(string idBarang, string namaBarang, string merkBarang, string kategori,
                           double beratGram, int stokAwal, string satuan, DateTime tanggalMasuk,
                           decimal hargaHarian, decimal dendaHarian, bool isPromo, decimal diskonPersen)
        {
            this.idBarang = idBarang;
            this.kategori = kategori;
            this.satuan = satuan;
            this.tanggalMasuk = tanggalMasuk;
            this.isPromo = isPromo;

            // Validasi melalui Property
            this.NamaBarang = namaBarang;
            this.MerkBarang = merkBarang;
            this.BeratGram = beratGram;
            this.HargaHarian = hargaHarian;
            this.DendaHarian = dendaHarian;
            this.DiskonPersen = diskonPersen;

            this.stok = stokAwal >= 0 ? stokAwal : 0;
        }

        // PROPERTIES
        public string IdBarang { get { return idBarang; } }
        public string Kategori { get { return kategori; } }
        public string Satuan { get { return satuan; } }
        public DateTime TanggalMasuk { get { return tanggalMasuk; } }
        public int Stok { get { return stok; } }
        public bool IsPromo { get { return isPromo; } }

        public decimal HargaSetelahDiskon
        {
            get
            {
                if (isPromo)
                {
                    return hargaHarian - (hargaHarian * (diskonPersen / 100m));
                }
                return hargaHarian;
            }
        }

        public decimal DiskonPersen
        {
            get { return diskonPersen; }
            set { if (value < 0 || value > 100) throw new ArgumentException("Diskon harus antara 0 - 100%"); diskonPersen = value; }
        }

        public string NamaBarang
        {
            get { return namaBarang; }
            set { if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Nama Barang tidak boleh kosong."); namaBarang = value; }
        }

        public string MerkBarang
        {
            get { return merkBarang; }
            set { if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Merk Barang tidak boleh kosong."); merkBarang = value; }
        }

        public double BeratGram
        {
            get { return beratGram; }
            set { if (value <= 0) throw new ArgumentException("Berat harus lebih dari 0 gram."); beratGram = value; }
        }

        public decimal HargaHarian
        {
            get { return hargaHarian; }
            set { if (value < 0) throw new ArgumentException("Harga Harian tidak valid!"); hargaHarian = value; }
        }

        public decimal DendaHarian
        {
            get { return dendaHarian; }
            set { if (value < 0) throw new ArgumentException("Denda Harian tidak valid!"); dendaHarian = value; }
        }

        public void KurangiStok(int jumlah)
        {
            if (jumlah <= 0)
                throw new ArgumentException("Jumlah yang dikurangi harus lebih dari 0.");
            if (jumlah > stok)
                throw new InvalidOperationException($"Stok tidak mencukupi. Stok tersedia: {stok}, diminta: {jumlah}.");
            stok -= jumlah;
        }

        public void TambahStok(int jumlah)
        {
            if (jumlah <= 0)
                throw new ArgumentException("Jumlah yang ditambahkan harus lebih dari 0.");
            stok += jumlah;
        }
    }
}
