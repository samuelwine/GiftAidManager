﻿using System.Collections.Generic;

namespace GiftAidManager.Web.Endpoints.ProjectEndpoints
{
    public class GetProjectByIdResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ToDoItemRecord> Items { get; set; } = new();
    }
}