using System;
using System.Collections.Generic;

namespace WebApi2Book.Web.Api.Models
{
    public class Task
    {
        public long? TaskId { get; set; }
        public string Subject { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? CompleteDate { get; set; }
        public Status Status { get; set; }
        public DateTime CreateDate { get; set; }

        private List<Link> _links = new List<Link>();
        public List<Link> Links
        {
            get { return _links ?? (_links = new List<Link>()); }
            set { _links = value; }
        }
    }
}