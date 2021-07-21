namespace ShopOnlineModel.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            ProductDetails = new HashSet<ProductDetail>();
        }

        [Key]
        [StringLength(50)]
        public string maSanPham { get; set; }

        [StringLength(150)]
        public string moTa { get; set; }

        public int giaSanPham { get; set; }

        [StringLength(50)]
        public string chatLieu { get; set; }

        [Required]
        [StringLength(50)]
        public string loaiSanPhamMa { get; set; }

        public int soLuongDatMua { get; set; }

        [StringLength(50)]
        public string mauSac { get; set; }

        [Required]
        [StringLength(150)]
        public string urlAnh { get; set; }

        [Column(TypeName = "date")]
        public DateTime ngayTao { get; set; }

        [Required]
        [StringLength(50)]
        public string tenSanPham { get; set; }

        public virtual GroupDetail GroupDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductDetail> ProductDetails { get; set; }
    }
}
