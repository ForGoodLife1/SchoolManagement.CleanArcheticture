using Azure.Core;
using SchoolProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SchoolProject.Core.Features.Students.Queries.Results;
using SchoolProject.Core.Bases;


namespace SchoolProject.Core.Features.Students.Queries.Models
{
    public class GetStudentListQuery : IRequest<Response< List<GetStudentListResponse>>>
    {
    }
}
