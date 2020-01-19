using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIPost.Models
{
    public class Post
    {
        public Guid MessageId { get; set; }
        public Guid? UserId { get; set; }
        public string Message { get; set; }
        public DateTime? Date { get; set; }
    }
}
