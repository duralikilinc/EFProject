using RepositoryFramework.Core.Entities;

namespace EFProject.Entities.Concrete
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Role")]
    public partial class Role : IEntity
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string RoleAd { get; set; }
    }
}
