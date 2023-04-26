using AutoMapper;
using RollOffApi.DTO;

namespace RollOffApi.Profiles
{
    public class FeedBackProfile:Profile
    {
        public FeedBackProfile()
        {
            CreateMap<FeedbackForm, FeedBackDTO>().ReverseMap();
        }
    }
}
