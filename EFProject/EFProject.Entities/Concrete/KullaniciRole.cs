using RepositoryFramework.Core.Entities;

namespace EFProject.Entities.Concrete
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KullaniciRole")]
    public partial class KullaniciRole : IEntity
    {
        public int Id { get; set; }

        public int KullaniciId { get; set; }

        public int RoleId { get; set; }
    }
}
