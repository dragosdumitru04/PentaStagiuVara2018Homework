using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework03ClassLibrary
{
    public class Post
    {
        public int Id { get; set; }
        public Person Author { get; set; }
        public string Message { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
