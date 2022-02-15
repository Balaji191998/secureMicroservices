using System;
using System.Collections.Generic;

namespace movies.client.dbentities
{
    public partial class CmsMacroProperty
    {
        public int Id { get; set; }
        public Guid UniquePropertyId { get; set; }
        public string EditorAlias { get; set; }
        public int Macro { get; set; }
        public int MacroPropertySortOrder { get; set; }
        public string MacroPropertyAlias { get; set; }
        public string MacroPropertyName { get; set; }

        public virtual CmsMacro MacroNavigation { get; set; }
    }
}
