namespace ShopOnlineModel.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GroupDetail")]
    public partial class GroupDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GroupDetail()
        {
            Products = new HashSet<Product>();
        }

        [Key]
        [StringLength(50)]
        public string maLoaiSanPham { get; set; }

        [Required]
        [StringLength(50)]
        public string tenLoaiSanPham { get; set; }

        [Required]
        [StringLength(50)]
        public string nhomMa { get; set; }

        [Column("meta-tittle")]
        [Required]
        [StringLength(50)]
        public string meta_tittle { get; set; }

        public virtual GroupPr GroupPr { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
    }
}
