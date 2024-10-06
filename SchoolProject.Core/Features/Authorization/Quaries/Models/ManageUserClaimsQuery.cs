using MediatR;
using SchoolProject.Core.Bases;
using SchoolProject.Data.Responses;

namespace SchoolProject.Core.Features.Authorization.Quaries.Models
{
    public class ManageUserClaimsQuery : IRequest<Response<ManageUserClaimsResponse>>
    {
        public int UserId { get; set; }
    }
}
