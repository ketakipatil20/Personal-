
using AutoMapper;
using RollOffApi.DTO;

namespace RollOffApi.Profiles
{
    public class RollOffProfile:Profile
    {
        public RollOffProfile()
        {
            CreateMap<RollOffTable, RollOffTableDTO>().ReverseMap();   
            //ReverseMap() is used in case if we want to map DTO to the Domain Model
            CreateMap<RollOffTable, UpdateEmployeeDTO>().ReverseMap();
        }
    }
}
