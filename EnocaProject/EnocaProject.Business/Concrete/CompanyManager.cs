using EnocaProject.Business.Abstract;
using EnocaProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaProject.Business.Concrete
{
    public class CompanyManager : ICompanyService
    {
        private readonly ICompanyService _companyService;
        public CompanyManager(ICompanyService companyService)
        {
            _companyService = companyService;
        }
        public void Add(Company company)
        {
            _companyService.Add(company);
        }

        public void Delete(int companyId)
        {
            _companyService.Delete(companyId);
        }

        public List<Company> GetAll()
        {
            return _companyService.GetAll();
        }

        public void Update(Company company)
        {
            _companyService.Update(company);
        }
    }
}
