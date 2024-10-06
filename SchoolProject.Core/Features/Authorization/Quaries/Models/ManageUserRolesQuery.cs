using MediatR;
using SchoolProject.Core.Bases;
using SchoolProject.Data.Responses;

namespace SchoolProject.Core.Features.Authorization.Quaries.Models
{
    public class ManageUserRolesQuery : IRequest<Response<ManageUserRolesResponse>>
    {
        public int UserId { get; set; }
    }
}
