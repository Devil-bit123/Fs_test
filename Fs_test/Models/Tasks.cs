using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fs_test.Models
{
    public class Tasks
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Expires_at { get; set; }
        public bool Completed { get; set; }


    }
}