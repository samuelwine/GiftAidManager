using System.Collections.Generic;
using GiftAidManager.Core.ProjectAggregate;

namespace GiftAidManager.Web.Endpoints.ProjectEndpoints
{
    public class ProjectListResponse
    {
        public List<ProjectRecord> Projects { get; set; } = new();
    }
}
