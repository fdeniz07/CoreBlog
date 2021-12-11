using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Models
{
    public class UserComment
    {
        public int Id { get; set; }
        public string UserName { get; set; }
    }
}
