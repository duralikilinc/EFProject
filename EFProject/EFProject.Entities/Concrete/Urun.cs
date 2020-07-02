using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryFramework.Core.Entities;

namespace EFProject.Entities.Concrete
{
   public class Urun:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
