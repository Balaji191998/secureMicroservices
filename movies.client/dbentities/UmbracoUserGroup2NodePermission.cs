using System;
using System.Collections.Generic;

namespace movies.client.dbentities
{
    public partial class UmbracoUserGroup2NodePermission
    {
        public int UserGroupId { get; set; }
        public int NodeId { get; set; }
        public string Permission { get; set; }

        public virtual UmbracoNode Node { get; set; }
        public virtual UmbracoUserGroup UserGroup { get; set; }
    }
}
