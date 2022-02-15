using System;
using System.Collections.Generic;

namespace movies.client.dbentities
{
    public partial class UmbracoUser2UserGroup
    {
        public int UserId { get; set; }
        public int UserGroupId { get; set; }

        public virtual UmbracoUser User { get; set; }
        public virtual UmbracoUserGroup UserGroup { get; set; }
    }
}
