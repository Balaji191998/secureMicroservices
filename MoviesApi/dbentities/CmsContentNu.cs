﻿using System;
using System.Collections.Generic;

namespace MoviesApi.dbentities
{
    public partial class CmsContentNu
    {
        public int NodeId { get; set; }
        public bool Published { get; set; }
        public string Data { get; set; }
        public long Rv { get; set; }

        public virtual UmbracoContent Node { get; set; }
    }
}
