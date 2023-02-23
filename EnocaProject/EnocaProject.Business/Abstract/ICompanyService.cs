using EnocaProject.Core.Utilities.Results;
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
        IDataResult<List<Company>> GetList();
        IResult Add(Company company);
        IResult Delete(Company company);
        IResult Update(Company company);
    }
}
