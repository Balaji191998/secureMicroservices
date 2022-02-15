using System;
using System.Collections.Generic;

namespace MoviesApi.dbentities
{
    public partial class UmbracoMediaVersion
    {
        public int Id { get; set; }
        public string Path { get; set; }

        public virtual UmbracoContentVersion IdNavigation { get; set; }
    }
}
