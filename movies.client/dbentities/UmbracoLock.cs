using System;
using System.Collections.Generic;

namespace movies.client.dbentities
{
    public partial class UmbracoLock
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public string Name { get; set; }
    }
}
