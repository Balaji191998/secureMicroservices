﻿using System;
using System.Collections.Generic;

namespace MoviesApi.dbentities
{
    public partial class UmbracoUserStartNode
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int StartNode { get; set; }
        public int StartNodeType { get; set; }

        public virtual UmbracoNode StartNodeNavigation { get; set; }
        public virtual UmbracoUser User { get; set; }
    }
}
