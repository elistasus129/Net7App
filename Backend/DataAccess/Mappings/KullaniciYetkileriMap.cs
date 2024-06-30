using Entities.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mappings
{
    public class KullaniciYetkileriMap:ClassMap<KullaniciYetkileri>
    {
        public KullaniciYetkileriMap()
        {
            Table("KullaniciYetkileri");
            Id(p=>p.Id).Column("Id").GeneratedBy.Increment();
            Map(p => p.Sifre).Column("Sifre");
            References(p=>p.PersonelId).Column("PersonelId").Not.LazyLoad();
            References(p => p.YetkiId).Column("YetkiId").Not.LazyLoad();
        }
    }
}
