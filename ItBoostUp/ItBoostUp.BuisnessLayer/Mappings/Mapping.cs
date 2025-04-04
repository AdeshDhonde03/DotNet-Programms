using ItBoostUp.BuisnessLayer.DTOs;
using ItBoostUp.BuisnessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItBoostUp.BuisnessLayer.Mappings
{
    public static class Mapping
    {
        public static void MapUpdateCompanyDtoWithCompany(this Company company, UpdateCompanyDto updateCompanyDto)
        {
            company.Name = updateCompanyDto.Name;
            company.Address = updateCompanyDto.Address;
        }
    }
}
