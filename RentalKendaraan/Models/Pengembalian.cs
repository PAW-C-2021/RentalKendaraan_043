using System;
using System.Collections.Generic;

namespace RentalKendaraan.Models
{
    public partial class Pengembalian
    {
        public int IdPengembalian { get; set; }
        public DateTime? TglPembelian { get; set; }
        public int? IdPeminjaman { get; set; }
        public int? IdKondisi { get; set; }
        public int? Denda { get; set; }

        public virtual KondisiKendaraan IdKondisiNavigation { get; set; }
        public virtual Peminjaman IdPeminjamanNavigation { get; set; }
    }
}
