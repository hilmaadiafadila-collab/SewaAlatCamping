using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace SewaAlatCamping
{
    public class Transaksi
    {
        // ==========================================
        // 1. PRIVATE FIELDS
        // ==========================================
        private string idTransaksi;
        private string namaPenyewa;
        private string barangId;
        private int jumlah;
        private DateTime tglSewa;
        private DateTime tglKembali;
        private decimal totalHarga;

        // ==========================================
        // 2. CONSTRUCTOR
        // ==========================================
        public Transaksi(string idTransaksi, string namaPenyewa, string barangId,
                         int jumlah, DateTime tglSewa, DateTime tglKembali, decimal totalHarga)
        {
            this.IdTransaksi = idTransaksi;
            this.NamaPenyewa = namaPenyewa;
            this.BarangId = barangId;
            this.Jumlah = jumlah;
            this.TglSewa = tglSewa;
            this.TglKembali = tglKembali;
            this.TotalHarga = totalHarga;
        }

        // ==========================================
        // 3. PROPERTIES WITH VALIDATION
        // ==========================================
        public string IdTransaksi
        {
            get { return idTransaksi; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("ID Transaksi tidak boleh kosong.");
                idTransaksi = value;
            }
        }

        public string NamaPenyewa
        {
            get { return namaPenyewa; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Nama Penyewa tidak boleh kosong.");
                namaPenyewa = value;
            }
        }

        public string BarangId
        {
            get { return barangId; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("ID Barang tidak boleh kosong.");
                barangId = value;
            }
        }

        public int Jumlah
        {
            get { return jumlah; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Jumlah harus lebih dari 0.");
                jumlah = value;
            }
        }

        public DateTime TglSewa
        {
            get { return tglSewa; }
            set { tglSewa = value; }
        }

        public DateTime TglKembali
        {
            get { return tglKembali; }
            set
            {
                if (value < tglSewa)
                    throw new ArgumentException("Tanggal kembali tidak boleh sebelum tanggal sewa.");
                tglKembali = value;
            }
        }

        public decimal TotalHarga
        {
            get { return totalHarga; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Total harga tidak boleh negatif.");
                totalHarga = value;
            }
        }

        // ==========================================
        // 4. COMPUTED PROPERTY
        // ==========================================
        public int DurasiHari
        {
            get
            {
                int hari = (tglKembali - tglSewa).Days;
                return hari <= 0 ? 1 : hari;
            }
        }
    }
}