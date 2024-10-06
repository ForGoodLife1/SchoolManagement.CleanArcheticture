using MediatR;
using SchoolProject.Core.Bases;
using SchoolProject.Core.Features.Authorization.Quaries.Responses;

namespace SchoolProject.Core.Features.Authorization.Quaries.Models
{
    public class GetRoleByIdQuery : IRequest<Response<GetRoleByIdResponse>>
    {
        public int Id { get; set; }
    }
}
