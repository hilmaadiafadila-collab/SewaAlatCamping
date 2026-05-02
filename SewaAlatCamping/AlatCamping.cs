using System;
using System.Collections.Generic;
using System.Text;

namespace SewaAlatCamping
{
    public class AlatCamping
    {
        private string idBarang;
        private string namaBarang;
        private string merkBarang;
        private string kategori;
        private double berat;
        private int stok;
        private string satuan;
        private DateTime tanggalMasuk; 
        private decimal hargaHarian;
        private decimal dendaHarian;

        public AlatCamping(string idBarang, string namaBarang, string merkBarang, string kategori,
                           double beratGram, int stokAwal, string satuan, DateTime tanggalMasuk,
                           decimal hargaHarian, decimal dendaHarian)
        {
            this.idBarang = idBarang;
            this.kategori = kategori;
            this.satuan = satuan;
            this.tanggalMasuk = tanggalMasuk;
            this.namaBarang = namaBarang;
            this.merkBarang = merkBarang;
            this.berat = beratGram;
            this.hargaHarian = hargaHarian;
            this.dendaHarian = dendaHarian;
            this.stok = stokAwal >= 0 ? stokAwal : 0;
        }

        public string IdBarang { get { return idBarang; } }
        public string Kategori { get { return kategori; } }
        public string Satuan { get { return satuan; } }
        public DateTime TanggalMasuk { get { return tanggalMasuk; } }
        public int Stok { get { return stok; } }

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
            get { return berat; }
            set { if (value <= 0) throw new ArgumentException("Berat harus lebih dari 0 gram."); berat = value; }
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

        public bool Sewa(int jumlahSewa)
        {
            if (jumlahSewa > 0 && this.stok >= jumlahSewa)
            {
                this.stok -= jumlahSewa;
                return true;
            }
            return false;
        }

        public void Kembali(int jumlahKembali)
        {
            if (jumlahKembali > 0)
            {
                this.stok += jumlahKembali;
            }
        }
    }
}
