using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using EFProject.Entities.Concrete;

namespace EFProject.Business.Abstract
{
    public interface IHastaService
    {
        List<HastaKarti> GetAll();
        void Add(HastaKarti hastaKarti);
        [OperationContract]
        List<HastaKarti> GetAllWebApi(string tc);
    }
}
