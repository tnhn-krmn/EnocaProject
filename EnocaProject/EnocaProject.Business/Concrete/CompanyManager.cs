using EnocaProject.Business.Abstract;
using EnocaProject.Business.Constants;
using EnocaProject.Core.Utilities.Results;
using EnocaProject.DataAccess.Abstract;
using EnocaProject.DataAccess.Concrete.EntityFramework;
using EnocaProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EnocaProject.Business.Concrete
{
    public class CompanyManager : ICompanyService
    {
        private readonly ICompanyDAL _companyDAL;
        public CompanyManager(ICompanyDAL companyDAL)
        {
            _companyDAL = companyDAL;
        }

        public IResult Add(Company company)
        {
            _companyDAL.Add(company);
            return new SuccessResult(Messages.CompanyAdded);
        }

        public IResult Delete(Company company)
        {
            _companyDAL.Delete(company);
            return new SuccessResult(Messages.CompanyDeleted);
        }

        public IDataResult<List<Company>> GetList()
        {
            var data = _companyDAL.GetList();
            return new SuccessDataResult<List<Company>>(data, Messages.CompanyListed);
        }

        public IResult Update(Company company)
        {
            _companyDAL.Update(company);
            return new SuccessResult(Messages.CompanyUpdated);
        }
    }
}
