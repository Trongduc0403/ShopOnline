namespace ShopOnlineModel.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReceiptDetail")]
    public partial class ReceiptDetail
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int maHoaDon { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string maSanPham { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(5)]
        public string size { get; set; }

        public int soLuongDatMua { get; set; }

        public long thanhTien { get; set; }

        public virtual ProductDetail ProductDetail { get; set; }

        public virtual Receipt Receipt { get; set; }
    }
}
