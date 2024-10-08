﻿using AutoMapper;
using MediatR;
using Microsoft.Extensions.Localization;
using SchoolProject.Core.Bases;
using SchoolProject.Core.Features.Students.Queries.Models;
using SchoolProject.Core.Features.Students.Queries.Results;
using SchoolProject.Core.Resources;
using SchoolProject.Core.Wrappers;
using SchoolProject.Data.Entities;
using SchoolProject.Service.Abstracts;
using System.Linq.Expressions;

namespace SchoolProject.Core.Features.Students.Queries.Handlers
{
    public class StudentQueryHandler : ResponseHandler,
                                     IRequestHandler<GetStudentListQuery, Response<List<GetStudentListResponse>>>,
                                      IRequestHandler<GetStudentByIDQuery, Response<GetSingleStudentResponse>>,
                                       IRequestHandler<GetStudentPaginatedListQuery, PaginatedResult<GetStudentPaginatedListResponse>>
    {
        #region Fields
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResources> _stringLocalizer;
        #endregion
        #region Constructors
        public StudentQueryHandler(IStudentService studentService,
                                   IMapper mapper,
                                    IStringLocalizer<SharedResources> stringLocalizer) : base(stringLocalizer)

        {
            _studentService = studentService;
            _mapper = mapper;
            _stringLocalizer = stringLocalizer;
        }
        #endregion
        public async Task<Response<List<GetStudentListResponse>>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {
            var studentList = await _studentService.GetStudentsListAsync();
            var studentListMapper = _mapper.Map<List<GetStudentListResponse>>(studentList);
            var result = Success(studentListMapper);
            result.Meta = new { Count = studentListMapper.Count() };
            return result;
        }

        public async Task<Response<GetSingleStudentResponse>> Handle(GetStudentByIDQuery request, CancellationToken cancellationToken)
        {

            var student = await _studentService.GetStudentByIDWithIncludeAsync(request.Id);
            if (student == null) return NotFound<GetSingleStudentResponse>(_stringLocalizer[SharedResourcesKeys.NotFound]);
            var result = _mapper.Map<GetSingleStudentResponse>(student);
            return Success(result);
        }

        public async Task<PaginatedResult<GetStudentPaginatedListResponse>> Handle(GetStudentPaginatedListQuery request, CancellationToken cancellationToken)
        {
            Expression<Func<Student, GetStudentPaginatedListResponse>> expression = e => new GetStudentPaginatedListResponse(e.StudID, e.Localize(e.NameAr, e.NameEn), e.Address, e.Department.Localize(e.Department.DNameAr, e.Department.DNameEn));
            var querable = _studentService.GetStudentsQuerable();
            var FilterQuery = _studentService.FilterStudentPaginatedQuerable(request.OrderBy, request.Search);
            var PaginatedList = await FilterQuery.Select(expression).ToPaginatedListAsync(request.PageNumber, request.PageSize);
            PaginatedList.Meta = new { Count = PaginatedList.Data.Count() };
            return PaginatedList;
        }
    }
}
