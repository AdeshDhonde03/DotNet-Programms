using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADOPrac.BusinessLogicLayer.Models;

namespace ADOPrac.BusinessLogicLayer.IRepository
{
    public interface ICountryRepository
    {
        public int Create(Country country);

        public int Delete(int id);

        public int Update(Country country);

        public Country GetCountryById(int id);

        public int ChangeIsActive(int id , int flag);

        public List<Country> GetCountriesList();
    }
}
