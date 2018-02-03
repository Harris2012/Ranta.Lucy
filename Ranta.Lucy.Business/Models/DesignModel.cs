namespace Ranta.Lucy.Business.Models
{
    using System;
    using System.Collections.Generic;

    public class DesignModel
    {
        public int Id { get; set; }

        public int ProjectId { get; set; }

        public string Data { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime LastUpdateTime { get; set; }
    }
}