using Base.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Personel:IEntity
    {
        public virtual int Id { get; set; }
        public virtual string AdiSoyadi { get; set; }
        public virtual string Telefonu { get; set; }
        public virtual string Adresi { get; set; }
        public virtual string Email { get; set; }
    }
}
