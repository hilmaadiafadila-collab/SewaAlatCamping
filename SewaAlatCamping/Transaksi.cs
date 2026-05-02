using System;
using System.Collections.Generic;
using System.Text;

namespace SewaAlatCamping
{
    public class Transaksi
    {
        public string IdTransaksi { get; set; }
        public string NamaPenyewa { get; set; }
        public AlatCamping AlatYangDisewa { get; set; } // Menghubungkan ke class AlatCamping
        public int Jumlah { get; set; }
        public DateTime TglSewa { get; set; }
        public DateTime TglKembali { get; set; }
        public decimal TotalHarga { get; set; }
    }
}
