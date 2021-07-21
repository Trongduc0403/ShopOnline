namespace ShopOnlineModel.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GroupPr")]
    public partial class GroupPr
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GroupPr()
        {
            GroupDetails = new HashSet<GroupDetail>();
        }

        [Key]
        [StringLength(50)]
        public string maNhom { get; set; }

        [Required]
        [StringLength(50)]
        public string tenNhom { get; set; }

        [Column("meta-tittle")]
        [Required]
        [StringLength(50)]
        public string meta_tittle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GroupDetail> GroupDetails { get; set; }
    }
}
