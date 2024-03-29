﻿using System;
using System.Collections.Generic;

namespace MoviesApi.dbentities
{
    public partial class UmbracoDocument
    {
        public int NodeId { get; set; }
        public bool Published { get; set; }
        public bool Edited { get; set; }

        public virtual UmbracoContent Node { get; set; }
    }
}
