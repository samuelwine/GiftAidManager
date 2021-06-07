﻿using System.Threading;
using System.Threading.Tasks;
using Ardalis.ApiEndpoints;
using GiftAidManager.Core.ProjectAggregate;
using GiftAidManager.SharedKernel.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace GiftAidManager.Web.Endpoints.ProjectEndpoints
{
    public class Create : BaseAsyncEndpoint
        .WithRequest<CreateProjectRequest>
        .WithResponse<CreateProjectResponse>
    {
        private readonly IRepository<Project> _repository;

        public Create(IRepository<Project> repository)
        {
            _repository = repository;
        }

        [HttpPost("/Projects")]
        [SwaggerOperation(
            Summary = "Creates a new Project",
            Description = "Creates a new Project",
            OperationId = "Project.Create",
            Tags = new[] { "ProjectEndpoints" })
        ]
        public override async Task<ActionResult<CreateProjectResponse>> HandleAsync(CreateProjectRequest request,
            CancellationToken cancellationToken)
        {
            var newProject = new Project(request.Name);

            var createdItem = await _repository.AddAsync(newProject); // TODO: pass cancellation token

            var response = new CreateProjectResponse
            {
                Id = createdItem.Id,
                Name = createdItem.Name
            };

            return Ok(response);
        }
    }
}
