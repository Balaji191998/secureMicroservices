using System;
using System.Collections.Generic;

namespace movies.client.dbentities
{
    public partial class UmbracoKeyValue
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public DateTime Updated { get; set; }
    }
}
