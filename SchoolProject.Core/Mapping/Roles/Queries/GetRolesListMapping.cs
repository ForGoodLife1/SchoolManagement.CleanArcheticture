using SchoolProject.Core.Features.Authorization.Quaries.Responses;
using SchoolProject.Data.Entities.Identity;

namespace SchoolProject.Core.Mapping.Roles
{
    public partial class RoleProfile
    {
        public void GetRolesListMapping()
        {
            CreateMap<Role, GetRolesListResponse>();
        }
    }
}
