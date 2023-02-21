using EnocaProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaProject.Business.Abstract
{
    public interface ICompanyService
    {
        List<Company> GetAll();
        void Add(Company company);
        void Update(Company company);
        void Delete(int companyId);
    }
}
