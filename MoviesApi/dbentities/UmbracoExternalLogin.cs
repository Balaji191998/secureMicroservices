using System;
using System.Collections.Generic;

namespace MoviesApi.dbentities
{
    public partial class UmbracoExternalLogin
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string LoginProvider { get; set; }
        public string ProviderKey { get; set; }
        public DateTime CreateDate { get; set; }
        public string UserData { get; set; }
    }
}
