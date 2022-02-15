using System;
using System.Collections.Generic;

namespace MoviesApi.dbentities
{
    public partial class UmbracoUserGroup2App
    {
        public int UserGroupId { get; set; }
        public string App { get; set; }

        public virtual UmbracoUserGroup UserGroup { get; set; }
    }
}
