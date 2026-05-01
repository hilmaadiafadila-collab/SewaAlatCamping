using System;
using System.Collections.Generic;
using System.Text;

namespace SewaAlatCamping
{
    public class AlatCamping
    {
        public string IdBarang { get; set; }
        public string NamaBarang { get; set; }
        public string Kategori { get; set; }
        public decimal HargaHarian {  get; set; }
        public decimal HargaPaket { get; set; }
        public int Stok { get; set; }
        public string Kondisi { get; set; }
        public DateTime TanggalMasuk { get; set; }
        public string Status { get; set; }
        public string Lokasi { get; set; }
    }
}
