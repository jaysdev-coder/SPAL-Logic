using AutoMapper;
using SPAL.App.Models.Table;

namespace SPAL.App.Models.MapperProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserTableModel, UserReadModel>();
        }
    }
}
