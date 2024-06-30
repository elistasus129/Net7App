using Entities.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mappings
{
    public class KategoriMap:ClassMap<Kategori>
    {
        public KategoriMap()
        {
            Table("Kategori");
            Id(p => p.Id).Column("Id").GeneratedBy.Increment();
            Map(p => p.Ad).Column("Ad");
    }
}
