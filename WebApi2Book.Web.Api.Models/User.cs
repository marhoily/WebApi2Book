using System.Collections.Generic;

namespace WebApi2Book.Web.Api.Models
{
    public class User
    {
        public long UserId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public byte[] Version { get; set; }

        private List<Link> _links = new List<Link>();
        public List<Link> Links
        {
            get { return _links ?? (_links = new List<Link>()); }
            set { _links = value; }
        }

        public void AddLink(Link link)
        {
            Links.Add(link);
        }
    }
}