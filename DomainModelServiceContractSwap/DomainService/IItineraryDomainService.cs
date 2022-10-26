using DomainModelServiceContract.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModelServiceContract.DomainService
{
    public interface IItineraryDomainService
    {
        List<ForbiddenOD> GetForbiddenODs();
    }
}
