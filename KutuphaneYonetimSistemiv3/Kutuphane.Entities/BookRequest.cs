using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Entities
{
    public class BookRequest
    {
        public int RequestId { get; set; }
        public int MemberId { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public DateTime RequestDate { get; set; }
        public string Status { get; set; }
    }
}
