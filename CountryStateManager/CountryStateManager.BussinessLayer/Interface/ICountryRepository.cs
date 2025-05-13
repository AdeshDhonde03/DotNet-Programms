using CountryStateManager.BussinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryStateManager.BussinessLayer.Interface
{
    public interface ICountryRepository
    {
        public int Create(Country country);
        public int Update(Country country);
        public List<Country> List();
        public Country GetById(int id);
        public int Delete(int id);
        public int ActivateCountry(int id, bool flag);
    }
}
