﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryFramework.Core.DataAccess;
using EFProject.Entities.ComplexType;
using EFProject.Entities.Concrete;

namespace EFProject.DataAccess.Abstract
{
    public interface IKullaniciDal:IEntityRepository<Kullanici>
    {
        List<KullaniciRoleItem> GetUserRoles(Kullanici user);
    }
}