namespace Ranta.Lucy.Business.Models
{
    using System;
    using System.Collections.Generic;

    public class ProjectModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int OwnerId { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime LastUpdateTime { get; set; }
    }
}