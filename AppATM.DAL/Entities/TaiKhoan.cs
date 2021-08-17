namespace AppATM.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        public int id { get; set; }

        [StringLength(50)]
        public string STK { get; set; }

        [StringLength(50)]
        public string PassWord { get; set; }

        [StringLength(50)]
        public string SoTien { get; set; }
    }
}
