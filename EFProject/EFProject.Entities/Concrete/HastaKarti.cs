using RepositoryFramework.Core.Entities;

namespace EFProject.Entities.Concrete
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HastaKarti")]
    public partial class HastaKarti : IEntity
    {
        public int Id { get; set; }

        [Required]
        [StringLength(11)]
        public string TCNo { get; set; }

        [Required]
        [StringLength(50)]
        public string Ad_Soyad { get; set; }

        public int DogumYili { get; set; }
    }
}
