using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Rahbaran_Andishe.Models
{
    public class SiteDb : DbContext

    {
        public SiteDb() : base("DefaultConnection")
        {

        }

        public virtual DbSet<Form> Forms { get; set; }
        public virtual DbSet<CityCategory> CityCategories { get; set; }
        public virtual DbSet<OtherfieldsCategory> OtherfieldsCategories { get; set; }
    }
}