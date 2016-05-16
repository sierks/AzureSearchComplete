using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AzureSearchComplete.DataAccess
{
    public class LocalDataSourceContext : System.Data.Entity.DbContext
    {
        public System.Data.Entity.DbSet<AzureSearchComplete.Models.SuperHeroModel> MarvelSuperHeroes { get; set; }
    }
}