using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class BorrowedBook
    {
        public DateTime BorrowTime { get; set; }
        public DateTime ReturnTime { get; set; }
        public int BookID { get; set; }
        public int UserID { get; set; }
    }
}
