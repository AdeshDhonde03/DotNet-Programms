using ItBoostUp.BuisnessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItBoostUp.BuisnessLayer.Interface
{
    public interface ICompanyRepository
    {
        public int Create(Company company);
        public int Update(Company company);
        public List<Company> List();
        public Company GetById(int id);
        public int Delete(int id);
    }
}
