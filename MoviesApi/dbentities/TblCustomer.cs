using System;
using System.Collections.Generic;

namespace MoviesApi.dbentities
{
    public partial class TblCustomer
    {
        public int Customerno { get; set; }
        public string CustomerNmae { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerOrder { get; set; }
        public DateTime? CustomerOrderedDate { get; set; }
    }
}
