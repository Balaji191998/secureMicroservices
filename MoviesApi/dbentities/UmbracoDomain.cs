﻿using System;
using System.Collections.Generic;

namespace MoviesApi.dbentities
{
    public partial class UmbracoDomain
    {
        public int Id { get; set; }
        public int? DomainDefaultLanguage { get; set; }
        public int? DomainRootStructureId { get; set; }
        public string DomainName { get; set; }

        public virtual UmbracoNode DomainRootStructure { get; set; }
    }
}
