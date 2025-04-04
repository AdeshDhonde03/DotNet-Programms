using AutoMapper;
using CountryStateManager.BussinessLayer.Models;
using CountryStateManager.BussinessLayer.Responses;

namespace CountryStateManager.DataAccessLayer.Mappings
{
    public class CountryProfile : Profile
    {
        public CountryProfile()
        {
            CreateMap<Country, CountryListForStates>();
        }
    }
}
