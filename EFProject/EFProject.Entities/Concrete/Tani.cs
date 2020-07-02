using RepositoryFramework.Core.Entities;

namespace EFProject.Entities.Concrete
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tani")]
    public partial class Tani : IEntity
    {
        public int Id { get; set; }

        [Column("Tani")]
        [StringLength(50)]
        public string TaniAdi { get; set; }

        public int DosyaNo { get; set; }
    }
}
