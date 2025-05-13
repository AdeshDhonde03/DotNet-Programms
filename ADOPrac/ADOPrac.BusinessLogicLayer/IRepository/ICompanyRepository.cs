using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADOPrac.BusinessLogicLayer.Models;

namespace ADOPrac.BusinessLogicLayer.IRepository
{
    public interface ICompanyRepository
    {
        public int Create(Company company);

        public int Update(Company company);

        public int Delete(int id);

        public List<Company> ListAllCompanies();

        public Company GetCompanyById(int id);
    }
}
