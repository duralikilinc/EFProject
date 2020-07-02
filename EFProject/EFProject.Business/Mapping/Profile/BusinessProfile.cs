using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using EFProject.Entities.Concrete;

namespace EFProject.Business.Mapping.Profile
{
   public class BusinessProfile:AutoMapper.Profile
    {
        public BusinessProfile()
        {
            CreateMap<HastaKarti, HastaKarti>();
        }
    }
}
